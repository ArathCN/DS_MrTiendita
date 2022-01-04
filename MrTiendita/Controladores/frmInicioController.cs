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
    class frmInicioController
    {
        private frmInicio vista;
        private frmPrincipal principal;
        private EmpleadoDAO empleadoDAO;
        public bool cierre = false;
        InicioSesion_Proxy.ITipoEmpleado conexion = new InicioSesion_Proxy.Sesion();

        public frmInicioController(frmInicio vista)
        {
            this.vista = vista;
            this.principal = new frmPrincipal();
            this.empleadoDAO = new EmpleadoDAO();
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
            this.vista.btn_Cerrar.Click += new EventHandler(btn_Cerrar_Click);
            this.vista.FormClosing += new FormClosingEventHandler(frmInicio_FormClosing);
            this.principal.btn_CerrarSesion.Click += new EventHandler(btn_CerrarSesion_Click);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string usuario = this.vista.tb_IDEmpleado.Text, clave = this.vista.tb_claveEmpleado.Text;
            

            Dictionary<int, int> opcionesUsuario = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 50}
            };
            Dictionary<int, int> opcionesClave = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 8},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 20}
            };

            if (!ValidacionDatos.Cadena(usuario, opcionesUsuario) || !ValidacionDatos.Cadena(clave, opcionesClave, patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$"))
            {
                Form mensajeError = new frmError(ValidacionDatos.mensajes);
                mensajeError.ShowDialog();
                return;
            }

            //Validar si los datos son correctos
            Empleado empleado = this.empleadoDAO.readByUsuario(usuario);
            if (empleado == null || !BCrypt.Net.BCrypt.EnhancedVerify(clave, empleado.Clave, BCrypt.Net.HashType.SHA512))
            {
                Form mensajeError = new frmError("No hay un empleado con el usuario y contraseña especificados.");
                mensajeError.ShowDialog();
                return;
            }

            //como son correctos se crea el empelado en cache
            EmpleadoCache.GetEmpleado(empleado);
            //EmpleadoCache.SetEmpleado(empleado);


            //abre las opciones segun el tipo de empleado
            conexion.Peticion(empleado.Tipo_empleado, principal);
            cierre = true;
            this.vista.Close();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmAdvertencia("Saldrá del sistema");
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                cierre = false;
                Application.Exit();
            }
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.principal.Hide();
            conexion.Cierre(this.vista);
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cierre == false)
            {
                Application.Exit();
            }
            else if (cierre == true)
            {
                cierre = false;
                e.Cancel = true;
                this.vista.Hide();
            }
                
        }

    }
    
}
