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
using MrTiendita.Patrones;

namespace MrTiendita.Controladores
{
    public class FrmProductoController
    {
        private readonly FrmInventario vista;
        private readonly ProductoDAO productoDAO;
        private readonly String accion;
        private readonly long id;
        private readonly Productos_Facade Productos = new Productos_Facade();

        public FrmProductoController(FrmInventario vista, string accion)
        {
            this.vista = vista;
            this.accion = accion;
            this.id = id;
            this.productoDAO = new ProductoDAO();
            this.vista.btn_AgregarProducto.Click += new EventHandler(Btn_AgregarProducto_Click);

            this.vista.tb_CodigoBarras.TextChanged += delegate (object sender, EventArgs e)
            {
                long codigo;
                String mensajeError = "Debe ser un número de 13 dígitos.";
                Dictionary<int, long> opciones2 = new Dictionary<int, long>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.NUM_CARACTERES, 13}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCodigo, mensajeError, this.vista.tb_CodigoBarras.Text, out codigo, opciones2);
            };

            this.vista.tb_CantidadCrear.TextChanged += delegate (object sender, EventArgs e)
            {
                double cantidad;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidad, mensajeError, this.vista.tb_CantidadCrear.Text, out cantidad, opciones2);
            };

            this.vista.tb_Descripcion.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Texto de entre 5 a 120 caracteres.";
                Dictionary<int, int> opciones2 = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 120}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorDescripcion, mensajeError, this.vista.tb_Descripcion.Text, opciones2);
            };

            this.vista.tb_PrecioCompra.TextChanged += delegate (object sender, EventArgs e)
            {
                double precioCompra;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorPrecioCompra, mensajeError, this.vista.tb_PrecioCompra.Text, out precioCompra, opciones2);
            };

            this.vista.tb_PrecioVenta.TextChanged += delegate (object sender, EventArgs e)
            {
                double precioVenta;
                String mensajeError = "De ser un número entre 0 y 10000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>() {
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorPrecioVenta, mensajeError, this.vista.tb_PrecioVenta.Text, out precioVenta, opciones2);
            };


        }


        /// <summary>
        /// Handles the Click event of the Btn_Cerrar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            bool IsCompleted;
            //Comprobar campos vacios...
            String codigoBarraCad = this.vista.tb_CodigoBarras.Text;
            String descripcionCad = this.vista.tb_Descripcion.Text;
            String cantidadCad = this.vista.tb_CantidadCrear.Text;
            String precioCompraCad = this.vista.tb_PrecioCompra.Text;
            ///
            /// 
            /// 
            ///Extraer los valores del formulario y cambiar las etiquetas en las validaciones.
            String categoriaCad = this.vista.cb_Categoria.SelectedItem.ToString();
            String minimoCad = this.vista.tb_Minima.Text;
            String gananciaCad = this.vista.cb_GananciaPorcentaje.SelectedItem.ToString().TrimEnd('%');
            int ganancia = 0;
            ///
            ///
            ///
            ///
            ///

            long codigoBarra;
            double cantidad, precioCompra, minimo;

            String mensajeCodigo = "Debe ser un número de 13 dígitos.";
            Dictionary<int, long> opCodigo = new Dictionary<int, long>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.NUM_CARACTERES, 13}
            };
            String msgCantidad = "Debe ser un número mayor a 0 con máximo dos decimales.";
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
            String msgCategoria = "Debe escoger una categoría.";
            Dictionary<int, int> opCategoria = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
            };
            String msgPc = "Debe ser un número mayor a 0 con máximo dos decimales.";
            Dictionary<int, double> opPc = new Dictionary<int, double>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            String msgGanancia = "Debe escoger un valor.";
            Dictionary<int, int> opGanancia = new Dictionary<int, int>() {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };

            if (
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCodigo, mensajeCodigo, codigoBarraCad, out codigoBarra, opCodigo) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidad, msgCantidad, cantidadCad, out cantidad, opCantidad) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDescripcion, msgDesc, descripcionCad, opDesc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorPrecioCompra, msgPc, precioCompraCad, out precioCompra, opPc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorGanancia, msgGanancia, gananciaCad, out ganancia, opGanancia) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCantidadCrear, msgCantidad, minimoCad, out minimo, opCantidad) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorCategoria, msgCategoria, categoriaCad, opCategoria)
                )
            {
                Form mensajeError = new FrmError("Llene todos los datos correctamente.");
                mensajeError.ShowDialog();
                return;
            }

            //comprobar el checkbox
            bool medida = this.vista.cb_TipoMedida.Checked;

            //compribar si la cantidad y la medida coinciden
            var parteDecimal = cantidad - Math.Truncate(cantidad);
            if (!medida && parteDecimal != 0)
            {
                Form mensajeError = new FrmError("La cantidad no puede ser decimal si la medida no es a granel.");
                mensajeError.ShowDialog();
                return;
            }

            //Si se agregará un producto o altualizará el codigo de barras comprobar que éste no exista en la BD
            if (this.id != codigoBarra && this.productoDAO.ReadById(codigoBarra) != null && this.accion != "editar") //aqui
            {
                Form mensajeError = new FrmError("El codigo de barras ya está en uso");
                mensajeError.ShowDialog();
                return;
            }

            //Obtener el producto de los campos...
            Producto producto = new Producto(codigoBarra, descripcionCad, ganancia, precioCompra, cantidad, medida, categoriaCad, minimo);

            //Hacer la acción 
            if (this.accion == "editar")
                IsCompleted = Productos.Modificar(producto, this.id);
            else
                IsCompleted = Productos.Agregar(producto);

            //if (IsCompleted) this.vista.Close();
        }
    }
}
