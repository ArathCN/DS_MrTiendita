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
    public partial class frmEAlmacen : Form
    {
        public frmEAlmacen()
        {
            InitializeComponent();
            //tablaProductos.Rows.Add("661440000953", "10", "Azúcar Zulka baja en calorías", "30.50");
            widthColumnas();
            tablaProductos.AllowUserToAddRows = false;
            frmEAlmacenController controlador = new frmEAlmacenController(this);
        }

        public void widthColumnas()
        {
            tablaProductos.Columns[0].Width = 120;
            tablaProductos.Columns[1].Width = 75;
            tablaProductos.Columns[2].Width = 245;
        }        

        
    }
}
