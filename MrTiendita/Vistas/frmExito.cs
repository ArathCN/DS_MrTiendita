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
    public partial class FrmExito : Form
    {
        public FrmExito(string mensaje)
        {
            InitializeComponent();
            sombra.SetShadowForm(this);
            lbl_Mensaje.Text = mensaje;
        }

        private void frmExito_Load(object sender, EventArgs e)
        {
   
        }

        public static void confirmacionForm(string mensaje)
        {
            FrmExito frm = new FrmExito(mensaje);
            frm.ShowDialog();
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
