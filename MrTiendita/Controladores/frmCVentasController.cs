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
    class frmCVentasController
    {
        private frmCVentas vista;
        private ProductoDAO productoDAO;

        private Producto producto;
        private double totalVenta;
        private List<Producto> productosVenta; //solo contiene productos con codigo y cantidad, lo demas vacio

        private Dictionary<String, long> listaProductos;

        public frmCVentasController(frmCVentas vista)
        {
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.productosVenta = new List<Producto>();
            this.totalVenta = 0;
            this.vista.Load += new EventHandler(vista_load);
            this.vista.tb_codigo.TextChanged += new EventHandler(tb_codigo_TextChanged);
            this.vista.cb_productos.SelectedValueChanged += new EventHandler(cb_productos_SelectedValueChanged);
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
            this.vista.btn_finalizar.Click += new EventHandler(venta_metodo_pago);
            this.vista.btn_cancelar.Click += new EventHandler(btn_cancelar_Click);
            this.vista.tablaVentas.CellContentClick += new DataGridViewCellEventHandler(tablaVentas_CellContentClick);
        }

        private void vista_load(object sender, EventArgs e)
        {
            this.listaProductos = new Dictionary<string, long>();
            List<Producto> productos = this.productoDAO.readAll();
            List<String> nombreProductos = new List<string>();
            foreach (Producto producto in productos)
            {
                this.listaProductos.Add(producto.Descripcion, producto.Codigo_barra);
                nombreProductos.Add(producto.Descripcion);
            }

            foreach (string producto in nombreProductos)
            {
                this.vista.cb_productos.Items.Add(producto);
            }
        }

        private void cb_productos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.vista.cb_productos.SelectedIndex != -1)
            {
                String nombreProducto = this.vista.cb_productos.SelectedItem.ToString();
                long idProducto = this.listaProductos[nombreProducto];
                this.vista.tb_codigo.Text = idProducto.ToString();
            }
        }

        private void tablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto xProducto = new Producto();
            xProducto.Codigo_barra = Int64.Parse(this.vista.tablaVentas.Rows[e.RowIndex].Cells["codigo"].Value.ToString());
            xProducto.Precio_venta = Convert.ToDouble(this.vista.tablaVentas.Rows[e.RowIndex].Cells["precio"].Value.ToString());
            xProducto.Cantidad_actual = Convert.ToDouble(this.vista.tablaVentas.Rows[e.RowIndex].Cells["cantidad_actual"].Value.ToString());

            if (this.vista.tablaVentas.Rows[e.RowIndex].Cells["restar"].Selected)
            {
                
                xProducto.Cantidad_actual--;
                if (xProducto.Cantidad_actual == 0)
                {
                    //eliminar el registro
                    DialogResult resultado = new DialogResult();
                    Form advertencia = new frmAdvertencia("El producto será eliminado de la venta");
                    resultado = advertencia.ShowDialog();
                    if (resultado == DialogResult.OK)
                        this.vista.tablaVentas.Rows.RemoveAt(this.vista.tablaVentas.CurrentRow.Index);
                }
                else
                {
                    this.vista.tablaVentas.Rows[e.RowIndex].Cells["cantidad_actual"].Value = xProducto.Cantidad_actual;
                    this.vista.tablaVentas.Rows[e.RowIndex].Cells["subtotal"].Value = xProducto.Cantidad_actual * xProducto.Precio_venta;
                }

                this.totalVenta -= xProducto.Precio_venta;
            }
            else if (this.vista.tablaVentas.Rows[e.RowIndex].Cells["sumar"].Selected)
            {
                //Falta comprobar que la cantidad no pase de la disponible en inventario
                Producto producto = this.productoDAO.readById(xProducto.Codigo_barra);
                xProducto.Cantidad_actual++;
                if (xProducto.Cantidad_actual > producto.Cantidad_actual)
                {
                    Form mensajeError = new frmError("No hay cantidad suficiente de este producto.");
                    mensajeError.ShowDialog();
                    return;
                }

                this.vista.tablaVentas.Rows[e.RowIndex].Cells["cantidad_actual"].Value = xProducto.Cantidad_actual;
                this.vista.tablaVentas.Rows[e.RowIndex].Cells["subtotal"].Value = xProducto.Cantidad_actual * xProducto.Precio_venta;
                this.totalVenta += xProducto.Precio_venta;
            }

            this.vista.lbl_total.Text = "$" + this.totalVenta.ToString();
        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {
            long codigoBarra;
            String _codigoBarra = this.vista.tb_codigo.Text;

            //si está vacio
            if (String.IsNullOrEmpty(_codigoBarra))
            {
                this.vista.tb_codigo.BackColor = Color.Salmon;
                this.producto = null;
                return;
            }

            //si no es un codigo valido
            if (!Int64.TryParse(_codigoBarra, out codigoBarra))
            {
                this.vista.tb_codigo.BackColor = Color.Salmon;
                this.producto = null;
                return;
            }


            this.producto = this.productoDAO.readById(codigoBarra);
            if (this.producto != null)
            {
                this.vista.tb_codigo.BackColor = Color.White;
            }
            else
            {
                this.vista.tb_codigo.BackColor = Color.Salmon;
                this.producto = null;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            String _cantidad = this.vista.tb_cantidad.Text;
            double cantidad;
            bool medida;

            //Comprobar que el código haya sido ingresado y que la cantidad sea numerica no nula mayor a 0
            if (this.producto == null ||
                !ValidacionDatos.Numero(_cantidad, out cantidad,
                new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.NUM_DECIMALES, 3} }))
            {
                Form mensajeError = new frmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar si la medida del producto coincide con la cantidad a vender
            var parteDecimal = cantidad - Math.Truncate(cantidad);
            if (producto.Medida == false && parteDecimal != 0)
            {
                Form mensajeError = new frmError("No se puede vender en decimales este producto.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar que no se quiera vender más de lo que hay
            if (cantidad > producto.Cantidad_actual)
            {
                Form mensajeError = new frmError("No hay suficiente cantidad de este producto.");
                mensajeError.ShowDialog();
                return;
            }

            //agregarlo a la tabla ----------- MEJOR PONERLO EN UN METODO PARA LLAMARLO TAMBIEN CUANDO SEA POR ESCANER
            double subtotal = cantidad * producto.Precio_venta;
            subtotal = Math.Round(subtotal, 2);
            bool siEncontrado = false;

            //si se ingresa un articulo que ya estaba en la lista sólo se le suma la cantidad a la fila.
            //this.productosVenta.Clear();
            foreach (DataGridViewRow articulo in this.vista.tablaVentas.Rows)
            {
                if (long.Parse(articulo.Cells["codigo"].Value.ToString()) == this.producto.Codigo_barra)
                {
                    articulo.Cells["cantidad_actual"].Value = Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString()) + cantidad;
                    articulo.Cells["subtotal"].Value = Convert.ToDouble(articulo.Cells["subtotal"].Value.ToString()) + subtotal;
                    siEncontrado = true;
                }
                /*this.productosVenta.Add(new Producto(long.Parse(articulo.Cells["codigo"].Value.ToString()),
                    "", 0, 0,
                    Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString())
                    , false));*/
            }

            if (!siEncontrado)
            {
                //se agre un nuevo producto a la tabla
                this.vista.tablaVentas.Rows.Add();
                int indexNuevoProducto = this.vista.tablaVentas.RowCount -1;
                Console.WriteLine(indexNuevoProducto);
                this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["cantidad_Actual"].Value = cantidad;
                this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["descripcion"].Value = producto.Descripcion;
                this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["precio"].Value = producto.Precio_venta;
                this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["subtotal"].Value = subtotal;
                this.vista.tablaVentas.Rows[indexNuevoProducto].Cells["codigo"].Value = producto.Codigo_barra;
                //this.vista.tablaVentas.Rows.Add(cantidad, producto.Descripcion, producto.Precio_venta, subtotal, producto.Codigo_barra);
                //this.productosVenta.Add(new Producto(codigo, "", 0, 0, cantidad, false));


                //Producto xProducto = new Producto(codigo, "", 0, 0, cantidad, false);
                //this.vista.tablaVentas.Rows.Add();
                //this.vista.tablaVentas.Rows[0].Cells["cantidad_actual"].Value = cantidad;
                //this.vista.tablaVentas.Rows[0].Cells["descripcion"].Value = producto.Descripcion;
                //this.vista.tablaVentas.Rows[0].Cells["precio"].Value = producto.Precio_venta;
                //this.vista.tablaVentas.Rows[0].Cells["subtotal"].Value = subtotal;
                //this.vista.tablaVentas.Rows[0].Cells["codigo"].Value = producto.Codigo_barra;
            }

            //actualizar el total
            this.totalVenta += subtotal;
            this.vista.lbl_total.Text = "$" + this.totalVenta;
            this.vista.tb_codigo.Text = "";
            this.vista.tb_cantidad.Text = "";
            this.vista.cb_productos.SelectedIndex = -1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.vista.tablaVentas.Rows.Clear();
            this.productosVenta.Clear();
            this.totalVenta = 0;
        }

        private void venta_metodo_pago(object sender, EventArgs e)
        {
            //Comprobar si la lista está vacia
            int lista = this.vista.tablaVentas.Rows.Count;
            if (lista == 0)
            {
                Form mensajeError = new frmError("No se a registrado ningún articulo para la venta.");
                mensajeError.ShowDialog();
                return;
            }

            //Generar la lista de compra
            this.productosVenta.Clear();
            foreach (DataGridViewRow articulo in this.vista.tablaVentas.Rows)
            {
                Producto producto = new Producto();
                producto.Codigo_barra = long.Parse(articulo.Cells["codigo"].Value.ToString());
                producto.Descripcion = articulo.Cells["descripcion"].Value.ToString();
                producto.Precio_venta = Convert.ToDouble(articulo.Cells["precio"].Value.ToString());
                producto.Cantidad_actual = Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString());

                this.productosVenta.Add(producto);

                /*this.productosVenta.Add(new Producto(long.Parse(articulo.Cells["codigo"].Value.ToString()),
                    articulo.Cells["descripcion"].Value.ToString(), Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString()), 0,
                    Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString())
                    , false));*/
            }


            frmCobro cobro = new frmCobro(this.productosVenta, this.totalVenta);
            cobro.ShowDialog();

            if (cobro.DialogResult == DialogResult.OK)
            {
                this.vista.tablaVentas.Rows.Clear();
                this.productosVenta.Clear();
                this.totalVenta = 0;
                this.vista.lbl_total.Text = "$00.00";
            }
        }
    }
}
