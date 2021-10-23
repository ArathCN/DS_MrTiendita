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
    public partial class frmEditarProveedor : Form
    {
        public frmEditarProveedor(string accion, int id)
        {
            InitializeComponent();
            if (accion == "agregar")
            {
                lbl_Titulo.Text = "Agregar proveedor";
            }
            else
            {
                lbl_Titulo.Text = "Actualizar proveedor";
            }
            frmProveedorController controlador = new frmProveedorController(this, accion, id);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
