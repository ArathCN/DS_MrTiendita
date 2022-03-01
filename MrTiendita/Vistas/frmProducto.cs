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
    public partial class FrmProducto : Form
    {
        public FrmProducto(string accion, long id)
        {
            InitializeComponent();
            sombra.SetShadowForm(this);
            if (accion == "agregar")
            {
                lbl_Titulo.Text = "Agregar producto";
            }
            else
            {
                lbl_Titulo.Text = "Actualizar producto";
            }
            FrmProductoController controlador = new FrmProductoController(this, accion, id);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
