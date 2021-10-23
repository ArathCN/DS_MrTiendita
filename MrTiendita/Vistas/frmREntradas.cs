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
            tablaEntradas.Rows.Add("1", "P23", "13/10/2021", "661440000953", "DR457GT8", "20", "20.50", "410");
            widthColumnas();
            tablaEntradas.AllowUserToAddRows = false;
        }

        public void widthColumnas()
        {
            tablaEntradas.Columns[0].Width = 55;
            tablaEntradas.Columns[1].Width = 55;
            tablaEntradas.Columns[2].Width = 100;
            tablaEntradas.Columns[3].Width = 155;
            tablaEntradas.Columns[4].Width = 150;
            tablaEntradas.Columns[5].Width = 115;
            tablaEntradas.Columns[6].Width = 115;
        }
    }
}
