using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;
using MrTiendita.Vistas;
using System.Drawing;

namespace MrTiendita.Controladores
{
    public class frmCAlmacenController
    {
        private frmCAlmacen vista;
        private EntradaAlmacenDAO entradaAlmacenDAO;
        private ProductoDAO productoDAO;

        private Producto prodcutoParaEntrada = null;
        public frmCAlmacenController(frmCAlmacen vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.productoDAO = new ProductoDAO();
            this.vista.btn_registrarEntrada.Click += new EventHandler(btn_registrarEntrada_Click);
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(tb_busqueda_TextChanged);
            this.vista.tb_codigo.TextChanged += new EventHandler(tb_codigo_TextChanged);
            this.vista.btn_Limpiar.Click += new EventHandler(btn_Limpiar_Click);
        }

        public void vista_Load(object sender, EventArgs e)
        {
            this.MostrarProductos();
            //this.vista.tablaProductos.DataSource = 
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
            if (String.IsNullOrEmpty(_codigoBarra))
            {
                this.vista.tb_codigo.BackColor = Color.Salmon;
                return;
            }
            
            if (Int64.TryParse(_codigoBarra, out codigoBarra))
            {
                prodcutoParaEntrada = this.productoDAO.readById(codigoBarra);
                if (prodcutoParaEntrada != null)
                {
                    this.vista.tb_codigo.BackColor = Color.White;
                }
                else
                {
                    this.vista.tb_codigo.BackColor = Color.Salmon;
                    this.prodcutoParaEntrada = null;
                }
            }
            else
            {
                this.vista.tb_codigo.BackColor = Color.Salmon;
                this.prodcutoParaEntrada = null;
                Form mensajeError = new frmError("El Codigo de barras introducido es incorrecto.");
                mensajeError.ShowDialog();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.vista.tb_codigo.Text = "";
            this.vista.tb_cantidad.Text = "";
        }

        public void btn_registrarEntrada_Click(object sender, EventArgs e)
        {
            //Combrobar que todos los campos estén llenos y que codigo y proveedor sean validos.
            if (
                String.IsNullOrEmpty(this.vista.tb_codigo.Text)
                || String.IsNullOrEmpty(this.vista.tb_cantidad.Text)
                || this.prodcutoParaEntrada == null)
            {
                Form mensajeError = new frmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            EntradaAlmacen entrada = new EntradaAlmacen();

            String _cantidad = this.vista.tb_cantidad.Text;
            String _codigoBarra = this.vista.tb_codigo.Text;

            double cantidad;
            long codigoBarra;

            if (Double.TryParse(_cantidad, out cantidad) && Int64.TryParse(_codigoBarra, out codigoBarra))
            {
                entrada.Codigo_barra = codigoBarra;
                entrada.Cantidad = cantidad;
                entrada.Fecha = DateTime.Now;
                entrada.Importe = prodcutoParaEntrada.Precio_compra * cantidad;
                entrada.Id_proveedor = 2; //MIENTRAS SE MODIFICAN LAS VISTAS
                this.prodcutoParaEntrada.Cantidad_actual = this.prodcutoParaEntrada.Cantidad_actual + cantidad;

                var parteDecimal = cantidad - Math.Truncate(cantidad);
                if (this.prodcutoParaEntrada.Medida == false && parteDecimal != 0)
                {
                    Form mensajeError = new frmError("No se puede agregar decimales a un producto por unidad.");
                    mensajeError.ShowDialog();
                    return;
                }


                bool res = this.entradaAlmacenDAO.create(entrada, this.prodcutoParaEntrada);
                if (res)
                {
                    this.vista.tb_codigo.Text = "";
                    this.vista.tb_cantidad.Text = "";
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
            else
            {
                Form mensajeError = new frmError("Uno o más datos son incorrectos, asegurase que sean números.");
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
    }
}
