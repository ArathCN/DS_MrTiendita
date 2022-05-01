using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using MrTiendita.Patrones;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Globalization;

namespace MrTiendita.Controladores
{
    public class FrmInventarioController
    {
        private FrmInventario vista;
        private Guna2Button botonSeleccionado;
        private Panel bordeInferior;
        private Panel pnlActivado;
        private EntradaAlmacenDAO entradaAlmacenDAO;
        private ProductoDAO productoDAO;
        private ProveedorDAO proveedorDAO;
        private Productos_Facade Productos;
        private Producto producto;

        private String accion;
        private long id;
        private Producto productoParaEntrada;
        private Dictionary<String, int> listaProveedores;

        public FrmInventarioController(FrmInventario vista)
        {
            this.vista = vista;
            this.pnlActivado = null;
            this.Productos = new Productos_Facade();
            this.producto = new Producto();
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.productoDAO = new ProductoDAO();
            this.proveedorDAO = new ProveedorDAO();

            this.accion = AccionesCRUD.CREATE;
            this.id = -1;
            this.productoParaEntrada = null;
            this.listaProveedores = null;
            

            this.vista.Load += new EventHandler(Vista_Load);

            //Pestañas
            this.vista.btn_NuevaEntrada.Click += new EventHandler(Btn_NuevaEntrada_Click);
            this.vista.btn_CrearProducto.Click += new EventHandler(Btn_CrearProducto_Click);
            this.vista.btn_ModificarProducto.Click += new EventHandler(Btn_ModificarProducto_Click);

            //Buscar y botones de la tabla
            this.vista.tb_BuscarProducto.TextChanged += new EventHandler(Tb_BuscarProducto_TextChanged);
            this.vista.dgv_TablaProductos.CellContentClick += new DataGridViewCellEventHandler(Dgv_TablaProductos_CellContentClick);

            //Botones de paneles
            this.vista.btn_AgregarProducto.Click += new EventHandler(btn_AgregarProducto_Click);
            this.vista.btn_RegistrarProducto.Click += new EventHandler(btn_RegistrarProducto_Click);
            this.vista.btn_LimpiarEntrada.Click += new EventHandler(btn_LimpiarEntrada_Click);

            //Campos nuevo producto
            this.vista.tb_CodigoBarras.TextChanged += delegate (object sender, EventArgs e)
            {
                long codigo;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCodigo, "", this.vista.tb_CodigoBarras.Text, out codigo, ValidacionDatosOpciones.CODIGO_BARRA);
            };
            this.vista.tb_Descripcion.TextChanged += delegate (object sender, EventArgs e)
            {
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorDescripcion, "", this.vista.tb_Descripcion.Text, ValidacionDatosOpciones.DESCRIPCION);
            };
            this.vista.tb_CantidadCrear.TextChanged += delegate (object sender, EventArgs e)
            {
                double cantidad;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidadCrear, "", this.vista.tb_CantidadCrear.Text, out cantidad, ValidacionDatosOpciones.CANTIDAD);
            };
            this.vista.tb_Minima.TextChanged += delegate (object sender, EventArgs e)
            {
                double minimo;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorMinimo, "", this.vista.tb_Minima.Text, out minimo, ValidacionDatosOpciones.CANTIDAD);
            };
            this.vista.tb_PrecioCompra.TextChanged += delegate (object sender, EventArgs e)
            {
                double precioCompra;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorPrecioCompra, "", this.vista.tb_PrecioCompra.Text, out precioCompra, ValidacionDatosOpciones.PRECIO);
            };
            this.vista.cb_GananciaPorcentaje.SelectedValueChanged += new EventHandler(cb_GananciaPorcentaje_tb_PrecioCompra_Changed);
            this.vista.tb_PrecioCompra.TextChanged += new EventHandler(cb_GananciaPorcentaje_tb_PrecioCompra_Changed);

            //Campos nueva entrada
            this.vista.tb_CodigoBarra.TextChanged += new EventHandler(tb_CodigoBarra_TextChanged);
            this.vista.tb_Cantidad.TextChanged += delegate (object sender, EventArgs e)
            {
                double cantidad;
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidad, "", this.vista.tb_Cantidad.Text, out cantidad, ValidacionDatosOpciones.CANTIDAD);
            };
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(160, 2);
            this.vista.pnl_MenuProductos.Controls.Add(bordeInferior);
            this.vista.btn_ModificarProducto.Visible = false;
            ActivarBoton(this.vista.btn_NuevaEntrada);
            AbrirPanel(this.vista.pnl_NuevaEntrada);
            MostrarProductos();
            this.CargarProveedores();
        }


        ////Métodos de pestañas
        private void Btn_NuevaEntrada_Click(object sender, EventArgs e)
        {
            this.accion = AccionesCRUD.CREATE;
            this.id = -1;
            ActivarBoton(sender);
            AbrirPanel(this.vista.pnl_NuevaEntrada);
        }

        private void Btn_CrearProducto_Click(object sender, EventArgs e)
        {
            this.vista.btn_ModificarProducto.Visible = false;
            this.bordeInferior.Visible = false;
            this.accion = AccionesCRUD.CREATE;
            this.id = -1;
            this.vista.lbl_Titulo.Text = "Crear un nuevo producto";
            this.vista.btn_AgregarProducto.Text = "Crear producto";
            this.vista.lbl_Descripcion.Text = "Crea un producto nuevo para empezar a venderlo en la tienda.";
            this.vista.tb_CodigoBarras.Text = "";
            this.vista.tb_Descripcion.Text = "";
            this.vista.tb_CantidadCrear.Text = "";
            this.vista.cb_TipoMedida.Checked = false;
            this.vista.cb_GananciaPorcentaje.SelectedIndex = -1;
            this.vista.tb_PrecioCompra.Text = "";
            this.vista.tb_PrecioVenta.Text = "";
            if (Properties.Settings.Default.siMinimoGlobal)
            {
                this.vista.tb_Minima.Text = Properties.Settings.Default.minimoGlobal.ToString(new CultureInfo("es-MX"));
                this.vista.tb_Minima.Enabled = false;
            }
            else this.vista.tb_Minima.Text = "";
            if (Properties.Settings.Default.siGanancia)
            {
                double opcion = (Properties.Settings.Default.ganancia / 5) - 2;
                this.vista.cb_GananciaPorcentaje.SelectedIndex = (Int32)opcion;
                this.vista.cb_GananciaPorcentaje.Enabled = false;
            }
            else this.vista.cb_Categoria.SelectedIndex = -1;




            OcultarErrores();
            ActivarBoton(sender);
            AbrirPanel(this.vista.pnl_CrearProducto);
        }

        private void Btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
        }
        

        ////Métodos botones de tabla y de buscar
        private void Tb_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProducto.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Descripcion,
                    xProducto.Precio_compra,
                    xProducto.Precio_venta,
                    xProducto.Ganancia,
                    xProducto.Categoria,
                    xProducto.Cantidad_actual,
                    xProducto.Minimo);
            }
        }

        private void Dgv_TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_Borrar"].Selected)
                {
                    Productos.Eliminar(this.vista, e);
                }
                else if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_Editar"].Selected)
                {
                    this.ActualizarProducto(e);
                }
            
        }


        //Métodos campos de nuevo producto
        private void cb_GananciaPorcentaje_tb_PrecioCompra_Changed(object sender, EventArgs e)
        {
            double precioCompra;
            int ganancia;

            if (String.IsNullOrEmpty(this.vista.cb_GananciaPorcentaje.Text) || String.IsNullOrEmpty(this.vista.tb_PrecioCompra.Text))
            {
                this.vista.tb_PrecioVenta.Text = "0";
                return;
            }
            
            if (!ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorPrecioCompra, "", this.vista.tb_PrecioCompra.Text, out precioCompra, ValidacionDatosOpciones.PRECIO))
                return;

            ganancia = Int32.Parse(this.vista.cb_GananciaPorcentaje.Text.TrimEnd('%'));

            this.vista.tb_PrecioVenta.Text = Math.Round(Producto.PresupuestarPrecioVenta(precioCompra, ganancia), 2).ToString();
        }
        
        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            bool medida;
            int ganancia = 0;
            long codigoBarra;
            double cantidad, precioCompra, minimo;

            //Se obtienen los valores de los txtbox
            String codigoBarraCad = this.vista.tb_CodigoBarras.Text;
            String descripcionCad = this.vista.tb_Descripcion.Text;
            String cantidadCad = this.vista.tb_CantidadCrear.Text;
            String precioCompraCad = this.vista.tb_PrecioCompra.Text;
            String categoriaCad, gananciaCad;
            if (this.vista.cb_Categoria.SelectedIndex == -1)
            {
                Form mensajeError = new FrmError("Debe seleccionar una categoría de producto.");
                mensajeError.ShowDialog();
                return;
            }
            else
                categoriaCad = this.vista.cb_Categoria.SelectedItem.ToString();
            String minimoCad = this.vista.tb_Minima.Text;
            if (this.vista.cb_GananciaPorcentaje.SelectedIndex == -1)
            {
                Form mensajeError = new FrmError("Debe seleccionar el porcentaje de ganancia para el producto");
                mensajeError.ShowDialog();
                return;
            }
            else
                gananciaCad = this.vista.cb_GananciaPorcentaje.SelectedItem.ToString().TrimEnd('%');

            if (
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, "", codigoBarraCad, out codigoBarra, ValidacionDatosOpciones.CODIGO_BARRA) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidadCrear, "", cantidadCad, out cantidad, ValidacionDatosOpciones.CANTIDAD) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDescripcion, "", descripcionCad, ValidacionDatosOpciones.DESCRIPCION) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorPrecioCompra, "", precioCompraCad, out precioCompra, ValidacionDatosOpciones.PRECIO) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorGanancia, "", gananciaCad, out ganancia, ValidacionDatosOpciones.GANANCIA) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorMinimo, "", minimoCad, out minimo, ValidacionDatosOpciones.CANTIDAD) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCategoria, "", categoriaCad, ValidacionDatosOpciones.CATEGORIA)
                )
            {
                Form mensajeError = new FrmError("Faltan campos de llenar o han sido llenados incorrectamente.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar el checkbox
            medida = this.vista.cb_TipoMedida.Checked;

            //comprobar si la cantidad y minimo coinciden con la medida.
            var parteDecimalCantidad = cantidad - Math.Truncate(cantidad);
            var parteDecimalMinimo = minimo - Math.Truncate(minimo);
            if (!medida && (parteDecimalCantidad != 0 || parteDecimalMinimo != 0))
            {
                Form mensajeError = new FrmError("La cantidad y cantidad minima no pueden ser decimales si la medida no es a granel.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar que el codigo de barras no exista en la BD
            if (this.id != codigoBarra && this.productoDAO.ReadById(codigoBarra) != null && this.accion != AccionesCRUD.UPDATE) //aqui
            {
                Form mensajeError = new FrmError("El codigo de barras ya está en uso");
                mensajeError.ShowDialog();
                return;
            }

            //Obtener el producto de los campos...
            Producto producto = new Producto(codigoBarra, descripcionCad, ganancia, precioCompra, cantidad, medida, categoriaCad, minimo);

            //Hacer la acción 
            //Hacer la acción 
            if (this.accion == AccionesCRUD.UPDATE)
            {
                Productos.Modificar(producto, this.id);
                this.DeshabilitarBoton();
                this.botonSeleccionado = null;
                this.vista.btn_ModificarProducto.Visible = false;
                this.pnlActivado.Visible = false;
                this.bordeInferior.Visible = false;
                this.pnlActivado = null;
                this.accion = AccionesCRUD.CREATE;
                this.id = -1;
                this.vista.lbl_Titulo.Text = "Crear un nuevo producto";
                this.vista.btn_AgregarProducto.Text = "Crear producto";
                this.vista.lbl_Descripcion.Text = "Crea un producto nuevo para empezar a venderlo en la tienda.";
                this.vista.tb_CodigoBarras.Text = "";
                this.vista.tb_Descripcion.Text = "";
                this.vista.tb_CantidadCrear.Text = "";
                this.vista.cb_Categoria.SelectedIndex = -1;
                this.vista.cb_TipoMedida.Checked = false;
                this.vista.cb_GananciaPorcentaje.SelectedIndex = -1;
                this.vista.tb_Minima.Text = "";
                this.vista.tb_PrecioCompra.Text = "";
                this.vista.tb_PrecioVenta.Text = "";
                this.AbrirPanel(this.vista.pnl_NuevaEntrada);
                this.ActivarBoton(this.vista.btn_NuevaEntrada);
            } 
            else if (this.accion == AccionesCRUD.CREATE)
            {
                Productos.Agregar(producto);
                
            }
                

            this.LimpiarCampos();
            this.OcultarErrores();
            this.MostrarProductos();
        }


        //Métodos campos de nueva entrada almacen
        private void tb_CodigoBarra_TextChanged(object sender, EventArgs e)
        {
            long codigoBarra;
            String codigoBarraCadena = this.vista.tb_CodigoBarra.Text;

            this.vista.lbl_ErrorCodigoBarras.Visible = false;

            //Comprueba que sea un numero long, no nulo y mayor a 0
            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigoBarras, "", codigoBarraCadena, out codigoBarra, ValidacionDatosOpciones.CODIGO_BARRA))
            {
                productoParaEntrada = null;
                return;
            }

            //Se busca si el codigo sí coincide con uno de la base de datos
            productoParaEntrada = this.productoDAO.ReadById(codigoBarra);
            if (productoParaEntrada != null)
            {
                this.vista.lbl_ErrorCodigo.Visible = false;
            }
            else
            {
                this.vista.lbl_ErrorCodigo.Text = "El código de barras no existe";
                this.vista.lbl_ErrorCodigo.Visible = true;
                productoParaEntrada = null;
            }
        }

        private void btn_RegistrarProducto_Click(object sender, EventArgs e)
        {
            String cantidadCadena = this.vista.tb_Cantidad.Text;
            String nombreProveedor;
            double cantidad;

            //Combrobar que el codigo haya sido correcto y que la cantidad es numerica, no nula y mayor a 0
            if (this.vista.cb_Proveedor.SelectedIndex == -1 ||
                productoParaEntrada == null ||
                !ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidad, "", cantidadCadena, out cantidad, ValidacionDatosOpciones.CANTIDAD)
                )
            {
                Form mensajeError = new FrmError("Asegurese de haber llenado todos los datos y que estén escritos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            nombreProveedor = this.vista.cb_Proveedor.SelectedItem.ToString();

            //comprobar que cantidad coincida con la medida del producto
            var parteDecimal = cantidad - Math.Truncate(cantidad);
            if (productoParaEntrada.Medida == false && parteDecimal != 0)
            {
                Form mensajeError = new FrmError("No se puede agregar decimales a un producto por unidad.");
                mensajeError.ShowDialog();
                return;
            }

            //Obtener el id del proveedor
            int idProveedor = this.listaProveedores[nombreProveedor];

            //Se crea a entrada al almacen
            EntradaAlmacen entrada = new EntradaAlmacen
            {
                Codigo_barra = productoParaEntrada.Codigo_barra,
                Cantidad = cantidad,
                Fecha = DateTime.Now,
                Importe = productoParaEntrada.Precio_compra * cantidad,
                Id_proveedor = idProveedor
            };
            productoParaEntrada.Cantidad_actual += cantidad;


            bool esCreado = this.entradaAlmacenDAO.Create(entrada, productoParaEntrada);
            if (esCreado)
            {
                this.vista.tb_CodigoBarra.Text = "";
                this.vista.tb_Cantidad.Text = "";
                this.vista.cb_Proveedor.SelectedIndex = -1;
                productoParaEntrada = null;

                Form mensajeExito = new FrmExito("Se ha hecho la entrada con éxito.");
                mensajeExito.ShowDialog();
                this.MostrarProductos();
                this.vista.lbl_ErrorCantidad.Visible = false;
                this.vista.lbl_ErrorCodigoBarras.Visible = false;
            }
            else if (this.entradaAlmacenDAO.ErrorUltimaConsulta)
            {
                Form mensajeError = new FrmError("Ha ocurrido un error en la base de datos.");
                mensajeError.ShowDialog();
            }
            else
            {
                Form mensajeError = new FrmError("Error desconocido.");
                mensajeError.ShowDialog();
            }
        }

        private void btn_LimpiarEntrada_Click(object sender, EventArgs e)
        {
            this.vista.tb_CodigoBarra.Text = "";
            this.vista.tb_Cantidad.Text = "";
            this.vista.lbl_ErrorCodigoBarras.Visible = false;
            this.vista.lbl_ErrorCantidad.Visible = false;
            this.productoParaEntrada = null;
            
        }


        ////Métodos auxiliares
        private void ActivarBoton(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                this.botonSeleccionado = (Guna2Button)boton;
                this.botonSeleccionado.ForeColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.BackColor = Color.FromArgb(0, 134, 255);
                this.bordeInferior.Location = new Point(this.botonSeleccionado.Location.X + 18, 45);
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

        protected void MostrarProductos()
        {
            this.vista.dgv_TablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Descripcion,
                    xProducto.Precio_compra,
                    xProducto.Precio_venta,
                    xProducto.Ganancia,
                    xProducto.Categoria,
                    xProducto.Cantidad_actual,
                    xProducto.Minimo) ;
            }
        }

        private void ActualizarProducto(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.vista.btn_ModificarProducto.Visible = true;
            if (Properties.Settings.Default.siMinimoGlobal) this.vista.tb_Minima.Enabled = false;
            if (Properties.Settings.Default.siGanancia) this.vista.cb_GananciaPorcentaje.Enabled = false;
            this.vista.lbl_Titulo.Text = "Modifica un producto";
            this.vista.btn_AgregarProducto.Text = "Guardar cambios";
            this.vista.lbl_Descripcion.Text = "Cambia el o los datos de un producto.";
            long id = long.Parse(idCadena);
            this.accion = AccionesCRUD.UPDATE;
            this.id = id;
            ActivarBoton(this.vista.btn_ModificarProducto);
            AbrirPanel(this.vista.pnl_CrearProducto);
            CargarProductoModificar(id);
        }

        private void CargarProductoModificar(long id)
        {
            Producto producto = this.productoDAO.ReadById(id);
            String porcentaje;

            this.vista.tb_CodigoBarras.Text = producto.Codigo_barra.ToString();
            this.vista.tb_Descripcion.Text = producto.Descripcion;
            this.vista.tb_CantidadCrear.Text = producto.Cantidad_actual.ToString();
            foreach (var categoria in this.vista.cb_Categoria.Items)
            {
                if (categoria.ToString() == producto.Categoria)
                {
                    this.vista.cb_Categoria.SelectedItem = producto.Categoria;
                }
            }
            if (producto.Medida) this.vista.cb_TipoMedida.Checked = true;
            foreach (var porcentajes in this.vista.cb_GananciaPorcentaje.Items)
            {
                porcentaje = porcentajes.ToString().TrimEnd('%');
                if (porcentaje == producto.Ganancia.ToString()) this.vista.cb_GananciaPorcentaje.SelectedItem = producto.Ganancia.ToString() + "%";
            }
            this.vista.tb_Minima.Text = producto.Minimo.ToString();
            this.vista.tb_PrecioCompra.Text = producto.Precio_compra.ToString();
            this.vista.tb_PrecioVenta.Text = producto.Precio_venta.ToString();
        }

        private void OcultarErrores()
        {
            this.vista.lbl_ErrorCodigo.Visible = false;
            this.vista.lbl_ErrorDescripcion.Visible = false;
            this.vista.lbl_ErrorCantidadCrear.Visible = false;
            this.vista.lbl_ErrorCategoria.Visible = false;
            this.vista.lbl_ErrorGanancia.Visible = false;
            this.vista.lbl_ErrorMinimo.Visible = false;
            this.vista.lbl_ErrorPrecioCompra.Visible = false;
            this.vista.lbl_ErrorPrecioVenta.Visible = false;
        }

        private void LimpiarCampos()
        {
            this.vista.tb_CodigoBarras.Text = "";
            this.vista.tb_Descripcion.Text = "";
            this.vista.tb_CantidadCrear.Text = "";
            this.vista.cb_Categoria.SelectedIndex = -1;
            this.vista.cb_TipoMedida.Checked = false;
            this.vista.cb_GananciaPorcentaje.SelectedIndex = -1;
            this.vista.tb_Minima.Text = "";
            this.vista.tb_PrecioCompra.Text = "";
            this.vista.tb_PrecioVenta.Text = "";
        }

        protected void CargarProveedores()
        {
            this.listaProveedores = new Dictionary<string, int>();
            List<Proveedor> proveedores = this.proveedorDAO.ReadAll();
            List<String> nombreProveedores = new List<string>();
            foreach (Proveedor proveedor in proveedores)
            {
                this.listaProveedores.Add(proveedor.Nombre, proveedor.Id_proveedor);
                nombreProveedores.Add(proveedor.Nombre);
            }

            foreach (string proveedor in nombreProveedores)
            {
                this.vista.cb_Proveedor.Items.Add(proveedor);
            }
        }
    }
}
