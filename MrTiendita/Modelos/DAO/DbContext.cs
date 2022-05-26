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

        /// <summary> La cadena de conexión con la base de datos. </summary>
        protected String stringConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=MrTiendita;Integrated Security=True";
        //protected String stringConexion = "Data Source=" + Environment.MachineName + ";Initial Catalog=MrTiendita;Integrated Security=True";

        /// <summary> The formato datetime </summary>
        protected String formatoDatetime = "yyyy-MM-dd HH:mm:ss";

        /// <summary> Boleano que nos avisa si hubo o no un error en la última consulta realizada. </summary>
        protected bool errorUltimaConsulta;

        /// <summary> Cadena que contiene el mensaje de error de la última consulta realizada. </summary>
        protected String mensajeError;

        /// <summary> Obtiene o asigna un valor a <see cref="errorUltimaConsulta"/> </summary>
        /// <value>
        ///   <c>true</c> o <c>false</c>.
        /// </value>
        public bool ErrorUltimaConsulta { get => errorUltimaConsulta; set => errorUltimaConsulta = value; }
        
        /// <summary> Obtiene o asigna un valor a <see cref="mensajeError"/>. </summary>
        /// <value>
        /// El mensaje de error de la última consulta realizada.
        /// </value>
        public string MensajeError { get => mensajeError; set => mensajeError = value; }

        /// <summary> Limpiar el último error de las propiedades. </summary>
        public void LimpiarError()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = "";
        }
    }

    /// <summary> Clase para actualizar los renglones no afectados. </summary>
    /// <seealso cref="System.Exception" />
    public class SqlUpdateNoAffectedRows : Exception
    {
        /// <summary> Initializes a new instance of the <see cref="SqlUpdateNoAffectedRows"/> class. </summary>
        public SqlUpdateNoAffectedRows() : base() { }
        /// <summary> Initializes a new instance of the <see cref="SqlUpdateNoAffectedRows"/> class. </summary>
        /// <param name="message">Mensaje que describe el error.</param>
        public SqlUpdateNoAffectedRows(string message) : base(message) { }
        /// <summary> Initializes a new instance of the <see cref="SqlUpdateNoAffectedRows"/> class. </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public SqlUpdateNoAffectedRows(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        /// <summary> Initializes a new instance of the <see cref="SqlUpdateNoAffectedRows"/> class. </summary>
        /// <param name="info"><see cref="T:System.Runtime.Serialization.SerializationInfo" /> que contiene los datos serializados del objeto que hacen referencia a la excepción que se va a producir.</param>
        /// <param name="context"><see cref="T:System.Runtime.Serialization.StreamingContext" /> que contiene información contextual sobre el origen o el destino.</param>
        protected SqlUpdateNoAffectedRows(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
