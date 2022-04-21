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
using System.Globalization;

namespace MrTiendita.Controladores
{
    /// <summary> Clase controlador de empleado </summary>
    class FrmEmpleadoController
    {
        /// <summary> The vista </summary>
        private FrmEditarEmpleado vista;
        /// <summary> The accion </summary>
        private String accion;
        /// <summary> The identifier </summary>
        private int id;
        /// <summary> The empleado DAO </summary>
        private EmpleadoDAO empleadoDAO;
        /// <summary> The empleado </summary>
        private Empleado empleado;

        /// <summary> Inicializa una nueva instancia de la clase <see cref="FrmEmpleadoController"/>.</summary>
        /// <param name="vista">The vista.</param>
        /// <param name="accion">The accion.</param>
        /// <param name="id">The identifier.</param>
        public FrmEmpleadoController(FrmEditarEmpleado vista, String accion, int id)
        {
            this.vista = vista;
            this.id = id;
            this.accion = accion;
            this.empleadoDAO = new EmpleadoDAO();
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_Aceptar.Click += new EventHandler(Btn_Cerrar_Click);
            this.vista.rb_cajero.CheckedChanged += new EventHandler(rb_cajero_CheckedChanged);
            this.vista.rb_encargado.CheckedChanged += new EventHandler(rb_encargado_CheckedChanged);

            this.vista.tb_idEmpleado.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 50 caracteres.";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 50}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorID, mensajeError, this.vista.tb_idEmpleado.Text, longitudCadenas);
            };

            this.vista.tb_nombre.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 3 a 100 caracteres.";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 3},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorNombre, mensajeError, this.vista.tb_nombre.Text, longitudCadenas);
            };

