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
    public class FrmReportesController
    {
        private Form formActivado;
        private readonly FrmRVentas fromVentas;
        private readonly FrmREntradas fromEntradas;
        private readonly FrmReportes vista;

        public FrmReportesController(FrmReportes vista)
        {
            this.vista = vista;
            this.formActivado = null;
            this.fromVentas = new FrmRVentas();
            this.fromEntradas = new FrmREntradas();
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_entradasAlmacen.Click += new EventHandler(Btn_entradasAlmacen_Click);
            this.vista.btn_ventas.Click += new EventHandler(Btn_ventas_Click);
            this.vista.dp_desde.onValueChanged += new EventHandler(Dp_desde_onValueChanged);
            this.vista.dp_hasta.onValueChanged += new EventHandler(Dp_hasta_onValueChanged);
            
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            this.vista.dp_desde.Value = DateTime.Now;
            this.vista.dp_hasta.Value = DateTime.Now;
        }

        private void Btn_ventas_Click(object sender, EventArgs e)
        {
            this.vista.btn_entradasAlmacen.Textcolor = Color.FromArgb(100, 118, 140);
            this.vista.btn_ventas.Textcolor = Color.FromArgb(30, 207, 245);
            this.vista.lbl_desde.ForeColor = Color.Black;
            this.vista.lbl_hasta.ForeColor = Color.Black;
            this.vista.dp_desde.BackColor = Color.FromArgb(186, 211, 17);
            this.vista.dp_hasta.BackColor = Color.FromArgb(186, 211, 17);
            AbrirFormulario(this.fromVentas);
        }

        private void Btn_entradasAlmacen_Click(object sender, EventArgs e)
        {
            this.vista.btn_ventas.Textcolor = Color.FromArgb(100, 118, 140);
            this.vista.btn_entradasAlmacen.Textcolor = Color.FromArgb(30, 207, 245);
            this.vista.lbl_desde.ForeColor = Color.Black;
            this.vista.lbl_hasta.ForeColor = Color.Black;
            this.vista.dp_desde.BackColor = Color.FromArgb(186, 211, 17);
            this.vista.dp_hasta.BackColor = Color.FromArgb(186, 211, 17);
            AbrirFormulario(this.fromEntradas);
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

        private void Dp_desde_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            DateTime fechaHasta = this.vista.dp_hasta.Value;
            DateTime fechaDesde = this.vista.dp_desde.Value;
            this.fromEntradas.controller.ActualizarEntradas(fechaDesde, fechaHasta);
            this.fromVentas.controller.ActualizarVentas(fechaDesde, fechaHasta);
        }

        private void Dp_hasta_onValueChanged(object sender, EventArgs e)
        {
            //yyyy - mm - dd hh: mm: ss
            DateTime fechaHasta = this.vista.dp_hasta.Value;
            DateTime fechaDesde = this.vista.dp_desde.Value;
            this.fromEntradas.controller.ActualizarEntradas(fechaDesde, fechaHasta);
            this.fromVentas.controller.ActualizarVentas(fechaDesde, fechaHasta);
        }
    }
}
