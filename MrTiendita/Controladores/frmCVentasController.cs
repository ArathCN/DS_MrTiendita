using System;
using System.Collections.Generic;
using System.Configuration;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;
using System.Drawing;
using CrearTicketVenta;
using System.IO;
using MrTiendita.Componentes;
using MrTiendita.Constantes;

namespace MrTiendita.Controladores
{
    /// <summary> Creamos la clase de control de las ventas. </summary>
    public class FrmCVentasController
    {
        /// <summary> The vista </summary>
        
        private FrmVentas vista;
        private FrmBuscarProducto vista2;

        /// <summary> The producto DAO </summary>
        private ProductoDAO productoDAO;
        /// <summary> The producto </summary>
        private Producto producto;
        /// <summary> The total venta </summary>
        private double totalVenta;
        /// <summary> The productos venta </summary>
        private List<Producto> productosVenta; //solo contiene productos con codigo y cantidad, lo demas vacio
        /// <summary>The lista productos </summary>
        private Dictionary<String, long> listaProductos;

        /// <summary> Inicializa una nueva instancia de la clase <see cref="FrmCVentasController"/>. </summary>
        /// <param name="vista">The vista.</param>
        public FrmCVentasController(FrmVentas vista)
        {
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.productosVenta = new List<Producto>();
            this.totalVenta = 0;
            this.vista.Load += new EventHandler(Vista_load);
            this.vista.btn_Buscar.Click += new EventHandler(Btn_Buscar_AbrirFrm);

            //this.vista.tb_codigo.TextChanged += new EventHandler(Tb_codigo_TextChanged);
            //this.vista.cb_productos.SelectedValueChanged += new EventHandler(Cb_productos_SelectedValueChanged);
            //this.vista.btn_aceptar.Click += new EventHandler(Btn_aceptar_Click);
            //this.vista.btn_finalizar.Click += new EventHandler(Venta_metodo_pago);
            //this.vista.btn_cancelar.Click += new EventHandler(Btn_cancelar_Click);
            //this.vista.tablaVentas.CellContentClick += new DataGridViewCellEventHandler(TablaVentas_CellContentClick);

            //this.vista.tb_cantidad.TextChanged += delegate (object sender, EventArgs e)
            //{
            //    double datoEvaluar;
            //    String mensajeError = "Inserta un número de 1-1000 con máximo dos decimales.";
            //    Dictionary<int, double> longitudCadenas = new Dictionary<int, double>() {
            //        {ValidacionDatosOpciones.MAYOR_A, 0},
            //        {ValidacionDatosOpciones.MENOR_A, 1001},
            //        {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            //    };
            //    ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidad, mensajeError, this.vista.tb_cantidad.Text, out datoEvaluar, longitudCadenas);
            //};
        }

        /// <summary> Maneja el evento de carga del control de Vista. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/> .</param>
        private void Vista_load(object sender, EventArgs e)
        {
            this.listaProductos = new Dictionary<string, long>();
            List<Producto> productos = this.productoDAO.ReadAll();
            List<String> nombreProductos = new List<string>();
            foreach (Producto producto in productos)
            {
                this.listaProductos.Add(producto.Descripcion, producto.Codigo_barra);
                nombreProductos.Add(producto.Descripcion);
            }

            foreach (string producto in nombreProductos)
            {
                //this.vista.cb_productos.Items.Add(producto);
            }
        }

        /// <summary> Maneja el evento Valor Seleccionado Cambiado del control Cb productos. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/> .</param>
        //private void Cb_productos_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (this.vista.cb_productos.SelectedIndex != -1)
        //    {
        //        int cantidadInicial = 1;
        //        String nombreProducto = this.vista.cb_productos.SelectedItem.ToString();
        //        long idProducto = this.listaProductos[nombreProducto];
        //        this.vista.tb_codigo.Text = idProducto.ToString();
        //        this.vista.tb_cantidad.Text = cantidadInicial.ToString();
        //    }
        //}

        /// <summary> Maneja el evento CellContentClick del control Tabla Ventas. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="DataGridViewCellEventArgs"/> .</param>
        //private void TablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Producto xProducto = new Producto
        //    {
        //        Codigo_barra = Int64.Parse(
        //            this.vista.tablaVentas.Rows[e.RowIndex].Cells["codigo"].Value.ToString()),
        //        Precio_venta = Convert.ToDouble(
        //            this.vista.tablaVentas.Rows[e.RowIndex].Cells["precio"].Value.ToString()),
        //        Cantidad_actual = Convert.ToDouble(
        //            this.vista.tablaVentas.Rows[e.RowIndex].Cells["cantidad_actual"].Value.ToString())
        //    };

