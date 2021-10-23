using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MrTiendita.Modelos.DTO;

namespace MrTiendita.Modelos.DAO
{
    class EntradaAlmacenDAO:DbContext
    {
        //Formato para fechas en SQL Server yyyy-mm-dd hh:mm:ss
        public bool create(EntradaAlmacen entradaAlmacen)
        {
            bool success = false;
            String sql = "INSERT INTO Entrada_Almacen (codigo_barra, id_proveedor, no_factura, fecha, cantidad, importe) " +
                "VALUES (@cb, @idp, @nf, @fecha, @cant, @imp);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters.Add("@idp", SqlDbType.Int);
                    command.Parameters.Add("@nf", SqlDbType.Int);
                    command.Parameters.Add("@fecha", SqlDbType.DateTime);
                    command.Parameters.Add("@cant", SqlDbType.Int);
                    command.Parameters.Add("@imp", SqlDbType.Decimal);

                    command.Parameters["@cb"].Value = entradaAlmacen.Codigo_barra;
                    command.Parameters["@idp"].Value = entradaAlmacen.Id_proveedor;
                    command.Parameters["@nf"].Value = entradaAlmacen.No_factura;
                    command.Parameters["@fecha"].Value = entradaAlmacen.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
                    command.Parameters["@cant"].Value = entradaAlmacen.Cantidad;
                    command.Parameters["@imp"].Value = entradaAlmacen.Importe;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        //Segun yo no se ocupa actualizar registros de entradas
        /*public bool update(EntradaAlmacen producto)
        {
            return false;
        }*/

        public List<EntradaAlmacen> readAll()
        {
            List<EntradaAlmacen> entradasAlmacen = new List<EntradaAlmacen>();
            String sql = "SELECT * FROM Entrada_almacen;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entradasAlmacen.Add(new EntradaAlmacen(reader.GetInt32(0), reader.GetInt64(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetInt32(5), decimal.ToDouble(reader.GetDecimal(6))));
                        }
                    }
                }
            }

            return entradasAlmacen;
        }

        public List<EntradaAlmacen> readBetweenDates(DateTime inicio, DateTime final)
        {
            List<EntradaAlmacen> entradasAlmacen = new List<EntradaAlmacen>();
            String sql = "SELECT * FROM Entrada_almacen WHERE fecha >= @fechaInicio AND fecha <= @fechaFin;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
                    command.Parameters.Add("@fechaFin", SqlDbType.DateTime);

                    command.Parameters["@fechaInicio"].Value = inicio;
                    command.Parameters["@fechaFin"].Value = final;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entradasAlmacen.Add(new EntradaAlmacen(reader.GetInt32(0), reader.GetInt64(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDateTime(4), reader.GetInt32(5), decimal.ToDouble(reader.GetDecimal(6))));
                        }
                    }
                }
            }

            return entradasAlmacen;
        }

        //Segun yo no se ocupa buscar por id, sino entre fechas
        /*public EntradaAlmacen readById(int id)
        {
            return null;
        }*/

        //Segun yo no se ocupa eliminar registros de entradas
        /*public bool delete(int id)
        {
            return false;
        }*/
    }
}
