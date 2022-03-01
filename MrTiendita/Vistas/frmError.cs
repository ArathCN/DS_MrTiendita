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
    public partial class FrmError : Form
    {
        public FrmError(string mensaje)
        {
            InitializeComponent();
            sombra.SetShadowForm(this);
            lbl_Mensaje.Text = mensaje;
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
