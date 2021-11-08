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
            this.vista.btn_finalizar.Click += new EventHandler(Venta);
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
            this.productosVenta.Clear();
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
        }

        private void Venta(object sender, EventArgs e)
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
                this.productosVenta.Add(new Producto(long.Parse(articulo.Cells["codigo"].Value.ToString()),
                    "", 0, 0,
                    Convert.ToDouble(articulo.Cells["cantidad_actual"].Value.ToString())
                    , false));
            }

            //se actualzia la cantidad en los productos del almacen
            bool res = this.productoDAO.updateCantidad(this.productosVenta);
            if (!res)
            {
                String mensaje = "Error: No se encontró el producto.";
                if (this.productoDAO.ErrorUltimaConsulta)
                {
                    mensaje = this.productoDAO.MensajeError;
                }
                Form mensajeError = new frmError(mensaje);
                mensajeError.ShowDialog();
                return;

            }

            CrearTicket ticket = this.GenerarTicket();
            //Console.WriteLine(ticket.Linea);
            this.GuardarTicket(ticket);
            //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }
        private CrearTicket GenerarTicket()
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("NOMBRE DE LA EMPRESA");
            //ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda("DIREC: Toluca #1380");
            ticket.TextoIzquierda("TEL: 6623596075");
            //ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            //ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            //ticket.TextoExtremos("Caja # 1", "Ticket # 002-0000006");
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: VENDEDOR");
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
            ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            //ticket.AgregarTotales("         SUBTOTAL......$", 100);
            //ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);

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
