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
    public class frmProveedorController
    {
        private frmEditarProveedor vista;
        private String accion;
        private int id;
        private ProveedorDAO proveedorDAO;
        public frmProveedorController(frmEditarProveedor vista, String accion, int id)
        {
            this.vista = vista;
            this.id = id;
            this.accion = accion;
            this.proveedorDAO = new ProveedorDAO();
            this.vista.btn_guardarProveedor.Click += new EventHandler(btn_Cerrar_Click);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool res = false;
            //Comprobar campos vacios...
            String _nombre = this.vista.tb_nombre.Text;
            String _telefono = this.vista.tb_telefono.Text;
            if (String.IsNullOrEmpty(_nombre) || String.IsNullOrEmpty(_telefono))
            {
                Form mensajeError = new frmError("Debe llenar todos los campos.");
                mensajeError.ShowDialog();
                return;
            }

            //Comprobar datos numericos
            long telefono;
            if (!long.TryParse(_telefono, out telefono))
            {
                Form mensajeError = new frmError("De de llenar los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }
            Proveedor proveedor = new Proveedor(-1, _nombre, telefono);

            if (this.accion == "agregar")
            {
                res = this.agregar(proveedor);
            }
            else
            {
                res = this.actualizar(proveedor);
            }

            if (res) this.vista.Close();
        }

        ///////////
        ///Metodos auxiliares
        ///
        private bool agregar(Proveedor proveedor)
        {
            bool res = this.proveedorDAO.create(proveedor);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha hecho el proveedor con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        private bool actualizar(Proveedor proveedor)
        {
            bool res = this.proveedorDAO.updateInfo(proveedor, this.id);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha actualizado el proveedor con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }
    }
}
