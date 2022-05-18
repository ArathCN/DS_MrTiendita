using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary> Clase para transportar datos sobre una venta. </summary>
    public class Venta
    {
        /// <summary> The identifier venta </summary>
        private int id_venta;
        /// <summary> The codigo barra </summary>
        private long codigo_barra;
        /// <summary> The identifier empleado </summary>
        private int id_empleado;
        /// <summary> The metodo pago </summary>
        private String metodo_pago;
        /// <summary> The fecha </summary>
        private DateTime fecha;
        /// <summary> The cantidad </summary>
        private double cantidad;
        /// <summary> The importe </summary>
        private double importe;
        /// <summary> The producto </summary>
        private Producto producto;

        /// <summary> Initializes a new instance of the <see cref="Venta"/> class. </summary>
        public Venta()
        {

        }

        /// <summary> Initializes a new instance of the <see cref="Venta"/> class. </summary>
        /// <param name="id_venta">The identifier venta.</param>
        /// <param name="codigo_barra">The codigo barra.</param>
        /// <param name="id_empleado">The identifier empleado.</param>
        /// <param name="metodo_pago">The metodo pago.</param>
        /// <param name="fecha">The fecha.</param>
        /// <param name="cantidad">The cantidad.</param>
        /// <param name="importe">The importe.</param>
        public Venta(int id_venta, long codigo_barra, int id_empleado, string metodo_pago, DateTime fecha, double cantidad, double importe)
        {
            this.id_venta = id_venta;
            this.codigo_barra = codigo_barra;
            this.id_empleado = id_empleado;
            this.metodo_pago = metodo_pago;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.importe = importe;
        }

        /// <summary> Initializes a new instance of the <see cref="Venta"/> class. </summary>
        /// <param name="fecha">The fecha.</param>
        /// <param name="cantidad">The cantidad.</param>
        public Venta(DateTime fecha, double cantidad)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
        }

        /// <summary> Gets or sets the identifier venta. </summary>
        /// <value> The identifier venta.</value>
        public int Id_venta { get => this.id_venta; set => this.id_venta = value; }
        /// <summary> Gets or sets the codigo barra. </summary>
        /// <value> The codigo barra. </value>
        public long Codigo_barra { get => this.codigo_barra; set => this.codigo_barra = value; }
        /// <summary> Gets or sets the identifier empleado. </summary>
        /// <value> The identifier empleado. </value>
        public int Id_empleado { get => this.id_empleado; set => this.id_empleado = value; }
        /// <summary> Gets or sets the metodo pago. </summary>
        /// <value> The metodo pago. </value>
        public string Metodo_pago { get => this.metodo_pago; set => this.metodo_pago = value; }
        /// <summary> Gets or sets the fecha. </summary>
        /// <value> The fecha. </value>
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        /// <summary> Gets or sets the cantidad. </summary>
        /// <value> The cantidad. </value>
        public double Cantidad { get => this.cantidad; set => this.cantidad = value; }
        /// <summary> Gets or sets the importe. </summary>
        /// <value> The importe. </value>
        public double Importe { get => this.importe; set => this.importe = value; }
        /// <summary>Gets or sets the producto. </summary>
        /// <value> The producto. </value>
        public Producto Producto { get => producto; set => producto = value; }
    }
}
