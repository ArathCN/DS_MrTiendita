using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using System.Windows.Forms;

namespace MrTiendita.Controladores
{
    public class frmProductoController
    {
        private frmProducto vista;
        private ProductoDAO productoDAO;
        private String accion;
        private long id;
        private Producto producto;
        public frmProductoController(frmProducto vista, String accion, long id)
        {
            this.vista = vista;
            this.accion = accion;
            this.id = id;
            this.productoDAO = new ProductoDAO();
            this.vista.btn_guardarProducto.Click += new EventHandler(btn_Cerrar_Click);
            this.vista.Load += new EventHandler(vista_Load);
        }

        private void vista_Load(object sender, EventArgs e)
        {
            if (this.accion == "editar")
            {
                Producto producto =  this.productoDAO.readById(this.id);

                this.vista.tb_codigo.Text = producto.Codigo_barra.ToString();
                this.vista.tb_descripcion.Text = producto.Descripcion;
                this.vista.tb_cantidad.Text = producto.Cantidad_actual.ToString();
                this.vista.tb_precioVenta.Text = producto.Precio_venta.ToString();
                this.vista.tb_precioCompra.Text = producto.Precio_compra.ToString();
                if (producto.Medida) this.vista.chbx_medida.Checked = true;

                this.producto = producto;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool res = false;
            //Comprobar campos vacios...
            String _codigoBarra = this.vista.tb_codigo.Text;
            String _cantidad = this.vista.tb_cantidad.Text;
            String _descripcion = this.vista.tb_descripcion.Text;
            String _precioVenta = this.vista.tb_precioVenta.Text;
            String _precioCompra = this.vista.tb_precioCompra.Text;

            long codigoBarra;
            double cantidad, precioVenta, precioCompra;

            if (
                !ValidacionDatos.Numero(_codigoBarra, out codigoBarra, new Dictionary<int, long>() { {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 13} })||
                !ValidacionDatos.Numero(_cantidad, out cantidad, new Dictionary<int, double>() { {ValidacionDatosOpciones.MAYOR_A, 0}, {ValidacionDatosOpciones.MENOR_IGUAL_A, 100} })||
                !ValidacionDatos.Cadena(_descripcion, new Dictionary<int, int>() { {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 10} })||
                !ValidacionDatos.Numero(_precioVenta, out precioVenta, new Dictionary<int, double>() { {ValidacionDatosOpciones.MAYOR_A, 0} })||
                !ValidacionDatos.Numero(_precioCompra, out precioCompra, new Dictionary<int, double>() { {ValidacionDatosOpciones.MAYOR_A, 0 } })
                )
            {
                Form mensajeError = new frmError(ValidacionDatos.mensajes);
                mensajeError.ShowDialog();
                return;
            }

            //comprobar el checkbox
            bool medida = this.vista.chbx_medida.Checked;

            //compribar si la cantidad y la medida coinciden
            var parteDecimal = cantidad - Math.Truncate(cantidad);
            if (!medida && parteDecimal != 0)
            {
                Form mensajeError = new frmError("La cantidad no puede ser decimal si la medida no es a granel.");
                mensajeError.ShowDialog();
                return;
            }

            //Si se agregará un producto o altualizará el codigo de barras comprobar que éste no exista en la BD
            if (this.id != codigoBarra && this.productoDAO.readById(codigoBarra) != null)
            {
                Form mensajeError = new frmError("El codigo de barras ya está en uso");
                mensajeError.ShowDialog();
                return;
            }

            //Obtener el producto de los campos...
            Producto producto = new Producto(codigoBarra, _descripcion, precioVenta, precioCompra, cantidad, medida);

            //Hacer la acción 
            if (this.accion == "agregar")
            {
                res = this.agregar(producto);
            }
            else
            {
                res = this.actualizar(producto);
            }

            if(res) this.vista.Close();
        }

        ///////////
        ///Metodos auxiliares
        ///

        private bool agregar(Producto producto)
        {
            bool res = this.productoDAO.create(producto);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha hecho el producto con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }

        private bool actualizar(Producto producto)
        {
            bool res = this.productoDAO.updateInfo(producto, this.id);
            if (res)
            {
                Form mensajeExito = new frmExito("Se ha actualizado el producto con éxito.");
                mensajeExito.ShowDialog();
            }
            else
            {
                Form mensajeError = new frmError("Ha ocurrido un error.");
                mensajeError.ShowDialog();
            }

            return res;
        }
    }
}
