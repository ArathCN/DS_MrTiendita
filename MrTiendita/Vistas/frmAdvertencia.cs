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
    /// <summary> Vista del formulario FrmAdvertencia. </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmAdvertencia : Form
    {
        /// <summary> Initializes a new instance of the <see cref="FrmAdvertencia"/> class. </summary>
        /// <param name="mensaje">The mensaje.</param>
        public FrmAdvertencia(string mensaje)
        {
            InitializeComponent();
            sha_Sombra.SetShadowForm(this);
            lbl_Mensaje.Text = mensaje;
        }

        /// <summary> Handles the 1 event of the btn_Si_Click control. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Si_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary> Handles the 1 event of the btn_No_Click control. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_No_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
