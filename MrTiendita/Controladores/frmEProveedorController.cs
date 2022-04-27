using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Constantes;
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
            this.vista.dgv_TablaProveedores.CellContentClick += new DataGridViewCellEventHandler(TablaProveedores_CellContentClick);
            this.vista.Load += new EventHandler(Vista_load);
            this.vista.tb_BuscarProveedor.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.btn_nuevoProveedor.Click += new EventHandler(Btn_nuevoProveedor_Click);
        }

        private void Vista_load(object sender, EventArgs e)
        {
            this.MostrarTodos();
        }

        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProveedor.Text;
            List<Proveedor> proveedores = this.proveedorDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProveedores.Rows.Clear();
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.dgv_TablaProveedores.Rows.Add(xProveedor.Id_proveedor, xProveedor.Nombre, xProveedor.Telefono);
            }
        }

        private void TablaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells["col_Borrar"].Selected)
                this.EliminarProveedor(e);
            else if (this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells["col_Editar"].Selected)
                this.ActualizarProveedor(e);
            this.MostrarTodos();
        }

        private void Btn_nuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmEditarProveedor editar = new FrmEditarProveedor(AccionesCRUD.CREATE, -1);
            editar.ShowDialog();
            this.MostrarTodos();
        }

        ///Métodos auxiliares
        private void MostrarTodos()
        {
            this.vista.dgv_TablaProveedores.Rows.Clear();
            List<Proveedor> proveedores = this.proveedorDAO.ReadAll();
            this.todosProveedores = proveedores;
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.dgv_TablaProveedores.Rows.Add(
                    xProveedor.Id_proveedor,
                    xProveedor.Nombre,
                    xProveedor.Telefono
                );
            }
        }

        private void EliminarProveedor(DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmAdvertencia("El proveedor se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                String idCadena = this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(idCadena);
                bool esEliminado = this.proveedorDAO.Delete(id);
                if (esEliminado)
                {
                    this.vista.dgv_TablaProveedores.Rows.Remove(this.vista.dgv_TablaProveedores.Rows[e.RowIndex]);
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
            String idCadena = this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            int id = Int32.Parse(idCadena);
            FrmEditarProveedor editar = new FrmEditarProveedor(AccionesCRUD.UPDATE, id);
            editar.ShowDialog();
        }
    }
}