        //    if (this.vista.tablaVentas.Rows[e.RowIndex].Cells["restar"].Selected)
        //    {
        //        xProducto.Cantidad_actual--;
        //        if (xProducto.Cantidad_actual == 0)
        //        {
        //            //eliminar el registro
        //            DialogResult resultado = new DialogResult();
        //            Form advertencia = new FrmAdvertencia("El producto será eliminado de la venta");
        //            resultado = advertencia.ShowDialog();
        //            if (resultado == DialogResult.OK)
        //                this.vista.tablaVentas.Rows.RemoveAt(this.vista.tablaVentas.CurrentRow.Index);
        //        }
        //        else
        //        {
        //            this.vista.tablaVentas.Rows[e.RowIndex].Cells["cantidad_actual"].Value = xProducto.Cantidad_actual;
        //            this.vista.tablaVentas.Rows[e.RowIndex].Cells["subtotal"].Value =
        //                xProducto.Cantidad_actual * xProducto.Precio_venta;
        //        }

        //        this.totalVenta -= xProducto.Precio_venta;
        //    }
        //    else if (this.vista.tablaVentas.Rows[e.RowIndex].Cells["sumar"].Selected)
        //    {
        //        Producto producto = this.productoDAO.ReadById(xProducto.Codigo_barra);
        //        xProducto.Cantidad_actual++;
        //        if (xProducto.Cantidad_actual > producto.Cantidad_actual)
        //        {
        //            Form mensajeError = new FrmError("No hay cantidad suficiente de este producto.");
        //            mensajeError.ShowDialog();
        //            return;
        //        }

        //        this.vista.tablaVentas.Rows[e.RowIndex].Cells["cantidad_actual"].Value = xProducto.Cantidad_actual;
        //        this.vista.tablaVentas.Rows[e.RowIndex].Cells["subtotal"].Value =
        //            xProducto.Cantidad_actual * xProducto.Precio_venta;
        //        this.totalVenta += xProducto.Precio_venta;
        //    }

        //    this.vista.lbl_total.Text = "$" + this.totalVenta.ToString();
        //}

        /// <summary>Maneja el evento Text Changed del control Tb_codigo. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento. <see cref="EventArgs"/>.</param>
        //private void Tb_codigo_TextChanged(object sender, EventArgs e)
        //{
        //    long codigoBarra;
        //    String mensajeError = "Debe ser un número de 13 dígitos.";
        //    Dictionary<int, long> longitudCadenas = new Dictionary<int, long>()
        //    {
        //        {ValidacionDatosOpciones.MAYOR_A, 0},
        //        {ValidacionDatosOpciones.NUM_CARACTERES, 13}
        //    };

        //    if (!ValidacionFormulario.Validar(
        //        this.vista.lbl_ErrorCodigo, mensajeError, this.vista.tb_codigo.Text, out codigoBarra, longitudCadenas))
        //    {
        //        this.producto = null;
        //        return;
        //    }

        //    //Se busca el producto...
        //    this.producto = this.productoDAO.ReadById(codigoBarra);
        //    if (this.producto != null)
        //    {
        //        this.vista.lbl_ErrorCodigo.Visible = false;
        //    }
        //    else
        //    {
        //        this.vista.lbl_ErrorCodigo.Text = "No hay un producto con ese código de barras.";
        //        this.vista.lbl_ErrorCodigo.Visible = true;
        //    }
        //}

        /// <summary> Maneja el evento Click del control Btn_accept.</summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/>.</param>
        //private void Btn_aceptar_Click(object sender, EventArgs e)
        //{
        //    String cantidadCadena = this.vista.tb_cantidad.Text;
        //    double cantidad;
        //    String mensajeErrorCantidad = "Debe ser un número de 1-1000 con máximo dos decimales.";
        //    Dictionary<int, double> opciones = new Dictionary<int, double>() {
        //            {ValidacionDatosOpciones.MAYOR_A, 0},
        //            {ValidacionDatosOpciones.MENOR_A, 1001},
        //            {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
        //    };

        //    //Comprobar que el código haya sido ingresado y que la cantidad sea numerica no nula mayor a 0
        //    if (this.producto == null ||
        //        !ValidacionFormulario.Validar(
        //            this.vista.lbl_ErrorCantidad, mensajeErrorCantidad, cantidadCadena, out cantidad, opciones))
        //    {
        //        Form mensajeError = new FrmError("Debe de llenar todos los campos correctamente.");
        //        mensajeError.ShowDialog();
        //        return;
        //    }

        //    //comprobar si la medida del producto coincide con la cantidad a vender
        //    var parteDecimal = cantidad - Math.Truncate(cantidad);
        //    if (producto.Medida == false && parteDecimal != 0)
        //    {
        //        Form mensajeError = new FrmError("No se puede vender en decimales este producto.");
        //        mensajeError.ShowDialog();
        //        return;
        //    }

        //    //comprobar que no se quiera vender más de lo que hay
        //    if (cantidad > producto.Cantidad_actual)
        //    {
        //        Form mensajeError = new FrmError("No hay suficiente cantidad de este producto.");
        //        mensajeError.ShowDialog();
        //        return;
        //    }

