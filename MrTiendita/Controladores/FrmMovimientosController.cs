using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using MrTiendita.Patrones;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using iText.Kernel.Pdf;
using System.IO;
using iTextSharp.text.pdf;
using iText.Layout;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Utils;

namespace MrTiendita.Controladores
{
    class FrmMovimientosController
    {
        private FrmMovimientos vista;

        private MovimientoDAO movimientoDAO;
        private VentaDAO VentaDAO;
        private CajaDAO cajaDAO;
        private Caja valorCaja;
        
        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private String movimientoSeleccionado;
        private Label periodo;

        //Corte de caja
        private Dictionary<string, string> corteCaja;
        private List<Movimiento> entradas;
        private List<Movimiento> salidas;
        private Dictionary<string, double> ventas;
        private Dictionary<string, double> ganancias;

        public FrmMovimientosController(FrmMovimientos vista)
        {
            this.vista = vista;
            this.movimientoDAO = new MovimientoDAO();
            this.VentaDAO = new VentaDAO();
            this.cajaDAO = new CajaDAO();
            this.corteCaja = new Dictionary<string, string>();
            this.ventas = new Dictionary<string, double>();
            this.ganancias = new Dictionary<string, double>();
            this.entradas = new List<Movimiento>();
            this.salidas = new List<Movimiento>();
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuSuperior.Controls.Add(bordeInferior);
            this.vista.Load += new EventHandler(Vista_Load);

            //Borde
            this.vista.pnl_MenuProductos.Click += new EventHandler(Pnl_MenuProductos_Click);

            //Pestañas
            this.vista.btn_ConsultarMovimientos.Click += new EventHandler(Btn_ConsultarMovimientos_Click);
            this.vista.btn_CorteCaja.Click += new EventHandler(Btn_CorteCaja_Click);

            //Vista de corte de caja
            this.vista.btn_GuardarArchivo.Click += new EventHandler(btn_GuardarArchivo_Click);

            //Vista de movimientos
            this.vista.cb_FiltroMovimientos.SelectedIndexChanged += new EventHandler(cb_FiltroMovimientos_SelectedIndexChanged);
            this.vista.lbl_mostrarTodos.Click += new EventHandler(lbl_mostrarTodos_Click);
            this.vista.lbl_Hoy.Click += new EventHandler(lbl_Hoy_Click);
            this.vista.lbl_EsteMes.Click += new EventHandler(lbl_EsteMes_Click);
            this.vista.lbl_EstaSemana.Click += new EventHandler(lbl_EstaSemana_Click);

            //formulario
            this.vista.tb_Importe.TextChanged += delegate (object sender, EventArgs e)
            {
                this.vista.pnl_MenuProductos.BorderThickness = 0;
                double datoEvaluar;
                ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, "", this.vista.tb_Importe.Text, out datoEvaluar, ValidacionDatosOpciones.CANTIDAD);
            };
            this.vista.tb_Desc.TextChanged += delegate (object sender, EventArgs e)
            {
                this.vista.pnl_MenuProductos.BorderThickness = 0;
                ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, "", this.vista.tb_Desc.Text, ValidacionDatosOpciones.CATEGORIA);
            };
            this.vista.btn_LimpiarEntrada.Click += new EventHandler(btn_LimpiarEntrada_Click);
            this.vista.btn_RegistrarMov.Click += new EventHandler(btn_RegistrarMov_Click);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            if (this.vista.esAtajo == false)
            {
                this.ActivarBoton(this.vista.btn_ConsultarMovimientos, new Point(this.vista.btn_ConsultarMovimientos.Location.X + 15, 40));
                this.PrepararVistaMovimientos();
                this.ObtenerValorCaja();
            }
            else
            {
                this.ActivarBoton(this.vista.btn_CorteCaja, new Point(this.vista.btn_CorteCaja.Location.X + 18, 40));
                this.PrepararVistaCorte();
                this.ObtenerValorCaja();
                this.vista.tlp_DisplayCorte.Visible = true;
                this.vista.tlp_DisplayConsultar.Visible = false;
            }
            this.ActivarPeriodo(this.vista.lbl_mostrarTodos);
            
        }

        //Borde
        private void Pnl_MenuProductos_Click(object sender, EventArgs e)
        {
            this.vista.pnl_MenuProductos.BorderThickness = 0;
        }

        //Pestañas
        private void Btn_ConsultarMovimientos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, new Point(this.vista.btn_ConsultarMovimientos.Location.X + 15, 40));
            this.vista.tlp_DisplayConsultar.Visible = true;
            this.vista.tlp_DisplayCorte.Visible = false;
            this.PrepararVistaMovimientos();
        }

        private void Btn_CorteCaja_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, new Point(this.vista.btn_CorteCaja.Location.X + 18, 40));
            this.vista.tlp_DisplayCorte.Visible = true;
            this.vista.tlp_DisplayConsultar.Visible = false;
            this.PrepararVistaCorte();
        }


        //Mátodos vista corte de caja
        private void btn_GuardarArchivo_Click(object sender, EventArgs e)
        {
            this.vista.btn_GuardarArchivo.Enabled = false;
            try
            {
                this.GenerarCorteCaja();
            }
            catch (Exception ex)
            {
                FrmError error = new FrmError(ex.Message);
                error.ShowDialog();
                return;
            }

            this.vista.btn_GuardarArchivo.Enabled = true;

        }

        //Metodos vista movimientos
        private void cb_FiltroMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipo = "";
            if (this.vista.cb_FiltroMovimientos.SelectedIndex == 0)
            {
                //this.vista.lbl_totaltxt.Text = "Total de efectivo:";
                tipo = TipoMovimiento.TODO;
            }
            if (this.vista.cb_FiltroMovimientos.SelectedIndex == 1)
            {
                //this.vista.lbl_totaltxt.Text = "Total de efectivo por entradas:";
                tipo = TipoMovimiento.ENTRADA;
            }
            if (this.vista.cb_FiltroMovimientos.SelectedIndex == 2)
            {
                //this.vista.lbl_totaltxt.Text = "Total de efectivo por salidas:";
                tipo = TipoMovimiento.SALIDA;
            }
            if (this.vista.cb_FiltroMovimientos.SelectedIndex == 3)
            {
                //this.vista.lbl_totaltxt.Text = "Total de efectivo por ventas:";
                tipo = TipoMovimiento.VENTA;
            }

            this.movimientoSeleccionado = tipo;

            this.MostrarMovimientos(tipo);
        }

        private void lbl_mostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarMovimientos(this.movimientoSeleccionado);
            ActivarPeriodo(sender);
        }

        private void lbl_Hoy_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today;
            DateTime final = DateTime.Today;

            //Se le pone horas, minutos y segundos para que se refiera al final del día
            final = final.AddHours(23);
            final = final.AddMinutes(59);
            final = final.AddSeconds(59);
            this.MostrarMovimientos(this.movimientoSeleccionado, inicio, final, sender);
            ActivarPeriodo(sender);
        }

        private void lbl_EsteMes_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime inicio = new DateTime(hoy.Year, hoy.Month, 1, 0, 0, 0);
            DateTime final = new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month), 23, 59, 59);
            ActivarPeriodo(sender);

            this.MostrarMovimientos(this.movimientoSeleccionado, inicio, final, sender);
            Console.WriteLine(inicio.ToString("yyyy-MM-dd HH:mm:ss") + "  -->  " + final.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void lbl_EstaSemana_Click(object sender, EventArgs e)
        {
            DateTime hoy_ = DateTime.Now;
            DateTime hoy = new DateTime(hoy_.Year, hoy_.Month, hoy_.Day, 0, 0, 0);

            int diaSemana = (int)hoy.DayOfWeek;
            if (diaSemana == 0) diaSemana = 7;
            diaSemana--;
            DateTime inicio = hoy.AddDays(-diaSemana);
            DateTime final = hoy.AddDays(6 - diaSemana);
            ActivarPeriodo(sender);
            this.MostrarMovimientos(this.movimientoSeleccionado, inicio, final, sender);
            Console.WriteLine(inicio.ToString("yyyy-MM-dd HH:mm:ss") + "  -->  " + final.ToString("yyyy-MM-dd HH:mm:ss"));
        }


        //Formulario
        private void btn_LimpiarEntrada_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.OcultarErrores();
        }

        private void btn_RegistrarMov_Click(object sender, EventArgs e)
        {
            String importeCadena = this.vista.tb_Importe.Text;
            String concepto = this.vista.tb_Desc.Text;
            int tipoIndice = this.vista.cb_TipoMov.SelectedIndex; //0 -> entrada   1->salida

            String tipo = "";
            double importe, dinero = 0;
            bool esValido = false;


            //Comprobar que el tipo de movimiento se haya seleccionado, concepto no sea nulo y que importe sea numero no nulo mayor a 0.
            if (this.vista.cb_TipoMov.SelectedIndex == -1 ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, "", concepto, ValidacionDatosOpciones.CATEGORIA) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, "", importeCadena, out importe, ValidacionDatosOpciones.CANTIDAD))
            {
                FrmError error = new FrmError("Se deben de llenar todos los campos correctamente");
                error.ShowDialog();
                return;
            }

            //Si es una entrada se suma la caja, si es una salida se resta
            //Si es salida comprobar que no se quiera sacar más de lo que hay en la caja
            if (tipoIndice == 0)
            {
                tipo = TipoMovimiento.ENTRADA;
                dinero = double.Parse(this.valorCaja.Valor) + importe;
            }
            else if (tipoIndice == 1)
            {
                if (importe > double.Parse(this.valorCaja.Valor))
                {
                    FrmError error = new FrmError("No hay dinero suficiente en la caja");
                    error.ShowDialog();
                    return;
                }
                tipo = TipoMovimiento.SALIDA;
                dinero = double.Parse(this.valorCaja.Valor) - importe;
            }

            this.valorCaja.Valor = dinero.ToString();

            Movimiento movimiento = new Movimiento(-1, tipo, DateTime.Now, importe, dinero, concepto);

            esValido = this.movimientoDAO.Create(movimiento, this.valorCaja);
            if (!esValido)
            {
                FrmError error = new FrmError("Hubo un error al registrar el movimiento. ->  " + this.movimientoDAO.MensajeError);
                error.ShowDialog();
                return;
            }            

            FrmExito mensajeExito = new FrmExito("Se registrado el movimiento con éxito.");
            mensajeExito.ShowDialog();
            this.MostrarMovimientos(TipoMovimiento.TODO);
            this.ObtenerValorCaja();

            this.LimpiarCampos();
            this.OcultarErrores();
        }


        //Métodos auxiliares
        private void ActivarBoton(object boton, Point punto)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                this.botonSeleccionado = (Guna2Button)boton;
                this.botonSeleccionado.ForeColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.BackColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.Location = punto;
                this.bordeInferior.BringToFront();
                this.bordeInferior.Visible = true;
            }
        }

        private void DeshabilitarBoton()
        {
            if (this.botonSeleccionado != null)
                this.botonSeleccionado.ForeColor = Color.FromArgb(70, 70, 74);
        }

        private void LimpiarCampos()
        {
            this.vista.cb_TipoMov.SelectedIndex = -1;
            this.vista.tb_Importe.Text = "";
            this.vista.tb_Desc.Text = "";
        }

        private void OcultarErrores()
        {
            this.vista.lbl_ErrorImporte.Visible = false;
            this.vista.lbl_ErrorDesc.Visible = false;
        }

        private void PrepararVistaMovimientos()
        {
            this.vista.cb_FiltroMovimientos.SelectedIndex = 0;
        }

        private void PrepararVistaCorte()
        {
            this.corteCaja.Clear();
            this.entradas.Clear();
            this.salidas.Clear();
            this.ventas.Clear();
            this.ganancias.Clear();
            this.vista.dgv_TablaEntradas.Rows.Clear();
            this.vista.dgv_TablaSalidas.Rows.Clear();

            DateTime hoy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            String dia = hoy.ToString("dd");
            String mes = hoy.ToString("MMMM", new CultureInfo("es-MX"));
            String anio = hoy.ToString("yyyy");

            List<Venta> ventasTotales = new List<Venta>();
            List<Venta> ventasEfectivo = new List<Venta>();
            List<Venta> ventasTarjeta = new List<Venta>();

            double totalVentas = 0;
            double totalVentasEfectivo = 0;
            double totalVentasTarjeta = 0;

            double totalEntradas = 0;
            double totalSalidas = 0;

            double totalGanancia = 0;

            NumberFormatInfo formato = new CultureInfo("es-MX").NumberFormat;
            formato.CurrencyGroupSeparator = ",";
            formato.NumberDecimalSeparator = ".";
            formato.CurrencyDecimalDigits = 2;

            foreach (Categoria categoria in Categorias.CATEGORIAS)
            {
                this.ventas.Add(categoria.Nombre, 0);
            }

            foreach (Categoria categoria in Categorias.CATEGORIAS)
            {
                this.ganancias.Add(categoria.Nombre, 0);
            }

            //Obtener las ventas y clasificarlas
            ventasTotales = this.VentaDAO.ReadBetweenDatesCompleteInfo(hoy, fin);
            foreach (Venta venta in ventasTotales)
            {
                //Sumar las ventas por cada tipo de pago
                if (venta.Metodo_pago == TipoMovimiento.EFECTIVO)
                {
                    ventasEfectivo.Add(venta);
                    totalVentasEfectivo += venta.Importe;
                }
                else if (venta.Metodo_pago == TipoMovimiento.TARJETA)
                {
                    ventasTarjeta.Add(venta);
                    totalVentasTarjeta += venta.Importe;
                }

                //Sumar las ventas a cada categoría
                if (this.ventas.ContainsKey(venta.Producto.Categoria))
                {
                    this.ventas[venta.Producto.Categoria] += venta.Importe;
                    this.ganancias[venta.Producto.Categoria] += venta.Importe - (venta.Producto.Precio_compra * venta.Cantidad);
                }
                else //no debería salir erro si cuando se dan de alta productos se usan las constantes de Categorias
                {
                    Form error = new FrmError("No se encontró -->" + venta.Producto.Categoria);
                    error.ShowDialog();
                }

                totalGanancia += venta.Importe - (venta.Producto.Precio_compra * venta.Cantidad);
                totalVentas += venta.Importe;
            }


            //Obtener las entradas y salida, sacar el total de cada una e implimir en la tabla
            this.entradas = this.movimientoDAO.Read(TipoMovimiento.ENTRADA, hoy, fin);
            this.salidas = this.movimientoDAO.Read(TipoMovimiento.SALIDA, hoy, fin);
            foreach (Movimiento movimiento in this.entradas)
            {
                totalEntradas += movimiento.Importe;
                this.vista.dgv_TablaEntradas.Rows.Add(movimiento.Concepto, movimiento.Importe.ToString("C", formato));
            }
            foreach (Movimiento movimiento in this.salidas)
            {
                totalSalidas += movimiento.Importe;
                this.vista.dgv_TablaSalidas.Rows.Add(movimiento.Concepto, movimiento.Importe.ToString("C", formato));
            }

            //Imprimir los resultados, los de las tablas se imprimen en los foreach para no hacer otro ciclo sólo de imprimir
            this.corteCaja.Add("fechaCorte", dia + " de " + mes + " de " + anio);
            this.corteCaja.Add("fechaHoraCorte", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " Hrs");
            this.corteCaja.Add("totalVentas", totalVentas.ToString("C", formato));
            this.corteCaja.Add("ventasTotales", totalVentas.ToString("C", formato));
            this.corteCaja.Add("ventasEfectivo", totalVentasEfectivo.ToString("C", formato));
            this.corteCaja.Add("ventasTarjeta", totalVentasTarjeta.ToString("C", formato));
            this.corteCaja.Add("numeroVentas", ventasTotales.Count().ToString());
            this.corteCaja.Add("gananciasTotales", totalGanancia.ToString("C", formato));

            this.vista.lbl_FechaCorte.Text = dia + " de " + mes + " de " + anio;
            this.vista.lbl_VentasTotales.Text = totalVentas.ToString("C", formato);

            this.vista.lbl_VentasEfectivo.Text = totalVentasEfectivo.ToString("C", formato);
            this.vista.lbl_VentasTarjeta.Text = totalVentasTarjeta.ToString("C", formato);

            this.vista.lbl_EntradasTotales.Text = totalEntradas.ToString("C", formato);
            this.vista.lbl_SalidasTotales.Text = totalSalidas.ToString("C", formato);

            this.vista.lbl_GananciasTotales.Text = totalGanancia.ToString("C", formato);

            this.vista.lbl_VentaFrutas.Text = this.ventas[Categorias.FRUTAS_VERDURAS.Nombre].ToString("C", formato);
            this.vista.lbl_VentasPanaderia.Text = this.ventas[Categorias.PANADERIA_TORTILLERIA.Nombre].ToString("C", formato);
            this.vista.lbl_VentasCarniceria.Text = this.ventas[Categorias.CARNICERIA.Nombre].ToString("C", formato);
            this.vista.lbl_VentasLacteos.Text = this.ventas[Categorias.LACTEOS.Nombre].ToString("C", formato);
            this.vista.lbl_VentasAbarrotes.Text = this.ventas[Categorias.ABARROTES.Nombre].ToString("C", formato);
            this.vista.lbl_VentasLimpieza.Text = this.ventas[Categorias.LIMPIEZA_HOGAR.Nombre].ToString("C", formato);
            this.vista.lbl_VentasHigiene.Text = this.ventas[Categorias.HIGENE_PERSONAL_SALUD.Nombre].ToString("C", formato);
            this.vista.lbl_VentasMascotas.Text = this.ventas[Categorias.MASCOTAS.Nombre].ToString("C", formato);
            this.vista.lbl_VentasRefrigerados.Text = this.ventas[Categorias.REFRIGERADOS.Nombre].ToString("C", formato);
            this.vista.lbl_VentasSinCategoria.Text = this.ventas[Categorias.SIN_CATEGORIA.Nombre].ToString("C", formato);

            this.vista.lbl_GananciaFrutas.Text = this.ganancias[Categorias.FRUTAS_VERDURAS.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaPanaderia.Text = this.ganancias[Categorias.PANADERIA_TORTILLERIA.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaCarniceria.Text = this.ganancias[Categorias.CARNICERIA.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaLacteos.Text = this.ganancias[Categorias.LACTEOS.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaAbarrotes.Text = this.ganancias[Categorias.ABARROTES.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaLimpieza.Text = this.ganancias[Categorias.LIMPIEZA_HOGAR.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaHigiene.Text = this.ganancias[Categorias.HIGENE_PERSONAL_SALUD.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaMascotas.Text = this.ganancias[Categorias.MASCOTAS.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaRefrigerados.Text = this.ganancias[Categorias.REFRIGERADOS.Nombre].ToString("C", formato);
            this.vista.lbl_GananciaSinCategoria.Text = this.ganancias[Categorias.SIN_CATEGORIA.Nombre].ToString("C", formato);
        }

        private void MostrarMovimientos(String filtro, DateTime inicio, DateTime fin, object sender)
        {
            List<Movimiento> movimientos = this.movimientoDAO.Read(filtro, inicio, fin);
            this.vista.tablaMovimientos.Rows.Clear();
            if (movimientos.Count == 0) MensajeError(sender);
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(
                    movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, "$" + movimiento.Importe);
            }
        }

        private void MostrarMovimientos(String filtro)
        {
            List<Movimiento> movimientos = this.movimientoDAO.ReadByType(filtro);
            this.vista.tablaMovimientos.Rows.Clear();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(
                    movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, "$" + movimiento.Importe);
            }
        }

        private void ObtenerValorCaja()
        {
            this.valorCaja = this.cajaDAO.ReadByName("Total");
            if (this.valorCaja == null)
            {
                FrmError error = new FrmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                return;
            }
            this.vista.lbl_EfetivoCaja.Text = "$" + this.valorCaja.Valor;
            this.vista.lbl_EfetivoCajaCorte.Text = "$" + this.valorCaja.Valor;
        }
      
        private void GenerarCorteCaja()
        {
            DateTime hoy = DateTime.Now;
            Random random = new Random();
            long numeroR = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            NumberFormatInfo formato = new CultureInfo("es-MX").NumberFormat;
            formato.CurrencyGroupSeparator = ",";
            formato.NumberDecimalSeparator = ".";
            formato.CurrencyDecimalDigits = 2;


            string plantillaCorteCaja = Properties.Settings.Default.RutaTickets + @"\plantillaCorteCaja.pdf";
            string corteCajaPreeliminar = Properties.Settings.Default.RutaTickets + @"\CorteCajaP" + numeroR + ".pdf";
            string corteCajaEntradasSalidas = Properties.Settings.Default.RutaTickets + @"\CorteCajaES" + numeroR + ".pdf";
            string corteCajaFinal = Properties.Settings.Default.RutaTickets + @"\CorteCaja_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm") + ".pdf";

            bool result = File.Exists(plantillaCorteCaja);
            if (!result)
            {
                FrmError error = new FrmError("La plantilla de corte de caja no se encuentra.");
                error.ShowDialog();
                return;
            }

            /////////////////////////
            // Primero se crea el corte de caja con los datos que se pueden poner con adobe
            iTextSharp.text.pdf.PdfReader pdfReader = null;

            // Create the form filler
            FileStream pdfOutputFile = new FileStream(corteCajaPreeliminar, FileMode.Create);

            pdfReader = new iTextSharp.text.pdf.PdfReader(plantillaCorteCaja);

            PdfStamper pdfStamper = null;

            pdfStamper = new PdfStamper(pdfReader, pdfOutputFile);

            // Get the form fields
            AcroFields testForm = pdfStamper.AcroFields;

            // Fill the form
            testForm.SetField("fechaCorte", this.corteCaja["fechaCorte"]);
            testForm.SetField("fechaHoraCorte", this.corteCaja["fechaHoraCorte"]);
            testForm.SetField("totalVentas", this.corteCaja["totalVentas"]);
            testForm.SetField("ventasTotales", this.corteCaja["ventasTotales"]);
            testForm.SetField("ventasEfectivo", this.corteCaja["ventasEfectivo"]);
            testForm.SetField("ventasTarjeta", this.corteCaja["ventasTarjeta"]);
            testForm.SetField("numeroVentas", this.corteCaja["numeroVentas"]);
            testForm.SetField("gananciasTotales", this.corteCaja["gananciasTotales"]);

            testForm.SetField("ventas_sinCategoria", this.ventas[Categorias.SIN_CATEGORIA.Nombre].ToString("C", formato));
            testForm.SetField("ventas_frutasVerduras", this.ventas[Categorias.FRUTAS_VERDURAS.Nombre].ToString("C", formato));
            testForm.SetField("ventas_panaderiaTortilleria", this.ventas[Categorias.PANADERIA_TORTILLERIA.Nombre].ToString("C", formato));
            testForm.SetField("ventas_carniceria", this.ventas[Categorias.CARNICERIA.Nombre].ToString("C", formato));
            testForm.SetField("ventas_lacteos", this.ventas[Categorias.LACTEOS.Nombre].ToString("C", formato));
            testForm.SetField("ventas_abarrotes", this.ventas[Categorias.ABARROTES.Nombre].ToString("C", formato));
            testForm.SetField("ventas_limpiezaHogar", this.ventas[Categorias.LIMPIEZA_HOGAR.Nombre].ToString("C", formato));
            testForm.SetField("ventas_higiene", this.ventas[Categorias.HIGENE_PERSONAL_SALUD.Nombre].ToString("C", formato));
            testForm.SetField("ventas_mascotas", this.ventas[Categorias.MASCOTAS.Nombre].ToString("C", formato));
            testForm.SetField("ventas_refrigerados", this.ventas[Categorias.REFRIGERADOS.Nombre].ToString("C", formato));

            testForm.SetField("ganancias_sinCategoria", this.ganancias[Categorias.SIN_CATEGORIA.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_frutasVerduras", this.ganancias[Categorias.FRUTAS_VERDURAS.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_panaderia", this.ganancias[Categorias.PANADERIA_TORTILLERIA.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_carniceria", this.ganancias[Categorias.CARNICERIA.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_lacteos", this.ganancias[Categorias.LACTEOS.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_abarrotes", this.ganancias[Categorias.ABARROTES.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_limpieza", this.ganancias[Categorias.LIMPIEZA_HOGAR.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_higiene", this.ganancias[Categorias.HIGENE_PERSONAL_SALUD.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_mascotas", this.ganancias[Categorias.MASCOTAS.Nombre].ToString("C", formato));
            testForm.SetField("ganancias_refrigerados", this.ganancias[Categorias.REFRIGERADOS.Nombre].ToString("C", formato));


            //’Flatten’ (make the text go directly onto the pdf) and close the form
            pdfStamper.FormFlattening = true;

            pdfStamper.Close();
            pdfReader.Close();


            ////////////////////////////
            //Ahora se crea un archivo pdf con las entradas y salidas de dinerp
            iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter(corteCajaEntradasSalidas));
            Document document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.LETTER);
            document.SetMargins(20f, 15f, 20f, 15f);
            iText.Kernel.Font.PdfFont fuente = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);


            document.Add(new Paragraph("Entradas de efectivo").SetFont(fuente).SetFontSize(16).SetBold().SetTextAlignment(TextAlignment.CENTER));

            Table tablaEntradas = new Table(UnitValue.CreatePercentArray(2));
            tablaEntradas.SetWidth(UnitValue.CreatePercentValue(60));
            tablaEntradas.SetTextAlignment(TextAlignment.JUSTIFIED);
            tablaEntradas.SetFont(fuente);
            tablaEntradas.SetFontSize(12);
            tablaEntradas.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            tablaEntradas.AddHeaderCell(new Cell().Add(new Paragraph("Concepto").SetFont(fuente).SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablaEntradas.AddHeaderCell(new Cell().Add(new Paragraph("Importe").SetFont(fuente).SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));

            foreach (Movimiento movimiento in this.entradas)
            {
                tablaEntradas.AddCell(movimiento.Concepto);
                tablaEntradas.AddCell(new Cell().Add(new Paragraph(movimiento.Importe.ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
            }

            document.Add(tablaEntradas);


            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph("Salidas de efectivo").SetFont(fuente).SetFontSize(16).SetBold().SetTextAlignment(TextAlignment.CENTER));
            
            Table tablasalidas = new Table(UnitValue.CreatePercentArray(2));
            tablasalidas.SetWidth(UnitValue.CreatePercentValue(60));
            tablasalidas.SetTextAlignment(TextAlignment.JUSTIFIED);
            tablasalidas.SetFont(fuente);
            tablasalidas.SetFontSize(12);
            tablasalidas.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            tablasalidas.AddHeaderCell(new Cell().Add(new Paragraph("Concepto").SetFont(fuente).SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            tablasalidas.AddHeaderCell(new Cell().Add(new Paragraph("Importe").SetFont(fuente).SetBold().SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)));
            foreach (Movimiento movimiento in this.salidas)
            {
                tablasalidas.AddCell(movimiento.Concepto);
                tablasalidas.AddCell(new Cell().Add(new Paragraph(movimiento.Importe.ToString("C", formato))).SetTextAlignment(TextAlignment.CENTER));
            }
            document.Add(tablasalidas);

            document.Close();



            ////////////////////////////////
            //Juntamos el documento con los datos generales y el documento con las tablas
            iText.Kernel.Pdf.PdfDocument CorteFinal = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfWriter(corteCajaFinal));
            string[] docsToMerge = new string[] { corteCajaPreeliminar, corteCajaEntradasSalidas };
            for (int a = 0; a < docsToMerge.Length; a++)
            {
                iText.Kernel.Pdf.PdfDocument origPdf2 = new iText.Kernel.Pdf.PdfDocument(new iText.Kernel.Pdf.PdfReader(docsToMerge[a]));
                PdfMerger merger = new PdfMerger(CorteFinal);
                merger.Merge(origPdf2, 1, origPdf2.GetNumberOfPages());

                origPdf2.Close();

            }
            CorteFinal.Close();

            File.Delete(corteCajaPreeliminar);
            File.Delete(corteCajaEntradasSalidas);

            FrmExito exito = new FrmExito("Se ha realizado el corte");
            exito.ShowDialog();
        }
      
        public void ActivarCorte(object sender)
        {
            ActivarBoton(sender, new Point(this.vista.btn_CorteCaja.Location.X + 18, 40));
            this.vista.tlp_DisplayCorte.Visible = true;
            this.vista.tlp_DisplayConsultar.Visible = false;
            this.PrepararVistaCorte();
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

        public void MensajeError(object sender)
        {
            string mensaje = "no se mostrará ningún movimiento. Seleccione mostrar todos";
            if (sender == this.vista.lbl_Hoy)
            {
                FrmError frmError = new FrmError($"Hoy no ha hecho movimientos, {mensaje} o agregue un movimiento.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_EstaSemana)
            {
                FrmError frmError = new FrmError($"Esta semana no ha hecho movimientos, {mensaje} o agregue un movimiento.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_EsteMes)
            {
                FrmError frmError = new FrmError($"Este mes no ha hecho movimientos, {mensaje} o agregue un movimiento.");
                frmError.ShowDialog();
            }
            else if (sender == this.vista.lbl_mostrarTodos)
            {
                FrmError frmError = new FrmError($"No ha hecho movimientos, realice uno nuevo para comenzar un registro.");
                frmError.ShowDialog();
            }
        }

    }
}
