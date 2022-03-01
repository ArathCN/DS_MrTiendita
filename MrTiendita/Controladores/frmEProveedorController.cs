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
    public class FrmEProveedorController
    {
        FrmProveedores vista;
        ProveedorDAO proveedorDAO;
        List<Proveedor> todosProveedores;
        public FrmEProveedorController(FrmProveedores vista)
        {
            this.vista = vista;
            this.proveedorDAO = new ProveedorDAO();
            this.vista.tablaProveedores.CellContentClick += new DataGridViewCellEventHandler(TablaProveedores_CellContentClick);
            this.vista.Load += new EventHandler(Vista_load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.btn_nuevoProveedor.Click += new EventHandler(Btn_nuevoProveedor_Click);
        }

        private void Vista_load(object sender, EventArgs e)
        {
            this.MostrarTodos();
        }

        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_busqueda.Text;
            List<Proveedor> proveedores = this.proveedorDAO.readByName(cadenaBusqueda);
            this.vista.tablaProveedores.Rows.Clear();
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.tablaProveedores.Rows.Add(xProveedor.Id_proveedor, xProveedor.Nombre, xProveedor.Telefono);
            }
        }

        private void TablaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaProveedores.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                this.EliminarProveedor(e);
            }
            else if (this.vista.tablaProveedores.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                this.ActualizarProveedor(e);
            }

            this.MostrarTodos();
        }

        private void Btn_nuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmEditarProveedor editar = new FrmEditarProveedor("agregar", -1);
            editar.ShowDialog();
            this.MostrarTodos();
        }

        ///Métodos auxiliares
        private void MostrarTodos()
        {
            this.vista.tablaProveedores.Rows.Clear();
            List<Proveedor> proveedores = this.proveedorDAO.readAll();
            this.todosProveedores = proveedores;
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.tablaProveedores.Rows.Add(xProveedor.Id_proveedor, xProveedor.Nombre, xProveedor.Telefono);
            }
        }

        private void EliminarProveedor(DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmError("El proveedor se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                String _id = this.vista.tablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(_id);
                bool IsDeleted = this.proveedorDAO.delete(id);
                if (IsDeleted)
                {
                    this.vista.tablaProveedores.Rows.Remove(this.vista.tablaProveedores.Rows[e.RowIndex]);
                    Form mensajeExito = new FrmError("El proveedor fue eliminado");
                    mensajeExito.ShowDialog();
                    this.MostrarTodos();
                }
                else
                {
                    Form mensajeError = new FrmError("Error al eliminar el proveedor.");
                    mensajeError.ShowDialog();
                }
            }
        }

        private void ActualizarProveedor(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.tablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            int id = Int32.Parse(idCadena);
            FrmEditarProveedor editar = new FrmEditarProveedor("editar", id);
            editar.ShowDialog();
        }
    }
}
