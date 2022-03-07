using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Controladores;
using MrTiendita.Vistas;
using System.Windows.Forms;
using MrTiendita.Constantes;

namespace MrTiendita.Patrones
{
    /// <summary>
    /// Clase que implementa el patrón Proxy para el inicio de sesión en el sistema.
    /// </summary>
    class InicioSesion_Proxy
    {

        /// <summary>
        /// Interfaz del tipo de empleado.
        /// </summary>
        public interface ITipoEmpleado
        {
            /// <summary>
            /// Hace una petición de inicio de sesión dependiendo del tipo de empleado.
            /// </summary>
            /// <param name="pOpcion"><see cref="string"/> que indica la opción deseada.</param>
            /// <param name="frmPrincipal">Ventana principal del sistema</param>
            void Peticion(string pOpcion, FrmPrincipal frmPrincipal);
            /// <summary>
            /// Cierra el formulario <see cref="FrmInicio"./>
            /// </summary>
            /// <param name="inicio">Ventana de inicio de sesión.</param>
            void Cierre(FrmInicio inicio);
        }

        /// <summary>
        /// Establece una sesión de un usuario.
        /// </summary>
        /// <seealso cref="MrTiendita.Patrones.InicioSesion_Proxy.ITipoEmpleado" />
        public class Sesion : ITipoEmpleado
        {
            /// <summary>
            /// Tipo de empleado que inicia sesión.
            /// </summary>
            private TipoEmpleado tipoEmpleado;

            /// <summary>
            /// Hace una petición de inicio de sesión dependiendo del tipo de empleado.
            /// </summary>
            /// <param name="pOpcion"><see cref="string"/>que indica la opción deseada.</param>
            /// <param name="frmPrincipal">Ventana principal del sistema</param>
            public void Peticion(string pOpcion, FrmPrincipal frmPrincipal)
            {
                if (pOpcion == TipoEmpleadoC.ENCARGADO) //Encargado == "Cajero"
                {
                    tipoEmpleado = new TipoEmpleado();
                    tipoEmpleado.Encargado(frmPrincipal);
                }
                else if (pOpcion == TipoEmpleadoC.CAJERO) //Cajero
                {
                    tipoEmpleado = new TipoEmpleado();
                    tipoEmpleado.Cajero(frmPrincipal);
                }
            }

            /// <summary>
            /// Cierra el formulario <see cref="FrmInicio"./>.
            /// </summary>
            /// <param name="inicio">Ventana de inicio de sesión.</param>
            public void Cierre(FrmInicio inicio)
            {
                inicio.tb_IDEmpleado.Clear();
                inicio.tb_claveEmpleado.Clear();
                inicio.Show();
            }
        }

        //Clases que va a usar el proxy dependiendo del tipo de empleado
        /// <summary>
        /// Clase que construye las opciones de la ventana principal dependiendo el tipo de empleado.
        /// </summary>
        private class TipoEmpleado
        {
            /// <summary>
            /// Vista de la ventana principal.
            /// </summary>
            private FrmPrincipal vista;
            /// <summary>
            /// Muestra las opciones de la ventana principal de un encargado.
            /// </summary>
            /// <param name="frmPrincipal">Ventana principal del sistema</param>
            public void Encargado(FrmPrincipal frmPrincipal)
            {
                this.vista = frmPrincipal;
                this.vista.Show();
                this.vista.pnl_Cajero.Visible = true;
                this.vista.pnl_OpCajero.Visible = false;
                this.vista.pnl_Encargado.Visible = true;
                this.vista.pnl_OpEncargado.Visible = false;
            }

            /// <summary>
            /// Muestra las opciones de la ventana principal de un cajero.
            /// </summary>
            /// <param name="frmPrincipal">Ventana principal del sistema</param>
            public void Cajero(FrmPrincipal frmPrincipal)
            {
                this.vista = frmPrincipal;
                this.vista.Show();
                this.vista.pnl_Cajero.Visible = false;
                this.vista.pnl_OpCajero.Visible = true;
                this.vista.pnl_Encargado.Visible = false;
                this.vista.pnl_OpEncargado.Visible = false;
            }
        }
    }
}
