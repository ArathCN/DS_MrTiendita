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

namespace Acciones
{
    class Productos
    {
        private ProductoDAO productoDAO = new ProductoDAO();

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

        public void Eliminar(FrmEAlmacen vista, DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmError("El producto se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                String _id = vista.tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                long id = Int64.Parse(_id);
                bool res = productoDAO.Delete(id);
                if (res)
                {
                    vista.tablaProductos.Rows.Remove(vista.tablaProductos.Rows[e.RowIndex]);
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

        public void Consultar(FrmEAlmacen vista)
        {
            vista.tablaProductos.Rows.Clear();
            List<Producto> productos = productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta, xProducto.Precio_compra);
            }
        }
    }

    class Empleados
    {
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();

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

    class Proveedor
    {

    }

}
