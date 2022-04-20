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
    public class FrmProveedorController
    {
        private FrmEditarProveedor vista;
        private String accion;
        private int id;
        private ProveedorDAO proveedorDAO;
        public FrmProveedorController(FrmEditarProveedor vista, String accion, int id)
        {
            this.vista = vista;
            this.id = id;
            this.accion = accion;
            this.proveedorDAO = new ProveedorDAO();
            this.vista.btn_guardarProveedor.Click += new EventHandler(Btn_Cerrar_Click);
            this.vista.Load += new EventHandler(Vista_Load);

            this.vista.tb_telefono.TextChanged += delegate (object sender, EventArgs e)
            {
                long dato2;
                String mensajeError = "De ser un número de 10 dígitos.";
                Dictionary<int, long> opciones2 = new Dictionary<int, long>()
                {
                    {ValidacionDatosOpciones.NUM_CARACTERES, 10}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorTel, mensajeError, this.vista.tb_telefono.Text, out dato2, opciones2);
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
        private void Vista_Load(object sender, EventArgs e)
        {
            if (this.accion == "editar")
            {
                Proveedor proveedor = this.proveedorDAO.ReadById(this.id);
                this.vista.tb_nombre.Text = proveedor.Nombre;
                this.vista.tb_telefono.Text = proveedor.Telefono.ToString();
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool res = false;
            //Comprobar campos vacios...
            String _nombre = this.vista.tb_nombre.Text;
            String _telefono = this.vista.tb_telefono.Text;
            ///
            ///
            ///
            ///Extraer el estado del formulario y camnbiar la etiqueta en validacion
            String _estado = "";
            ///

            long telefono;

            String msgTel = "Número de 10 dígitos";
            Dictionary<int, long> opTel = new Dictionary<int, long>()
            {
                {ValidacionDatosOpciones.NUM_CARACTERES, 10}
            };

            String msgNom = "Cadena de 5 a 10 caracteres.";
            Dictionary<int, int> opNom = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
            };

            String msgEstado = "Cadena de 5 a 100 caracteres.";
            Dictionary<int, int> opEstado = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
            };

            //Comprobar que el nombre tenga inimo 10 caracteres
            //Comprobar que el telefeno tenga minimo 10 caracteres y que sea mayor a 0 (no negativo)
            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorTel, msgTel, _telefono, out telefono, opTel) ||
            !ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, msgNom, _nombre, opNom) ||
            !ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, msgEstado, _estado, opEstado))
            {
                Form mensajeError = new FrmError("Llene todos los datos datos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            Proveedor proveedor = new Proveedor(-1, _nombre, telefono, _estado);

            if (this.accion == "Agregar")
            {
                res = this.Agregar(proveedor);
            }
            else
            {
                res = this.Actualizar(proveedor);
            }

            if (res) this.vista.Close();
        }

        ///Metodos auxiliares
        private bool Agregar(Proveedor proveedor)
        {
            bool res = this.proveedorDAO.Create(proveedor);
            if (res)
            {
                Form mensajeExito = new FrmExito("Se ha hecho el proveedor con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        private bool Actualizar(Proveedor proveedor)
        {
            bool res = this.proveedorDAO.UpdateInfo(proveedor, this.id);
            if (res)
            {
                Form mensajeExito = new FrmExito("Se ha actualizado el proveedor con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }
    }
}
