using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary> Clase para transportar datos sobre Entradas al almacén. </summary>
    public class EntradaAlmacen
    {
        /// <summary> The identifier entrada </summary>
        private int id_entrada;

        /// <summary> The codigo barra </summary>
        private long codigo_barra;

        /// <summary> The fecha </summary>
        private DateTime fecha; //Formato para fechas en SQL Server yyyy-mm-dd hh:mm:ss

        /// <summary> The cantidad </summary>
        private double cantidad;

        /// <summary> The importe </summary>
        private double importe;

        /// <summary> The identifier proveedor </summary>
        private int id_proveedor;

        /// <summary> The producto </summary>
        private Producto producto;

        /// <summary> Initializes a new instance of the <see cref="EntradaAlmacen"/> class. </summary>
        public EntradaAlmacen()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EntradaAlmacen"/> class. </summary>
        /// <param name="id_entrada">The identifier entrada.</param>
        /// <param name="codigo_barra">The codigo barra.</param>
        /// <param name="fecha">The fecha.</param>
        /// <param name="cantidad">The cantidad.</param>
        /// <param name="importe">The importe.</param>
        /// <param name="proveedor">The proveedor.</param>
        public EntradaAlmacen(int id_entrada, long codigo_barra, DateTime fecha, double cantidad, double importe, int proveedor)
        {
            this.id_entrada = id_entrada;
            this.codigo_barra = codigo_barra;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.importe = importe;
            this.Id_proveedor = proveedor;
        }

        /// <summary> Gets or sets the identifier entrada. </summary>
        /// <value> The identifier entrada. </value>
        public int Id_entrada { get => this.id_entrada; set => this.id_entrada = value; }
        /// <summary> Gets or sets the codigo barra. </summary>
        /// <value> The codigo barra. </value>
        public long Codigo_barra { get => this.codigo_barra; set => this.codigo_barra = value; }
        /// <summary> Gets or sets the fecha. </summary>
        /// <value> The fecha. </value>
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        /// <summary> Gets or sets the cantidad. </summary>
        /// <value> The cantidad. </value>
        public double Cantidad { get => this.cantidad; set => this.cantidad = value; }
        /// <summary> Gets or sets the importe. </summary>
        /// <value> The importe. </value>
        public double Importe { get => this.importe; set => this.importe = value; }
        /// <summary> Gets or sets the identifier proveedor. </summary>
        /// <value> The identifier proveedor. </value>
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        /// <summary> Gets or sets the producto. </summary>
        /// <value> The producto. </value>
        public Producto Producto { get => producto; set => producto = value; }
    }
}
