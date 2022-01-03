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
    public partial class frmRVentas : Form
    {
        public frmRVentasController controller;

        public frmRVentas()
        {
            InitializeComponent();
            //tablaVentas.Rows.Add("1", "661440000953", "1211", "Efectivo", "2021-11-08 23:15:01", "2.00", "103.00");
            //tablaVentas.Rows.Add("2", "661440000951", "1211", "Tarjeta", "2021-11-09 23:15:01", "3.00", "220.00");
            widthColumnas();
            tablaVentas.AllowUserToAddRows = false;
            tablaVentas.CurrentCell = null;
            controller = new frmRVentasController(this);
        }

        public void widthColumnas()
        {
            tablaVentas.Columns[0].Width = 43;
            tablaVentas.Columns[1].Width = 144;
            tablaVentas.Columns[2].Width = 134;
            tablaVentas.Columns[3].Width = 155;
            tablaVentas.Columns[4].Width = 165;
            tablaVentas.Columns[5].Width = 95;
            //tablaVentas.Columns[6].Width = 85;
        }
    }
}
