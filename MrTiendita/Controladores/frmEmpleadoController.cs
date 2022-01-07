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
using BCrypt.Net;

namespace MrTiendita.Controladores
{
    class frmEmpleadoController
    {
        private frmEditarEmpleado vista;
        private String accion;
        private int id;
        private EmpleadoDAO empleadoDAO;
        private Empleado empleado;

        public frmEmpleadoController(frmEditarEmpleado vista, String accion, int id)
        {
            this.vista = vista;
            this.id = id;
            this.accion = accion;
            this.empleadoDAO = new EmpleadoDAO();
            this.vista.btn_guardarEmpleado.Click += new EventHandler(btn_Cerrar_Click);
            this.vista.Load += new EventHandler(vista_Load);
        }

        private void vista_Load(object sender, EventArgs e)
        {
            this.vista.tb_nombre.MaxLength = 100;
            this.vista.tb_apPaterno.MaxLength = 60;
            this.vista.tb_apMaterno.MaxLength = 60;
            this.vista.tb_telefono.MaxLength = 10;
            this.vista.tb_sueldo.MaxLength = 13;
            this.vista.tb_idEmpleado.MaxLength = 100;
            this.vista.tb_clave.MaxLength = 20;
            this.vista.tb_clave.Enabled = true;
            if (this.accion == "editar")
            {
                this.vista.tb_clave.MaxLength = 60;
                this.vista.tb_clave.Enabled = false;

                Empleado empleado = this.empleadoDAO.readById(this.id);

                this.vista.tb_idEmpleado.Text = empleado.Usuario;
                this.vista.tb_nombre.Text = empleado.Nombre;
                this.vista.tb_apPaterno.Text = empleado.A_paterno;
                this.vista.tb_apMaterno.Text = empleado.A_materno;
                this.vista.tb_telefono.Text = empleado.Telefono.ToString();
                this.vista.tb_sueldo.Text = empleado.Sueldo.ToString();
                if (empleado.Tipo_empleado == "Encargado")
                {
                    this.vista.rb_encargado.Checked = true;
                    this.vista.rb_cajero.Checked = false;
                }
                else if (empleado.Tipo_empleado == "Cajero")
                {
                    this.vista.rb_encargado.Checked = false;
                    this.vista.rb_cajero.Checked = true;
                }
                this.vista.tb_clave.Text = empleado.Clave;

                this.empleado = empleado;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool res = false;
            //Comprobar campos vacios...
            String _usuario = this.vista.tb_idEmpleado.Text;
            String _nombre = this.vista.tb_nombre.Text;
            String _apPaterno = this.vista.tb_apPaterno.Text;
            String _apMaterno = this.vista.tb_apMaterno.Text;
            String _telefono = this.vista.tb_telefono.Text;
            String _sueldo = this.vista.tb_sueldo.Text;
            String _clave = this.vista.tb_clave.Text;
            String _tipoEmpleado = "";

            long telefono;
            double sueldo;

            if (this.vista.rb_encargado.Checked == true)
                _tipoEmpleado = TipoEmpleadoC.ENCARGADO;
            else if (this.vista.rb_cajero.Checked == true)
                _tipoEmpleado = TipoEmpleadoC.CAJERO;


            //Falta validar los datos
            Dictionary<int, int> opcionesUsuario = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 50}
            };
            Dictionary<int, int> opcionesClave = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 8},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 20}
            };
            Dictionary<int, int> opcionesCadena = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 4}
            };
            Dictionary<int, long> opcionesLong = new Dictionary<int, long>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 10},
                {ValidacionDatosOpciones.MAYOR_A, 0}
            };
            Dictionary<int, double> opcionesSueldo = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.NUM_DECIMALES, 2},
                {ValidacionDatosOpciones.MAYOR_A, 0}
            };

            if (
                !ValidacionDatos.Cadena(_usuario, opcionesUsuario) ||
                !ValidacionDatos.Cadena(_nombre, opcionesCadena) ||
                !ValidacionDatos.Cadena(_apPaterno, opcionesCadena) ||
                !ValidacionDatos.Cadena(_apMaterno, opcionesCadena) ||
                !ValidacionDatos.Numero(_telefono, out telefono) ||
                !ValidacionDatos.Numero(_sueldo, out sueldo, opcionesSueldo) ||
                !ValidacionDatos.Cadena(_clave, opcionesCadena, patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$")
                )
            {
                Form mensajeError = new frmError(ValidacionDatos.mensajes);
                mensajeError.ShowDialog();
                return;
            }

            //Crear el empleado
            Empleado empleado = new Empleado(-1, _nombre, _apPaterno, _apPaterno, telefono, sueldo, _tipoEmpleado, _clave, _usuario);

            if (this.accion == "agregar")
            {
                res = this.agregar(empleado);
            }
            else
            {
                res = this.actualizar(empleado);
            }

            if (res) this.vista.Close();
        }

        ///////////
        ///Metodos auxiliares
        ///
        private bool agregar(Empleado empleado)
        {
            //encriptar la contraseña
            empleado.Clave = BCrypt.Net.BCrypt.EnhancedHashPassword(empleado.Clave, HashType.SHA512, workFactor: 10);

            bool res = this.empleadoDAO.create(empleado);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha creado el empleado con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error -> " + this.empleadoDAO.MensajeError);
                mensajeError.ShowDialog();
            }

            return res;
        }

        private bool actualizar(Empleado empleado)
        {
            bool res = this.empleadoDAO.updateInfo(empleado, this.id);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha actualizado el empleado con éxito.");
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
