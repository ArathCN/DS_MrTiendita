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
    public partial class frmEEmpleado : Form
    {
        public frmEEmpleado()
        {
            InitializeComponent();
            //tablaEmpleados.Rows.Add("1211", "Ana Sofía", "De Haro", "De La Cruz", "6221828945", "$5500", "Cajero", "AnaSofia27.");
            //tablaEmpleados.Rows.Add("1212", "Ricardo Alan", "Pasos", "Teposte", "6622906919", "$5500", "Cajero", "Ricardo1234!");
            //tablaEmpleados.Rows.Add("1213", "Sebastian Arath", "Cañedo", "Núñez", "6623596075", "$6000", "Encargado", "Sebastian1234!");
            widthColumnas();
            tablaEmpleados.AllowUserToAddRows = false;
            tablaEmpleados.CurrentCell = null;
            frmEEmpleadosController controlador = new frmEEmpleadosController(this);
        }

        public void widthColumnas()
        {
            tablaEmpleados.Columns[0].Width = 100;
            tablaEmpleados.Columns[1].Width = 100;
            tablaEmpleados.Columns[2].Width = 110;
            tablaEmpleados.Columns[3].Width = 110;
            tablaEmpleados.Columns[4].Width = 95;
            tablaEmpleados.Columns[5].Width = 80;
            tablaEmpleados.Columns[6].Width = 85;
        }
    }
}
