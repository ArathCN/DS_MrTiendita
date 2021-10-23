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
    public partial class frmProducto : Form
    {
        public frmProducto(string accion, long id)
        {
            InitializeComponent();
            if (accion == "agregar")
            {
                lbl_Titulo.Text = "Agregar producto";
            }
            else
            {
                lbl_Titulo.Text = "Actualizar producto";
            }
            frmProductoController controlador = new frmProductoController(this, accion, id);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
