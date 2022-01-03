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
    class InicioSesion_Proxy
    {

        public interface ITipoEmpleado
        {
            void Peticion(string pOpcion, frmPrincipal frmPrincipal);
        }

        public class Sesion : ITipoEmpleado
        {
            private TipoEmpleado tipoEmpleado;
            private frmPrincipal principal;

            public void Peticion(string pOpcion, frmPrincipal frmPrincipal)
            {
                this.principal = frmPrincipal;
                if (pOpcion == TipoEmpleadoC.ENCARGADO) //Encargado
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
        }

        //Clases que va a usar el proxy dependiendo del tipo de empleado
        private class TipoEmpleado
        {
            private frmPrincipal vista;
            public void Encargado(frmPrincipal frmPrincipal)
            {
                this.vista = frmPrincipal;
                this.vista.Show();
                this.vista.pnl_Cajero.Visible = false;
                this.vista.pnl_OpCajero.Visible = false;
                this.vista.pnl_Encargado.Visible = false;
                this.vista.pnl_OpEncargado.Visible = true;
            }

            public void Cajero(frmPrincipal frmPrincipal)
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
