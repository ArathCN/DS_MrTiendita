using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary>
    /// Clase para transportar datos sobre un proveedor.
    /// </summary>
    public class Proveedor
    {
        /// <summary>
        /// The identifier proveedor
        /// </summary>
        private int id_proveedor;
        /// <summary>
        /// The nombre
        /// </summary>
        private String nombre;
        /// <summary>
        /// The telefono
        /// </summary>
        private long telefono;
        /// <summary>
        /// The estado
        /// </summary>
        //private String estado;

        /// <summary>
        /// Initializes a new instance of the <see cref="Proveedor"/> class.
        /// </summary>
        public Proveedor()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proveedor"/> class.
        /// </summary>
        /// <param name="id_proveedor">The identifier proveedor.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="estado">The nombre.</param>

        public Proveedor(int id_proveedor, string nombre, long telefono)
        {
            this.id_proveedor = id_proveedor;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        /// <summary>
        /// Gets or sets the identifier proveedor.
        /// </summary>
        /// <value>
        /// The identifier proveedor.
        /// </value>
        public int Id_proveedor { get => this.id_proveedor; set => this.id_proveedor = value; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telefono.
        /// </value>
        public long Telefono { get => this.telefono; set => this.telefono = value; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        //public string Estado { get => this.estado; set => this.estado = value; }
    }
}