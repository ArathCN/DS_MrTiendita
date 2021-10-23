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
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
  
        }

        private void btn_Cajero_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_OpCajero);
        }

        private void btn_Encargado_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_OpEncargado);
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
            AbrirFormulario(new frmReportes());
        }

        private void btn_CAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCAlmacen());
        }

        private void btn_CCaja_Click(object sender, EventArgs e)
        {

        }

        private void btn_EAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEAlmacen());
        }

        private void btn_EProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());
        }

        private void btn_EEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btn_ECaja_Click(object sender, EventArgs e)
        {

        }

        private void btn_CVentas_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmError("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
           
        }
    }
}
