using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using System.Windows.Forms;

namespace Acciones
{
    class Productos
    {
        private ProductoDAO productoDAO = new ProductoDAO();
        private long id;

        public bool Agregar(Producto producto)
        {
            bool res = productoDAO.create(producto);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha hecho el producto con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        public bool Actualizar(Producto producto)
        {
            bool res = productoDAO.updateInfo(producto, this.id);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha actualizado el producto con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        public void Eliminar(frmEAlmacen vista, DataGridViewCellEventArgs e)
        {
            Form mensaje = new frmError("El producto se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                //para el ejemplo borrare la unica que hay
                String _id = vista.tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(_id);
                bool res = productoDAO.delete(id);
                if (res)
                {
                    vista.tablaProductos.Rows.Remove(vista.tablaProductos.Rows[e.RowIndex]);
                    Form mensajeExito = new frmError("El producto fue eliminado");
                    Consultar(vista);
                }
                else
                {
                    Form mensajeError = new frmError("Error al eliminar el producto.");
                    mensajeError.ShowDialog();
                }
            }
        }

        public void Consultar(frmEAlmacen vista)
        {
            vista.tablaProductos.Rows.Clear();
            List<Producto> productos = productoDAO.readAll();
            foreach (Producto xProducto in productos)
            {
                vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta, xProducto.Precio_compra);
            }
        }
    }
}
