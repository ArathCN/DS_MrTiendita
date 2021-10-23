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
        private ProveedorDAO proveedorDAO;

        private Producto prodcutoParaEntrada = null;
        private Proveedor proveedorParaEntrada = null;
        public frmCAlmacenController(frmCAlmacen vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.productoDAO = new ProductoDAO();
            this.proveedorDAO = new ProveedorDAO();
            this.vista.btn_registrarEntrada.Click += new EventHandler(btn_registrarEntrada_Click);
            this.vista.btn_nuevaEntrada.Click += new EventHandler(btn_nuevaEntrada_Click);
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(tb_busqueda_TextChanged);
            this.vista.tb_codigo.TextChanged += new EventHandler(tb_codigo_TextChanged);
            this.vista.tb_noProveedor.TextChanged += new EventHandler(tb_noProveedor_TextChanged);
            this.vista.tb_cantidad.TextChanged += new EventHandler(tb_cantidad_TextChanged);
        }

        public void vista_Load(object sender, EventArgs e)
        {
            List<Producto> productos = this.productoDAO.readAll();
            foreach (Producto xProducto in  productos)
            {
                this.vista.tablaProductos.Rows.Add(xProducto.Codigo_barra, xProducto.Cantidad_actual, xProducto.Descripcion, xProducto.Precio_venta);
            }
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
            String _codigoBarra = this.vista.tb_codigo.Text;
            if (String.IsNullOrEmpty(_codigoBarra))
            {
                this.vista.tb_codigo.BackColor = Color.Salmon;
                return;
            }
            int codigoBarra;
            if (Int32.TryParse(_codigoBarra, out codigoBarra))
            {
                prodcutoParaEntrada = this.productoDAO.readById(codigoBarra);
                if (prodcutoParaEntrada != null)
                {
                    this.vista.tb_codigo.BackColor = Color.White;
                    this.calcularImporte();
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

        private void tb_noProveedor_TextChanged(object sender, EventArgs e)
        { 
            String _idProveedor = this.vista.tb_noProveedor.Text;

            if (String.IsNullOrEmpty(_idProveedor))
            {
                this.vista.tb_noProveedor.BackColor = Color.Salmon;
                return;
            }

            int idProveedor;
            if (Int32.TryParse(_idProveedor, out idProveedor))
            {
                proveedorParaEntrada = this.proveedorDAO.readById(idProveedor);
                if (proveedorParaEntrada != null)
                {
                    this.vista.tb_noProveedor.BackColor = Color.White;
                }
                else
                {
                    this.proveedorParaEntrada = null;
                    this.vista.tb_noProveedor.BackColor = Color.Salmon;
                }
            }
            else
            {
                this.proveedorParaEntrada = null;
                this.vista.tb_noProveedor.BackColor = Color.Salmon;
                Form mensajeError = new frmError("El id del proveedor introducido es incorrecto.");
                mensajeError.ShowDialog();
            }
        }

        private void tb_cantidad_TextChanged(object sender, EventArgs e)
        {
            String _cantidad = this.vista.tb_cantidad.Text;
            if (String.IsNullOrEmpty(_cantidad))
            {
                return;
            }

            int cantidad;
            if (Int32.TryParse(_cantidad, out cantidad))
            {
                this.calcularImporte();
            }
        }

        public void btn_registrarEntrada_Click(object sender, EventArgs e)
        {
            //Combrobar que todos los campos estén llenos y que codigo y proveedor sean validos.
            if (String.IsNullOrEmpty(this.vista.tb_codigo.Text) || String.IsNullOrEmpty(this.vista.tb_noFactura.Text)
                || String.IsNullOrEmpty(this.vista.tb_noProveedor.Text) || String.IsNullOrEmpty(this.vista.tb_cantidad.Text)
                || this.prodcutoParaEntrada == null || this.proveedorParaEntrada == null)
            {
                Form mensajeError = new frmError("Debe de llenar todos los campos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            EntradaAlmacen entrada = new EntradaAlmacen();

            String _noFactura = this.vista.tb_noFactura.Text;
            String _cantidad = this.vista.tb_cantidad.Text;

            int noFactura;
            int cantidad;

            if (Int32.TryParse(_noFactura, out noFactura) && Int32.TryParse(_cantidad, out cantidad))
            {
                entrada.Id_proveedor = proveedorParaEntrada.Id_proveedor;
                entrada.Codigo_barra = this.prodcutoParaEntrada.Codigo_barra;
                entrada.No_factura = noFactura;
                entrada.Cantidad = cantidad;
                entrada.Fecha = DateTime.Now;

                entrada.Importe = prodcutoParaEntrada.Precio_compra * cantidad;

                bool res = this.entradaAlmacenDAO.create(entrada);
                if (res != false)
                {
                    this.vista.pnl_nuevaEntradaInactiva.Visible = true;
                    this.vista.pnl_nuevaEntradaActiva.Visible = false;

                    this.vista.tb_busqueda2.Text = "";
                    this.vista.tb_codigo.Text = "";
                    this.vista.tb_noProveedor.Text = "";
                    this.vista.tb_noFactura.Text = "";
                    this.vista.tb_cantidad.Text = "";

                    Form mensajeExito = new frmExito("Se ha hecho la entrada con éxito.");
                    mensajeExito.ShowDialog();
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

        public void btn_nuevaEntrada_Click(object sender, EventArgs e)
        {
            this.vista.pnl_nuevaEntradaActiva.Visible = true;
            this.vista.pnl_nuevaEntradaInactiva.Visible = false;

        }

        //////////////////////////////////////////
        ///Métodos auxiliares
        ///
        protected bool calcularImporte()
        {
            String _cantidad = this.vista.tb_cantidad.Text;
            int cantidad;
            if (!String.IsNullOrEmpty(_cantidad) && Int32.TryParse(_cantidad, out cantidad) && this.prodcutoParaEntrada != null)
            {
                this.vista.lbl_total.Text = "$" + (cantidad * this.prodcutoParaEntrada.Precio_compra);
            }
            return false;
        }
    }
}
