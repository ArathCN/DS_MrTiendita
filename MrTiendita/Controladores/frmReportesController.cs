using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Vistas;
using MrTiendita.Constantes;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using Guna.UI2.WinForms;
using Guna.UI.WinForms;
using iText.Kernel.Pdf;
using System.IO;
using iTextSharp.text.pdf;
using iText.Layout;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Utils;
using System.Globalization;
using iText.Layout.Borders;

namespace MrTiendita.Controladores
{
    public class FrmReportesController
    {
        private readonly FrmReportes_ vista;
        private Guna2Button botonSeleccionado;
        private Label periodo, labelSince, labelUntil;
        private GunaDateTimePicker dateTimePicker, dateTimePickerSince, dateTimePickerUntil;
        private Guna2DataGridView tabla;
        private Panel bordeInferior;
        private DateTime desde;
        private DateTime hasta;
        private VentaDAO ventaDAO;
        private EntradaAlmacenDAO entradaAlmacenDAO;
        private bool esActivado = false;
        private bool reporte; //true ventas, false entradas

        //reporte ventas
        private Dictionary<string, string> reporteVenta;
        private Dictionary<string, double> CategoriaNumero;
        private Dictionary<string, double> CategoriaVentas;
        private Dictionary<string, double> CategoriaGanancias;
        private List<Venta> ventaPorProducto;

        public FrmReportesController(FrmReportes_ vista)
        {
            this.vista = vista;
            this.ventaDAO = new VentaDAO();
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();

            this.CategoriaNumero = new Dictionary<string, double>();
            this.CategoriaVentas = new Dictionary<string, double>();
            this.CategoriaGanancias = new Dictionary<string, double>();
            this.ventaPorProducto = new List<Venta>();
            this.reporteVenta = new Dictionary<string, string>();

            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_Ventas.Click += new EventHandler(Btn_Ventas_Click);
            this.vista.btn_Entradas.Click += new EventHandler(Btn_Entradas_Click);
            
            //Reporte entradas
            this.vista.lbl_HoyEntradas.Click += new EventHandler(Lbl_HoyEntradas_Click);
            this.vista.lbl_EstaSemanaEntradas.Click += new EventHandler(Lbl_EstaSemanaEntradas_Click);
            this.vista.lbl_EsteMesEntradas.Click += new EventHandler(Lbl_EsteMesEntradas_Click);
            this.vista.dp_DesdeEntradas.ValueChanged += new EventHandler(Dp_DesdeEntradas_onValueChanged);
            this.vista.dp_HastaEntradas.ValueChanged += new EventHandler(Dp_HastaEntradas_onValueChanged);
            this.vista.dp_DesdeEntradas.Click += new EventHandler(Dp_DesdeEntradas_Click);
            this.vista.dp_HastaEntradas.Click += new EventHandler(Dp_HastaEntradas_Click);

            //Reportes Ventas
            this.vista.cb_TipoReporte.SelectedIndexChanged += new EventHandler(Cb_TipoReporte_SelectedIndexChanged);
            this.vista.lbl_HoyVentas.Click += new EventHandler(Lbl_HoyVentas_Click);
            this.vista.lbl_EstaSemanaVentas.Click += new EventHandler(Lbl_EstaSemanaVentas_Click);
            this.vista.lbl_EsteMesVentas.Click += new EventHandler(Lbl_EsteMesVentas_Click);
            this.vista.dp_DesdeVentas.ValueChanged += new EventHandler(Dp_DesdeVentas_onValueChanged);
            this.vista.dp_HastaVentas.ValueChanged += new EventHandler(Dp_HastaVentas_onValueChanged);
            this.vista.dp_DesdeVentas.Click += new EventHandler(Dp_DesdeVentas_Click);
            this.vista.dp_HastaVentas.Click += new EventHandler(Dp_HastaVentas_Click);

            //guardar
            this.vista.btn_GuardarArchivo.Click += new EventHandler(btn_GuardarArchivo_Click);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            this.vista.dp_DesdeEntradas.Value = DateTime.Today;
            this.vista.dp_HastaEntradas.Value = DateTime.Today.AddDays(+1); ;
            this.vista.dp_DesdeVentas.Value = DateTime.Today;
            this.vista.dp_HastaVentas.Value = DateTime.Today.AddDays(+1);
            BlackOutDateTimePicker(this.vista.dp_DesdeVentas, this.vista.dp_HastaVentas);
            BlackOutDateTimePicker(this.vista.dp_DesdeEntradas, this.vista.dp_HastaEntradas);
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            ActivarBoton(this.vista.btn_Ventas);
            this.vista.pnl_Ventas.Visible = true;
            this.vista.pnl_EntradasAlmacen.Visible = false;
            this.vista.lbl_HoyVentas.ForeColor = Color.FromArgb(0, 134, 255);

            //Ventas
            this.vista.cb_TipoReporte.SelectedIndex = 0;
            this.reporte = true;
            CambiarReporte(this.vista.dgv_TablaTodasVentas);
            this.desde = DateTime.Today;
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarVentasTotales(this.desde, this.hasta, this.vista.lbl_HoyVentas);
            ActivarPeriodo(this.vista.lbl_HoyVentas);
            esActivado = true;
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            this.reporte = true;
            ActivarBoton(sender);
            this.vista.pnl_Ventas.Visible = true;
            this.vista.pnl_EntradasAlmacen.Visible = false;
            this.vista.cb_TipoReporte.SelectedIndex = 0;
            CambiarReporte(this.vista.dgv_TablaTodasVentas);
            this.desde = DateTime.Today;
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarVentasTotales(this.desde, this.hasta, this.vista.lbl_HoyVentas);
            ActivarPeriodo(this.vista.lbl_HoyVentas);
        }

