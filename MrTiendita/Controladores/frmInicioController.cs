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
        private Dictionary<int, string> listaEmpleados;
        public bool cierre = false;

        public frmInicioController(frmInicio vista)
        {
            this.vista = vista;
            this.principal = new frmPrincipal();
            this.empleadoDAO = new EmpleadoDAO();
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
            this.vista.btn_Cerrar.Click += new EventHandler(btn_Cerrar_Click);
            this.vista.FormClosing += new FormClosingEventHandler(frmInicio_FormClosing);
            CargarEmpleados();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string clave, _tipo;
            int id_empleado, tipoEmpleado;
            List<Empleado> empleados = this.empleadoDAO.readAll();

            //Falta verificar los campos-------------
            id_empleado = Int32.Parse(this.vista.tb_IDEmpleado.Text);
            clave = this.vista.tb_claveEmpleado.Text;
            _tipo = this.listaEmpleados[id_empleado];

            if (_tipo == "Encargado") //1: Encargado   2: Cajero
                tipoEmpleado = 1;
            else
                tipoEmpleado = 2;

            InicioSesion_Proxy.ITipoEmpleado conexion = new InicioSesion_Proxy.Sesion();
            conexion.Peticion(tipoEmpleado, principal);
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
                Application.Exit();
            }
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
            }
                
        }

        protected void CargarEmpleados()
        {
            this.listaEmpleados = new Dictionary<int, string>();
            List<Empleado> empleados = this.empleadoDAO.readAll();
            foreach (Empleado empleado in empleados)
            {
                this.listaEmpleados.Add(empleado.Id_empleado, empleado.Tipo_empleado);
            }
        }
    }
    
}
