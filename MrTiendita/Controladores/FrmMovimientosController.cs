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

namespace MrTiendita.Controladores
{
    class FrmMovimientosController
    {
        private FrmMovimientos vista;

        private MovimientoDAO movimientoDAO;
        private CajaDAO cajaDAO;
        private Caja valorCaja;

        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private Panel pnlActivado;
        private String movimientoSeleccionado;

        public FrmMovimientosController(FrmMovimientos vista)
        {
            this.vista = vista;
            this.movimientoDAO = new MovimientoDAO();
            this.cajaDAO = new CajaDAO();


            this.vista.Load += new EventHandler(Vista_Load);

            //Pestañas
            this.vista.btn_ConsultarMovimientos.Click += new EventHandler(Btn_ConsultarMovimientos_Click);
            this.vista.btn_CorteCaja.Click += new EventHandler(Btn_CorteCaja_Click);

            //Vista de movimientos
            this.vista.cb_FiltroMovimientos.SelectedIndexChanged += new EventHandler(cb_FiltroMovimientos_SelectedIndexChanged);
            this.vista.lbl_Hoy.Click += new EventHandler(lbl_Hoy_Click);
            this.vista.lbl_EsteMes.Click += new EventHandler(lbl_EsteMes_Click);
            this.vista.lbl_EstaSemana.Click += new EventHandler(lbl_EstaSemana_Click);

            //formulario
            this.vista.tb_Importe.TextChanged += delegate (object sender, EventArgs e)
            {
                double datoEvaluar;
                ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, "", this.vista.tb_Importe.Text, out datoEvaluar, ValidacionDatosOpciones.CANTIDAD);
            };
            this.vista.tb_Desc.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, "", this.vista.tb_Desc.Text, ValidacionDatosOpciones.CATEGORIA);
            };
            this.vista.btn_LimpiarEntrada.Click += new EventHandler(btn_LimpiarEntrada_Click);
            this.vista.btn_RegistrarMov.Click += new EventHandler(btn_RegistrarMov_Click);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuSuperior.Controls.Add(bordeInferior);
            this.ActivarBoton(this.vista.btn_ConsultarMovimientos, new Point(this.vista.btn_ConsultarMovimientos.Location.X + 15, 40));

            this.PrepararVistaMovimientos();
            this.ObtenerValorCaja();
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

        private void lbl_Hoy_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Today;
            DateTime final = DateTime.Today;

            //Se le pone horas, minutos y segundos para que se refiera al final del día
            final = final.AddHours(23);
            final = final.AddMinutes(59);
            final = final.AddSeconds(59);
            this.MostrarMovimientos(this.movimientoSeleccionado, inicio, final);
            //Console.WriteLine(inicio.ToString("yyyy-MM-dd HH:mm:ss") + "  -->  " + final.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void lbl_EsteMes_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime inicio = new DateTime(hoy.Year, hoy.Month, 1, 0, 0, 0);
            DateTime final = new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month), 23, 59, 59);

            this.MostrarMovimientos(this.movimientoSeleccionado, inicio, final);
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

            this.MostrarMovimientos(this.movimientoSeleccionado, inicio, final);
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

            //esValido = this.movimientoDAO.Create(movimiento);
            //if (!esValido)
            //{
            //    FrmError error = new FrmError("Hubo un error al registrar el movimiento. ->  " + this.movimientoDAO.MensajeError);
            //    error.ShowDialog();
            //    return;
            //}

            //esValido = this.cajaDAO.UpdateValue("Total", this.valorCaja.Valor);
            //if (!esValido)
            //{
            //    FrmError error = new FrmError("Hubo un error al actualizar el total de la caja. ->  " + this.cajaDAO.MensajeError);
            //    error.ShowDialog();
            //    return;
            //}

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

        }

        private void MostrarMovimientos(String filtro, DateTime inicio, DateTime fin)
        {
            //double total = 0;

            List<Movimiento> movimientos = this.movimientoDAO.Read(filtro, inicio, fin);
            this.vista.tablaMovimientos.Rows.Clear();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(
                    movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, movimiento.Importe);
                //total += movimiento.Importe;
            }

            //this.vista.lbl_total.Text = "$" + total.ToString();

            //Hacer visibles las etiquetas para el total
            //this.vista.lbl_totaltxt.Visible = true;
            //this.vista.lbl_total.Visible = true;
        }

        private void MostrarMovimientos(String filtro)
        {
            //double total = 0;

            List<Movimiento> movimientos = this.movimientoDAO.ReadByType(filtro);
            this.vista.tablaMovimientos.Rows.Clear();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(
                    movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, movimiento.Importe);
                //total += movimiento.Importe;
            }

            //this.vista.lbl_total.Text = "$" + total.ToString();

            //Hacer visibles las etiquetas para el total
            //this.vista.lbl_totaltxt.Visible = true;
            //this.vista.lbl_total.Visible = true;
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
            //this.vista.lbl_totalCaja.Text = this.valorCaja.Valor;
        }
    }
}
