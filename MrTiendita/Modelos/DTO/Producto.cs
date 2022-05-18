using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary> Clase para transportar datos sobre un producto. </summary>
    public class Producto
    {
        /// <summary> The codigo barra </summary>
        private long codigo_barra;
        /// <summary> The descripcion </summary>
        private String descripcion;
        /// <summary>The precio venta </summary>
        private int ganancia;
        /// <summary> The precio compra </summary>
        private double precio_compra;
        /// <summary>The cantidad actual </summary>
        private double cantidad_actual;
        /// <summary> The medida </summary>
        private bool medida; //false es medida por unidad, true por kilos
        /// <summary> The categoria </summary>
        private String categoria;
        private double minimo;
        private double precio_venta;

        /// <summary> Initializes a new instance of the <see cref="Producto"/> class. </summary>
        public Producto()
        {

        }
        /// <summary> Initializes a new instance of the <see cref="Producto"/> class. </summary>
        /// <param name="codigo_barra">The codigo barra.</param>
        /// <param name="descripcion">The descripcion.</param>
        /// <param name="ganancia">The precio venta.</param>
        /// <param name="precio_compra">The precio compra.</param>
        /// <param name="cantidad_actual">The cantidad actual.</param>
        /// <param name="medida">if set to <c>true</c> [medida].</param>
        /// <param name="categoria">The categoria.</param>
        /// <param name="minimo">The minimo del producto.</param>
        public Producto(long codigo_barra, string descripcion, int ganancia, double precio_compra, double cantidad_actual, bool medida, String categoria, double minimo)
        {
            this.codigo_barra = codigo_barra;
            this.descripcion = descripcion;
            this.ganancia = ganancia;
            this.precio_compra = precio_compra;
            this.cantidad_actual = cantidad_actual;
            this.medida = medida;
            this.categoria = categoria;
            this.minimo = minimo;
            this.precio_venta = this.CalcularPrecioVenta();
        }

        /// <summary> Initializes a new instance of the <see cref="Producto"/> class. </summary>
        /// <param name="codigo_barra">The codigo barra.</param>
        /// <param name="descripcion">The descripcion.</param>
        /// <param name="precio_compra">The precio compra.</param>
        public Producto(long codigo_barra, string descripcion, double precio_compra)
        {
            this.codigo_barra = codigo_barra;
            this.descripcion = descripcion;
        }

        /// <summary> Gets or sets the codigo barra. </summary>
        /// <value> The codigo barra.</value>
        public long Codigo_barra
        {
            get { return this.codigo_barra; }
            set { this.codigo_barra = value; }
        }

        /// <summary> Gets or sets the descripcion. </summary>
        /// <value> The descripcion. </value>
        public String Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        /// <summary> Gets or sets the precio venta. </summary>
        /// <value> The precio venta. </value>
        public int Ganancia
        {
            get { return this.ganancia; }
            set { this.ganancia = value; }
        }
        /// <summary> Gets or sets the cantidad actual. </summary>
        /// <value> The cantidad actual. </value>
        public double Cantidad_actual
        {
            get { return this.cantidad_actual; }
            set { this.cantidad_actual = value; }
        }

        /// <summary> Gets or sets the precio compra. </summary>
        /// <value> The precio compra. </value>
        public double Precio_compra { get => this.precio_compra; set => this.precio_compra = value; }

        /// <summary> Gets or sets a value indicating whether this <see cref="Producto"/> is medida. </summary>
        /// <value>   <c>true</c> if medida; otherwise, <c>false</c>. </value>
        public bool Medida { get => this.medida; set => this.medida = value; }

        /// <summary> Gets or sets the categoria. </summary>
        /// <value>The categoria. </value>
        public String Categoria { get => this.categoria; set => this.categoria = value; }

        /// <summary> Gets or sets the minimo. </summary>
        /// <value> The minimo. </value>
        public double Minimo { get => this.minimo; set => this.minimo = value; }

        /// <summary> Gets or sets the precio venta. </summary>
        /// <value> The precio venta. </value>
        public double Precio_venta { get => this.precio_venta; set => this.precio_venta = value; }

        private double CalcularPrecioVenta()
        {
            return Producto.PresupuestarPrecioVenta(this.precio_compra, this.ganancia);
        }

        /// <summary> Presupuestars the precio venta. </summary>
        /// <param name="precioCompra">The precio compra.</param>
        /// <param name="ganancia">The ganancia.</param>
        /// <returns>El calculo para presupuestar el precio de venta. </returns>
        static public double PresupuestarPrecioVenta(double precioCompra, int ganancia)
        {
            return Math.Round(((ganancia * precioCompra) / 100) + precioCompra, 2);
        }
    }
}
