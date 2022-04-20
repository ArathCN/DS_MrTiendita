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
    }
}
