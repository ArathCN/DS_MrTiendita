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
    public partial class frmAdvertencia : Form
    {
        public frmAdvertencia(string mensaje)
        {
            InitializeComponent();
            sombra.SetShadowForm(this);
            lbl_Mensaje.Text = mensaje;
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
