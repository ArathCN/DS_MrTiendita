using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Guna.UI2.WinForms;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;

namespace MrTiendita.Controladores
{
    class FrmEmpleadosController
    {
        private FrmEmpleados vista;
        private EmpleadoDAO empleadoDAO;
        private String accion;
        private int id;

        private Panel bordeInferior;
        private Panel pnlActivado;
        private Guna2Button botonSeleccionado;
        public FrmEmpleadosController(FrmEmpleados vista)
        {
            this.vista = vista;
            this.empleadoDAO = new EmpleadoDAO();
            this.accion = AccionesCRUD.CREATE;

            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.tablaEmpleados.CellContentClick += new DataGridViewCellEventHandler(Table_TablaEmpleados_CellContentClick);

            //Pestañas
            this.vista.btn_RegistrarEmpleado.Click += new EventHandler(btn_RegistrarEmpleado_Click);
            this.vista.btn_ModificarEmpleado.Click += new EventHandler(btn_ModificarEmpleado_Click);

            //Formulario
            this.vista.cb_Encargado.OnChange += new EventHandler(cb_Encargado_OnChange);
            this.vista.cb_Cajero.OnChange += new EventHandler(cb_Cajero_OnChange);
            this.vista.btn_AgregarEmpleado.Click += new EventHandler(btn_AgregarEmpleado_Click);

            //Listener para error
            this.vista.tb_Usuario.TextChanged += delegate (object sender, EventArgs e)
            {
                
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorUsuario, "", this.vista.tb_Usuario.Text, ValidacionDatosOpciones.USUARIO);
            };

