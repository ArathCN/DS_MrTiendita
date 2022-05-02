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
        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private Panel pnlActivado;


        public FrmMovimientosController(FrmMovimientos vista)
        {
            this.vista = vista;

            this.vista.Load += new EventHandler(Vista_Load);

            //Pestañas
            this.vista.btn_ConsultarMovimientos.Click += new EventHandler(Btn_ConsultarMovimientos_Click);
            this.vista.btn_CorteCaja.Click += new EventHandler(Btn_CorteCaja_Click);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuSuperior.Controls.Add(bordeInferior);
            this.ActivarBoton(this.vista.btn_ConsultarMovimientos);
            
        }

        private void Btn_ConsultarMovimientos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            this.bordeInferior.Location = new Point(this.botonSeleccionado.Location.X + 15, 40);
            this.vista.tlp_DisplayConsultar.Visible = true;
            this.vista.tlp_DisplayCorte.Visible = false;
        }

        private void Btn_CorteCaja_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            this.vista.tlp_DisplayCorte.Visible = true;
            this.vista.tlp_DisplayConsultar.Visible = false;
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
                this.bordeInferior.Location = new Point(this.botonSeleccionado.Location.X + 18, 40);
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
