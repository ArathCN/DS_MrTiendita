using MrTiendita.Modelos.DTO;
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
    public partial class frmCobro : Form
    {
        public frmCobro(List<Producto> productos, double total)
        {
            InitializeComponent();
            frmCobroController controller = new frmCobroController(this, productos, total);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_metodoPago_onItemSelected(object sender, EventArgs e)
        {
            if (cb_metodoPago.selectedIndex == 0)
            {
                pnl_efectivo.Visible = true;
            }
        }
    }
}