        private void Btn_Entradas_Click(object sender, EventArgs e)
        {
            this.reporte = false;
            ActivarBoton(sender);
            this.vista.pnl_Ventas.Visible = false;
            this.vista.pnl_EntradasAlmacen.Visible = true;
            this.desde = DateTime.Today;
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarEntradas(this.desde, this.hasta, this.vista.lbl_HoyEntradas);
            ActivarPeriodo(this.vista.lbl_HoyEntradas);
        }

        private void Lbl_HoyEntradas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.desde = DateTime.Today;
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarEntradas(this.desde, this.hasta, sender);
            UnfocusDatePicker(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
        }

        private void Lbl_EstaSemanaEntradas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            FiltroSemana();
            ActualizarEntradas(this.desde, this.hasta, sender);
            UnfocusDatePicker(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
        }

        private void Lbl_EsteMesEntradas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            this.desde = FiltroMes(this.hasta);
            ActualizarEntradas(this.desde, this.hasta, sender);
            UnfocusDatePicker(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
        }

        private void Dp_DesdeEntradas_onValueChanged(object sender, EventArgs e)
        {
            this.desde = this.vista.dp_DesdeEntradas.Value;
            BlackOutDateTimePicker(sender, this.vista.dp_HastaEntradas);
            DateTime fechaDesde = this.vista.dp_DesdeEntradas.Value;
            DateTime fechaHasta = this.vista.dp_HastaEntradas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarEntradas(fechaDesde, fechaHasta, this.vista.lbl_Periodo);
            ActivarPeriodo(this.vista.lbl_Periodo);
        }

        private void Dp_HastaEntradas_onValueChanged(object sender, EventArgs e)
        {
            this.hasta = this.vista.dp_HastaEntradas.Value;
            DateTime fechaDesde = this.vista.dp_DesdeEntradas.Value;
            DateTime fechaHasta = this.vista.dp_HastaEntradas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarEntradas(fechaDesde, fechaHasta, this.vista.lbl_Periodo);
            ActivarPeriodo(this.vista.lbl_Periodo);
        }

        private void Dp_DesdeEntradas_Click(object sender, EventArgs e)
        {
            DatePickerFocus(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
            DatePickerFocus(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
        }

        private void Dp_HastaEntradas_Click(object sender, EventArgs e)
        {
            DatePickerFocus(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
            DatePickerFocus(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
        }

        private void Cb_TipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = DateTime.Today;
            DateTime fechaHasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            if (esActivado)
            {
                switch (this.vista.cb_TipoReporte.SelectedIndex)
                {
                    case 0:
                        CambiarReporte(this.vista.dgv_TablaTodasVentas);
                        ActivarPeriodo(this.vista.lbl_HoyVentas);
                        ActualizarVentasTotales(fechaDesde, fechaHasta, this.vista.lbl_HoyVentas);
                        break;
                    case 1:
                        CambiarReporte(this.vista.dgv_TablaVentasCategoria);
                        ActivarPeriodo(this.vista.lbl_HoyVentas);
                        ActualizarVentasCategoria(fechaDesde, fechaHasta, this.vista.lbl_HoyVentas);
                        break;
                    default:
                        break;
                }
                UnfocusDatePicker(this.vista.lbl_Desde, this.vista.lbl_Hasta);
            }
        }

        private void Lbl_HoyVentas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.desde = DateTime.Today;
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    ActualizarVentasTotales(this.desde, this.hasta, sender);
                    break;
                case 1:
                    ActualizarVentasCategoria(this.desde, this.hasta, sender);
                    break;
                default:
                    break;
            }
            UnfocusDatePicker(this.vista.lbl_Desde, this.vista.lbl_Hasta);
        }

        private void Lbl_EstaSemanaVentas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            FiltroSemana();
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    ActualizarVentasTotales(this.desde, this.hasta, sender);
                    break;
                case 1:
                    ActualizarVentasCategoria(this.desde, this.hasta, sender);
                    break;
                default:
                    break;
            }
            UnfocusDatePicker(this.vista.lbl_Desde, this.vista.lbl_Hasta);
        }

