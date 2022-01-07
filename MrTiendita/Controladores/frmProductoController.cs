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
using Acciones;

namespace MrTiendita.Controladores
{
    public class frmProductoController
    {
        private frmProducto vista;
        private ProductoDAO productoDAO;
        private String accion;
        private long id;
        private Producto producto;
        private Productos_Facade facade = new Productos_Facade();

        public frmProductoController(frmProducto vista, String accion, long id)
        {
            this.vista = vista;
            this.accion = accion;
            this.id = id;
            this.productoDAO = new ProductoDAO();
            this.vista.btn_guardarProducto.Click += new EventHandler(btn_Cerrar_Click);
            this.vista.Load += new EventHandler(vista_Load);

            this.vista.tb_codigo.TextChanged += delegate (object sender, EventArgs e)
            {
                long dato2;
                String mensajeError = "Debe ser un número de 13 dígitos.";
                Dictionary<int, long> opciones2 = new Dictionary<int, long>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.NUM_CARACTERES, 13}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, mensajeError, this.vista.tb_codigo.Text, out dato2, opciones2);
            };

            this.vista.tb_cantidad.TextChanged += delegate (object sender, EventArgs e)
            {
                double dato2;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidad, mensajeError, this.vista.tb_cantidad.Text, out dato2, opciones2);
            };

            this.vista.tb_descripcion.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 120 caracteres.";
                Dictionary<int, int> opciones2 = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 120}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, mensajeError, this.vista.tb_descripcion.Text, opciones2);
            };

            this.vista.tb_precioCompra.TextChanged += delegate (object sender, EventArgs e)
            {
                double dato2;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorPc, mensajeError, this.vista.tb_precioCompra.Text, out dato2, opciones2);
            };

            this.vista.tb_precioVenta.TextChanged += delegate (object sender, EventArgs e)
            {
                double dato2;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorPv, mensajeError, this.vista.tb_precioVenta.Text, out dato2, opciones2);
            };


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

            String mensajeCodigo = "Debe ser un número de 13 dígitos.";
            Dictionary<int, long> opCodigo = new Dictionary<int, long>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.NUM_CARACTERES, 13}
            };
            String msgCantidad = "De ser un número entre 0 y 10000 con máximo dos decimales.";
            Dictionary<int, double> opCantidad = new Dictionary<int, double>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            String msgDesc = "Texto de entre 5 a 120 caracteres.";
            Dictionary<int, int> opDesc = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 120}
            };
            String msgPc = "De ser un número entre 0 y 10000 con máximo dos decimales.";
            Dictionary<int, double> opPc = new Dictionary<int, double>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };

            if (
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, mensajeCodigo, _codigoBarra, out codigoBarra, opCodigo) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidad, msgCantidad, _cantidad, out cantidad, opCantidad) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, msgDesc, _descripcion, opDesc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorPc, msgPc, _precioCompra, out precioCompra, opPc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorPv, msgPc, _precioVenta, out precioVenta, opPc)
                )
            {
                Form mensajeError = new frmError("Llene todos los datos correctamente.");
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
                res = facade.Agregar(producto);
            }
            else
            {
                res = facade.Modificar(producto, this.id);
            }

            if(res) this.vista.Close();
        }
    }
}
