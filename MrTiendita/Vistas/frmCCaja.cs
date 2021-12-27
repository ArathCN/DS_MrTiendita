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
    }
}