            this.vista.tb_Nombre.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorNombre, "", this.vista.tb_Nombre.Text, ValidacionDatosOpciones.NOMBRE);
            };

            this.vista.tb_ApellidoPa.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorApeliidoPa, "", this.vista.tb_ApellidoPa.Text, ValidacionDatosOpciones.APELLIDO);
            };

            this.vista.tb_ApellidoMa.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorApellidoMa, "", this.vista.tb_ApellidoMa.Text, ValidacionDatosOpciones.APELLIDO);
            };

            this.vista.tb_Telefono.TextChanged += delegate (object sender, EventArgs e)
            {
                long datoEvaluar;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorTelefono, "", this.vista.tb_Telefono.Text, out datoEvaluar, ValidacionDatosOpciones.TELEFONO);
            };

            this.vista.tb_Sueldo.TextChanged += delegate (object sender, EventArgs e)
            {
                double datoEvaluar;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorSueldo, "", this.vista.tb_Sueldo.Text, out datoEvaluar, ValidacionDatosOpciones.PRECIO);
            };

            this.vista.tb_Clave.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorClave,
                    "Acepta a-z 0-9 * ? ! @ # $ / () {} = - . , ; :",
                    this.vista.tb_Clave.Text,
                    ValidacionDatosOpciones.CLAVE,
                    patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$");
            };

        }

        /// <summary> Maneja el evento Load del control de Vista. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Vista_Load(object sender, EventArgs e)
        {
            this.bordeInferior = new Panel();
            this.bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            this.vista.btn_ModificarEmpleado.Visible = false;
            ActivarBoton(this.vista.btn_RegistrarEmpleado);
            AbrirPanel(this.vista.pnl_RegistrarEmpleado);
            this.PreperarFormularioCrearEmpleado();
            this.MostrarTodos();
            this.vista.cb_Cajero.Checked = true;
            this.CajeroDefault();
        }

        /// <summary> Maneja el evento Text Changed del control Tb_busqueda. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_busqueda.Text;
            List<Empleado> empleados = this.empleadoDAO.ReadByName(cadenaBusqueda);
            this.vista.tablaEmpleados.Rows.Clear();
            foreach (Empleado xEmpleado in empleados)
            {
                this.vista.tablaEmpleados.Rows.Add(
                    xEmpleado.Id_empleado,
                    xEmpleado.Nombre + " " + xEmpleado.A_paterno + " " + xEmpleado.A_materno,
                    xEmpleado.Telefono.ToString(),
                    xEmpleado.Sueldo.ToString(new CultureInfo("es-MX")),
                    xEmpleado.Tipo_empleado,
                    xEmpleado.Usuario
                );
            }
        }

        /// <summary> Handles the CellContentClick event of the Table_TablaEmpleados control. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void Table_TablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaEmpleados.Rows[e.RowIndex].Cells["col_Borrar"].Selected)
            {
                this.EliminarEmpleado(e);
                this.MostrarTodos();
            }  
            else if (this.vista.tablaEmpleados.Rows[e.RowIndex].Cells["col_Editar"].Selected)
                PreperarFormularioActualizarEmpleado(e);

            
        }


        private void cb_Cajero_OnChange(object sender, EventArgs e)
        {
            this.CajeroDefault();
        }
        private void cb_Encargado_OnChange(object sender, EventArgs e)
        {
            this.EncargadoDefault();
        }
        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            //Se obtienen los valores del formulario
            String usuarioCad = this.vista.tb_Usuario.Text;
            String nombreCad = this.vista.tb_Nombre.Text;
            String apPaternoCad = this.vista.tb_ApellidoPa.Text;
            String apMaternoCad = this.vista.tb_ApellidoMa.Text;
            String telefonoCad = this.vista.tb_Telefono.Text;
            String sueldoCad = this.vista.tb_Sueldo.Text;
            String claveCad = this.vista.tb_Clave.Text;
            String tipoEmpleadoCad = "";
            long telefono;
            double sueldo;

            if (this.vista.cb_Encargado.Checked == true)
                tipoEmpleadoCad = TipoEmpleadoC.ENCARGADO;
            else if (this.vista.cb_Cajero.Checked == true)
                tipoEmpleadoCad = TipoEmpleadoC.CAJERO;

            //Validar si todos son correctos
            if (
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorUsuario, "", usuarioCad, ValidacionDatosOpciones.USUARIO) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, "", nombreCad, ValidacionDatosOpciones.NOMBRE) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorApeliidoPa, "", apPaternoCad, ValidacionDatosOpciones.APELLIDO) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorApellidoMa, "", apMaternoCad, ValidacionDatosOpciones.APELLIDO) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorTelefono, "", telefonoCad, out telefono, ValidacionDatosOpciones.TELEFONO) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorSueldo, "", sueldoCad, out sueldo, ValidacionDatosOpciones.PRECIO) ||
                (this.accion == AccionesCRUD.CREATE && !ValidacionFormulario.Validar(this.vista.lbl_ErrorClave, "", claveCad, ValidacionDatosOpciones.CLAVE, patron: "^[a-z0-9\\-\\*\\?\\!\\@\\#\\$\\/\\(\\)\\{\\}\\=\\.\\,\\;\\:]*$"))
                )
            {
                Form mensajeError = new FrmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            Empleado empleado = new Empleado(
                -1, nombreCad, apPaternoCad, apMaternoCad, telefono, sueldo, tipoEmpleadoCad, claveCad, usuarioCad);

            if (this.accion == AccionesCRUD.CREATE)
            {
                this.CrearEmpleado(empleado);
            }
            else if(this.accion == AccionesCRUD.UPDATE)
            {
                this.ActualizarEmpleado(empleado);
                
            }

            this.PreperarFormularioCrearEmpleado();
            this.MostrarTodos();
        }


        ////Métodos de pestañas
        private void btn_RegistrarEmpleado_Click(object sender, EventArgs e)
        {
            this.PreperarFormularioCrearEmpleado();
        }

        private void btn_ModificarEmpleado_Click(object sender, EventArgs e)
        {
            ActivarBoton(this.vista.btn_ModificarEmpleado);
        }

        //Métodos auxiliares
        /// <summary> Mostrars the todos. </summary>
        private void MostrarTodos()
        {
            this.vista.tablaEmpleados.Rows.Clear();
            List<Empleado> empleados = this.empleadoDAO.ReadAll();
            foreach (Empleado xEmpleado in empleados)
            {
                this.vista.tablaEmpleados.Rows.Add(
                    xEmpleado.Id_empleado,
                    xEmpleado.Nombre + " " + xEmpleado.A_paterno + " " + xEmpleado.A_materno,
                    xEmpleado.Telefono.ToString(),
                    xEmpleado.Sueldo.ToString(new CultureInfo("es-MX")),
                    xEmpleado.Tipo_empleado,
                    xEmpleado.Usuario
                );
            }
        }

        ////Métodos auxiliares
        private void ActivarBoton(Guna2Button boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                this.botonSeleccionado = boton;
                this.botonSeleccionado.ForeColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.BackColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.Location = new Point(this.botonSeleccionado.Location.X + 18, 49);
                this.bordeInferior.BringToFront();
                this.bordeInferior.Visible = true;
            }
        }

        private void DeshabilitarBoton()
        {
            if (this.botonSeleccionado != null)
                this.botonSeleccionado.ForeColor = Color.FromArgb(70, 70, 74);
        }

        private void AbrirPanel(Panel PanelHijo)
        {
            if (this.pnlActivado != null)
                this.pnlActivado.Visible = false;
            this.pnlActivado = PanelHijo;
            this.vista.pnl_MenuProductos.Controls.Add(PanelHijo);
            this.vista.pnl_MenuProductos.Tag = PanelHijo;
            PanelHijo.Location = new Point(18, 62);
            PanelHijo.BringToFront();
            this.pnlActivado.Visible = true;
        }

        private void OcultarErrores()
        {
            this.vista.lbl_ErrorUsuario.Visible = false;
            this.vista.lbl_ErrorNombre.Visible = false;
            this.vista.lbl_ErrorApeliidoPa.Visible = false;
            this.vista.lbl_ErrorApellidoMa.Visible = false;
            this.vista.lbl_ErrorTelefono.Visible = false;
            this.vista.lbl_ErrorSueldo.Visible = false;
            this.vista.lbl_ErrorClave.Visible = false;
        }

        private void LimpiarCampos()
        {
            this.vista.tb_Usuario.Text = "";
            this.vista.tb_Nombre.Text = "";
            this.vista.tb_ApellidoPa.Text = "";
            this.vista.tb_ApellidoMa.Text = "";
            this.vista.tb_Telefono.Text = "";
            this.vista.tb_Sueldo.Text = "";
            this.vista.tb_Clave.Text = "";
            this.vista.cb_Encargado.Checked = false;
            this.vista.cb_Cajero.Checked = false;
        }

        /// <summary> Eliminars the empleado. </summary>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void EliminarEmpleado(DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmAdvertencia("El empleado se eliminará, ¿está seguro?");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar empleado según la fila seleccionada
                String idCadena = this.vista.tablaEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(idCadena);
                bool esEliminado = this.empleadoDAO.Delete(id);

                if (esEliminado)
                {
                    Form mensajeExito = new FrmError("El empleado fue eliminado");
                    mensajeExito.ShowDialog();
                }
                else
                {
                    Form mensajeError = new FrmError("Error al eliminar el empleado  ->  " + this.empleadoDAO.MensajeError);
                    mensajeError.ShowDialog();
                }
            }
        }

        /// <summary> Actualizar el empleado. </summary>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void ActualizarEmpleado(Empleado empleado)
        {
            bool esActualizado = this.empleadoDAO.UpdateInfo(empleado, this.id);
            if (esActualizado)
            {
                Form mensajeExito = new FrmExito("Se ha actualizado el empleado con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error ->  " + this.empleadoDAO.MensajeError);
                mensajeError.ShowDialog();
            }
        }

        private void CrearEmpleado(Empleado empleado)
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
                Form mensajeError = new FrmError("Ha ocurrido un error ->  " + this.empleadoDAO.MensajeError);
                mensajeError.ShowDialog();
            }
        }

        private void PreperarFormularioCrearEmpleado()
        {
            //Se desaparece el boton de actualizar
            this.vista.btn_ModificarEmpleado.Visible = false;
            this.bordeInferior.Visible = false;

            //Reiniciamos las varibles apra editar
            this.accion = AccionesCRUD.CREATE;
            this.id = -1;

            //Se vacia el formulario y las etiquetas
            this.vista.lbl_Titulo.Text = "Crear un nuevo empleado";
            this.vista.btn_AgregarEmpleado.Text = "Crear emplado";
            this.vista.lbl_Descripcion.Text = "Crea un empleado para que pueda acceder al sistema.";
            this.vista.tb_Clave.Enabled = true;
            this.LimpiarCampos();

            if (Properties.Settings.Default.lada != 0) this.vista.tb_Telefono.Text = Properties.Settings.Default.lada.ToString();

            this.OcultarErrores();

            ActivarBoton(this.vista.btn_RegistrarEmpleado);
            this.vista.cb_Cajero.Checked = true;
            this.CajeroDefault();
        }

        private void PreperarFormularioActualizarEmpleado(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.tablaEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();

            this.vista.btn_ModificarEmpleado.Visible = true;
            this.vista.lbl_Titulo.Text = "Modifica un emplado";
            this.vista.btn_AgregarEmpleado.Text = "Guardar cambios";
            this.vista.lbl_Descripcion.Text = "Cambia el o los datos de un empleado.";

            this.accion = AccionesCRUD.UPDATE;
            this.id = Int32.Parse(idCadena);

            this.LimpiarCampos();

            Empleado empleado = this.empleadoDAO.ReadById(id);
            this.vista.tb_Usuario.Text = empleado.Usuario;
            this.vista.tb_Nombre.Text = empleado.Nombre;
            this.vista.tb_ApellidoPa.Text = empleado.A_paterno;
            this.vista.tb_ApellidoMa.Text = empleado.A_materno;
            this.vista.tb_Telefono.Text = empleado.Telefono.ToString();
            this.vista.tb_Sueldo.Text = empleado.Sueldo.ToString(new CultureInfo("es-MX"));
            this.vista.tb_Clave.Text = empleado.Clave;
            this.vista.tb_Clave.Enabled = false;
            if (empleado.Tipo_empleado == TipoEmpleadoC.CAJERO)
                this.vista.cb_Cajero.Checked = true;
            else if (empleado.Tipo_empleado == TipoEmpleadoC.ENCARGADO)
                this.vista.cb_Encargado.Checked = true;

            this.OcultarErrores();
            this.ActivarBoton(this.vista.btn_ModificarEmpleado);
        }

        private void CajeroDefault()
        {
            if (this.vista.cb_Cajero.Checked) this.vista.cb_Encargado.Checked = false;
            if (this.vista.cb_Cajero.Checked)
                this.vista.tb_Sueldo.Text = Properties.Settings.Default.sueldoCajeros.ToString(new CultureInfo("es-MX"));
            if (this.vista.cb_Cajero.Checked == false) this.vista.cb_Cajero.Checked = true;
            this.vista.tb_Sueldo.Text = Properties.Settings.Default.sueldoCajeros.ToString(new CultureInfo("es-MX"));
        }

        private void EncargadoDefault()
        {
            if (this.vista.cb_Encargado.Checked) this.vista.cb_Cajero.Checked = false;
            if (this.vista.cb_Encargado.Checked)
                this.vista.tb_Sueldo.Text = Properties.Settings.Default.sueldoEncargados.ToString(new CultureInfo("es-MX"));
            if (this.vista.cb_Encargado.Checked == false) this.vista.cb_Encargado.Checked = true;
            this.vista.tb_Sueldo.Text = Properties.Settings.Default.sueldoEncargados.ToString(new CultureInfo("es-MX"));
        }
    }
}
