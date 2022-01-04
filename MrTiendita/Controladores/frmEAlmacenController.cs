﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;
using MrTiendita.Vistas;
using Acciones;

namespace MrTiendita.Controladores
{
    class frmEAlmacenController
    {
        private frmEAlmacen vista;
        private ProductoDAO productoDAO;
        private Productos_Facade facade = new Productos_Facade();

        public frmEAlmacenController(frmEAlmacen vista){
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.vista.tablaProductos.CellContentClick += new DataGridViewCellEventHandler(tablaProductos_CellContentClick);
            this.vista.Load += new EventHandler(vista_load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(tb_busqueda_TextChanged);
            this.vista.btn_nuevoProducto.Click += new EventHandler(btn_nuevoProducto_Click);
        }

        private void vista_load(object sender, EventArgs e)
        {
            facade.Consultar(this.vista);
        }

        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String condicion = this.vista.tb_busqueda.Text;
            List<Producto> productos = this.productoDAO.readByName(condicion);
            this.vista.tablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta, xProducto.Precio_compra);
            }
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaProductos.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                facade.Eliminar(this.vista, e);
            }
            else if (this.vista.tablaProductos.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                this.actualizarProducto(e);
            }
        }

        private void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto editar = new frmProducto("agregar", -1);
            editar.ShowDialog();
            facade.Consultar(this.vista);
        }

        private void actualizarProducto(DataGridViewCellEventArgs e)
        {
            String _id = this.vista.tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            long id = long.Parse(_id);
            frmProducto editar = new frmProducto("editar", id);
            editar.ShowDialog();
            facade.Consultar(this.vista);
        }
    }
}
