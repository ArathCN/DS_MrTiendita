using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;

namespace Mr.Tiendita.Controladores
{
    public class PrincipalController
    {
        private frmPrincipal vista;
        private ProductoDAO productoDAO;
        private ProveedorDAO proveedorDAO;
        private EntradaAlmacenDAO entradaAlmacenDAO;

        public PrincipalController(frmPrincipal vista)
        {
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.proveedorDAO = new ProveedorDAO();
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.vista.btn_producto.Click += new EventHandler(btn_producto_click);
            this.vista.btn_verProductos.Click += new EventHandler(btn_verProductos_click);
            this.vista.btn_verProductosId.Click += new EventHandler(btn_verProductosId_click);
            this.vista.btn_eliminarProducto.Click += new EventHandler(btn_eliminarProducto_click);

            this.vista.btn_proveedor.Click += new EventHandler(btn_proveedor_click);
            this.vista.btn_verProveedores.Click += new EventHandler(btn_verProveedores_click);
            this.vista.btn_verProveedoresId.Click += new EventHandler(btn_verProveedoresId_click);
            this.vista.btn_eliminarProveedor.Click += new EventHandler(btn_eliminarProveedor_click);

            this.vista.btn_entrada.Click += new EventHandler(btn_entrada_click);
            this.vista.btn_verEntradas.Click += new EventHandler(btn_verEntradas_click);
            this.vista.btn_verEntradasId.Click += new EventHandler(btn_verEntradasId_click);
        }

        public void btn_producto_click (object sender, EventArgs e)
        {
            int tiempo = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var random = new Random();
            this.vista.btn_producto.Text = "A";
            this.productoDAO.create(new Producto(tiempo, "Producto prueba " + tiempo, "Producto de prueba descripcion.", 15.0f, 10.0f, random.Next(1, 30)));
        }

        public void btn_verProductos_click(object sender, EventArgs e)
        {
            List<Producto> productos = this.productoDAO.readAll();
            this.vista.dgv_datos.DataSource = productos;
        }

        public void btn_verProductosId_click(object sender, EventArgs e)
        {
            int id;
            String stringId = this.vista.tb_id.Text;
            if (Int32.TryParse(stringId, out id))
            {
                Producto producto = this.productoDAO.readById(id);
                this.vista.dgv_datos.DataSource = new List<Producto>() {producto};
            }
            else
            {
                String mensaje = "No se ha podido obtener un ID numerico, por favor ingrese de nuevo.";
                String titulo = "Error con ID";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
            }
        }

        public void btn_eliminarProducto_click(object sender, EventArgs e)
        {
            int id;
            String stringId = this.vista.tb_eliminar.Text;
            if (Int32.TryParse(stringId, out id))
            {
                bool res = this.productoDAO.delete(id);

                String mensaje = "Rsultado de la eliminación: " + res;
                String titulo = "Eliminar producto";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
            }
            else
            {
                String mensaje = "No se ha podido obtener un ID numerico, por favor ingrese de nuevo.";
                String titulo = "Error con ID";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
            }
        }

        public void btn_proveedor_click(object sender, EventArgs e)
        {
            int tiempo = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var random = new Random();
            this.vista.btn_proveedor.Text = "B";
            this.proveedorDAO.create(new Proveedor(-1, "Proveedor prueba " + tiempo, 6623596071, "Efectivo"));
        }

        public void btn_verProveedores_click(object sender, EventArgs e)
        {
            List<Proveedor> proveedores = this.proveedorDAO.readAll();
            this.vista.dgv_datos.DataSource = proveedores;
        }

        public void btn_verProveedoresId_click(object sender, EventArgs e)
        {
            int id;
            String stringId = this.vista.tb_id.Text;
            if (Int32.TryParse(stringId, out id))
            {
                Proveedor proveedor = this.proveedorDAO.readById(id);
                this.vista.dgv_datos.DataSource = new List<Proveedor>() { proveedor };
            }
            else
            {
                String mensaje = "No se ha podido obtener un ID numerico, por favor ingrese de nuevo.";
                String titulo = "Error con ID";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
            }
        }
        public void btn_eliminarProveedor_click(object sender, EventArgs e)
        {
            int id;
            String stringId = this.vista.tb_eliminar.Text;
            if (Int32.TryParse(stringId, out id))
            {
                bool res = this.proveedorDAO.delete(id);

                String mensaje = "Rsultado de la eliminación: " + res;
                String titulo = "Eliminar proveedor";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
            }
            else
            {
                String mensaje = "No se ha podido obtener un ID numerico, por favor ingrese de nuevo.";
                String titulo = "Error con ID";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK);
            }
        }

        public void btn_entrada_click(object sender, EventArgs e)
        {
            int tiempo = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var random = new Random();
            this.vista.btn_entrada.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.entradaAlmacenDAO.create(new EntradaAlmacen(-1, 5, 4, 1213, DateTime.Now, 12, 1231.12f));
            
        }

        public void btn_verEntradas_click(object sender, EventArgs e)
        {
            List<EntradaAlmacen> entradasAlmacen = this.entradaAlmacenDAO.readAll();
            this.vista.dgv_datos.DataSource = entradasAlmacen;
        }

        public void btn_verEntradasId_click(object sender, EventArgs e)
        {
            DateTime inicio = this.vista.dtp_inicio.Value.Date;
            DateTime fin = this.vista.dtp_fin.Value.Date;

            List<EntradaAlmacen> entradasAlmacen = this.entradaAlmacenDAO.readBetweenDates(inicio, fin);
            this.vista.dgv_datos.DataSource = entradasAlmacen;
            
        }
    }
}
