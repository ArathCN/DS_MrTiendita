using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Vistas;

namespace MrTiendita.Controladores
{
    public class frmReportesController
    {
        private Form formActivado;
        private frmRVentas fromVentas;
        private frmREntradas fromEntradas;
        private frmReportes vista;

        public frmReportesController(frmReportes vista)
        {
            this.vista = vista;
            this.formActivado = null;
            this.fromVentas = new frmRVentas();
            this.fromEntradas = new frmREntradas();
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.btn_entradasAlmacen.Click += new EventHandler(btn_entradasAlmacen_Click);
            this.vista.btn_ventas.Click += new EventHandler(btn_ventas_Click);
            this.vista.dp_desde.onValueChanged += new EventHandler(dp_desde_onValueChanged);
            this.vista.dp_hasta.onValueChanged += new EventHandler(dp_hasta_onValueChanged);
            
        }

        private void vista_Load(object sender, EventArgs e)
        {
            this.vista.dp_desde.Value = DateTime.Now;
            this.vista.dp_hasta.Value = DateTime.Now;
            //this.AbrirFormulario(this.fromEntradas);
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            //100; 118; 140
            this.vista.btn_entradasAlmacen.Textcolor = Color.FromArgb(100, 118, 140);
            this.vista.btn_ventas.Textcolor = Color.FromArgb(30, 207, 245);
            this.vista.lbl_desde.ForeColor = Color.Black;
            this.vista.lbl_hasta.ForeColor = Color.Black;
            this.vista.dp_desde.BackColor = Color.FromArgb(186, 211, 17);
            this.vista.dp_hasta.BackColor = Color.FromArgb(186, 211, 17);
            AbrirFormulario(this.fromVentas);
            //this.fromEntradas = new frmREntradas();
        }

        private void btn_entradasAlmacen_Click(object sender, EventArgs e)
        {
            this.vista.btn_ventas.Textcolor = Color.FromArgb(100, 118, 140);
            this.vista.btn_entradasAlmacen.Textcolor = Color.FromArgb(30, 207, 245);
            this.vista.lbl_desde.ForeColor = Color.Black;
            this.vista.lbl_hasta.ForeColor = Color.Black;
            this.vista.dp_desde.BackColor = Color.FromArgb(186, 211, 17);
            this.vista.dp_hasta.BackColor = Color.FromArgb(186, 211, 17);
            AbrirFormulario(this.fromEntradas);
            //this.fromVentas = new frmRVentas();
        }

        private void AbrirFormulario(Form FormHijo)
        {
            if (this.formActivado != null)
                this.formActivado.Visible = false;
            this.formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            this.vista.Contenedor.Controls.Add(FormHijo);
            this.vista.Contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void dp_desde_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            DateTime a = this.vista.dp_desde.Value;
            this.fromEntradas.controller.act(this.vista.dp_desde.Value, this.vista.dp_hasta.Value);
            this.fromVentas.controller.act(this.vista.dp_desde.Value, this.vista.dp_hasta.Value);
        }

        private void dp_hasta_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            DateTime a = this.vista.dp_hasta.Value;
            this.fromEntradas.controller.act(this.vista.dp_desde.Value, this.vista.dp_hasta.Value);
            this.fromVentas.controller.act(this.vista.dp_desde.Value, this.vista.dp_hasta.Value);
        }
    }
}
