using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;
using MrTiendita.Vistas;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using System.Drawing;

namespace MrTiendita.Controladores
{
    /// <summary>
    /// Creamos el controlador del Almacén.
    /// </summary>
    public class FrmCAlmacenController
    {
        /// <summary> La vista del form controlador de almacén</summary>
        private FrmCAlmacen vista;
        /// <summary> La entrada almacen DAO </summary>
        private EntradaAlmacenDAO entradaAlmacenDAO;
        /// <summary> El producto DAO</summary>
        private ProductoDAO productoDAO;
        /// <summary> El proveedor DAO </summary>
        private ProveedorDAO proveedorDAO;
        /// <summary> El producto para entrada </summary>
        private Producto productoParaEntrada = null;
        /// <summary> La lista proveedores </summary>
        private Dictionary<String, int> listaProveedores;

        /// <summary> Inicializa una nueva instancia de la clase <see cref="FrmCAlmacenController"/>. </summary>
        /// <param name="vista">vista.</param>
        public FrmCAlmacenController(FrmCAlmacen vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.productoDAO = new ProductoDAO();
            this.proveedorDAO = new ProveedorDAO();

            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_registrarEntrada.Click += new EventHandler(Btn_registrarEntrada_Click);
            this.vista.tb_busqueda.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.tb_codigo.TextChanged += new EventHandler(Tb_codigo_TextChanged);
            this.vista.btn_Limpiar.Click += new EventHandler(Btn_Limpiar_Click);

            this.vista.tb_cantidad.TextChanged += delegate (object sender, EventArgs e)
            {
                double datoEvaluar;
                String mensajeError = "Debe de ser un número de 0-100 con máximo dos decimales.";
                Dictionary<int, double> longitudCadenas = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 100},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidad, mensajeError, this.vista.tb_cantidad.Text, out datoEvaluar, longitudCadenas);
            };
        }

        /// <summary> Maneja el evento Load del control de Vista. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"><see cref="EventArgs"/>  La instancia que contiene los datos del evento.</param>
        public void Vista_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.CargarProveedores();
        }

        /// <summary> Maneja el evento Text Changed del control Tb_busqueda. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"><see cref="EventArgs"/> La instancia que contiene los datos del evento.</param>
        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_busqueda.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.tablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Cantidad_actual,
                    xProducto.Descripcion,
                    xProducto.Precio_venta
                );
            }
        }

        /// <summary> Maneja el evento Text Changed del control Tb_codigo. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"><see cref="EventArgs"/> La instancia que contiene los datos del evento.</param>
        private void Tb_codigo_TextChanged(object sender, EventArgs e)
        {
            long codigoBarra;
            String codigoBarraCadena = this.vista.tb_codigo.Text;
            String mensaje = "Solo se aceptan números de 13 dígitos.";
            Dictionary<int, long> opcionesNumero = new Dictionary<int, long>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.NUM_CARACTERES, 13}
            };

            this.vista.lbl_ErrorCodigo.Visible = false;

            //Comprueba que sea un numero long, no nulo y mayor a 0
            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, mensaje, codigoBarraCadena, out codigoBarra, opcionesNumero))
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

        /// <summary> Maneja el evento Click del control Btn_Limpiar. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"><see cref="EventArgs"/> La instancia que contiene los datos del evento.</param>
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.vista.tb_codigo.Text = "";
            productoParaEntrada = null;
            this.vista.tb_cantidad.Text = "";
        }

        /// <summary>Maneja el evento Click del control Btn_registrarEntrada </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"><see cref="EventArgs"/> La instancia que contiene los datos del evento.</param>
        public void Btn_registrarEntrada_Click(object sender, EventArgs e)
        {
            String cantidadCadena = this.vista.tb_cantidad.Text;
            String nombreProveedor;
            double cantidad;
            String mensaje = "Debe de ser un número de 0-100 con máximo dos decimales.";
            Dictionary<int, double> longitudCadenas = new Dictionary<int, double>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_A, 100},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };

            //Combrobar que el codigo haya sido correcto y que la cantidad es numerica, no nula y mayor a 0
            if (this.vista.cb_Proveedor.SelectedIndex == -1 ||
                productoParaEntrada == null ||
                !ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidad, mensaje, cantidadCadena, out cantidad, longitudCadenas)
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
                this.vista.tb_codigo.Text = "";
                this.vista.tb_cantidad.Text = "";
                this.vista.cb_Proveedor.SelectedIndex = -1;
                productoParaEntrada = null;

                Form mensajeExito = new FrmExito("Se ha hecho la entrada con éxito.");
                mensajeExito.ShowDialog();
                this.MostrarProductos();
                this.vista.lbl_ErrorCantidad.Visible = false;
                this.vista.lbl_ErrorCodigo.Visible = false;
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

        /// <summary> Muestra los productos. </summary>
        /// Métodos auxiliares
        protected void MostrarProductos()
        {
            this.vista.tablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Cantidad_actual,
                    xProducto.Descripcion,
                    xProducto.Precio_venta,
                    xProducto.Precio_compra);
            }
        }

        /// <summary>Cargar los proveedores. </summary>
        protected void CargarProveedores()
        {
            this.listaProveedores = new Dictionary<string, int>();
            List<Proveedor> proveedores = this.proveedorDAO.ReadByState(TipoEmpleadoC.ESTADO_ACTIVO);
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
