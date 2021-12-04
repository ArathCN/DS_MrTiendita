using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DAO
{
    public class DbContext
    {
        protected String stringConexion = "Data Source=HP-PAVILION-R5;Initial Catalog=MrTiendita;Integrated Security=True";
        //protected String stringConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=MrTiendita;Integrated Security=True";
        //protected String stringConexion = "Data Source=LAPTOP-3SLQTV7O;Initial Catalog=MrTiendita;Integrated Security=True";
        protected bool errorUltimaConsulta;
        protected String mensajeError;

        public bool ErrorUltimaConsulta { get => errorUltimaConsulta; set => errorUltimaConsulta = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }

        public void LimpiarError()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = "";
        }

    }
}
