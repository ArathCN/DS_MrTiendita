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

namespace MrTiendita.Controladores
{
    public class FrmReportesController
    {
        private readonly FrmReportes_ vista;
        private Guna2Button botonSeleccionado;
        private Label periodo;
        private Guna2DataGridView tabla;
        private Panel bordeInferior;
        private DateTime desde;
        private DateTime hasta;
        private VentaDAO ventaDAO;
        private EntradaAlmacenDAO entradaAlmacenDAO;

        public FrmReportesController(FrmReportes_ vista)
        {
            this.vista = vista;
            this.ventaDAO = new VentaDAO();
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_Ventas.Click += new EventHandler(Btn_Ventas_Click);
            this.vista.btn_Entradas.Click += new EventHandler(Btn_Entradas_Click);
            
            //Reporte entradas
            this.vista.lbl_HoyEntradas.Click += new EventHandler(Lbl_HoyEntradas_Click);
            this.vista.lbl_EstaSemanaEntradas.Click += new EventHandler(Lbl_EstaSemanaEntradas_Click);
            this.vista.lbl_EsteMesEntradas.Click += new EventHandler(Lbl_EsteMesEntradas_Click);
            this.vista.dp_DesdeEntradas.ValueChanged += new EventHandler(Dp_DesdeEntradas_onValueChanged);
            this.vista.dp_HastaEntradas.ValueChanged += new EventHandler(Dp_HastaEntradas_onValueChanged);

            //Reportes Ventas
            this.vista.cb_TipoReporte.SelectedIndexChanged += new EventHandler(Cb_TipoReporte_SelectedIndexChanged);
            this.vista.lbl_HoyVentas.Click += new EventHandler(Lbl_HoyVentas_Click);
            this.vista.lbl_EstaSemanaVentas.Click += new EventHandler(Lbl_EstaSemanaVentas_Click);
            this.vista.lbl_EsteMesVentas.Click += new EventHandler(Lbl_EsteMesVentas_Click);
            this.vista.dp_DesdeVentas.ValueChanged += new EventHandler(Dp_DesdeVentas_onValueChanged);
            this.vista.dp_HastaVentas.ValueChanged += new EventHandler(Dp_HastaVentas_onValueChanged);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            this.vista.dp_DesdeEntradas.Value = DateTime.Today;
            this.vista.dp_HastaEntradas.Value = DateTime.Today;
            this.vista.dp_DesdeVentas.Value = DateTime.Today;
            this.vista.dp_HastaVentas.Value = DateTime.Today;
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            ActivarBoton(this.vista.btn_Ventas);
            this.vista.pnl_Ventas.Visible = true;
            this.vista.pnl_EntradasAlmacen.Visible = false;
            this.vista.lbl_HoyVentas.ForeColor = Color.FromArgb(0, 134, 255);

            //Ventas
            this.vista.cb_TipoReporte.SelectedIndex = 0;
            CambiarReporte(this.vista.dgv_TablaTodasVentas);
            this.desde = DateTime.Today;
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarVentasTotales(this.desde, this.hasta, this.vista.lbl_HoyVentas);
            ActivarPeriodo(this.vista.lbl_HoyVentas);
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
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
        }

        private void Lbl_EstaSemanaEntradas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.desde = DateTime.Today.AddDays(-7);
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            ActualizarEntradas(this.desde, this.hasta, sender);
        }

