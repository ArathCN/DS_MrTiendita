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
    class frmCobroController
    {
        private frmCobro vista;
        private List<Producto> productosVenta;
        private ProductoDAO productoDAO;
        private MovimientoDAO movimientoDAO;
        private Empleado empleado;
        private CajaDAO cajaDAO;
        private VentaDAO ventaDAO;
        private double totalVenta;
        private double efectivo;
        private bool metodoEfectivo = true; 

        public frmCobroController(frmCobro vista, List<Producto> productos, double total)
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
            this.vista.cb_metodoPago.SelectedIndexChanged += new EventHandler(cb_metodoPago_SelectedIndexChanged);
            this.vista.tb_efectivo.TextChanged += new EventHandler(tb_efectivo_textChanged);
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
        }

        private void cb_metodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vista.btn_aceptar.Visible = true;
            if (this.vista.cb_metodoPago.SelectedIndex == 0)
            {
                this.vista.label1.Visible = true;
                this.vista.label2.Visible = true;
                this.vista.lbl_cambio.Visible = true;
                this.vista.tb_efectivo.Visible = true;
                //this.vista.pictureBox2.Visible = true;
                this.metodoEfectivo = true;
            }
            else if (this.vista.cb_metodoPago.SelectedIndex == 1)
            {
                this.vista.label1.Visible = false;
                this.vista.label2.Visible = false;
                this.vista.lbl_cambio.Visible = false;
                this.vista.tb_efectivo.Visible = false;
                //this.vista.pictureBox2.Visible = false;
                this.metodoEfectivo = false;
            }
        }

        private void tb_efectivo_textChanged(object sender, EventArgs e)
        {
            String _efectivo = this.vista.tb_efectivo.Text;
            double dato2;
            String mensajeError = "De ser un número mayor a " + this.totalVenta + " con máximo dos decimales.";
            Dictionary<int, double> opciones2 = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, this.totalVenta},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };

            //el boton de aceptar se mantiene inactivo hasta que pase todas las pruebas el campo efectivo
            this.vista.btn_aceptar.Enabled = false;
            this.vista.lbl_cambio.Text = "--.--";
            

            if (!ValidacionFormulario.Validar(this.vista.lbl_ErrorEfectivo, mensajeError, _efectivo, out this.efectivo, opciones2))
            {
                this.vista.tb_efectivo.BackColor = Color.Salmon;
                return;
            }

            this.vista.btn_aceptar.Enabled = true;
            this.vista.tb_efectivo.BackColor = Color.White;
            this.vista.lbl_cambio.Text = "$" + (this.efectivo - this.totalVenta);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            //se actualzia la cantidad en los productos del almacen
            bool res = this.productoDAO.updateCantidad(this.productosVenta);
            if (!res)
            {
                String mensaje = "Error: No se encontró el producto.";
                if (this.productoDAO.ErrorUltimaConsulta)
                {
                    mensaje = this.productoDAO.MensajeError;
                }
                frmError mensajeError = new frmError(mensaje);
                mensajeError.ShowDialog();
                this.vista.DialogResult = DialogResult.Abort;
                return;

            }

            //Obtener el valor de la caja
            Caja caja = this.cajaDAO.readByName("Total");
            if (caja == null)
            {
                frmError error = new frmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                this.vista.DialogResult = DialogResult.Abort;
                return;
            }

            //Generar venta
            res = this.GenerarVenta();
            if (!res)
            {
                frmError error = new frmError("Hubo un error al registrar las ventas.");
                error.ShowDialog();
                this.vista.DialogResult = DialogResult.Abort;
                return;
            }

            //Si el met. es efectivo se crea una entrada de dinero y se actualiza la caja
            if (this.metodoEfectivo)
            {
                //Registrar la entrada de dinero, sólo es es efectivo
                Movimiento movimiento = new Movimiento(-1, TipoMovimiento.VENTA, DateTime.Now, this.totalVenta, double.Parse(caja.Valor) + this.totalVenta, TipoMovimiento.VENTA);
                res = this.movimientoDAO.create(movimiento);
                if (!res)
                {
                    frmError error = new frmError("Hubo un error al registrar el movimiento.");
                    error.ShowDialog();
                    this.vista.DialogResult = DialogResult.Abort;
                    return;
                }

                //Actualizar el dinero en la caja, sólo si es efectivo
                res = this.cajaDAO.updateValue("Total", (double.Parse(caja.Valor) + this.totalVenta).ToString());
                if (!res)
                {
                    frmError error = new frmError("Hubo un error al actualizar el total de la caja.");
                    error.ShowDialog();
                    this.vista.DialogResult = DialogResult.Abort;
                    return;
                }
            }

            CrearTicket ticket = this.GenerarTicket();
            this.GuardarTicket(ticket);
            //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera

            frmExito mensajeExito = new frmExito("Se registrado la venta con éxito.");
            mensajeExito.ShowDialog();
            //this.vista.tablaVentas.Rows.Clear();
            this.vista.DialogResult = DialogResult.OK;


        }


        private bool GenerarVenta()
        {
            bool res = true;
            for (int i = 0; i < this.productosVenta.Count && res; i++)
            {
                Venta venta = new Venta();
                venta.Id_venta = -1;
                venta.Codigo_barra = this.productosVenta[i].Codigo_barra;
                venta.Id_empleado = this.empleado.Id_empleado;
                venta.Metodo_pago = "Efectivo";
                venta.Fecha = DateTime.Now;
                venta.Cantidad = this.productosVenta[i].Cantidad_actual;
                venta.Importe = this.totalVenta;

                res = this.ventaDAO.create(venta);
                if (!res)
                {
                    return false;
                }
            }

            return true;
        }
        private CrearTicket GenerarTicket()
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("EL RINCÓN");
            //ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            //ticket.TextoIzquierda("DIREC: Toluca #1380");
            //ticket.TextoIzquierda("TEL: 6623596075");
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            //ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            //ticket.TextoExtremos("Caja # 1", "Ticket # 002-0000006");
            //ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: " + this.empleado.Nombre);
            //ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            //ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("");
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            foreach (Producto item in this.productosVenta)
            {
               //var importe item.Precio_venta * item.Cantidad_actual;
                ticket.AgregaArticulo(item.Descripcion, item.Cantidad_actual, item.Precio_venta, item.Precio_venta * item.Cantidad_actual);
            }
            //ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            //ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            //ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            //ticket.AgregarTotales("         SUBTOTAL......$", 100);
            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", this.totalVenta);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", this.efectivo);
            ticket.AgregarTotales("         CAMBIO........$", this.efectivo - this.totalVenta);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            //ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            //ticket.TextoIzquierda("");
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
                Form mensajeError = new frmError("Error: " + e.Message);
                mensajeError.ShowDialog();
            }
        }
    }
}
