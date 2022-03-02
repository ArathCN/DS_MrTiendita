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
    class FrmEEmpleadosController
    {
        FrmEEmpleado vista;
        EmpleadoDAO empleadoDAO;
        List<Empleado> todosEmpleados;

        public FrmEEmpleadosController(FrmEEmpleado vista)
        {
            this.vista = vista;
            this.empleadoDAO = new EmpleadoDAO();
            this.vista.tablaEmpleados.CellContentClick += new DataGridViewCellEventHandler(TablaEmpleados_CellContentClick);
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.btn_nuevoEmpleado.Click += new EventHandler(Btn_nuevoEmpleado_Click);
        }

        private void TablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaEmpleados.Rows[e.RowIndex].Cells["eliminar"].Selected)
                this.EliminarEmpleado(e);
            else if (this.vista.tablaEmpleados.Rows[e.RowIndex].Cells["editar"].Selected)
                this.ActualizarEmpleado(e);

            this.MostrarTodos();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            this.MostrarTodos();
        }

        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_busqueda.Text;
            List<Empleado> empleados = this.empleadoDAO.ReadByName(cadenaBusqueda);
            this.vista.tablaEmpleados.Rows.Clear();
            foreach (Empleado xEmpleado in empleados)
            {
                this.vista.tablaEmpleados.Rows.Add(xEmpleado.Id_empleado, xEmpleado.Nombre, xEmpleado.A_paterno, xEmpleado.A_materno, xEmpleado.Telefono, xEmpleado.Sueldo, xEmpleado.Tipo_empleado);
            }
        }

        private void Btn_nuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado editar = new FrmEditarEmpleado("agregar", -1);
            editar.ShowDialog();
            this.MostrarTodos();
        }

        //Métodos auxiliares
        private void MostrarTodos()
        {
            this.vista.tablaEmpleados.Rows.Clear();
            List<Empleado> empleados = this.empleadoDAO.ReadAll();
            this.todosEmpleados = empleados;
            foreach (Empleado xEmpleado in empleados)
            {
                this.vista.tablaEmpleados.Rows.Add(xEmpleado.Usuario, xEmpleado.Nombre, xEmpleado.A_paterno, xEmpleado.A_materno, xEmpleado.Telefono, xEmpleado.Sueldo, xEmpleado.Tipo_empleado, xEmpleado.Id_empleado);
            }
        }

        private void EliminarEmpleado(DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmError("El empleado se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                String idCadena = this.vista.tablaEmpleados.Rows[e.RowIndex].Cells[7].Value.ToString();
                int id = Int32.Parse(idCadena);
                bool esEliminado = this.empleadoDAO.Delete(id);

                if (esEliminado)
                {
                    this.vista.tablaEmpleados.Rows.Remove(this.vista.tablaEmpleados.Rows[e.RowIndex]);
                    Form mensajeExito = new FrmError("El empleado fue eliminado");
                    this.MostrarTodos();
                }
                else
                {
                    Form mensajeError = new FrmError("Error al eliminar el empleado");
                    mensajeError.ShowDialog();
                }
            }
        }

        private void ActualizarEmpleado(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.tablaEmpleados.Rows[e.RowIndex].Cells[7].Value.ToString();
            int id = Int32.Parse(idCadena);
            FrmEditarEmpleado editar = new FrmEditarEmpleado("editar", id);
            editar.ShowDialog();
        }

    }
}
