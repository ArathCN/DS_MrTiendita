﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using MrTiendita.Patrones;
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
        private EntradaAlmacenDAO entradaAlmacenDAO;
        private ProductoDAO productoDAO;
        private Productos_Facade Productos = new Productos_Facade();

        public FrmInventarioController(FrmInventario vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.productoDAO = new ProductoDAO();

            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_NuevaEntrada.Click += new EventHandler(Btn_NuevaEntrada_Click);
            this.vista.btn_CrearProducto.Click += new EventHandler(Btn_CrearProducto_Click);
            this.vista.btn_ModificarProducto.Click += new EventHandler(Btn_ModificarProducto_Click);
            this.vista.tb_BuscarProducto.TextChanged += new EventHandler(Tb_BuscarProducto_TextChanged);
            this.vista.dgv_TablaProductos.CellContentClick += new DataGridViewCellEventHandler(Dgv_TablaProductos_CellContentClick);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            this.vista.btn_ModificarProducto.Visible = false;
            ActivarBoton(this.vista.btn_NuevaEntrada);
            AbrirPanel(this.vista.pnl_NuevaEntrada);
            MostrarProductos();
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

        private void Tb_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProducto.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Cantidad_actual,
                    xProducto.Descripcion,
                    xProducto.Precio_venta
                );
            }
        }

        private void Dgv_TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Productos.Eliminar(this.vista, e);
            }
            else if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                this.ActualizarProducto(e);
            }
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
                bordeInferior.Location = new Point(botonSeleccionado.Location.X + 18, 45);
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

        protected void MostrarProductos()
        {
            this.vista.dgv_TablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Descripcion,
                    xProducto.Precio_compra,
                    CalcularPrecioVenta(xProducto.Ganancia, xProducto.Precio_compra),
                    xProducto.Ganancia,
                    xProducto.Categoria,
                    xProducto.Cantidad_actual,
                    xProducto.Minimo) ;
            }
        }

        private double CalcularPrecioVenta(double ganancia, double precioCompra)
        {
            double porcentajeGanancia, precioVenta;
            porcentajeGanancia = ganancia * 0.01;
            precioVenta = precioCompra + (precioCompra * porcentajeGanancia);
            return precioVenta;
        }

        private void ActualizarProducto(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.vista.btn_ModificarProducto.Visible = true;
            ActivarBoton(this.vista.btn_ModificarProducto);

            //long id = long.Parse(idCadena);
            //FrmProducto editar = new FrmProducto("editar", id);
            //editar.ShowDialog();
            MostrarProductos();
        }
    }
}
