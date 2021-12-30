﻿using System;
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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private Form formActivado = null;

        private void AbrirFormulario(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(FormHijo);
            Contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btn_ventas.Textcolor = Color.FromArgb(100, 118, 140);
            btn_entradasAlmacen.Textcolor = Color.FromArgb(30, 207, 245);
            lbl_desde.ForeColor = Color.Black;
            lbl_hasta.ForeColor = Color.Black;
            dp_desde.BackColor = Color.FromArgb(186, 211, 17);
            dp_hasta.BackColor = Color.FromArgb(186, 211, 17);
            AbrirFormulario(new frmREntradas());
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            //100; 118; 140
            btn_entradasAlmacen.Textcolor = Color.FromArgb(100, 118, 140);
            btn_ventas.Textcolor = Color.FromArgb(30, 207, 245);
            lbl_desde.ForeColor = Color.Black;
            lbl_hasta.ForeColor = Color.Black;
            dp_desde.BackColor = Color.FromArgb(186, 211, 17);
            dp_hasta.BackColor = Color.FromArgb(186, 211, 17);
            AbrirFormulario(new frmRVentas());
        }
    }
}
