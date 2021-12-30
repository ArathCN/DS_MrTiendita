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
    public class frmCAlmacenController
    {
        private frmCAlmacen vista;
        private EntradaAlmacenDAO entradaAlmacenDAO;
        private ProductoDAO productoDAO;
        private ProveedorDAO proveedorDAO;

        private Producto prodcutoParaEntrada = null;
        private Dictionary<String, int> listaProveedores;

        public frmCAlmacenController(frmCAlmacen vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.productoDAO = new ProductoDAO();
            this.proveedorDAO = new ProveedorDAO();
            this.vista.btn_registrarEntrada.Click += new EventHandler(btn_registrarEntrada_Click);
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(tb_busqueda_TextChanged);
            this.vista.tb_codigo.TextChanged += new EventHandler(tb_codigo_TextChanged);
            this.vista.btn_Limpiar.Click += new EventHandler(btn_Limpiar_Click);
            //this.vista.cb_Proveedor.SelectedValueChanged += new EventHandler(cb_Proveedor_SelectedValueChanged);
        }

        public void vista_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            this.CargarProveedores();
        }

        private void cb_Proveedor_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String condicion = this.vista.tb_busqueda.Text;
            List<Producto> productos = this.productoDAO.readByName(condicion);
            this.vista.tablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            { 
                this.vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta);
            }
        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {
            long codigoBarra;
            String _codigoBarra = this.vista.tb_codigo.Text;
            this.vista.lbl_ErrorCodigo.Visible = false;

            //Comprueba que sea un numero long, no nulo y mayor a 0;
            if (!ValidacionDatos.Numero(_codigoBarra, out codigoBarra, new Dictionary<int, long>() { { ValidacionDatosOpciones.MAYOR_A, 0 } }))
            {
                this.vista.lbl_ErrorCodigo.Text = "El formato es incorrecto";
                this.vista.lbl_ErrorCodigo.Visible = true;
                this.prodcutoParaEntrada = null;
                return;
            }

            //Se busca si el codigo sí coincide con uno de la BD
            this.prodcutoParaEntrada = this.productoDAO.readById(codigoBarra);
            if (prodcutoParaEntrada != null)
            {
                this.vista.lbl_ErrorCodigo.Visible = false;
            }
            else
            {
                this.vista.lbl_ErrorCodigo.Text = "El código de barras no existe";
                this.vista.lbl_ErrorCodigo.Visible = true;
                this.prodcutoParaEntrada = null;
            }
        }

        //private void cb_Proveedor_SelectedItem(object sender, EventArgs e)
        //{
        //    String nombre = this.vista.cb_Proveedor.SelectedValue.ToString();
        //    int id = this.listaProveedores[nombre];
        //}

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.vista.tb_codigo.Text = "";
            this.prodcutoParaEntrada = null;
            this.vista.tb_cantidad.Text = "";
        }

        public void btn_registrarEntrada_Click(object sender, EventArgs e)
        {
            String _cantidad = this.vista.tb_cantidad.Text;
            String nombreProveedor;
            double cantidad;

            //Combrobar que el codigo haya sido correcto y que la cantidad es numerica, no nula y mayor a 0
            if (this.vista.cb_Proveedor.SelectedIndex == -1 ||
                this.prodcutoParaEntrada == null ||
                !ValidacionDatos.Numero(_cantidad, out cantidad, new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 100},
                    {ValidacionDatosOpciones.NUM_DECIMALES, 3} }))
            {
                String mensaje = "Asegurese de haber escrito un código de barras válido y haber seleccionado un proveedor.";
                if (ValidacionDatos.error)
                {
                    this.vista.tb_cantidad.BackColor = Color.Salmon;
                    mensaje = ValidacionDatos.mensajes;
                }
                Form mensajeError = new frmError(mensaje);
                mensajeError.ShowDialog();
                return;
            }
            nombreProveedor = this.vista.cb_Proveedor.SelectedValue.ToString() ;

            //comprobar que cantidad coincida con la medida del producto
            var parteDecimal = cantidad - Math.Truncate(cantidad);
            if (this.prodcutoParaEntrada.Medida == false && parteDecimal != 0)
            {
                Form mensajeError = new frmError("No se puede agregar decimales a un producto por unidad.");
                mensajeError.ShowDialog();
                return;
            }

            //Obtener el id del proveedor
            int idProveedor = this.listaProveedores[nombreProveedor];

            //Se crea a entrada al almacen
            EntradaAlmacen entrada = new EntradaAlmacen();
            entrada.Codigo_barra = this.prodcutoParaEntrada.Codigo_barra;
            entrada.Cantidad = cantidad;
            entrada.Fecha = DateTime.Now;
            entrada.Importe = prodcutoParaEntrada.Precio_compra * cantidad;
            entrada.Id_proveedor = idProveedor;
            this.prodcutoParaEntrada.Cantidad_actual = this.prodcutoParaEntrada.Cantidad_actual + cantidad;


            bool res = this.entradaAlmacenDAO.create(entrada, this.prodcutoParaEntrada);
            if (res)
            {
                this.vista.tb_codigo.Text = "";
                this.vista.tb_cantidad.Text = "";
                this.vista.cb_Proveedor.SelectedIndex = -1;
                this.prodcutoParaEntrada = null;

                Form mensajeExito = new frmExito("Se ha hecho la entrada con éxito.");
                mensajeExito.ShowDialog();
                this.MostrarProductos();
            }
            else if (this.entradaAlmacenDAO.ErrorUltimaConsulta)
            {
                Form mensajeError = new frmError("Ha ocurrido un error en la base de datos.");
                mensajeError.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Error desconocido.");
                mensajeError.ShowDialog();
            }
        }

        //////////////////////////////////////////
        ///Métodos auxiliares
        ///
        protected void MostrarProductos()
        {
            this.vista.tablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.readAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta, xProducto.Precio_compra);
            }
        }

        protected void CargarProveedores()
        {
            this.listaProveedores = new Dictionary<string, int>();
            List<Proveedor> proveedores = this.proveedorDAO.readAll();
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
