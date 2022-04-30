using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DAO
{
    /// <summary>
    /// Clase que heredan las demás clases DAO, define la  cadena de conexión con la base de datos, propiedades y métodos para los errores en las consultas.
    /// </summary>
    public class DbContext
    {

        /// <summary>
        /// La cadena de conexión con la base de datos.
        /// </summary>
        //protected String stringConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=MrTiendita;Integrated Security=True";
        protected String stringConexion = "Data Source=LAPTOP-3SLQTV7O;Initial Catalog=MRTIENDITA;Integrated Security=True";
        //protected String stringConexion = "Data Source=HP-PAVILION-R5;Initial Catalog=MrTiendita;Integrated Security=True";

        /// <summary>
        /// Boleano que nos avisa si hubo o no un error en la última consulta realizada.
        /// </summary>
        protected bool errorUltimaConsulta;

        /// <summary>
        /// Cadena que contiene el mensaje de error de la última consulta realizada.
        /// </summary>
        protected String mensajeError;

        /// <summary>
        /// Obtiene o asigna un valor a <see cref="errorUltimaConsulta"/>
        /// </summary>
        /// <value>
        ///   <c>true</c> o <c>false</c>.
        /// </value>
        public bool ErrorUltimaConsulta { get => errorUltimaConsulta; set => errorUltimaConsulta = value; }
        
        /// <summary>
        /// Obtiene o asigna un valor a <see cref="mensajeError"/>.
        /// </summary>
        /// <value>
        /// El mensaje de error de la última consulta realizada.
        /// </value>
        public string MensajeError { get => mensajeError; set => mensajeError = value; }

        /// <summary>
        /// Limpiar el último error de las propiedades.
        /// </summary>
        public void LimpiarError()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = "";
        }

    }
}
