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
    public class frmEProveedorController
    {
        frmProveedores vista;
        ProveedorDAO proveedorDAO;
        List<Proveedor> todosProveedores;
        public frmEProveedorController(frmProveedores vista)
        {
            this.vista = vista;
            this.proveedorDAO = new ProveedorDAO();
            this.vista.tablaProveedores.CellContentClick += new DataGridViewCellEventHandler(tablaProveedores_CellContentClick);
            this.vista.Load += new EventHandler(vista_load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(tb_busqueda_TextChanged);
            this.vista.btn_nuevoProveedor.Click += new EventHandler(btn_nuevoProveedor_Click);
        }

        private void vista_load(object sender, EventArgs e)
        {
            this.mostrarTodos();
        }

        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String condicion = this.vista.tb_busqueda.Text;
            List<Proveedor> proveedores = this.proveedorDAO.readByName(condicion);
            this.vista.tablaProveedores.Rows.Clear();
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.tablaProveedores.Rows.Add(xProveedor.Id_proveedor, xProveedor.Nombre, xProveedor.Telefono, xProveedor.Metodo_pago);
            }
        }

        private void tablaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaProveedores.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                this.eliminarProveedor(e);
            }
            else if (this.vista.tablaProveedores.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                this.actualizarProveedor(e);
            }

            this.mostrarTodos();
        }

        private void btn_nuevoProveedor_Click(object sender, EventArgs e)
        {
            frmEditarProveedor editar = new frmEditarProveedor("agregar", -1);
            editar.ShowDialog();
            this.mostrarTodos();
        }

        ///////////////////////////////
        ///Métodos auxiliares
        ///
        private void mostrarTodos()
        {
            this.vista.tablaProveedores.Rows.Clear();
            List<Proveedor> proveedores = this.proveedorDAO.readAll();
            this.todosProveedores = proveedores;
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.tablaProveedores.Rows.Add(xProveedor.Id_proveedor, xProveedor.Nombre, xProveedor.Telefono, xProveedor.Metodo_pago);
            }
        }
        private void eliminarProveedor(DataGridViewCellEventArgs e)
        {
            Form mensaje = new frmError("El proveedor se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                //para el ejemplo borrare la unica que hay
                String _id = this.vista.tablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(_id);
                bool res = this.proveedorDAO.delete(id);
                if (res)
                {
                    this.vista.tablaProveedores.Rows.Remove(this.vista.tablaProveedores.Rows[e.RowIndex]);
                    Form mensajeExito = new frmError("El proveedor fue eliminado");
                    this.mostrarTodos();
                }
                else
                {
                    Form mensajeError = new frmError("Error al eliminar el proveedor.");
                    mensajeError.ShowDialog();
                }
            }
        }

        private void actualizarProveedor(DataGridViewCellEventArgs e)
        {
            String _id = this.vista.tablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            int id = Int32.Parse(_id);
            frmEditarProveedor editar = new frmEditarProveedor("editar", id);
            editar.ShowDialog();
        }
    }
}
