using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DTO;

namespace MrTiendita.Modelos.DAO
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MrTiendita.Modelos.DAO.DbContext" />
    class CajaDAO :DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CajaDAO"/> class.
        /// </summary>
        public CajaDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

        /// <summary>
        /// Reads the name.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <returns>Un <see cref="int"/></returns>
        public Caja ReadByName(String nombre)
        {
            Caja caja = null;

            String sql = "SELECT * FROM Caja WHERE atributo = @att;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@att", SqlDbType.VarChar);
                    command.Parameters["@att"].Value = nombre;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            caja = new Caja(reader.GetString(0), reader.GetString(1));
                        }
                    }
                }
            }

            return caja;
        }

        /// <summary> Updates the value. </summary>
        /// <param name="atributo">The atributo.</param>
        /// <param name="valor">The valor.</param>
        /// <returns>Un <see cref="bool"/></returns>
        public bool UpdateValue(String atributo, String valor)
        {

            bool resultado = false;
            String sql = "UPDATE Caja SET valor = @val WHERE atributo = @att";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@val", SqlDbType.VarChar);
                    command.Parameters.Add("@att", SqlDbType.VarChar);

                    command.Parameters["@val"].Value = valor;
                    command.Parameters["@att"].Value = atributo;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) resultado = true;
                }
            }
            return resultado;
        }
    }
}