        private void Lbl_EsteMesVentas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            this.desde = FiltroMes(this.hasta);
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    ActualizarVentasTotales(this.desde, this.hasta, sender);
                    break;
                case 1:
                    ActualizarVentasCategoria(this.desde, this.hasta, sender);
                    break;
                default:
                    break;
            }
            UnfocusDatePicker(this.vista.lbl_Desde, this.vista.lbl_Hasta);
        }

        private void Dp_DesdeVentas_onValueChanged(object sender, EventArgs e)
        {
            this.desde = this.vista.dp_DesdeVentas.Value;
            BlackOutDateTimePicker(sender, this.vista.dp_HastaVentas);
            DateTime fechaDesde = this.vista.dp_DesdeVentas.Value;
            DateTime fechaHasta = this.vista.dp_HastaVentas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    ActualizarVentasTotales(fechaDesde, fechaHasta, sender);
                    break;
                case 1:
                    ActualizarVentasCategoria(fechaDesde, fechaHasta, sender);
                    break;
                default:
                    break;
            }
            ActivarPeriodo(this.vista.lbl_Periodo);
        }

        private void Dp_HastaVentas_onValueChanged(object sender, EventArgs e)
        {
            this.hasta = this.vista.dp_HastaVentas.Value;
            DateTime fechaDesde = this.vista.dp_DesdeVentas.Value;
            DateTime fechaHasta = this.vista.dp_HastaVentas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    ActualizarVentasTotales(fechaDesde, fechaHasta, sender);
                    break;
                case 1:
                    ActualizarVentasCategoria(fechaDesde, fechaHasta, sender);
                    break;
                default:
                    break;
            }
            ActivarPeriodo(this.vista.lbl_Periodo);
        }

        private void Dp_HastaVentas_Click(object sender, EventArgs e)
        {
            DatePickerFocus(this.vista.lbl_Desde, this.vista.lbl_Hasta);
            DatePickerFocus(this.vista.lbl_Desde, this.vista.lbl_Hasta);
        }

        private void Dp_DesdeVentas_Click(object sender, EventArgs e)
        {
            DatePickerFocus(this.vista.lbl_Desde2, this.vista.lbl_Hasta2);
            DatePickerFocus(this.vista.lbl_Desde, this.vista.lbl_Hasta);
        }

        private void btn_GuardarArchivo_Click(object sender, EventArgs e)
        {

            if (this.reporte)this.GenerarReporteVentasTotales();
            else this.GenerarReporteInventario();
        }

        //Métodos auxiliares
        private void ActivarBoton(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                this.botonSeleccionado = (Guna2Button)boton;
                this.botonSeleccionado.ForeColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.BackColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.Location = new Point(this.botonSeleccionado.Location.X + 18, 49);
                this.bordeInferior.BringToFront();
                this.bordeInferior.Visible = true;
            }
        }

        private void DeshabilitarBoton()
        {
            if (this.botonSeleccionado != null)
                this.botonSeleccionado.ForeColor = Color.FromArgb(70, 70, 74);
        }

        public void ActualizarVentasTotales(DateTime desde, DateTime hasta, object sender)
        {

            //ReadBetweenDatesWithDescription
            List<Venta> ventas = this.ventaDAO.ReadBetweenDatesCompleteInfo(desde, hasta);
            if (ventas.Count != 0)
            {
                this.vista.btn_GuardarArchivo.Enabled = true;
                this.vista.dgv_TablaTodasVentas.Rows.Clear();
                foreach (Venta venta in ventas)
                {
                    this.vista.dgv_TablaTodasVentas.Rows.Add(
                        venta.Id_venta,
                        venta.Codigo_barra,
                        venta.Producto.Descripcion,
                        venta.Id_empleado,
                        venta.Metodo_pago,
                        venta.Fecha,
                        venta.Cantidad,
                        "$"+venta.Importe);
                }
            }
            else
            {
                this.vista.btn_GuardarArchivo.Enabled = false;
                MensajeError(sender);
                this.vista.dgv_TablaTodasVentas.Rows.Clear();
            }
        }       

        public void ActualizarVentasCategoria(DateTime desde, DateTime hasta, object sender)
        {
            List<Venta> ventasTotales = this.ventaDAO.ReadBetweenDatesCompleteInfo(desde, hasta);
            if (ventasTotales.Count != 0)
            {
                this.vista.btn_GuardarArchivo.Enabled = true;
                Dictionary<string, double> totalVentasCategoria = new Dictionary<string, double>();
                Dictionary<string, double> totalGananciaCategoria = new Dictionary<string, double>();
                Dictionary<string, double> totalProductosCategoria = new Dictionary<string, double>();

                List<Categoria> categorias = Categorias.CATEGORIAS;
                categorias.RemoveAt(0);

                foreach (Categoria categoria in categorias)
                {
                    totalVentasCategoria.Add(categoria.Nombre, 0);
                    totalGananciaCategoria.Add(categoria.Nombre, 0);
                    totalProductosCategoria.Add(categoria.Nombre, 0);
                }

                foreach (Venta venta in ventasTotales)
                {
                    //Sumar las ventas a cada categoría
                    if (totalVentasCategoria.ContainsKey(venta.Producto.Categoria))
                    {
                        totalVentasCategoria[venta.Producto.Categoria] += venta.Importe;
                        totalGananciaCategoria[venta.Producto.Categoria] += venta.Importe - (venta.Producto.Precio_compra * venta.Cantidad);
                        totalProductosCategoria[venta.Producto.Categoria] += venta.Cantidad;
                    }
                }
                this.vista.dgv_TablaVentasCategoria.Rows.Clear();
                foreach (Categoria categoria in categorias)
                {
                    this.vista.dgv_TablaVentasCategoria.Rows.Add(
                    categoria.Nombre,
                    totalProductosCategoria[categoria.Nombre],
                    "$"+totalVentasCategoria[categoria.Nombre],
                    "$"+totalGananciaCategoria[categoria.Nombre]
                    );
                    
                }
            }
            else
            {
                this.vista.btn_GuardarArchivo.Enabled = false;
                MensajeError(sender);
                this.vista.dgv_TablaVentasCategoria.Rows.Clear();
            }
            
        }

        public void ActualizarEntradas(DateTime desde, DateTime hasta, object sender)
        {
            List<EntradaAlmacen> entradas = this.entradaAlmacenDAO.ReadBetweenDates(desde, hasta);
            if (entradas.Count != 0)
            {
                this.vista.btn_GuardarArchivo.Enabled = true;
                this.vista.dgv_TablaEntradas.Rows.Clear();
                foreach (EntradaAlmacen entrada in entradas)
                {
                    this.vista.dgv_TablaEntradas.Rows.Add(
                    entrada.Id_entrada,
                    entrada.Codigo_barra,
                    entrada.Producto.Descripcion,
                    entrada.Cantidad,
                    entrada.Fecha,
                    "$" + entrada.Producto.Precio_compra,
                    "$" + entrada.Producto.Precio_venta,
                    "$" + entrada.Importe);
                }
            }
            else
            {
                this.vista.btn_GuardarArchivo.Enabled = false;
                MensajeError(sender);
                this.vista.dgv_TablaEntradas.Rows.Clear();
            }
        }

        public void ActivarPeriodo(object label)
        {
            if (label != null)
            {
                DesactivarPeriodos();
                this.periodo = (Label)label;
                this.periodo.ForeColor = Color.FromArgb(0, 134, 255);

            }
        }

        public void DesactivarPeriodos()
        {
            if (this.periodo != null)
                this.periodo.ForeColor = Color.FromArgb(70, 70, 74);
        }

        private void DatePickerFocus(object label, object label2)
        {
                this.labelSince = (Label)label;
                this.labelUntil = (Label)label2;
                this.labelSince.ForeColor = Color.FromArgb(0, 134, 255);
                this.labelUntil.ForeColor = Color.FromArgb(0, 134, 255);
        }

        private void UnfocusDatePicker(object label, object label2)
        {
            this.labelSince = (Label)label;
            this.labelUntil = (Label)label2;
            this.labelSince.ForeColor = Color.FromArgb(70, 70, 74);
            this.labelUntil.ForeColor = Color.FromArgb(70, 70, 74);
        }

        private void BlackOutDateTimePicker(object DatePickerSince, object DatePickerUntil)
        {
            this.dateTimePickerSince = (GunaDateTimePicker)DatePickerSince;
            this.dateTimePickerUntil = (GunaDateTimePicker)DatePickerUntil;
            DateTime sinceDate = this.dateTimePickerSince.Value;
            this.dateTimePickerUntil.MinDate = sinceDate.AddDays(+1);           
        }

        public DateTime FiltroMes(DateTime hoy)
        {
            DateTime inicioMes = hoy;
            int diasMenos;
            hoy = hoy.AddDays(-1);
            diasMenos = hoy.Day;
            inicioMes = inicioMes.AddDays(-diasMenos).AddHours(-23).AddMinutes(-59).AddSeconds(-59);
            return inicioMes;
        }

        public void FiltroSemana()
        {
            DateTime hoy_ = DateTime.Now;
            DateTime hoy = new DateTime(hoy_.Year, hoy_.Month, hoy_.Day, 0, 0, 0);
            int diaSemana = (int)hoy.DayOfWeek;
            if (diaSemana == 0) diaSemana = 7;
            diaSemana--;
            DateTime inicio = hoy.AddDays(-diaSemana);
            DateTime final = hoy.AddDays(6 - diaSemana);
            this.desde = inicio;
            this.hasta = final;
        }

        public void MensajeError(object sender)
        {
            string mensaje = "se mostrará un reporte vacío. Seleccione un período de tiempo más grande";
            if (sender == this.vista.lbl_HoyEntradas)
            {
                FrmError frmError = new FrmError($"Hoy no ha hecho una entrada al almacén, {mensaje} o agregue una entrada al almacén.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_EstaSemanaEntradas)
            {
                FrmError frmError = new FrmError($"Esta semana no ha hecho una entrada al almacén, {mensaje} o agregue una entrada al almacén.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_EsteMesEntradas)
            {
                FrmError frmError = new FrmError($"Este mes no ha hecho una entrada al almacén, {mensaje} o agregue una entrada al almacén.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_HoyVentas)
            {
                FrmError frmError = new FrmError($"Hoy no ha hecho ninguna venta, {mensaje} o realice una venta.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_EstaSemanaVentas)
            {
                FrmError frmError = new FrmError($"Esta semana no ha hecho ninguna venta, {mensaje} o realice una venta.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_EsteMesVentas)
            {
                FrmError frmError = new FrmError($"Este mes no ha hecho ninguna venta, {mensaje} o realice una venta.");
                frmError.ShowDialog();
            }
        }

        public void CambiarReporte(object tabla)
        {
            if (tabla != null )
            {
                if (this.tabla != null) this.tabla.Visible = false;
                this.tabla = (Guna2DataGridView)tabla;
                this.tabla.Visible = true;
            }
        }

        private void GenerarReporteVentasTotales()
        {
            this.CategoriaVentas.Clear();
            this.CategoriaGanancias.Clear();
            this.CategoriaNumero.Clear();
            this.reporteVenta.Clear();
            this.ventaPorProducto.Clear();

            List<Categoria> categorias = Categorias.CATEGORIAS;
            categorias.RemoveAt(0);

            NumberFormatInfo formato = new CultureInfo("es-MX").NumberFormat;
            formato.CurrencyGroupSeparator = ",";
            formato.NumberDecimalSeparator = ".";
            formato.CurrencyDecimalDigits = 2;

            double totalVentas = 0;
            double totalVentasEfectivo = 0;
            double totalVentasTarjeta = 0;
            double totalGanancia = 0;

            foreach (Categoria categoria in categorias)
            {
                this.CategoriaVentas.Add(categoria.Nombre, 0);
                this.CategoriaGanancias.Add(categoria.Nombre, 0);
                this.CategoriaNumero.Add(categoria.Nombre, 0);
            }

            List<Venta> ventasTotales = this.ventaDAO.ReadBetweenDatesCompleteInfo(this.desde, this.hasta);

            //Juntar los registros de ventas que sean de un mismo producto.
            foreach (Venta venta in ventasTotales)
            {
                bool encontrado = false;
                for (int j = 0; j < this.ventaPorProducto.Count() && !encontrado; j++)
                {
                    if (venta.Codigo_barra == this.ventaPorProducto[j].Codigo_barra)
                    {
                        this.ventaPorProducto[j].Cantidad += venta.Cantidad;
                        this.ventaPorProducto[j].Importe += venta.Importe;
                        encontrado = true;
                    }
                }
                if (!encontrado) this.ventaPorProducto.Add(venta);
            }

            foreach (Venta venta in ventasTotales)
            {

                //Sumar las ventas por cada tipo de pago
                if (venta.Metodo_pago == TipoMovimiento.EFECTIVO)
                {
                    totalVentasEfectivo += venta.Importe;
                }
                else if (venta.Metodo_pago == TipoMovimiento.TARJETA)
                {
                    totalVentasTarjeta += venta.Importe;
                }

                //Sumar las ventas, ganancias y numero de productos a cada categoría
                if (this.CategoriaVentas.ContainsKey(venta.Producto.Categoria))
                {
                    this.CategoriaVentas[venta.Producto.Categoria] += venta.Importe;
                    this.CategoriaGanancias[venta.Producto.Categoria] += venta.Importe - (venta.Producto.Precio_compra * venta.Cantidad);
                    this.CategoriaNumero[venta.Producto.Categoria] += venta.Cantidad;
                }
                else //no debería salir erro si cuando se dan de alta productos se usan las constantes de Categorias
                {
                    Form error = new FrmError("No se encontró -->" + venta.Producto.Categoria);
                    error.ShowDialog();
                }

                totalGanancia += venta.Importe - (venta.Producto.Precio_compra * venta.Cantidad);
                totalVentas += venta.Importe;
            }

            this.reporteVenta.Add("numVentas", ventasTotales.Count().ToString());
            this.reporteVenta.Add("ventasTotales", totalVentas.ToString("C", formato));
            this.reporteVenta.Add("gananciasTotales", totalGanancia.ToString("C", formato));
            this.reporteVenta.Add("efectivoTotal", totalVentasEfectivo.ToString("C", formato));
            this.reporteVenta.Add("tarjetaTotal", totalVentasTarjeta.ToString("C", formato));

            DateTime hoy = DateTime.Now;
            String dia = hoy.ToString("dd");
            String mes = hoy.ToString("MMMM", new CultureInfo("es-MX"));
            String anio = hoy.ToString("yyyy");
            long numeroR = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            //////////////////////////////
            ///Creación del archivo....
            string reporteVentasTotales = Properties.Settings.Default.RutaTickets + @"\ReporteVentasTotales_" + this.desde.ToString("dd-MM-yyyy") + "_" + this.hasta.ToString("dd-MM-yyyy") + ".pdf";

            
            ////////////////////////////
            //Ahora se crea un archivo pdf con las entradas y salidas de dinerp
            iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter(reporteVentasTotales));
            Document document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.LETTER);
            document.SetMargins(20f, 15f, 20f, 15f);
            iText.Kernel.Font.PdfFont fuente = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);


            document.Add(new Paragraph("Reporte de ventas").SetFont(fuente).SetFontSize(16).SetBold().SetTextAlignment(TextAlignment.CENTER));
            document.Add(new Paragraph(dia + " de " + mes + " de " + anio).SetFont(fuente).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table fechas = new Table(UnitValue.CreatePercentArray(2));
            fechas.SetWidth(UnitValue.CreatePercentValue(95));
            fechas.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            fechas.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(
                new Paragraph("Desde:   " + this.desde.ToString("dd/MM/yyyy")).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));
            fechas.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(
                new Paragraph("Hasta:   " + this.hasta.ToString("dd/MM/yyyy")).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));

            document.Add(fechas);

            document.Add(new Paragraph(""));

            document.Add(new Paragraph(this.reporteVenta["numVentas"] + "  ventas.").SetFont(fuente).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table totales = new Table(UnitValue.CreatePercentArray(2));
            totales.SetWidth(UnitValue.CreatePercentValue(90));
            totales.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            totales.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(
                new Paragraph("Ventas totales:   " + this.reporteVenta["ventasTotales"]).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));
            totales.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(
                new Paragraph("Ganancias totales:   " + this.reporteVenta["gananciasTotales"]).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));

            document.Add(totales);

            document.Add(new Paragraph(""));

            document.Add(new Paragraph("Efectivo:   " + this.reporteVenta["efectivoTotal"]).SetFont(fuente).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Tarjeta:   " + this.reporteVenta["tarjetaTotal"]).SetFont(fuente).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new Paragraph("Ventas por categoría").SetFont(fuente).SetFontSize(13).SetBold().SetTextAlignment(TextAlignment.CENTER));
            document.Add(new Paragraph(""));

            Table tablaCategorias = new Table(UnitValue.CreatePercentArray(new float[] { 1.3f, 1, 1, 1}));
            tablaCategorias.SetWidth(UnitValue.CreatePercentValue(60));
            tablaCategorias.SetTextAlignment(TextAlignment.JUSTIFIED);
            tablaCategorias.SetFont(fuente);
            tablaCategorias.SetFontSize(12);
            tablaCategorias.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Categoría").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Total").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Ganancia").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));

            foreach (var venta in this.CategoriaVentas)
            {
                tablaCategorias.AddCell(venta.Key);
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(this.CategoriaNumero[venta.Key].ToString(formato))).SetTextAlignment(TextAlignment.CENTER));
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(venta.Value.ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(this.CategoriaGanancias[venta.Key].ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
            }

            document.Add(tablaCategorias);

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new Paragraph("Ventas por producto").SetFont(fuente).SetFontSize(13).SetBold().SetTextAlignment(TextAlignment.CENTER));
            document.Add(new Paragraph(""));

            Table ventas = new Table(UnitValue.CreatePercentArray(new float[] { 1.3f, 1, 1 }));
            ventas.SetWidth(UnitValue.CreatePercentValue(60));
            ventas.SetTextAlignment(TextAlignment.JUSTIFIED);
            ventas.SetFont(fuente);
            ventas.SetFontSize(12);
            ventas.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            ventas.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            ventas.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            ventas.AddHeaderCell(new Cell().Add(new Paragraph("Total").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));

            foreach (Venta venta in this.ventaPorProducto)
            {
                ventas.AddCell(venta.Producto.Descripcion);
                ventas.AddCell(new Cell().Add(new Paragraph(venta.Cantidad.ToString(formato))).SetTextAlignment(TextAlignment.CENTER));
                ventas.AddCell(new Cell().Add(new Paragraph(venta.Importe.ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
            }

            document.Add(ventas);

            document.Close();



            ////////////////////////////////
            //Juntamos el documento con los datos generales y el documento con las tablas
            //iText.Kernel.Pdf.PdfDocument CorteFinal = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter(corteCajaFinal));
            //string[] docsToMerge = new string[] { corteCajaPreeliminar, corteCajaEntradasSalidas };
            //for (int a = 0; a < docsToMerge.Length; a++)
            //{
            //    iText.Kernel.Pdf.PdfDocument origPdf2 = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfReader(docsToMerge[a]));
            //    PdfMerger merger = new PdfMerger(CorteFinal);
            //    merger.Merge(origPdf2, 1, origPdf2.GetNumberOfPages());

            //    origPdf2.Close();

            //}
            //CorteFinal.Close();

            //File.Delete(corteCajaPreeliminar);
            //File.Delete(corteCajaEntradasSalidas);

            FrmExito exito = new FrmExito("Se ha generado el reporte con éxito.");
            exito.ShowDialog();
        }

        private void GenerarReporteInventario()
        {
            double importeTotal = 0, valorTotal = 0, entradasTotales = 0;

            DateTime hoy = DateTime.Now;
            String dia = hoy.ToString("dd");
            String mes = hoy.ToString("MMMM", new CultureInfo("es-MX"));
            String anio = hoy.ToString("yyyy");
            long numeroR = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            NumberFormatInfo formato = new CultureInfo("es-MX").NumberFormat;
            formato.CurrencyGroupSeparator = ",";
            formato.NumberDecimalSeparator = ".";
            formato.CurrencyDecimalDigits = 2;

            List<EntradaAlmacen> entradas = this.entradaAlmacenDAO.ReadBetweenDates(this.desde, this.hasta);

            foreach (EntradaAlmacen entrada in entradas)
            {
                entradasTotales += entrada.Cantidad;
                importeTotal += entrada.Importe;
                valorTotal += entrada.Producto.Precio_venta * entrada.Cantidad;
            }
            

            //////////////////////////////
            ///Creación del archivo....
            string reporteEntradas = Properties.Settings.Default.RutaTickets + @"\ReporteEntradas_" + this.desde.ToString("dd-MM-yyyy") + "_" + this.hasta.ToString("dd-MM-yyyy") + ".pdf";


            ////////////////////////////
            //Ahora se crea un archivo pdf con las entradas y salidas de dinerp
            iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter(reporteEntradas));
            Document document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.LETTER);
            document.SetMargins(20f, 15f, 20f, 15f);
            iText.Kernel.Font.PdfFont fuente = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);


            document.Add(new Paragraph("Reporte de entradas al almacén").SetFont(fuente).SetFontSize(16).SetBold().SetTextAlignment(TextAlignment.CENTER));
            document.Add(new Paragraph(dia + " de " + mes + " de " + anio).SetFont(fuente).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table fechas = new Table(UnitValue.CreatePercentArray(2));
            fechas.SetWidth(UnitValue.CreatePercentValue(95));
            fechas.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            fechas.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(
                new Paragraph("Desde:   " + this.desde.ToString("dd/MM/yyyy")).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));
            fechas.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(
                new Paragraph("Hasta:   " + this.hasta.ToString("dd/MM/yyyy")).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));

            document.Add(fechas);

            document.Add(new Paragraph(""));

            document.Add(new Paragraph(entradasTotales + "  entradas.").SetFont(fuente).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table totales = new Table(UnitValue.CreatePercentArray(2));
            totales.SetWidth(UnitValue.CreatePercentValue(90));
            totales.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            totales.AddCell(new Cell().SetTextAlignment(TextAlignment.LEFT).Add(
                new Paragraph("Importe total:   " + importeTotal.ToString("C", formato)).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));
            totales.AddCell(new Cell().SetTextAlignment(TextAlignment.RIGHT).Add(
                new Paragraph("Valor de venta total:   " + valorTotal.ToString("C", formato)).SetFont(fuente).SetFontSize(12)).SetBorder(Border.NO_BORDER));

            document.Add(totales);

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new Paragraph("Entradas realizadas").SetFont(fuente).SetFontSize(13).SetBold().SetTextAlignment(TextAlignment.CENTER));
            document.Add(new Paragraph(""));

            Table tablaCategorias = new Table(UnitValue.CreatePercentArray(new float[] {1.5f, 1.5f, 1, 1, 1 }));
            tablaCategorias.SetWidth(UnitValue.CreatePercentValue(70));
            tablaCategorias.SetTextAlignment(TextAlignment.JUSTIFIED);
            tablaCategorias.SetFont(fuente);
            tablaCategorias.SetFontSize(12);
            tablaCategorias.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Fecha").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Producto").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Importe").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaCategorias.AddHeaderCell(new Cell().Add(new Paragraph("Valor de venta").SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));

            foreach (EntradaAlmacen entrada in entradas)
            {
                double valor = entrada.Cantidad * entrada.Producto.Precio_venta;
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(entrada.Fecha.ToString("dd/MM/yyyy HH:mm Hrs."))).SetTextAlignment(TextAlignment.CENTER));
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(entrada.Producto.Descripcion)).SetTextAlignment(TextAlignment.CENTER));
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(entrada.Cantidad.ToString(formato))).SetTextAlignment(TextAlignment.CENTER));
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(entrada.Importe.ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
                tablaCategorias.AddCell(new Cell().Add(new Paragraph(valor.ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
            }

            document.Add(tablaCategorias);

            

            document.Close();



            ////////////////////////////////
            //Juntamos el documento con los datos generales y el documento con las tablas
            //iText.Kernel.Pdf.PdfDocument CorteFinal = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter(corteCajaFinal));
            //string[] docsToMerge = new string[] { corteCajaPreeliminar, corteCajaEntradasSalidas };
            //for (int a = 0; a < docsToMerge.Length; a++)
            //{
            //    iText.Kernel.Pdf.PdfDocument origPdf2 = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfReader(docsToMerge[a]));
            //    PdfMerger merger = new PdfMerger(CorteFinal);
            //    merger.Merge(origPdf2, 1, origPdf2.GetNumberOfPages());

            //    origPdf2.Close();

            //}
            //CorteFinal.Close();

            //File.Delete(corteCajaPreeliminar);
            //File.Delete(corteCajaEntradasSalidas);

            FrmExito exito = new FrmExito("Se ha generado el reporte con éxito.");
            exito.ShowDialog();
        }
    }
}
