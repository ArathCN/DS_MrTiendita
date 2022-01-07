using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;
using MrTiendita.Componentes;
using MrTiendita.Constantes;

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
            this.vista.Load += new EventHandler(vista_Load);
        }
        private void vista_Load(object sender, EventArgs e)
        {
            this.vista.tb_nombre.MaxLength = 60;
            this.vista.tb_telefono.MaxLength = 10;

            if (this.accion == "editar")
            {
                Proveedor proveedor = this.proveedorDAO.readById(this.id);
                this.vista.tb_nombre.Text = proveedor.Nombre;
                this.vista.tb_telefono.Text = proveedor.Telefono.ToString();
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool res = false;
            //Comprobar campos vacios...
            String _nombre = this.vista.tb_nombre.Text;
            String _telefono = this.vista.tb_telefono.Text;
            long telefono;

            //Comprobar que el nombre tenga inimo 10 caracteres
            //Comprobar que el telefeno tenga minimo 10 caracteres y que sea mayor a 0 (no negativo)
            if (!ValidacionDatos.Cadena(_nombre, new Dictionary<int, int>()
            { {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 10} }) ||
            !ValidacionDatos.Numero(_telefono, out telefono, new Dictionary<int, long>()
            { {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 10},
                {ValidacionDatosOpciones.MAYOR_A, 0}
            })
            )
            {
                Form mensajeError = new frmError(ValidacionDatos.mensajes);
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
