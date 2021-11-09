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
    public partial class frmCVentas : Form
    {
        public frmCVentas()
        {
            InitializeComponent();
            //tablaVentas.Rows.Add("2", "Azúcar Zulka baja en calorías", "30.50", "61.00");
            widthColumnas();
            tablaVentas.AllowUserToAddRows = false;
            tablaVentas.CurrentCell = null;
            frmCVentasController controller = new frmCVentasController(this);
        }

        public void widthColumnas()
        {
            tablaVentas.Columns[0].Width = 100;
            tablaVentas.Columns[1].Width = 350;
            tablaVentas.Columns[2].Width = 140;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            frmCobro frm = new frmCobro();
            frm.ShowDialog();
        }
    }
}
