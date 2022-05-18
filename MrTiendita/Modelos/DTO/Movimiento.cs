using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary> Clase para transportar datos sobre un movimiento. </summary>
    class Movimiento
    {
        /// <summary> The identifier movimiento </summary>
        private int id_movimiento;
        /// <summary> The tipo </summary>
        private String tipo;
        /// <summary> The fecha </summary>
        private DateTime fecha;
        /// <summary> The importe </summary>
        private double importe;
        /// <summary> The caja </summary>
        private double caja;
        /// <summary> The concepto </summary>
        private String concepto;

        /// <summary> Initializes a new instance of the <see cref="Movimiento"/> class. </summary>
        public Movimiento()
        {

        }

        /// <summary> Initializes a new instance of the <see cref="Movimiento"/> class. </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="tipo">The tipo.</param>
        /// <param name="fecha">The fecha.</param>
        /// <param name="importe">The importe.</param>
        /// <param name="caja">The caja.</param>
        /// <param name="concepto">The concepto.</param>
        public Movimiento(int id, String tipo, DateTime fecha, double importe, double caja, String concepto)
        {
            this.id_movimiento = id;
            this.tipo = tipo;
            this.fecha = fecha;
            this.importe = importe;
            this.caja = caja;
            this.Concepto = concepto;
        }

        /// <summary> Gets or sets the identifier movimiento. </summary>
        /// <value> The identifier movimiento. </value>
        public int Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        /// <summary> Gets or sets the tipo.</summary>
        /// <value>The tipo.</value>
        public string Tipo { get => tipo; set => tipo = value; }
        /// <summary> Gets or sets the fecha.</summary>
        /// <value> The fecha. </value>
        public DateTime Fecha { get => fecha; set => fecha = value; }
        /// <summary> Gets or sets the importe. </summary>
        /// <value> The importe. </value>
        public double Importe { get => importe; set => importe = value; }
        /// <summary> Gets or sets the caja. </summary>
        /// <value> The caja. </value>
        public double Caja { get => caja; set => caja = value; }
        /// <summary> Gets or sets the concepto. </summary>
        /// <value> The concepto. </value>
        public string Concepto { get => concepto; set => concepto = value; }
    }
}
