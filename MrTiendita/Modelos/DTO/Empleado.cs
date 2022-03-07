using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary>
    /// Clase para transportar datos sobre un empleado.
    /// </summary>
    public class Empleado
    {
        /// <summary>
        /// The identifier empleado
        /// </summary>
        private int id_empleado;

        /// <summary>
        /// The nombre
        /// </summary>
        private String nombre;

        /// <summary>
        /// The apellido paterno
        /// </summary>
        private String a_paterno;

        /// <summary>
        /// The apellido materno
        /// </summary>
        private String a_materno;

        /// <summary>
        /// The telefono
        /// </summary>
        private long telefono;

        /// <summary>
        /// The sueldo
        /// </summary>
        private double sueldo;

        /// <summary>
        /// The tipo empleado
        /// </summary>
        private String tipo_empleado;

        /// <summary>
        /// The clave
        /// </summary>
        private String clave;

        /// <summary>
        /// The usuario
        /// </summary>
        private String usuario;


        /// <summary>
        /// Initializes a new instance of the <see cref="Empleado"/> class.
        /// </summary>
        public Empleado()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Empleado"/> class.
        /// </summary>
        /// <param name="id_empleado">The identifier empleado.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="a_paterno">The apellido paterno.</param>
        /// <param name="a_materno">The apellido materno.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="sueldo">The sueldo.</param>
        /// <param name="tipo_empleado">The tipo empleado.</param>
        /// <param name="clave">The clave.</param>
        /// <param name="usuario">The usuario.</param>
        public Empleado(int id_empleado, string nombre, string a_paterno, string a_materno, long telefono, double sueldo, string tipo_empleado, string clave, string usuario)
        {
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.a_paterno = a_paterno;
            this.a_materno = a_materno;
            this.telefono = telefono;
            this.sueldo = sueldo;
            this.tipo_empleado = tipo_empleado;
            this.clave = clave;
            this.usuario = usuario;
        }

        /// <summary>
        /// Gets or sets the identifier empleado.
        /// </summary>
        /// <value>
        /// The identifier empleado.
        /// </value>
        public int Id_empleado { get => this.id_empleado; set => this.id_empleado = value; }

        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get => this.nombre; set => this.nombre = value; }

        /// <summary>
        /// Gets or sets apellido paterno.
        /// </summary>
        /// <value>
        /// a paterno.
        /// </value>
        public string A_paterno { get => this.a_paterno; set => this.a_paterno = value; }

        /// <summary>
        /// Gets or sets apellido materno.
        /// </summary>
        /// <value>
        /// a materno.
        /// </value>
        public string A_materno { get => this.a_materno; set => this.a_materno = value; }

        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>
        /// The telefono.
        /// </value>
        public long Telefono { get => this.telefono; set => this.telefono = value; }

        /// <summary>
        /// Gets or sets the sueldo.
        /// </summary>
        /// <value>
        /// The sueldo.
        /// </value>
        public double Sueldo { get => this.sueldo; set => this.sueldo = value; }

        /// <summary>
        /// Gets or sets the tipo empleado.
        /// </summary>
        /// <value>
        /// The tipo empleado.
        /// </value>
        public string Tipo_empleado { get => this.tipo_empleado; set => this.tipo_empleado = value; }

        /// <summary>
        /// Gets or sets the clave.
        /// </summary>
        /// <value>
        /// The clave.
        /// </value>
        public string Clave { get => this.clave; set => this.clave = value; }

        /// <summary>
        /// Gets or sets the usuario.
        /// </summary>
        /// <value>
        /// The usuario.
        /// </value>
        public string Usuario { get => this.usuario; set => this.usuario = value; }

    }
}
