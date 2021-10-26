using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasMrTiendita
{
    public partial class frmExito : Form
    {
        public frmExito(string mensaje)
        {
            InitializeComponent();
            lbl_Mensaje.Text = mensaje;
        }

        private void frmExito_Load(object sender, EventArgs e)
        {
   
        }

        public static void confirmacionForm(string mensaje)
        {
            frmExito frm = new frmExito(mensaje);
            frm.ShowDialog();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
