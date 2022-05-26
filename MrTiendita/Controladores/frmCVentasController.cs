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
using System.Globalization;

namespace MrTiendita.Controladores
{
    /// <summary> Creamos la clase de control de las ventas. </summary>
    public class FrmCVentasController
    {
        private FrmVentas vista;
        private FrmBuscarProducto vista2;

        private ProductoDAO productoDAO;
        private VentaDAO ventaDAO;
        private CajaDAO cajaDAO;

        private Empleado empleado;
        private double totalVenta;
        private double efectivo;
        private string metodoPago;
        private NumberFormatInfo formato;
        private Producto producto;

        private List<Producto> productosVenta; //solo contiene productos con codigo y cantidad, lo demas vacio
        private Dictionary<String, long> listaProductos;

        /// <summary> Inicializa una nueva instancia de la clase <see cref="FrmCVentasController"/>. </summary>
        /// <param name="vista">The vista.</param>
        public FrmCVentasController(FrmVentas vista)
        {
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.ventaDAO = new VentaDAO();
            this.cajaDAO = new CajaDAO();

            this.productosVenta = new List<Producto>();
            this.empleado = EmpleadoCache.GetEmpleado();
            this.totalVenta = 0;
            this.efectivo = 0;
            this.metodoPago = TipoMovimiento.EFECTIVO;

            this.formato = new CultureInfo("es-MX").NumberFormat;
            this.formato.CurrencyGroupSeparator = ",";
            this.formato.NumberDecimalSeparator = ".";
            this.formato.CurrencyDecimalDigits = 2;

            this.vista.Load += new EventHandler(Vista_load);
            this.vista.btn_Buscar.Click += new EventHandler(Btn_Buscar_AbrirFrm);
            this.vista.tb_Codigo.TextChanged += new EventHandler(tb_Codigo_TextChanged);
            this.vista.tb_Cantidad.TextChanged += delegate (object sender, EventArgs e)
            {
                double cantidad;
                Label label = new Label();
                ValidacionFormulario.Validar(
                    label, "", this.vista.tb_Cantidad.Text, out cantidad, ValidacionDatosOpciones.CANTIDAD);
            };
            this.vista.btn_Agregar.Click += new EventHandler(btn_Agregar_Click);

            this.vista.check_Efectivo.OnChange += new EventHandler(check_Efectivo_OnChange);
            this.vista.check_Tarjeta.OnChange += new EventHandler(check_Tarjeta_OnChange);
            this.vista.tb_Efectivo.TextChanged += new EventHandler(tb_Efectivo_TextChanged);

            this.vista.btn_CompletarVenta.Click += new EventHandler(btn_CompletarVenta_Click);
            this.vista.btn_CancelarVenta.Click += new EventHandler(Btn_cancelar_Click);
            this.vista.dgv_TablaVentas.CellContentClick += new DataGridViewCellEventHandler(TablaVentas_CellContentClick);
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

        private void check_Efectivo_OnChange(object sender, EventArgs e)
        {
            this.EfectivoDefault();
        }

        private void check_Tarjeta_OnChange(object sender, EventArgs e)
        {
            this.TarjetaDefault();
        }

        private void tb_Efectivo_TextChanged(object sender, EventArgs e)
        {
            Dictionary<int, double> longitudCadenas = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_IGUAL_A, this.totalVenta},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };

            //el boton de aceptar se mantiene inactivo hasta que pase todas las pruebas el campo efectivo
            this.vista.btn_CompletarVenta.Enabled = false;
            this.vista.lbl_Cambio.Text = "$--.--";


            if (!ValidacionFormulario.Validar(
                this.vista.lbl_EfetivoTb, "", this.vista.tb_Efectivo.Text, out this.efectivo, longitudCadenas))
            {
                return;
            }

            this.vista.btn_CompletarVenta.Enabled = true;
            this.vista.lbl_Cambio.Text = (this.efectivo - this.totalVenta).ToString("C", this.formato);
        }

