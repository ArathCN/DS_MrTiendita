using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace MrTiendita.Controladores
{
    public class FrmInventarioController
    {
        private FrmInventario vista;
        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private Panel pnlActivado = null;

        public FrmInventarioController(FrmInventario vista)
        {
            this.vista = vista;
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_NuevaEntrada.Click += new EventHandler(Btn_NuevaEntrada_Click);
            this.vista.btn_CrearProducto.Click += new EventHandler(Btn_CrearProducto_Click);
            this.vista.btn_ModificarProducto.Click += new EventHandler(Btn_ModificarProducto_Click);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160,2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            this.vista.btn_ModificarProducto.Visible = false;
            ActivarBoton(this.vista.btn_NuevaEntrada);
            AbrirPanel(this.vista.pnl_NuevaEntrada);
        }

        private void Btn_ConsultarProductos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            bordeInferior.Location = new Point(botonSeleccionado.Location.X + 15, 42);
        }

        private void Btn_NuevaEntrada_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirPanel(this.vista.pnl_NuevaEntrada);
        }

        private void Btn_CrearProducto_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirPanel(this.vista.pnl_CrearProducto);
        }

        private void Btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            bordeInferior.Location = new Point(botonSeleccionado.Location.X + 15, 42);
        }


        //Métodos auxiliares
        private void ActivarBoton(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                botonSeleccionado = (Guna2Button)boton;
                botonSeleccionado.ForeColor = Color.FromArgb(0, 134, 255);
                bordeInferior.BackColor = Color.FromArgb(0, 134, 255);
                bordeInferior.Location = new Point(botonSeleccionado.Location.X+18, 45);
                bordeInferior.BringToFront();
                bordeInferior.Visible = true;
            }
        }

        private void DeshabilitarBoton()
        {
            if (botonSeleccionado != null)
                botonSeleccionado.ForeColor = Color.FromArgb(70, 70, 74);
        }

        private void AbrirPanel(Panel PanelHijo)
        {
            if (pnlActivado != null)
                pnlActivado.Visible = false;
            pnlActivado = PanelHijo;
            this.vista.pnl_MenuProductos.Controls.Add(PanelHijo);
            this.vista.pnl_MenuProductos.Tag = PanelHijo;
            PanelHijo.Location = new Point(18, 62);
            PanelHijo.BringToFront();
            pnlActivado.Visible = true;
        }
    }
}
