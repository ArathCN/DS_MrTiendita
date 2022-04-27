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
using BCrypt.Net;

namespace MrTiendita.Patrones
{
    /// <summary>
    /// Clase que usa <see cref="Productos_Facade"/> para implementar el patrón Facade.
    /// </summary>
    class Productos
    {
        /// <summary>
        /// Instancia de <see cref="ProductoDAO"/> que contiene los métodos de acceso a la base de datos.
        /// </summary>
        private ProductoDAO productoDAO = new ProductoDAO();

        /// <summary>
        /// Crea un registro de producto en la base de datos.
        /// </summary>
        /// <param name="producto">El producto a agregar</param>
        /// <returns>Regresa el mismo valor que <see cref="ProductoDAO.Create(Producto)"/></returns>
        public bool Agregar(Producto producto)
        {
            bool res = productoDAO.Create(producto);
            if (res)
            {
                Form mensajeExito = new FrmExito("Se ha hecho el producto con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        /// <summary>
        /// Actualiza un registro de producto en la base de datos.
        /// </summary>
        /// <param name="producto">Los datos del producto a actualizar.</param>
        /// <param name="id">El id a buscar.</param>
        /// <returns>Regresa el mismo valor que <see cref="ProductoDAO.UpdateInfo(Producto, long)"/></returns>
        public bool Actualizar(Producto producto, long id)
        {
            bool res = productoDAO.UpdateInfo(producto, id);
            if (res)
            {
                Form mensajeExito = new FrmExito("Se ha actualizado el producto con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        /// <summary>
        /// Elimina un registro de producto de la base de datos.
        /// </summary>
        /// <param name="vista">Formulario que contiene la tabla de productos.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        public void Eliminar(FrmInventario vista, DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmError("El producto se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                String _id = vista.dgv_TablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                long id = Int64.Parse(_id);
                bool res = productoDAO.Delete(id);
                if (res)
                {
                    vista.dgv_TablaProductos.Rows.Remove(vista.dgv_TablaProductos.Rows[e.RowIndex]);
                    Form mensajeExito = new FrmError("El producto fue eliminado");
                    Consultar(vista);
                }
                else
                {
                    Form mensajeError = new FrmError("Error al eliminar el producto.");
                    mensajeError.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Consulta todos los productos de la base de datos y los despliega en una tabla.
        /// </summary>
        /// <param name="vista">Formulario que contiene la tabla donde se despliegan los prodcutos.</param>
        public void Consultar(FrmInventario vista)
        {
            vista.dgv_TablaProductos.Rows.Clear();
            List<Producto> productos = productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                vista.dgv_TablaProductos.Rows.Add(xProducto.Codigo_barra,
                                                  xProducto.Descripcion,
                                                  xProducto.Precio_compra,
                                                  xProducto.Ganancia,
                                                  xProducto.Categoria,
                                                  xProducto.Cantidad_actual,
                                                  xProducto.Minimo);
            }
        }
    }

    /// <summary>
    /// Clase auxiliar para implementar el patrón Facade en <see cref="Empleado"/>.
    /// </summary>
    class Empleados
    {
        /// <summary>
        /// Instancia de <see cref="EmpleadoDAO"/> que contiene los métodos de acceso a la base de datos.
        /// </summary>
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();

        /// <summary>
        /// Crea un registro de empleado en la base de datos.
        /// </summary>
        /// <param name="empleado">El empleado a agregar.</param>
        /// <returns>Regresa el mismo valor que <see cref="EmpleadoDAO.Create(Empleado)"/></returns>
        public bool Agregar(Empleado empleado)
        {
            empleado.Clave = BCrypt.Net.BCrypt.EnhancedHashPassword(empleado.Clave, HashType.SHA512, workFactor: 10);

            bool res = this.empleadoDAO.Create(empleado);
            if (res)
            {
                Form mensajeExito = new FrmExito("Se ha creado el empleado con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error -> " + empleadoDAO.MensajeError);
                mensajeError.ShowDialog();
            }

            return res;
        }

        /// <summary>
        /// Actualiza el registro del empleado según el id.
        /// </summary>
        /// <param name="empleado">Daros nuevos a actualziar.</param>
        /// <param name="id">El id a buscar.</param>
        /// <returns>Regresa el mismo valor que <see cref="EmpleadoDAO.UpdateInfo(Empleado, long)"/></returns>
        public bool Actualizar(Empleado empleado, long id)
        {
            bool res = empleadoDAO.UpdateInfo(empleado, id);
            if (res)
            {
                Form mensajeExito = new FrmExito("Se ha actualizado el empleado con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        /// <summary>
        /// Elimina un registro de empleado de la base de datos.
        /// </summary>
        /// <param name="vista">Formulario que contiene la tabla de empleados.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        public void Eliminar(FrmEEmpleado vista, DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmError("El empleado se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                //para el ejemplo borrare la unica que hay
                String _id = vista.tablaEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(_id);
                bool res = empleadoDAO.Delete(id);
                if (res)
                {
                    vista.tablaEmpleados.Rows.Remove(vista.tablaEmpleados.Rows[e.RowIndex]);
                    Form mensajeExito = new FrmError("El empleado fue eliminado");
                    Consultar(vista);
                }
                else
                {
                    Form mensajeError = new FrmError("Error al eliminar el empleado");
                    mensajeError.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Consultar todos los empleados de la base de datos.
        /// </summary>
        /// <param name="vista">Formulario que contiene la tabla donde se despliegan los empleados.</param>
        public void Consultar(FrmEEmpleado vista)
        {
            List<Empleado> todosEmpleados;
            vista.tablaEmpleados.Rows.Clear();
            List<Empleado> empleados = empleadoDAO.ReadAll();
            todosEmpleados = empleados;
            foreach (Empleado xEmpleado in empleados)
            {
                vista.tablaEmpleados.Rows.Add(xEmpleado.Id_empleado, xEmpleado.Nombre, xEmpleado.A_paterno, xEmpleado.A_materno, xEmpleado.Telefono, xEmpleado.Sueldo, xEmpleado.Tipo_empleado);
            }
        }
    }

    /// <summary>
    /// Clase auxiliar para implementar el patrón Facade en <see cref="Proveedor"/>.
    /// </summary>
    class Proveedor
    {

    }

}
