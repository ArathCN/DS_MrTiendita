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
    class CajaDAO:DbContext
    {
        public CajaDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

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
