using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Controladores;
using MrTiendita.Patrones;

namespace MrTiendita.Vistas
{
    public partial class frmPrincipal : Form
    {
        private Form formActivado = null;
        private bool bandera = false;
        public frmPrincipal()
        {
            InitializeComponent();
            personalizarDiseno();
            frmPrincipalController controlador = new frmPrincipalController(this);
        }

        private void personalizarDiseno()
        {
            pnl_OpCajero.Visible = false;
            pnl_OpEncargado.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnl_OpCajero.Visible == true)
                pnl_OpCajero.Visible = false;
            if (pnl_OpEncargado.Visible == true)
                pnl_OpEncargado.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
                btn_Cajero.FillColor = Color.FromArgb(240, 240, 240);
                btn_Encargado.FillColor = Color.FromArgb(240, 240, 240);
            }
            else
                subMenu.Visible = false;

        }

        private void ColorGris()
        {
            btn_CAlmacen.FillColor = Color.FromArgb(240, 240, 240);
            btn_CCaja.FillColor = Color.FromArgb(240, 240, 240);
            btn_CVentas.FillColor = Color.FromArgb(240, 240, 240);
            btn_EAlmacen.FillColor = Color.FromArgb(240, 240, 240);
            btn_EReportes.FillColor = Color.FromArgb(240, 240, 240);
            btn_EProveedores.FillColor = Color.FromArgb(240, 240, 240);
            btn_EEmpleados.FillColor = Color.FromArgb(240, 240, 240);
            btn_ECaja.FillColor = Color.FromArgb(240, 240, 240);
        }

        private void btn_Cajero_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(pnl_OpCajero);
            btn_Cajero.FillColor = Color.FromArgb(4, 208, 217);
        }

        private void btn_Encargado_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(pnl_OpEncargado);
            btn_Encargado.FillColor = Color.FromArgb(4, 208, 217);
        }

        private void AbrirFormulario(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(FormHijo);
            Contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btn_EReportes_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EReportes.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmReportes());
        }

        private void btn_CAlmacen_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CAlmacen.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCAlmacen());
        }

        private void btn_CCaja_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CCaja.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCCaja());
        }

        private void btn_EAlmacen_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EAlmacen.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmEAlmacen());
        }

        private void btn_EProveedores_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EProveedores.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmProveedores());
        }

        private void btn_EEmpleados_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EEmpleados.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmEEmpleado());
        }

        private void btn_ECaja_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_ECaja.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCCaja());
        }

        private void btn_CVentas_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CVentas.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCVentas());
        }

        private void btn_EVentas_Click(object sender, EventArgs e)
        {
            ColorGris();
            AbrirFormulario(new frmCVentas());
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmAdvertencia("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                bandera = true;
                Application.Exit();
            }

        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            bandera = true;
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bandera == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
