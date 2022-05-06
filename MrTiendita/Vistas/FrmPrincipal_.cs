using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MrTiendita.Vistas;
using MrTiendita.Controladores;

namespace MrTiendita.Vistas
{
    public partial class FrmPrincipal_ : Form
    {
        public bool esCerrado = false, esActivado = false;
        private Form formActivado = null;
        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private FrmTablero tablero;
        private FrmMovimientos movimientos;
        private FrmInventario inventario;
        private FrmTableroController controller;
        private FrmMovimientosController movimientosController;

        public FrmPrincipal_()
        {
            InitializeComponent();
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(3, 40);
            pnl_Menu.Controls.Add(bordeInferior);
            this.tablero = new FrmTablero();
            this.movimientos = new FrmMovimientos(true);
            this.inventario = new FrmInventario();
            FrmTableroController frmTableroController = new FrmTableroController(this.tablero);
            FrmMovimientosController frmMovimientosController = new FrmMovimientosController(this.movimientos);
            this.controller = frmTableroController;
            this.movimientosController = frmMovimientosController;

            //AbrirFormulario(this.tablero);
            AbrirTablero(this.tablero);
            ActivarBoton(this.btn_Tablero);
            pnl_Contenedor2.Visible = true;
            pnl_Contenedor.Visible = false;
            this.tablero.btn_AtajoVenta.Click += new EventHandler(Btn_AtajoVenta_Click);
            this.tablero.btn_AtajoProductos.Click += new EventHandler(Btn_AtajoProductos_Click);
            this.tablero.btn_AtajoEntrada.Click += new EventHandler(Btn_AtajoEntrada_Click);
            this.tablero.btn_AtajoSalida.Click += new EventHandler(Btn_AtajoSalida_Click);
            this.tablero.btn_AtajoCorte.Click += new EventHandler(Btn_AtajoCorte_Click);
        }

        private void Btn_AtajoCorte_Click(object sender, EventArgs e)
        {
            this.movimientos = new FrmMovimientos(true);
            AbrirFormulario(this.movimientos);
            ActivarBoton(btn_Movimientos);
        }
        private void Btn_AtajoSalida_Click(object sender, EventArgs e)
        {
            this.movimientos = new FrmMovimientos(false);
            this.movimientos.pnl_MenuProductos.BorderColor = Color.FromArgb(0, 134, 255);
            this.movimientos.pnl_MenuProductos.BorderThickness = 2;
            this.movimientos.cb_TipoMov.SelectedIndex = 1;
            AbrirFormulario(this.movimientos);
            ActivarBoton(btn_Movimientos);
        }

        private void Btn_AtajoEntrada_Click(object sender, EventArgs e)
        {
            this.movimientos = new FrmMovimientos(false);
            this.movimientos.pnl_MenuProductos.BorderColor = Color.FromArgb(0, 134, 255);
            this.movimientos.pnl_MenuProductos.BorderThickness = 2;
            this.movimientos.cb_TipoMov.SelectedIndex = 0;
            AbrirFormulario(this.movimientos);
            ActivarBoton(btn_Movimientos);
        }

        private void Btn_AtajoVenta_Click(object sender, EventArgs e) 
        {
            AbrirFormulario(new FrmVentas());
            ActivarBoton(btn_Ventas);
        }

        private void Btn_AtajoProductos_Click(object sender, EventArgs e)
        {
            this.inventario = new FrmInventario();
            this.inventario.pnl_MenuProductos.BorderColor = Color.FromArgb(0, 134, 255);
            this.inventario.pnl_MenuProductos.BorderThickness = 2;
            AbrirFormulario(this.inventario);
            ActivarBoton(btn_Inventario);
        }

        private void AbrirFormulario(Form FormHijo)
        {
            pnl_Contenedor.Visible = true;
            pnl_Contenedor2.Visible = false;
            if (formActivado != null) 
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            pnl_Contenedor.Controls.Add(FormHijo);
            pnl_Contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void AbrirTablero(Form FormHijo)
        {
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            pnl_Contenedor2.Controls.Add(FormHijo);
            pnl_Contenedor2.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            pnl_Contenedor2.Visible = true;
            pnl_Contenedor.Visible = false;
        }

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConfiguraciones());
            ActivarBoton(sender);
            esActivado = true;
        }

        private void btn_Tablero_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmTablero());
            controller.ModificarNotificacion(this.tablero.flp_ListaNotificaciones);
            controller.ObtenerValorCaja();
            AbrirTablero(this.tablero);
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentas());
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmpleados());
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmProveedores());
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_Movimientos_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new FrmMovimientos(false));
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes_());
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInventario());
            ActivarBoton(sender);
            esActivado = false;
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            esActivado = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new FrmAdvertencia("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                esCerrado = true;
                Application.Exit();
            }
        }

        private void FrmPrincipal__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (esCerrado == false)
            {
                e.Cancel = true;
                esCerrado = true;
                this.Hide();
                AbrirTablero(this.tablero);
            }
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

            if (esActivado)
                ActivarBoton(btn_Configuracion);
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (esActivado)
                ActivarBoton(btn_Configuracion);
        }

        //Metodos auxiliares
        private void ActivarBoton(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                this.botonSeleccionado = (Guna2Button)boton;
                this.botonSeleccionado.FillColor = Color.FromArgb(221, 226, 249);
                this.bordeInferior.BackColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.Location = new Point(0, this.botonSeleccionado.Location.Y);
                this.bordeInferior.BringToFront();
                this.bordeInferior.Visible = true;
            }
        }

        private void DeshabilitarBoton()
        {
            if (this.botonSeleccionado != null)
            {
                this.botonSeleccionado.ForeColor = Color.FromArgb(70, 70, 74);
                this.botonSeleccionado.FillColor = Color.FromArgb(237, 240, 255);
            }
            
        }

        private void FrmPrincipal__Load(object sender, EventArgs e)
        {
            
        }
    }
}
