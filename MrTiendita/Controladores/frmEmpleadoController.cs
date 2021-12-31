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
            if (this.accion == "editar")
            {
                Empleado empleado = this.empleadoDAO.readById(this.id);

                this.vista.tb_idEmpleado.Text = empleado.Id_empleado.ToString();
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
            String _idEmpleado = this.vista.tb_idEmpleado.Text;
            String _nombre = this.vista.tb_nombre.Text;
            String _apPaterno = this.vista.tb_apPaterno.Text;
            String _apMaterno = this.vista.tb_apMaterno.Text;
            String _telefono = this.vista.tb_telefono.Text;
            String _sueldo = this.vista.tb_sueldo.Text;
            String _tipoEmpleado;
            if (this.vista.rb_encargado.Checked == true)
                _tipoEmpleado = "Encargado";
            else if (this.vista.rb_cajero.Checked == true)
                _tipoEmpleado = "Cajero";
            String _clave = this.vista.tb_clave.Text;

            //Falta validar los datos

        }
    }

    
}
