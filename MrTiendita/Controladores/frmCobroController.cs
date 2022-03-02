using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using CrearTicketVenta;
using System.Windows.Forms;
using System.IO;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using System.Drawing;

namespace MrTiendita.Controladores
{
    class FrmCobroController
    {
        private FrmCobro vista;
        private List<Producto> productosVenta;
        private ProductoDAO productoDAO;
        private MovimientoDAO movimientoDAO;
        private Empleado empleado;
        private CajaDAO cajaDAO;
        private VentaDAO ventaDAO;
        private double totalVenta;
        private double efectivo;
        private bool metodoEfectivo = true; 

        public FrmCobroController(FrmCobro vista, List<Producto> productos, double total)
        {
            this.productoDAO = new ProductoDAO();
            this.movimientoDAO = new MovimientoDAO();
            this.cajaDAO = new CajaDAO();
            this.empleado = EmpleadoCache.GetEmpleado();
            this.ventaDAO = new VentaDAO();
            this.vista = vista;
            this.productosVenta = productos;
            this.totalVenta = total;
            this.efectivo = 0;
            this.vista.cb_metodoPago.SelectedIndexChanged += new EventHandler(Cb_metodoPago_SelectedIndexChanged);
            this.vista.tb_efectivo.TextChanged += new EventHandler(Tb_efectivo_textChanged);
            this.vista.btn_aceptar.Click += new EventHandler(Btn_aceptar_Click);
        }

        private void Cb_metodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vista.btn_aceptar.Visible = true;
            if (this.vista.cb_metodoPago.SelectedIndex == 0)
            {
                this.vista.label1.Visible = true;
                this.vista.label2.Visible = true;
                this.vista.lbl_cambio.Visible = true;
                this.vista.tb_efectivo.Visible = true;
                this.metodoEfectivo = true;
            }
            else if (this.vista.cb_metodoPago.SelectedIndex == 1)
            {
                this.vista.label1.Visible = false;
                this.vista.label2.Visible = false;
                this.vista.lbl_cambio.Visible = false;
                this.vista.tb_efectivo.Visible = false;
                this.metodoEfectivo = false;
            }
        }

        private void Tb_efectivo_textChanged(object sender, EventArgs e)
        {
            String efectivoCadena = this.vista.tb_efectivo.Text;
            String mensajeError = "De ser un número mayor a " + this.totalVenta + " con máximo dos decimales.";
            Dictionary<int, double> longitudCadenas = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, this.totalVenta},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };

            //el boton de aceptar se mantiene inactivo hasta que pase todas las pruebas el campo efectivo
            this.vista.btn_aceptar.Enabled = false;
            this.vista.lbl_cambio.Text = "--.--";
            

            if (!ValidacionFormulario.Validar(
                this.vista.lbl_ErrorEfectivo,
                mensajeError,
                efectivoCadena,
                out this.efectivo,
                longitudCadenas))
            {
                return;
            }

            this.vista.btn_aceptar.Enabled = true;
            this.vista.lbl_cambio.Text = "$" + (this.efectivo - this.totalVenta);
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            
            //se actualzia la cantidad en los productos del almacen
            bool esActualizado = this.productoDAO.UpdateCantidad(this.productosVenta);
            if (!esActualizado)
            {
                String mensaje = "Error: No se encontró el producto.";
                if (this.productoDAO.ErrorUltimaConsulta)
                    mensaje = this.productoDAO.MensajeError;
                FrmError mensajeError = new FrmError(mensaje);
                mensajeError.ShowDialog();
                this.vista.DialogResult = DialogResult.Abort;
                return;
            }

            //Obtener el valor de la caja
            Caja caja = this.cajaDAO.ReadByName("Total");
            if (caja == null)
            {
                FrmError error = new FrmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                this.vista.DialogResult = DialogResult.Abort;
                return;
            }

            //Generar venta
            esActualizado = this.GenerarVenta();
            if (!esActualizado)
            {
                FrmError error = new FrmError("Hubo un error al registrar las ventas.");
                error.ShowDialog();
                this.vista.DialogResult = DialogResult.Abort;
                return;
            }

            //Si el metodo es efectivo se crea una entrada de dinero y se actualiza la caja
            if (this.metodoEfectivo)
            {
                //Registrar la entrada de dinero, sólo si es en efectivo
                Movimiento movimiento = new Movimiento(
                    -1, TipoMovimiento.VENTA,
                    DateTime.Now,
                    this.totalVenta,
                    double.Parse(caja.Valor) + this.totalVenta,
                    TipoMovimiento.VENTA);
                esActualizado = this.movimientoDAO.Create(movimiento);
                if (!esActualizado)
                {
                    FrmError error = new FrmError("Hubo un error al registrar el movimiento.");
                    error.ShowDialog();
                    this.vista.DialogResult = DialogResult.Abort;
                    return;
                }

                //Actualizar el dinero en la caja, sólo si es efectivo
                esActualizado = this.cajaDAO.UpdateValue("Total", (double.Parse(caja.Valor) + this.totalVenta).ToString());
                if (!esActualizado)
                {
                    FrmError error = new FrmError("Hubo un error al actualizar el total de la caja.");
                    error.ShowDialog();
                    this.vista.DialogResult = DialogResult.Abort;
                    return;
                }
            }

            CrearTicket ticket = this.GenerarTicket();
            this.GuardarTicket(ticket);
            //ticket.ImprimirTicket("Microsoft XPS Document Writer"); //Nombre de la impresora ticketera
            FrmExito mensajeExito = new FrmExito("Se registrado la venta con éxito.");
            mensajeExito.ShowDialog();
            this.vista.DialogResult = DialogResult.OK;

        }

        //Métodos auxiliares
        private bool GenerarVenta()
        {
            bool esCreado = true;
            for (int i = 0; i < this.productosVenta.Count && esCreado; i++)
            {
                Venta venta = new Venta();
                venta.Id_venta = -1;
                venta.Codigo_barra = this.productosVenta[i].Codigo_barra;
                venta.Id_empleado = this.empleado.Id_empleado;
                venta.Metodo_pago = "Efectivo";
                venta.Fecha = DateTime.Now;
                venta.Cantidad = this.productosVenta[i].Cantidad_actual;
                venta.Importe = this.totalVenta;

                esCreado = this.ventaDAO.Create(venta);
                if (!esCreado)
                    return false;
            }

            return true;
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
