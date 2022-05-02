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
    public class FrmBuscarProductoController
    {
        private FrmBuscarProducto vista;
        private ProductoDAO productoDAO;


        public FrmBuscarProductoController(FrmBuscarProducto vista) 
        { 
            this.vista = vista;

            this.productoDAO = new ProductoDAO();

            this.vista.Load += new EventHandler(Vista_Load);

            this.vista.tb_BuscarProducto.TextChanged += new EventHandler(Tb_BuscarProducto_TextChanged);

            this.vista.cb_Categoria.TextChanged += new EventHandler (Cb_Categoria_TextChanged);

            this.vista.dgv_TablaProductos.CellContentClick += new DataGridViewCellEventHandler(Dgv_TablaProductos_CellContentClick);

        }

        private void Vista_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        protected void MostrarProductos()
        {
            this.vista.dgv_TablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta);
            }
        }

        private void Tb_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProducto.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta);
            }
        }
        
        private void Cb_Categoria_TextChanged(object sender, EventArgs e) 
        {

            String cadenaBusqueda = this.vista.cb_Categoria.Text;

            if (cadenaBusqueda == "Todos")
            {

                this.vista.dgv_TablaProductos.Rows.Clear();
                List<Producto> productos1 = this.productoDAO.ReadAll();
                foreach (Producto xProducto in productos1)
                {
                    this.vista.dgv_TablaProductos.Rows.Add(
                        xProducto.Descripcion,
                        xProducto.Categoria,
                        xProducto.Precio_venta);
                }
            }
            else {
                List<Producto> productos = this.productoDAO.ReadByCategoria(cadenaBusqueda);
                this.vista.dgv_TablaProductos.Rows.Clear();
                foreach (Producto xProducto in productos)
                {
                    this.vista.dgv_TablaProductos.Rows.Add(
                        xProducto.Descripcion,
                        xProducto.Categoria,
                        xProducto.Precio_venta);
                }
            }  
        }

        private void Dgv_TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_AgregarCarrito"].Selected)
            {
                this.AgregarVenta(e);
            }
        }

        private void AgregarVenta(DataGridViewCellEventArgs e) 
        { 

        }
    }
}




 
 
 
 

 
 
