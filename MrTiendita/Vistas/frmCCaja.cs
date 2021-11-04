using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Vistas
{
    public partial class frmCCaja : Form
    {
        public frmCCaja()
        {
            InitializeComponent();
            tablaMovimientos.Rows.Add("Ingreso de dinero", "27/10/2021", "$500.00", "$1567.00");
            widthColumnas();
            tablaMovimientos.AllowUserToAddRows = false;
            tablaMovimientos.CurrentCell = null;
            
        }

        public void widthColumnas()
        {
            tablaMovimientos.Columns[0].Width = 210;
            tablaMovimientos.Columns[1].Width = 140;
            tablaMovimientos.Columns[2].Width = 130;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmCCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
