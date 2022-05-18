using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;

namespace MrTiendita.Controladores
{
    public class FrmEProveedorController
    {
        private FrmProveedores vista;
        private ProveedorDAO proveedorDAO;
        private List<Proveedor> todosProveedores;
        private String accion;
        private int id;

        private Panel bordeInferior;
        private Panel pnlActivado;
        private Guna2Button botonSeleccionado;
        public FrmEProveedorController(FrmProveedores vista)
        {
            this.vista = vista;
            this.proveedorDAO = new ProveedorDAO();
            this.accion = AccionesCRUD.CREATE;


            this.vista.Load += new EventHandler(Vista_load);
            this.vista.tb_BuscarProveedor.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.dgv_TablaProveedores.CellContentClick += new DataGridViewCellEventHandler(TablaProveedores_CellContentClick);
            this.vista.btn_form.Click += new EventHandler(btn_form_Click);

            this.vista.tb_Telefono.TextChanged += delegate (object sender, EventArgs e)
            {
                long dato2;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorTelefono, "", this.vista.tb_Telefono.Text, out dato2, ValidacionDatosOpciones.TELEFONO);
            };
            this.vista.tb_Nombre.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, "", this.vista.tb_Nombre.Text, ValidacionDatosOpciones.APELLIDO);
            };

            this.vista.btn_RegistrarProveedor.Click += new EventHandler(btn_RegistrarProveedor_Click);
        }

        private void Vista_load(object sender, EventArgs e)
        {
            this.bordeInferior = new Panel();
            this.bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            this.vista.btn_ModificarEmpleado.Visible = false;
            ActivarBoton(this.vista.btn_RegistrarProveedor);
            AbrirPanel(this.vista.pnl_RegistrarEmpleado);
            this.PreperarFormularioCrearProveedor();
            this.MostrarTodos();
        }

        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProveedor.Text;
            List<Proveedor> proveedores = this.proveedorDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProveedores.Rows.Clear();
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.dgv_TablaProveedores.Rows.Add(xProveedor.Id_proveedor, xProveedor.Nombre, xProveedor.Telefono);
            }
        }

        private void TablaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells["col_Borrar"].Selected)
            {
                this.EliminarProveedor(e);
                this.MostrarTodos();
            }
            else if (this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells["col_Editar"].Selected)
                PreperarFormularioActualizarProveedor(e);
        }

        private void btn_form_Click(object sender, EventArgs e)
        {
            //Se obtienen los valores del formulario
            String nombreCad = this.vista.tb_Nombre.Text;
            String telefonoCad = this.vista.tb_Telefono.Text;
            long telefono;

            //Validar si todos son correctos
            if (
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorNombre, "", nombreCad, ValidacionDatosOpciones.APELLIDO) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorTelefono, "", telefonoCad, out telefono, ValidacionDatosOpciones.TELEFONO)
                )
            {
                Form mensajeError = new FrmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            Proveedor proveedor = new Proveedor(-1, nombreCad, telefono);

            if (this.accion == AccionesCRUD.CREATE)
            {
                this.CrearProveedor(proveedor);
            }
            else if (this.accion == AccionesCRUD.UPDATE)
            {
                this.ActualizarProveedor(proveedor);

            }

            this.PreperarFormularioCrearProveedor();
            this.MostrarTodos();
        }

        private void btn_RegistrarProveedor_Click(object sender, EventArgs e)
        {
            this.PreperarFormularioCrearProveedor();
        }

        //Métodos auxiliares
        private void MostrarTodos()
        {
            this.vista.dgv_TablaProveedores.Rows.Clear();
            List<Proveedor> proveedores = this.proveedorDAO.ReadAll();
            this.todosProveedores = proveedores;
            foreach (Proveedor xProveedor in proveedores)
            {
                this.vista.dgv_TablaProveedores.Rows.Add(
                    xProveedor.Id_proveedor,
                    xProveedor.Nombre,
                    xProveedor.Telefono
                );
            }
        }

        private void EliminarProveedor(DataGridViewCellEventArgs e)
        {
            Form mensaje = new FrmAdvertencia("El proveedor se eliminará");
            DialogResult resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //Eliminar la fila seleccionada
                String idCadena = this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(idCadena);
                bool esEliminado = this.proveedorDAO.Delete(id);
                if (esEliminado)
                {
                    Form mensajeExito = new FrmError("El proveedor fue eliminado");
                    mensajeExito.ShowDialog();
                }
                else
                {
                    Form mensajeError = new FrmError("Error al eliminar el proveedor.");
                    mensajeError.ShowDialog();
                }
            }
        }

        private void ActualizarProveedor(Proveedor proveedor)
        {
            bool esActualizado = this.proveedorDAO.UpdateInfo(proveedor, this.id);
            if (esActualizado)
            {
                Form mensajeExito = new FrmExito("Se ha actualizado el proveedor con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error ->  " + this.proveedorDAO.MensajeError);
                mensajeError.ShowDialog();
            }
        }

        private void CrearProveedor(Proveedor proveedor)
        {
            bool esCreado = this.proveedorDAO.Create(proveedor);
            if (esCreado)
            {
                Form mensajeExito = new FrmExito("Se ha creado el proveedor con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Ha ocurrido un error ->  " + this.proveedorDAO.MensajeError);
                mensajeError.ShowDialog();
            }
        }

        private void PreperarFormularioCrearProveedor()
        {
            //Se desaparece el boton de actualizar
            this.vista.btn_ModificarEmpleado.Visible = false;
            this.bordeInferior.Visible = false;

            //Reiniciamos las varibles apra editar
            this.accion = AccionesCRUD.CREATE;
            this.id = -1;

            //Se vacia el formulario y las etiquetas
            this.vista.lbl_TituloForm.Text = "Crear un nuevo empleado";
            this.vista.btn_form.Text = "Crear emplado";
            this.vista.lbl_DescripcionProveedor.Text = "Crea un empleado para que pueda acceder al sistema.";
            this.LimpiarCampos();

            if (Properties.Settings.Default.lada != 0) this.vista.tb_Telefono.Text = Properties.Settings.Default.lada.ToString();

            this.OcultarErrores();

            ActivarBoton(this.vista.btn_RegistrarProveedor);
        }

        private void PreperarFormularioActualizarProveedor(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.dgv_TablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();

            this.vista.btn_ModificarEmpleado.Visible = true;
            this.vista.lbl_TituloForm.Text = "Modifica un emplado";
            this.vista.btn_form.Text = "Guardar cambios";
            this.vista.lbl_DescripcionProveedor.Text = "Cambia el o los datos de un empleado.";

            this.accion = AccionesCRUD.UPDATE;
            this.id = Int32.Parse(idCadena);

            this.LimpiarCampos();

            Proveedor proveedor = this.proveedorDAO.ReadById(id);
            this.vista.tb_Nombre.Text = proveedor.Nombre;
            this.vista.tb_Telefono.Text = proveedor.Telefono.ToString();
            

            this.OcultarErrores();
            this.ActivarBoton(this.vista.btn_ModificarEmpleado);
        }

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
            this.vista.lbl_ErrorNombre.Visible = false;
            this.vista.lbl_ErrorTelefono.Visible = false;
        }

        private void LimpiarCampos()
        {
            this.vista.tb_Nombre.Text = "";
            this.vista.tb_Telefono.Text = "";
        }
    }
}
