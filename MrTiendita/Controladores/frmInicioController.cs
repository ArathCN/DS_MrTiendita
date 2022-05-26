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
            this.vista.tb_IDEmpleado.KeyPress += new KeyPressEventHandler(Keypressed);
            this.vista.tb_claveEmpleado.KeyPress += new KeyPressEventHandler(Keypressed);

            this.vista.tb_IDEmpleado.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorID, "", this.vista.tb_IDEmpleado.Text, ValidacionDatosOpciones.USUARIO);
            };

            this.vista.tb_claveEmpleado.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorClave, "", this.vista.tb_claveEmpleado.Text, ValidacionDatosOpciones.CLAVE, patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$");
            };
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            this.ValidarDatos();
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
            this.vista.lbl_ErrorID.Visible = false;
            this.vista.lbl_ErrorClave.Visible = false;
            EmpleadoCache.SetEmpleado(null);
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

        private void ValidarDatos()
        {
            string usuario = this.vista.tb_IDEmpleado.Text, clave = this.vista.tb_claveEmpleado.Text;

            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorID, "", usuario, ValidacionDatosOpciones.USUARIO) ||
                !ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorClave,
                    "",
                    clave,
                    ValidacionDatosOpciones.CLAVE,
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
            EmpleadoCache.SetEmpleado(empleado);

            //abre las opciones segun el tipo de empleado
            conexion.Peticion(empleado.Tipo_empleado, principal);
            esCerradoInicio = true;
            this.vista.Close();
        }
        private void Keypressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                ValidarDatos();
            }
        }
    }
    
}
