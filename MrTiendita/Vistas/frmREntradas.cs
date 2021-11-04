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
    public partial class frmREntradas : Form
    {
        public frmREntradas()
        {
            InitializeComponent();
            tablaEntradas.Rows.Add("1", "Distribiudora Bimbo", "27/10/2021", "661440000953", "20", "20.50", "25.00","410.00");
            tablaEntradas.Rows.Add("2", "Coca Cola", "27/10/2021", "661440000952", "35", "14.60", "17.00", "511.00");
            widthColumnas();
            tablaEntradas.AllowUserToAddRows = false;
            tablaEntradas.CurrentCell = null;
        }

        public void widthColumnas()
        {
            tablaEntradas.Columns[0].Width = 30;
            tablaEntradas.Columns[1].Width = 150;
            tablaEntradas.Columns[2].Width = 100;
            tablaEntradas.Columns[3].Width = 155;
            tablaEntradas.Columns[4].Width = 100;
            tablaEntradas.Columns[5].Width = 120;
            tablaEntradas.Columns[6].Width = 85;
        }
    }
}
