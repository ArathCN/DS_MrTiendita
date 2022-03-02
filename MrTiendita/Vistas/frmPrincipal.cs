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
    public partial class FrmPrincipal : Form
    {
        private Form formActivado = null;

        public bool esCerrado = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseno();
            FrmPrincipalController controlador = new FrmPrincipalController(this);
        }

        private void PersonalizarDiseno()
        {
            pnl_OpCajero.Visible = false;
            pnl_OpEncargado.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnl_OpCajero.Visible == true)
                pnl_OpCajero.Visible = false;
            if (pnl_OpEncargado.Visible == true)
                pnl_OpEncargado.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
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

        private void Btn_Cajero_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnl_OpCajero);
            btn_Cajero.FillColor = Color.FromArgb(4, 208, 217);
        }

        private void Btn_Encargado_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnl_OpEncargado);
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

        private void Btn_EReportes_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EReportes.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmReportes());
        }

        private void Btn_CAlmacen_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CAlmacen.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmCAlmacen());
        }

        private void Btn_CCaja_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CCaja.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmCCaja());
        }

        private void Btn_EAlmacen_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EAlmacen.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmEAlmacen());
        }

        private void Btn_EProveedores_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EProveedores.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmProveedores());
        }

        private void Btn_EEmpleados_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_EEmpleados.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmEEmpleado());
        }

        private void Btn_ECaja_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_ECaja.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmCCaja());
        }

        private void Btn_CVentas_Click(object sender, EventArgs e)
        {
            ColorGris();
            btn_CVentas.FillColor = Color.FromArgb(218, 238, 86);
            AbrirFormulario(new FrmCVentas());
        }

        private void Btn_EVentas_Click(object sender, EventArgs e)
        {
            ColorGris();
            AbrirFormulario(new FrmCVentas());
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new FrmAdvertencia("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                esCerrado = true;
                Application.Exit();
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (esCerrado == false)
            {
                e.Cancel = true;
                esCerrado = true;
                this.Hide();
            }
        }
    }
}
