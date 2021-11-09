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

namespace MrTiendita.Vistas
{
    public partial class frmPrincipal : Form
    {
        private Form formActivado = null;
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
                btn_Cajero.Normalcolor = Color.FromArgb(240, 240, 240);
                btn_Encargado.Normalcolor = Color.FromArgb(240, 240, 240);
            }
            else
                subMenu.Visible = false;
                
        }

        private void ColorGris()
        {
            btn_CAlmacen.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_CCaja.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_CVentas.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_EAlmacen.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_EReportes.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_EProveedores.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_EEmpleados.Normalcolor = Color.FromArgb(240, 240, 240);
            btn_ECaja.Normalcolor = Color.FromArgb(240, 240, 240);
        }

        private void btn_Cajero_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(pnl_OpCajero);
            btn_Cajero.Normalcolor = Color.FromArgb(4, 208, 217);
        }

        private void btn_Encargado_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(pnl_OpEncargado);
            btn_Encargado.Normalcolor = Color.FromArgb(4, 208, 217);
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
            btn_EReportes.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmReportes());
        }

        private void btn_CAlmacen_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CAlmacen.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCAlmacen());
        }

        private void btn_CCaja_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CCaja.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCCaja());
        }

        private void btn_EAlmacen_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EAlmacen.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmEAlmacen());
        }

        private void btn_EProveedores_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EProveedores.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmProveedores());
        }

        private void btn_EEmpleados_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EEmpleados.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmEEmpleado());
        }

        private void btn_ECaja_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_ECaja.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCCaja());
        }

        private void btn_CVentas_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CVentas.Normalcolor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new frmCVentas());
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmAdvertencia("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
           
        }
    }
}