        private void Lbl_EsteMesEntradas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            this.desde = FiltroMes(this.hasta);
            ActualizarEntradas(this.desde, this.hasta, sender);
        }

        private void Dp_DesdeEntradas_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            DateTime fechaDesde = this.vista.dp_DesdeEntradas.Value;
            DateTime fechaHasta = this.vista.dp_HastaEntradas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            //MessageBox.Show($"Desde: {fechaDesde}");
            //MessageBox.Show($"Hasta: {fechaHasta}");
            ActualizarEntradas(fechaDesde, fechaHasta, this.vista.lbl_Periodo);
            ActivarPeriodo(this.vista.lbl_Periodo);
        }

        private void Dp_HastaEntradas_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            DateTime fechaDesde = this.vista.dp_DesdeEntradas.Value;
            DateTime fechaHasta = this.vista.dp_HastaEntradas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            //MessageBox.Show($"Desde: {fechaDesde}");
            //MessageBox.Show($"Hasta: {fechaHasta}");
            ActualizarEntradas(fechaDesde, fechaHasta, this.vista.lbl_Periodo);
            ActivarPeriodo(this.vista.lbl_Periodo);
        }

        private void Cb_TipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.vista.dp_DesdeVentas.Value;
            DateTime fechaHasta = this.vista.dp_HastaVentas.Value;
            fechaHasta = fechaHasta.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    CambiarReporte(this.vista.dgv_TablaTodasVentas);
                    ActualizarVentasTotales(fechaDesde, fechaHasta, this.vista.lbl_Periodo);
                    break;
                case 1:
                    CambiarReporte(this.vista.dgv_TablaVentasProducto);
                    break;
                case 2:
                    CambiarReporte(this.vista.dgv_TablaVentasCategoria);
                    ActualizarVentasCategoria(fechaDesde, fechaHasta, this.vista.lbl_Periodo);
                    break;
                default:
                    break;
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
        }

        private void Lbl_EstaSemanaVentas_Click(object sender, EventArgs e)
        {
            ActivarPeriodo(sender);
            this.desde = DateTime.Today.AddDays(-7);
            this.hasta = DateTime.Today.AddHours(+23).AddMinutes(+59).AddSeconds(+59);
            switch (this.vista.cb_TipoReporte.SelectedIndex)
            {
                case 0:
                    ActualizarVentasTotales(this.desde, this.hasta, sender);
                    break;
                case 2:
                    ActualizarVentasCategoria(this.desde, this.hasta, sender);
                    break;
                default:
                    break;
            }
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
        }

        private void Dp_DesdeVentas_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
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
            //yyyy - mm - dd hh: mm: ss
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
            List<Venta> ventas = this.ventaDAO.ReadBetweenDatesWithDescription(desde, hasta);
            if (ventas.Count != 0)
            {
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
                        venta.Importe);
                }
            }
            else
            {
                MensajeError(sender);
                this.vista.dgv_TablaTodasVentas.Rows.Clear();
            }
        }

        public void ActualizarVentasProducto(DateTime desde, DateTime hasta, object sender)
        {
            ////Ventas por cada producto
            //List<Venta> ventasPorProducto = this.ventaDAO.ReadBetweenDatesByProduct();
            //if (ventasPorProducto.Count != 0)
            //{
            //    Dictionary<string, double> totalVentasProducto = new Dictionary<string, double>();
            //    Dictionary<string, double> totalEfectivoProducto = new Dictionary<string, double>();
            //    Dictionary<string, double> totalGananciaProducto = new Dictionary<string, double>();
            //    foreach (Venta ventas in ventasPorProducto)
            //    {
            //        if (ventas.Fecha.Date == )
            //        {

            //        }
            //    }
            //}
            //else
            //{
            //    MensajeError(sender);
            //    this.vista.dgv_TablaTodasVentas.Rows.Clear();
            //}
        }

        public void ActualizarVentasCategoria(DateTime desde, DateTime hasta, object sender)
        {
            List<Venta> ventasTotales = this.ventaDAO.ReadBetweenDatesCompleteInfo(desde, hasta);
            MessageBox.Show($"Desde: {desde}");
            MessageBox.Show($"Hasta: {hasta}");
            if (ventasTotales.Count != 0)
            {
                Dictionary<string, double> totalVentasCategoria = new Dictionary<string, double>();
                Dictionary<string, double> totalGananciaCategoria = new Dictionary<string, double>();
                Dictionary<string, double> totalProductosCategoria = new Dictionary<string, double>();
                foreach (Categoria categoria in Categorias.CATEGORIAS)
                {
                    totalVentasCategoria.Add(categoria.Nombre, 0);
                }

                foreach (Categoria categoria in Categorias.CATEGORIAS)
                {
                    totalGananciaCategoria.Add(categoria.Nombre, 0);
                }

                foreach (Categoria categoria in Categorias.CATEGORIAS)
                {
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
                foreach (Categoria categoria in Categorias.CATEGORIAS)
                {
                    if (categoria.Nombre != "Todos")
                    {
                        this.vista.dgv_TablaVentasCategoria.Rows.Add(
                        categoria.Nombre,
                        totalProductosCategoria[categoria.Nombre],
                        "$"+totalVentasCategoria[categoria.Nombre],
                        "$"+totalGananciaCategoria[categoria.Nombre]
                        );
                    }
                }
            }
            else
            {
                MensajeError(sender);
                this.vista.dgv_TablaTodasVentas.Rows.Clear();
            }
            
        }

        public void ActualizarEntradas(DateTime desde, DateTime hasta, object sender)
        {
            List<EntradaAlmacen> entradas = this.entradaAlmacenDAO.ReadBetweenDates(desde, hasta);
            if (entradas.Count != 0)
            {
                this.vista.dgv_TablaEntradas.Rows.Clear();
                foreach (EntradaAlmacen entrada in entradas)
                {
                    this.vista.dgv_TablaEntradas.Rows.Add(
                    entrada.Id_entrada,
                    entrada.Codigo_barra,
                    entrada.Producto.Descripcion,
                    entrada.Cantidad,
                    entrada.Fecha,
                    entrada.Producto.Precio_compra,
                    entrada.Producto.Precio_venta,
                    entrada.Importe);
                }
            }
            else
            {
                MensajeError(sender);
                this.vista.dgv_TablaEntradas.Rows.Clear();
            }
        }

        private void ActivarPeriodo(object label)
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

        public DateTime FiltroMes(DateTime hoy)
        {
            DateTime inicioMes = hoy;
            int diasMenos;
            //this.desde = DateTime.Today;
            //MessageBox.Show(string.Format("Día {0}. Mes {1}. Año {2}. ", this.desde.Day, this.desde.Month, this.desde.Year));
            hoy = hoy.AddDays(-1);
            diasMenos = hoy.Day;
            inicioMes = inicioMes.AddDays(-diasMenos).AddHours(-23).AddMinutes(-59).AddSeconds(-59);
            return inicioMes;
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
    }
}
