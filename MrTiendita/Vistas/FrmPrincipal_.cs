using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Vistas
{
    public partial class FrmPrincipal_ : Form
    {
        public bool esCerrado = false;
        private Form formActivado = null;
        public FrmPrincipal_()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            pnl_Contenedor.Controls.Add(FormHijo);
            pnl_Contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConfiguraciones());
        }

        private void btn_Tablero_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTablero());
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentas());
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmpleados());
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProveedores());
        }

        private void btn_Movimientos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {

        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
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

        private void FrmPrincipal__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (esCerrado == false)
            {
                e.Cancel = true;
                esCerrado = true;
                this.Hide();
                AbrirFormulario(new FrmTablero());
            }
        }
    }
}
