using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;

namespace MrTiendita.Controladores
{
    class frmEEmpleadosController
    {
        frmEEmpleado vista;
        EmpleadoDAO empleadoDAO;
        List<Empleado> todosEmpleados;

        public frmEEmpleadosController(frmEEmpleado vista)
        {
            this.vista = vista;
            this.empleadoDAO = new EmpleadoDAO();

            this.vista.tablaEmpleados.CellContentClick += new DataGridViewCellEventHandler(tablaEmpleados_CellContentClick);
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(tb_busqueda_TextChanged);
            this.vista.btn_nuevoEmpleado.Click += new EventHandler(btn_nuevoEmpleado_Click);
        }

        private void tablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaEmpleados.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                this.eliminarEmpleado(e);
            }
            else if (this.vista.tablaEmpleados.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                this.actualizarEmpleado(e);
            }

            this.mostrarTodos();
        }

        private void vista_Load(object sender, EventArgs e)
        {
            this.mostrarTodos();
            this.vista.tb_busqueda.MaxLength = 100;
        }

        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String condicion = this.vista.tb_busqueda.Text;
            List<Empleado> empleados = this.empleadoDAO.readByName(condicion);
            this.vista.tablaEmpleados.Rows.Clear();
            foreach (Empleado xEmpleado in empleados)
            {
                this.vista.tablaEmpleados.Rows.Add(xEmpleado.Id_empleado, xEmpleado.Nombre, xEmpleado.A_paterno, xEmpleado.A_materno, xEmpleado.Telefono, xEmpleado.Sueldo, xEmpleado.Tipo_empleado);
            }
        }

        private void btn_nuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado editar = new frmEditarEmpleado("agregar", -1);
            editar.ShowDialog();
            this.mostrarTodos();
        }

        //Métodos auxiliares
        private void mostrarTodos()
        {
            this.vista.tablaEmpleados.Rows.Clear();
            List<Empleado> empleados = this.empleadoDAO.readAll();
            this.todosEmpleados = empleados;
            foreach (Empleado xEmpleado in empleados)
            {
                this.vista.tablaEmpleados.Rows.Add(xEmpleado.Id_empleado, xEmpleado.Nombre, xEmpleado.A_paterno, xEmpleado.A_materno, xEmpleado.Telefono, xEmpleado.Sueldo, xEmpleado.Tipo_empleado);
            }
        }

        private void eliminarEmpleado(DataGridViewCellEventArgs e)
        {
            Form mensaje = new frmError("El empleado se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                //para el ejemplo borrare la unica que hay
                String _id = this.vista.tablaEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(_id);
                bool res = this.empleadoDAO.delete(id);
                if (res)
                {
                    this.vista.tablaEmpleados.Rows.Remove(this.vista.tablaEmpleados.Rows[e.RowIndex]);
                    Form mensajeExito = new frmError("El empleado fue eliminado");
                    this.mostrarTodos();
                }
                else
                {
                    Form mensajeError = new frmError("Error al eliminar el empleado");
                    mensajeError.ShowDialog();
                }
            }
        }

        private void actualizarEmpleado(DataGridViewCellEventArgs e)
        {
            String _id = this.vista.tablaEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
            int id = Int32.Parse(_id);
            frmEditarEmpleado editar = new frmEditarEmpleado("editar", id);
            editar.ShowDialog();
        }

    }
}
