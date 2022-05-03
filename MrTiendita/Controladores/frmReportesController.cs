using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Vistas;
using Guna.UI2.WinForms;

namespace MrTiendita.Controladores
{
    public class FrmReportesController
    {
        private Form formActivado;
        private readonly FrmRVentas fromVentas;
        private readonly FrmREntradas fromEntradas;
        private readonly FrmReportes_ vista;
        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private Panel pnlActivado;

        public FrmReportesController(FrmReportes_ vista)
        {
            this.vista = vista;
            this.formActivado = null;
            this.fromVentas = new FrmRVentas();
            this.fromEntradas = new FrmREntradas();
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_Ventas.Click += new EventHandler(Btn_Ventas_Click);
            this.vista.btn_Entradas.Click += new EventHandler(Btn_Entradas_Click);
            //this.vista.dp_desde.onValueChanged += new EventHandler(Dp_desde_onValueChanged);
            //this.vista.dp_hasta.onValueChanged += new EventHandler(Dp_hasta_onValueChanged);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            this.vista.dp_DesdeEntradas.Value = DateTime.Now;
            this.vista.dp_HastaEntradas.Value = DateTime.Now;
            this.vista.dp_DesdeVentas.Value = DateTime.Now;
            this.vista.dp_DesdeEntradas.Value = DateTime.Now;
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            ActivarBoton(this.vista.btn_Ventas);
            this.vista.pnl_Ventas.Visible = true;
            this.vista.pnl_EntradasAlmacen.Visible = false;
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            this.vista.pnl_Ventas.Visible = true;
            this.vista.pnl_EntradasAlmacen.Visible = false;
        }

        private void Btn_Entradas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            this.vista.pnl_Ventas.Visible = false;
            this.vista.pnl_EntradasAlmacen.Visible = true;
        }


        private void Dp_desde_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            //DateTime fechaHasta = this.vista.dp_hasta.Value;
            //DateTime fechaDesde = this.vista.dp_desde.Value;
            //this.fromEntradas.controller.ActualizarEntradas(fechaDesde, fechaHasta);
            //this.fromVentas.controller.ActualizarVentas(fechaDesde, fechaHasta);
        }

        private void Dp_hasta_onValueChanged(object sender, EventArgs e)
        {
            ////yyyy - mm - dd hh: mm: ss
            //DateTime fechaHasta = this.vista.dp_hasta.Value;
            //DateTime fechaDesde = this.vista.dp_desde.Value;
            //this.fromEntradas.controller.ActualizarEntradas(fechaDesde, fechaHasta);
            //this.fromVentas.controller.ActualizarVentas(fechaDesde, fechaHasta);
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

    }
}
