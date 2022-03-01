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
    public partial class FrmEAlmacen : Form
    {
        public FrmEAlmacen()
        {
            InitializeComponent();
            //tablaProductos.Rows.Add("661440000953", "10", "Azúcar Zulka baja en calorías", "30.50", "29.00");
            widthColumnas();
            tablaProductos.AllowUserToAddRows = false;
            tablaProductos.CurrentCell = null;
            FrmEAlmacenController controlador = new FrmEAlmacenController(this);
        }

        public void widthColumnas()
        {
            tablaProductos.Columns[0].Width = 120;
            tablaProductos.Columns[1].Width = 75;
            tablaProductos.Columns[2].Width = 246;
            tablaProductos.Columns[3].Width = 105;
            tablaProductos.Columns[4].Width = 105;
        }
    }
}
