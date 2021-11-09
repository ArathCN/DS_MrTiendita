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
            //tablaMovimientos.Rows.Add("Entrada", "27/10/2021 20:12 PM", "$500.00", "$1567.00");
            widthColumnas();
            tablaMovimientos.AllowUserToAddRows = false;
            tablaMovimientos.CurrentCell = null;
            frmCCajaController controller = new frmCCajaController(this);

        }

        public void widthColumnas()
        {
            tablaMovimientos.Columns[0].Width = 207;
            tablaMovimientos.Columns[1].Width = 173;
            tablaMovimientos.Columns[2].Width = 137;
        }
    }
}
