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
    public class FrmProductoController
    {
        private readonly FrmProducto vista;
        private readonly ProductoDAO productoDAO;
        private readonly String accion;
        private readonly long id;
        private Producto producto;
        private readonly Productos_Facade Productos = new Productos_Facade();

        public FrmProductoController(FrmProducto vista, String accion, long id)
        {
            this.vista = vista;
            this.accion = accion;
            this.id = id;
            this.productoDAO = new ProductoDAO();
            this.vista.btn_guardarProducto.Click += new EventHandler(Btn_Cerrar_Click);
            this.vista.Load += new EventHandler(Vista_Load);

            this.vista.tb_codigo.TextChanged += delegate (object sender, EventArgs e)
            {
                long codigo;
                String mensajeError = "Debe ser un número de 13 dígitos.";
                Dictionary<int, long> opciones2 = new Dictionary<int, long>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.NUM_CARACTERES, 13}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, mensajeError, this.vista.tb_codigo.Text, out codigo, opciones2);
            };

            this.vista.tb_cantidad.TextChanged += delegate (object sender, EventArgs e)
            {
                double cantidad;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidad, mensajeError, this.vista.tb_cantidad.Text, out cantidad, opciones2);
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
                double precioCompra;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorPc, mensajeError, this.vista.tb_precioCompra.Text, out precioCompra, opciones2);
            };

            this.vista.tb_precioVenta.TextChanged += delegate (object sender, EventArgs e)
            {
                double precioVenta;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorPv, mensajeError, this.vista.tb_precioVenta.Text, out precioVenta, opciones2);
            };


        }

        private void Vista_Load(object sender, EventArgs e)
        {
            if (this.accion == "editar")
            {
                Producto producto =  this.productoDAO.ReadById(this.id);

                this.vista.tb_codigo.Text = producto.Codigo_barra.ToString();
                this.vista.tb_descripcion.Text = producto.Descripcion;
                this.vista.tb_cantidad.Text = producto.Cantidad_actual.ToString();
                this.vista.tb_precioVenta.Text = producto.Precio_venta.ToString();
                this.vista.tb_precioCompra.Text = producto.Precio_compra.ToString();
                if (producto.Medida) this.vista.chbx_medida.Checked = true;

                this.producto = producto;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            bool IsCompleted;
            //Comprobar campos vacios...
            String codigoBarraCad = this.vista.tb_codigo.Text;
            String cantidadCad = this.vista.tb_cantidad.Text;
            String descripcionCad = this.vista.tb_descripcion.Text;
            String precioVentaCad = this.vista.tb_precioVenta.Text;
            String precioCompraCad = this.vista.tb_precioCompra.Text;

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
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, mensajeCodigo, codigoBarraCad, out codigoBarra, opCodigo) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidad, msgCantidad, cantidadCad, out cantidad, opCantidad) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, msgDesc, descripcionCad, opDesc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorPc, msgPc, precioCompraCad, out precioCompra, opPc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorPv, msgPc, precioVentaCad, out precioVenta, opPc)
                )
            {
                Form mensajeError = new FrmError("Llene todos los datos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar el checkbox
            bool medida = this.vista.chbx_medida.Checked;

            //compribar si la cantidad y la medida coinciden
            var parteDecimal = cantidad - Math.Truncate(cantidad);
            if (!medida && parteDecimal != 0)
            {
                Form mensajeError = new FrmError("La cantidad no puede ser decimal si la medida no es a granel.");
                mensajeError.ShowDialog();
                return;
            }

            //Si se agregará un producto o altualizará el codigo de barras comprobar que éste no exista en la BD
            if (this.id != codigoBarra && this.productoDAO.ReadById(codigoBarra) != null) //aqui
            {
                Form mensajeError = new FrmError("El codigo de barras ya está en uso");
                mensajeError.ShowDialog();
                return;
            }

            //Obtener el producto de los campos...
            Producto producto = new Producto(codigoBarra, descripcionCad, precioVenta, precioCompra, cantidad, medida);

            //Hacer la acción 
            if (this.accion == "agregar")
                IsCompleted = Productos.Agregar(producto);
            else
                IsCompleted = Productos.Modificar(producto, this.id);

            if(IsCompleted) this.vista.Close();
        } 
    }
}
