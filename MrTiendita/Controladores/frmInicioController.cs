using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using MrTiendita.Patrones;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;

namespace MrTiendita.Controladores
{
    class FrmInicioController
    {
        private readonly FrmInicio vista;
        private readonly FrmPrincipal_ principal;
        private readonly EmpleadoDAO empleadoDAO;
        public bool esCerradoInicio = false;
        readonly InicioSesion_Proxy.ITipoEmpleado conexion = new InicioSesion_Proxy.Sesion();

        public FrmInicioController(FrmInicio vista)
        {
            this.vista = vista;
            this.principal = new FrmPrincipal_();
            this.empleadoDAO = new EmpleadoDAO();
            this.vista.btn_aceptar.Click += new EventHandler(Btn_aceptar_Click);
            this.vista.btn_Cerrar.Click += new EventHandler(Btn_Cerrar_Click);
            this.vista.FormClosing += new FormClosingEventHandler(FrmInicio_FormClosing);
            this.principal.btn_CerrarSesion.Click += new EventHandler(Btn_CerrarSesion_Click);

            this.vista.tb_IDEmpleado.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 50 caracteres.";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 50}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorID, mensajeError, this.vista.tb_IDEmpleado.Text, longitudCadenas);
            };

            this.vista.tb_claveEmpleado.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 20 caracteres, acepta a-z 0-9 * ? ! @ # $ / () {} = - . , ; :";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 20}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorClave, mensajeError, this.vista.tb_claveEmpleado.Text, longitudCadenas, patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$");
            };
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            string usuario = this.vista.tb_IDEmpleado.Text, clave = this.vista.tb_claveEmpleado.Text;
            String mensajeErrorUsuario = "Texto de entre 5 a 50 caracteres.";
            String mensajeErrorClave = "Texto de entre 5 a 20 caracteres, acepta a-z 0-9 * ? ! @ # $ / () {} = - . , ; :";


            Dictionary<int, int> opcionesUsuario = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 50}
            };
            Dictionary<int, int> opcionesClave = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 20}
            };

            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorID, mensajeErrorUsuario, usuario, opcionesUsuario) ||
                !ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorClave,
                    mensajeErrorClave,
                    clave,
                    opcionesClave,
                    patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$"))
            {
                Form mensajeError = new FrmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            //Validar si los datos son correctos
            Empleado empleado = this.empleadoDAO.ReadByUsuario(usuario);
            if (empleado == null || !BCrypt.Net.BCrypt.EnhancedVerify(clave, empleado.Clave, BCrypt.Net.HashType.SHA512))
            {
                Form mensajeError = new FrmError("No hay un empleado con el usuario y contraseña especificados.");
                mensajeError.ShowDialog();
                return;
            }

            //como son correctos se crea el empelado en cache
            EmpleadoCache.GetEmpleado(empleado);

            //abre las opciones segun el tipo de empleado
            conexion.Peticion(empleado.Tipo_empleado, principal);
            esCerradoInicio = true;
            this.vista.Close();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            Form mensaje = new FrmAdvertencia("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                esCerradoInicio = false;
                Application.Exit();
            }
        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.principal.esCerrado = false;
            this.principal.Close();
            conexion.Cierre(this.vista);
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (esCerradoInicio == false)
                Application.Exit();
            else if (esCerradoInicio == true)
            {
                esCerradoInicio = false;
                e.Cancel = true;
                this.vista.Hide();
            }
        }
    }
    
}
