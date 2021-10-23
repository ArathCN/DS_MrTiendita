using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;
using MrTiendita.Vistas;

namespace MrTiendita.Controladores
{
    class frmEAlmacenController
    {
        private frmEAlmacen vista;
        private ProductoDAO productoDAO;

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
            this.mostrarTodos();
        }

        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String condicion = this.vista.tb_busqueda.Text;
            List<Producto> productos = this.productoDAO.readByName(condicion);
            this.vista.tablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta);
            }
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaProductos.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                this.eliminarProducto(e);
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
            this.mostrarTodos();
        }

        ///////////////////////////////
        ///Métodos auxiliares
        ///
        private void mostrarTodos()
        {
            this.vista.tablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.readAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta);
            }
        }

        private void eliminarProducto(DataGridViewCellEventArgs e)
        {
            Form mensaje = new frmError("El producto se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                //para el ejemplo borrare la unica que hay
                String _id = this.vista.tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(_id);
                bool res = this.productoDAO.delete(id);
                if (res)
                {
                    this.vista.tablaProductos.Rows.Remove(this.vista.tablaProductos.Rows[e.RowIndex]);
                    Form mensajeExito = new frmError("El producto fue eliminado");
                    this.mostrarTodos();
                }
                else
                {
                    Form mensajeError = new frmError("Error al eliminar el producto.");
                    mensajeError.ShowDialog();
                }
            }
        }

        private void actualizarProducto(DataGridViewCellEventArgs e)
        {
            String _id = this.vista.tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            long id = long.Parse(_id);
            frmProducto editar = new frmProducto("editar", id);
            editar.ShowDialog();
            this.mostrarTodos();
        }
    }
}
