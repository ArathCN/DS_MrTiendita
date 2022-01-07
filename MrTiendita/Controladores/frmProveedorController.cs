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

            this.vista.tb_telefono.TextChanged += delegate (object sender, EventArgs e)
            {
                long dato2;
                String mensajeError = "De ser un número de 10 dígitos.";
                Dictionary<int, long> opciones2 = new Dictionary<int, long>()
                {
                    {ValidacionDatosOpciones.NUM_CARACTERES, 10}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorTel, mensajeError, this.vista.tb_telefono.Text, out dato2, opciones2);
            };

            this.vista.tb_nombre.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 60 caracteres.";
                Dictionary<int, int> opciones2 = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, mensajeError, this.vista.tb_nombre.Text, opciones2);
            };
        }
        private void vista_Load(object sender, EventArgs e)
        {
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
            Dictionary<int, long> opTel = new Dictionary<int, long>()
            {
                {ValidacionDatosOpciones.NUM_CARACTERES, 10}
            };
            Dictionary<int, int> opNom = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
            };

            //Comprobar que el nombre tenga inimo 10 caracteres
            //Comprobar que el telefeno tenga minimo 10 caracteres y que sea mayor a 0 (no negativo)
            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorTel, "", _telefono, out telefono, opTel) ||
            !ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, "", _nombre, opNom))
            {
                Form mensajeError = new frmError("Llene todos los datos datos correctamente.");
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