        /// <summary> Maneja el evento CellContentClick del control Tabla Ventas. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="DataGridViewCellEventArgs"/> .</param>
        private void TablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto xProducto = new Producto
            {
                Codigo_barra = Int64.Parse(
                    this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Codigo"].Value.ToString()),
                Precio_venta = Convert.ToDouble(
                    this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Precio"].Value.ToString()),
                Cantidad_actual = Convert.ToDouble(
                    this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Cantidad"].Value.ToString())
            };

            if (this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Menos"].Selected)
            {
                xProducto.Cantidad_actual--;
                if (xProducto.Cantidad_actual == 0)
                {
                    //eliminar el registro
                    DialogResult resultado = new DialogResult();
                    Form advertencia = new FrmAdvertencia("El producto será eliminado de la venta");
                    resultado = advertencia.ShowDialog();
                    if (resultado == DialogResult.OK)
                        this.vista.dgv_TablaVentas.Rows.RemoveAt(this.vista.dgv_TablaVentas.CurrentRow.Index);
                }
                else
                {
                    this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Cantidad"].Value = xProducto.Cantidad_actual;
                    this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Subtotal"].Value =
                        xProducto.Cantidad_actual * xProducto.Precio_venta;
                }

                this.totalVenta -= xProducto.Precio_venta;
            }
            else if (this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Mas"].Selected)
            {
                Producto producto = this.productoDAO.ReadById(xProducto.Codigo_barra);
                xProducto.Cantidad_actual++;
                if (xProducto.Cantidad_actual > producto.Cantidad_actual)
                {
                    Form mensajeError = new FrmError("No hay cantidad suficiente de este producto.");
                    mensajeError.ShowDialog();
                    return;
                }

                this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Cantidad"].Value = xProducto.Cantidad_actual;
                this.vista.dgv_TablaVentas.Rows[e.RowIndex].Cells["col_Subtotal"].Value =
                    xProducto.Cantidad_actual * xProducto.Precio_venta;
                this.totalVenta += xProducto.Precio_venta;
            }

            this.vista.lbl_TotalAPagar.Text = this.totalVenta.ToString("C", this.formato);
            this.vista.tb_Efectivo.Text = this.totalVenta.ToString();
        }

        /// <summary> Maneja el evento Click del control Btn_Cancelar.</summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/>.</param>
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarVista();
        }

        /// <summary> Maneja el evento pago del control Venta_metodo.</summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia que contiene los datos del evento <see cref="EventArgs"/>.</param>
        private void btn_CompletarVenta_Click(object sender, EventArgs e)
        {
            bool siExito = false;
            //Comprobar si la lista está vacia
            int listaVentas = this.vista.dgv_TablaVentas.Rows.Count;
            if (listaVentas == 0)
            {
                Form mensajeError = new FrmError("No se a registrado ningún articulo para la venta.");
                mensajeError.ShowDialog();
                return;
            }

            //Generar la lista de Producto para actualziar su cantidad
            this.productosVenta.Clear();
            foreach (DataGridViewRow articulo in this.vista.dgv_TablaVentas.Rows)
            {
                Producto producto = new Producto
                {
                    Codigo_barra = long.Parse(articulo.Cells["col_Codigo"].Value.ToString()),
                    Descripcion = articulo.Cells["col_Descripcion"].Value.ToString(),
                    Precio_venta = Convert.ToDouble(articulo.Cells["col_Precio"].Value.ToString()),
                    Cantidad_actual = Convert.ToDouble(articulo.Cells["col_Cantidad"].Value.ToString())
                };
                this.productosVenta.Add(producto);
            }

            //Generar la lista de Ventas
            List<Venta> ventas = new List<Venta>();
            foreach (Producto producto in this.productosVenta)
            {
                Venta venta = new Venta();
                venta.Id_venta = -1;
                venta.Codigo_barra = producto.Codigo_barra;
                venta.Id_empleado = this.empleado.Id_empleado;
                venta.Metodo_pago = "Efectivo";
                venta.Fecha = DateTime.Now;
                venta.Cantidad = producto.Cantidad_actual;
                venta.Importe = Math.Round(producto.Cantidad_actual * producto.Precio_venta, 2);
                ventas.Add(venta);
            }

            //Según el método de pago llama a métodos diferentes
            if (this.metodoPago == TipoMovimiento.EFECTIVO)
            {
                //Obtener el valor de la caja
                Caja caja = this.cajaDAO.ReadByName("Total");
                if (caja == null)
                {
                    FrmError error = new FrmError("No se pudo obtener la información sobre la caja.");
                    error.ShowDialog();
                    this.vista.DialogResult = DialogResult.Abort;
                    return;
                }
                caja.Valor = (double.Parse(caja.Valor) + this.totalVenta).ToString();

                //Se crea un objeto Movimiento para la entrada de dinero
                Movimiento movimiento = new Movimiento(
                    -1,
                    TipoMovimiento.VENTA,
                    DateTime.Now,
                    this.totalVenta,
                    double.Parse(caja.Valor),
                    TipoMovimiento.VENTA
                );
                siExito = this.ventaDAO.Create(ventas, this.productosVenta, movimiento, caja);
            }
            else if (this.metodoPago == TipoMovimiento.TARJETA)
            {
                siExito = this.ventaDAO.Create(ventas, this.productosVenta);
            }

            if (!siExito)
            {
                FrmError error = new FrmError("Hubo un error al realizar la venta  --> " + this.ventaDAO.MensajeError);
                error.ShowDialog();
                return;
            }
            CrearTicket ticket = this.GenerarTicket();
            this.GuardarTicket(ticket);
            FrmExito mensajeExito = new FrmExito("Se registrado la venta con éxito.");
            mensajeExito.ShowDialog();

            this.LimpiarVista();
        }

        private void Btn_Buscar_AbrirFrm(object sender, EventArgs e)
        {
            this.vista2 = new FrmBuscarProducto(this);
            this.vista2.ShowDialog();
        }

        private void tb_Codigo_TextChanged(object sender, EventArgs e)
        {
            string _codigo = this.vista.tb_Codigo.Text;
            long codigo;
            Label label = new Label();

            if (!ValidacionFormulario.Validar(label, "", _codigo, out codigo, ValidacionDatosOpciones.CODIGO_BARRA))
            {
                this.producto = null;
                return;
            }

            this.producto = this.productoDAO.ReadById(codigo);

            if(this.producto == null)
            {
                //imprimir el mensaje en la etiqueta
                label.Text = "Producto no encontrado...";
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            double cantidad;
            Label label = new Label();
            if (this.producto == null ||
                !ValidacionFormulario.Validar(label, "", this.vista.tb_Cantidad.Text, out cantidad, ValidacionDatosOpciones.CANTIDAD))
            {
                FrmError error = new FrmError("Debe de escribir el código de barras y la cantidad correctamente.");
                error.ShowDialog();
                return;
            }

            this.AgregarProducto(this.producto.Codigo_barra, cantidad);
        }


        //Métodos auxiliares
        public void AgregarProducto(long codigobarra, double cantidad) 
        {
            Producto producto = this.productoDAO.ReadById(codigobarra);
            bool siencontrado = false;
            int indexRow = -1;
            double cantidadTabla = 0;
            double subtotal = 0;
            //se comprubea si el producto ya está en la tabla o no 
            foreach (DataGridViewRow articulo in this.vista.dgv_TablaVentas.Rows)
            {
                if (long.Parse(articulo.Cells["col_Codigo"].Value.ToString()) == producto.Codigo_barra)
                {
                    siencontrado = true;
                    indexRow = articulo.Index;
                    cantidadTabla = Convert.ToDouble(articulo.Cells["col_Cantidad"].Value.ToString());
                }
            }

            //comprobar que no se quiera vender más de lo que hay
            if ((cantidad + cantidadTabla) > producto.Cantidad_actual)
            {
                Form mensajeerror = new FrmError("no hay suficiente cantidad de este producto.");
                mensajeerror.ShowDialog();
                return;
            }

            //agregar a la tabla la nueva fila, si no existe, o actualizar la fila, si existe
            subtotal = cantidad * producto.Precio_venta;
            if (!siencontrado)
            {
                this.vista.dgv_TablaVentas.Rows.Add();
                indexRow = this.vista.dgv_TablaVentas.RowCount - 1;
                this.vista.dgv_TablaVentas.Rows[indexRow].Cells["col_Cantidad"].Value = cantidad;
                this.vista.dgv_TablaVentas.Rows[indexRow].Cells["col_Descripcion"].Value = producto.Descripcion;
                this.vista.dgv_TablaVentas.Rows[indexRow].Cells["col_Precio"].Value = producto.Precio_venta;
                this.vista.dgv_TablaVentas.Rows[indexRow].Cells["col_Subtotal"].Value = subtotal;
                this.vista.dgv_TablaVentas.Rows[indexRow].Cells["col_Codigo"].Value = codigobarra;
            }
            else
            {
                DataGridViewRow articulo = this.vista.dgv_TablaVentas.Rows[indexRow];
                DataGridViewCell celdaCantidad = articulo.Cells["col_Cantidad"];
                DataGridViewCell celdaSubtotal = articulo.Cells["col_subtotal"];
                celdaCantidad.Value = Convert.ToDouble(celdaCantidad.Value.ToString()) + cantidad;
                celdaSubtotal.Value = Convert.ToDouble(celdaSubtotal.Value.ToString()) + subtotal;
            }

            //actualizar el total
            this.totalVenta += subtotal;
            this.vista.lbl_TotalAPagar.Text = this.totalVenta.ToString("C", this.formato);
            this.vista.tb_Efectivo.Text = this.totalVenta.ToString();
        }

        private void EfectivoDefault()
        {
            if (this.vista.check_Efectivo.Checked)
            {
                this.vista.check_Tarjeta.Checked = false;
                this.vista.tb_Efectivo.Enabled = true;
                this.metodoPago = TipoMovimiento.EFECTIVO;
            }
            else this.vista.check_Efectivo.Checked = true;

        }

        private void TarjetaDefault()
        {
            if (this.vista.check_Tarjeta.Checked)
            {
                this.vista.check_Efectivo.Checked = false;
                this.vista.tb_Efectivo.Enabled = false;
                this.metodoPago = TipoMovimiento.TARJETA;
            }
            else this.vista.check_Tarjeta.Checked = true;
        }

        private void LimpiarVista()
        {
            this.vista.dgv_TablaVentas.Rows.Clear();
            this.productosVenta.Clear();
            this.totalVenta = 0;
            this.vista.lbl_TotalAPagar.Text = "$0.00";
            this.vista.lbl_Cambio.Text = "$0.00";
            this.vista.tb_Efectivo.Text = "";
            this.vista.btn_CompletarVenta.Enabled = true;
        }

        private CrearTicket GenerarTicket()
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            ticket.AbreCajon();//Para abrir el cajon de dinero.
            ticket.TextoCentro("EL RINCÓN");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: " + this.empleado.Nombre);
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("");
            ticket.LineasAsteriscos();
            ticket.EncabezadoVenta();
            ticket.LineasAsteriscos();
            foreach (Producto item in this.productosVenta)
            {
                ticket.AgregaArticulo(
                    item.Descripcion, item.Cantidad_actual, item.Precio_venta, item.Precio_venta * item.Cantidad_actual);
            }
            ticket.LineasIgual();
            ticket.AgregarTotales("         TOTAL.........$", this.totalVenta);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", this.efectivo);
            ticket.AgregarTotales("         CAMBIO........$", this.efectivo - this.totalVenta);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            return ticket;
        }

        /// <summary> Guardars the ticket. </summary>
        /// <param name="ticket">The ticket.</param>
        private void GuardarTicket(CrearTicket ticket)
        {
            DateTime hora = DateTime.Now;
            String nombre = "Ticket_" + hora.ToString("yyyy-MM-dd_HH-mm-ss");
            String rutaTickets = Properties.Settings.Default.RutaTickets;
            String ruta = rutaTickets + "\\" + nombre + ".txt";
            Console.WriteLine(ruta);
            try
            {
                using (StreamWriter file = new StreamWriter(ruta))
                {
                    file.WriteLine(ticket.Linea);
                }
            }
            catch (Exception e)
            {
                Form mensajeError = new FrmError("Error: " + e.Message);
                mensajeError.ShowDialog();
            }
        }
    }
}
