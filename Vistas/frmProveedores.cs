using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MrTiendita.Controladores;

namespace VistasMrTiendita
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            tablaProveedores.Rows.Add("", "Distribuidora Bimbo", "6621828945");
            widthColumnas();
            tablaProveedores.AllowUserToAddRows = false;
            //frmEProveedorController controlador = new frmEProveedorController(this);
        }

        public void widthColumnas()
        {
            tablaProveedores.Columns[1].Width = 290;
            tablaProveedores.Columns[2].Width = 180;
            //tablaProductos.Columns[4].Width = 39;
            //tablaProductos.Columns[5].Width = 39;
        }

    }
}
