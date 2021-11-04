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
    public partial class frmCAlmacen : Form
    {
        public frmCAlmacen()
        {
            InitializeComponent();

            //tablaProductos.Rows.Add("661440000953", "10", "Azúcar Zulka baja en calorías", "30.50");
            widthColumnas();
            tablaProductos.AllowUserToAddRows = false;
            tablaProductos.CurrentCell = null;
            frmCAlmacenController controlador = new frmCAlmacenController(this);
        }

        public void widthColumnas()
        {
            tablaProductos.Columns[0].Width = 120;
            tablaProductos.Columns[1].Width = 75;
            tablaProductos.Columns[2].Width = 245;
        }

        private void check_granel_OnChange(object sender, EventArgs e)
        {
            if (check_granel.Checked == true)
            {
                lb_cantidad.Text = "Kilos:";
            }
            else
            {
                lb_cantidad.Text = "Cantidad:";
            }
    }
    }
}