        //    //agregarlo a la tabla ----------- MEJOR PONERLO EN UN METODO PARA LLAMARLO TAMBIEN CUANDO SEA POR ESCANER
        //    double subtotal = cantidad * producto.Precio_venta;
        //    subtotal = Math.Round(subtotal, 2);
        //    bool siEncontrado = false;

        //    //si se ingresa un articulo que ya estaba en la lista sólo se le suma la cantidad a la fila.
        //    foreach (DataGridViewRow articulo in this.vista.tablaVentas.Rows)
        //    {
        //        if (long.Parse(articulo.Cells["codigo"].Value.ToString()) == this.producto.Codigo_barra)
        //        {
        //            articulo.Cells["cantidad_actual"].Value =
        //                Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString()) + cantidad;
        //            articulo.Cells["subtotal"].Value =
        //                Convert.ToDouble(articulo.Cells["subtotal"].Value.ToString()) + subtotal;
        //            siEncontrado = true;
        //        }
        //    }

        //    if (!siEncontrado)
        //    {
        //        //se agrega un nuevo producto a la tabla
        //        this.vista.tablaVentas.Rows.Add();
        //        int indexNuevoProducto = this.vista.tablaVentas.RowCount - 1;
        //        Console.WriteLine(indexNuevoProducto);
        //        this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["cantidad_Actual"].Value = cantidad;
        //        this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["descripcion"].Value = producto.Descripcion;
        //        this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["precio"].Value = producto.Precio_venta;
        //        this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["subtotal"].Value = subtotal;
        //        this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["codigo"].Value = producto.Codigo_barra;
        //    }

        //    //actualizar el total
        //    this.totalVenta += subtotal;
        //    this.vista.lbl_total.Text = "$" + this.totalVenta;
        //    this.vista.tb_codigo.Text = "";
        //    this.vista.tb_cantidad.Text = "";
        //    this.vista.cb_productos.SelectedIndex = -1;
        //    this.vista.lbl_ErrorCodigo.Visible = false;
        //    this.vista.lbl_ErrorCantidad.Visible = false;
        //}

        /// <summary> Maneja el evento Click del control Btn_Cancelar.</summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/>.</param>
        //private void Btn_cancelar_Click(object sender, EventArgs e)
        //{
        //    this.vista.tablaVentas.Rows.Clear();
        //    this.productosVenta.Clear();
        //    this.totalVenta = 0;
        //}

        ///// <summary> Maneja el evento pago del control Venta_metodo.</summary>
        ///// <param name="sender">La fuente del evento.</param>
        ///// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/>.</param>
        //private void Venta_metodo_pago(object sender, EventArgs e)
        //{
        //    //Comprobar si la lista está vacia
        //    int listaVentas = this.vista.tablaVentas.Rows.Count;
        //    if (listaVentas == 0)
        //    {
        //        Form mensajeError = new FrmError("No se a registrado ningún articulo para la venta.");
        //        mensajeError.ShowDialog();
        //        return;
        //    }

        //    //Generar la lista de compra
        //    this.productosVenta.Clear();
        //    foreach (DataGridViewRow articulo in this.vista.tablaVentas.Rows)
        //    {
        //        Producto producto = new Producto
        //        {
        //            Codigo_barra = long.Parse(articulo.Cells["codigo"].Value.ToString()),
        //            Descripcion = articulo.Cells["descripcion"].Value.ToString(),
        //            Precio_venta = Convert.ToDouble(articulo.Cells["precio"].Value.ToString()),
        //            Cantidad_actual = Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString())
        //        };

        //        this.productosVenta.Add(producto);
        //    }

        //    FrmCobro cobro = new FrmCobro(this.productosVenta, this.totalVenta);
        //    cobro.ShowDialog();

        //    if (cobro.DialogResult == DialogResult.OK)
        //    {
        //        this.vista.tablaVentas.Rows.Clear();
        //        this.productosVenta.Clear();
        //        this.totalVenta = 0;
        //        this.vista.lbl_total.Text = "$00.00";
        //    }
        //}

        private void Btn_Buscar_AbrirFrm(object sender, EventArgs e) 
        {
            this.vista2 = new FrmBuscarProducto(this);
            this.vista2.Show();
        }

        public void AgregarProducto(long codigobarra, double cantidad) 
        {
            int indexNuevoProducto;
            Producto producto = this.productoDAO.ReadById(codigobarra);
            this.vista.dgv_TablaVentas.Rows.Add();
            indexNuevoProducto = this.vista.dgv_TablaVentas.RowCount - 1;
            this.vista.dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Cantidad"].Value = cantidad;
            this.vista.dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Descripcion"].Value = producto.Descripcion;
            this.vista.dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Precio"].Value = producto.Precio_venta;
            this.vista.dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Subtotal"].Value = (cantidad * producto.Precio_venta);
            this.vista.dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Codigo"].Value = codigobarra;

        }
    }
}