            this.vista.tb_apPaterno.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 3 a 60 caracteres.";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 3},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorAp, mensajeError, this.vista.tb_apPaterno.Text, longitudCadenas);
            };

            this.vista.tb_apMaterno.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 3 a 60 caracteres.";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 3},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorAm, mensajeError, this.vista.tb_apMaterno.Text, longitudCadenas);
            };

            this.vista.tb_telefono.TextChanged += delegate (object sender, EventArgs e)
            {
                long datoEvaluar;
                String mensajeError = "Debe ser un número de 10 dígitos.";
                Dictionary<int, long> longitudCadenas = new Dictionary<int, long>()
                {
                    {ValidacionDatosOpciones.NUM_CARACTERES, 10}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorTel, mensajeError, this.vista.tb_telefono.Text, out datoEvaluar, longitudCadenas);
            };

            this.vista.tb_sueldo.TextChanged += delegate (object sender, EventArgs e)
            {
                double datoEvaluar;
                String mensajeError = "De ser un número entre 1 y 10,000 con máximo dos decimales.";
                Dictionary<int, double> longitudCadenas = new Dictionary<int, double>()
                {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_IGUAL_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorSue, mensajeError, this.vista.tb_sueldo.Text, out datoEvaluar, longitudCadenas);
            };

            this.vista.tb_clave.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 20 caracteres, acepta a-z 0-9 * ? ! @ # $ / () {} = - . , ; :";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 20}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorClave,
                    mensajeError,
                    this.vista.tb_clave.Text,
                    longitudCadenas,
                    patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$");
            };
        }

        /// <summary> Maneja el evento Load del control de Vista. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/> .</param>
        private void Vista_Load(object sender, EventArgs e)
        {
            this.vista.tb_clave.MaxLength = 20;
            this.vista.tb_clave.Enabled = true;
            if (this.accion == "editar")
            {
                this.vista.tb_clave.MaxLength = 60;
                this.vista.tb_clave.Enabled = false;
                this.vista.lbl_ErrorClave.Visible = false;
                Empleado empleado = this.empleadoDAO.ReadById(this.id);
                this.vista.tb_idEmpleado.Text = empleado.Usuario;
                this.vista.tb_nombre.Text = empleado.Nombre;
                this.vista.tb_apPaterno.Text = empleado.A_paterno;
                this.vista.tb_apMaterno.Text = empleado.A_materno;
                this.vista.tb_telefono.Text = empleado.Telefono.ToString();
                

                if (empleado.Tipo_empleado == TipoEmpleadoC.CAJERO)
                {
                    this.vista.rb_encargado.Checked = false;
                    this.vista.rb_cajero.Checked = true;
                }
                else if (empleado.Tipo_empleado == TipoEmpleadoC.ENCARGADO)
                {
                    this.vista.rb_encargado.Checked = true;
                    this.vista.rb_cajero.Checked = false;
                }
                this.vista.tb_sueldo.Text = empleado.Sueldo.ToString(new CultureInfo("es-MX"));
                this.vista.tb_clave.Text = empleado.Clave;
                this.vista.lbl_ErrorClave.Visible = false;
                this.empleado = empleado;
            }
            else
            {
                this.vista.tb_telefono.Text = Properties.Settings.Default.lada.ToString();
                this.vista.tb_sueldo.Text = Properties.Settings.Default.sueldoCajeros.ToString(new CultureInfo("es-MX"));
            }
        }

        private void rb_cajero_CheckedChanged(object sender, EventArgs e)
        {
            if (this.vista.rb_cajero.Checked)
            this.vista.tb_sueldo.Text = Properties.Settings.Default.sueldoCajeros.ToString(new CultureInfo("es-MX"));
        }

        private void rb_encargado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.vista.rb_encargado.Checked)
                this.vista.tb_sueldo.Text = Properties.Settings.Default.sueldoEncargados.ToString(new CultureInfo("es-MX"));
        }

        /// <summary> Maneja el evento Click del control Btn_Cerrar. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento. <see cref="EventArgs"/>.</param>
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool esValido = false;
            String usuarioCad = this.vista.tb_idEmpleado.Text;
            String nombreCad = this.vista.tb_nombre.Text;
            String apPaternoCad = this.vista.tb_apPaterno.Text;
            String apMaternoCad = this.vista.tb_apMaterno.Text;
            String telefonoCad = this.vista.tb_telefono.Text;
            String sueldoCad = this.vista.tb_sueldo.Text;
            String claveCad = this.vista.tb_clave.Text;
            String tipoEmpleadoCad = "";
            String estado = TipoEmpleadoC.ESTADO_ACTIVO;
            long telefono;
            double sueldo;

            if (this.vista.rb_encargado.Checked == true)
                tipoEmpleadoCad = TipoEmpleadoC.ENCARGADO;
            else if (this.vista.rb_cajero.Checked == true)
                tipoEmpleadoCad = TipoEmpleadoC.CAJERO;

            Dictionary<int, int> opUsuario = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 50}
            };
            Dictionary<int, int> opNom = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
            };
            Dictionary<int, int> opAp = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
            };
            Dictionary<int, int> opAm = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 60}
            };
            Dictionary<int, long> opTel = new Dictionary<int, long>()
            {
                {ValidacionDatosOpciones.NUM_CARACTERES, 10}
            };
            Dictionary<int, double> opSueldo = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_IGUAL_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            Dictionary<int, int> opClave = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 20}
            };
            String pat = "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$";

            //Si es editar cambio las opciones de la clave para que no de problemas con la encriptacion
            if (this.accion == "editar")
            {
                opClave[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES] = 255;
                pat = null;
            }

            if (
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorID, "", usuarioCad, opUsuario) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, "", nombreCad, opNom) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorAp, "", apPaternoCad, opAp) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorAm, "", apMaternoCad, opAm) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorTel, "", telefonoCad, out telefono, opTel) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorSue, "", sueldoCad, out sueldo, opSueldo) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorClave, "", claveCad, opClave, patron: pat)
                )
            {
                Form mensajeError = new FrmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            //Crear el empleado
            Empleado empleado = new Empleado(
                -1, nombreCad, apPaternoCad, apMaternoCad, telefono, sueldo, tipoEmpleadoCad, claveCad, usuarioCad, estado);

            if (this.accion == "agregar")
                esValido = this.Agregar(empleado);
            else
                esValido = this.Actualizar(empleado);
            if (esValido) this.vista.Close();
        }

        /// <summary> Agregar el empleado especificado. </summary>
        /// <param name="empleado">The empleado.</param>
        /// <returns>Un booleano.</returns>
        /// Metodos auxiliares
        private bool Agregar(Empleado empleado)
        {
            //encriptar la contraseña
            empleado.Clave = BCrypt.Net.BCrypt.EnhancedHashPassword(empleado.Clave, HashType.SHA512, workFactor: 10);

            bool esCreado = this.empleadoDAO.Create(empleado);
            if (esCreado)
            {
                Form mensajeExito = new FrmExito("Se ha creado el empleado con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error -> " + this.empleadoDAO.MensajeError);
                mensajeError.ShowDialog();
            }

            return esCreado;
        }

        /// <summary> Actualizar el empleado especificado.</summary>
        /// <param name="empleado">The empleado.</param>
        /// <returns></returns>
        private bool Actualizar(Empleado empleado)
        {
            bool esActualizado = this.empleadoDAO.UpdateInfo(empleado, this.id);
            if (esActualizado)
            {
                Form mensajeExito = new FrmExito("Se ha actualizado el empleado con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error -> " + this.empleadoDAO.MensajeError);
                mensajeError.ShowDialog();
            }

            return esActualizado;
        }
    }

    
}
