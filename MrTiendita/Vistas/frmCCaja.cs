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
    public partial class frmCCaja : Form
    {
        public frmCCaja()
        {
            InitializeComponent();
            //tablaMovimientos.Rows.Add("Entrada", "Pago a proveedor Sabritas","27/10/2021 20:12:56 PM", "$500.00");
            widthColumnas();
            tablaMovimientos.AllowUserToAddRows = false;
            tablaMovimientos.CurrentCell = null;
            frmCCajaController controller = new frmCCajaController(this);

        }

        public void widthColumnas()
        {
            tablaMovimientos.Columns[0].Width = 97;
            tablaMovimientos.Columns[1].Width = 256;
            tablaMovimientos.Columns[2].Width = 174;
        }

        private void cb_tipoMov2_onItemSelected(object sender, EventArgs e)
        {
            lbl_totaltxt.Visible = true;
            lbl_total.Visible = true;
            if (cb_tipoMov2.selectedIndex == 0)
            {
                lbl_totaltxt.Text = "Total de dinero por entradas:";
            }
            if (cb_tipoMov2.selectedIndex == 1)
            {
                lbl_totaltxt.Text = "Total de dinero por salidas:";
            }
            if (cb_tipoMov2.selectedIndex == 2)
            {
                lbl_totaltxt.Text = "Total de dinero por ventas:";
            }
        }
    }
}
