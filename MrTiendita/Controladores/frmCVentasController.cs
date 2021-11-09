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

namespace MrTiendita.Controladores
{
    class frmCVentasController
    {
        private frmCVentas vista;
        private ProductoDAO productoDAO;
        private Producto producto;
        private double totalVenta;
        private List<Producto> productosVenta; //solo contiene productos con codigo y cantidad, lo demas vacio

        public frmCVentasController(frmCVentas vista)
        {
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.productosVenta = new List<Producto>();
            this.totalVenta = 0;
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
            this.vista.tb_codigo.TextChanged += new EventHandler(tb_codigo_TextChanged);
            this.vista.btn_finalizar.Click += new EventHandler(venta_metodo_pago);
            this.vista.btn_cancelar.Click += new EventHandler(btn_cancelar_Click);
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
            String _codigo = this.vista.tb_codigo.Text;
            long codigo;
            String _cantidad = this.vista.tb_cantidad.Text;
            double cantidad;
            bool medida;

            //comprobar que no estén vacios
            if (String.IsNullOrEmpty(_codigo) || String.IsNullOrEmpty(_cantidad))
            {
                Form mensajeError = new frmError("Debe de llenar todos los campos.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar que el codigo sea un numero long y la cantidad un decimal
            if (!Double.TryParse(_cantidad, out cantidad) || !Int64.TryParse(_codigo, out codigo))
            {
                Form mensajeError = new frmError("Uno o más datos son incorrectos, asegurase que sean números.");
                mensajeError.ShowDialog();
                return;
            }

            //obtener el producto por el codigo
            Producto producto = this.productoDAO.readById(codigo);

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
            bool siEncontrado = false;

            //si se ingresa un articulo que ya estaba en la lista sólo se le suma la cantidad a la fila.
            //this.productosVenta.Clear();
            foreach (DataGridViewRow articulo in this.vista.tablaVentas.Rows)
            {
                if (long.Parse(articulo.Cells["codigo"].Value.ToString()) == codigo)
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
                this.vista.tablaVentas.Rows.Add(cantidad, producto.Descripcion, producto.Precio_venta, subtotal, producto.Codigo_barra);
                //this.productosVenta.Add(new Producto(codigo, "", 0, 0, cantidad, false));
                //Producto xProducto = new Producto(codigo, "", 0, 0, cantidad, false);
            }

            //actualizar el total
            this.totalVenta += subtotal;
            this.vista.lbl_total.Text = "$" + this.totalVenta;
            this.vista.tb_codigo.Text = "";
            this.vista.tb_cantidad.Text = "";
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
