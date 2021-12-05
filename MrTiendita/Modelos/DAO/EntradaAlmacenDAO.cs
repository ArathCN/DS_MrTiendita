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

        public EntradaAlmacenDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

        //Formato para fechas en SQL Server yyyy-mm-dd hh:mm:ss
        public bool create(EntradaAlmacen entradaAlmacen, Producto producto)
        {
            this.LimpiarError();
            StringBuilder errorMessages = new StringBuilder();
            bool success = false;
            int rowsAffected = 0;

            String sql = "INSERT INTO Entrada_Almacen (codigo_barra, fecha, cantidad, importe, id_proveedor) " +
                "VALUES (@cb, @fecha, @cant, @imp, @idp);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlTransaction tran = connection.BeginTransaction("EntradaAlmacen" + DateTimeOffset.Now.ToUnixTimeSeconds()))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, tran))
                    {
                        command.Parameters.Add("@cb", SqlDbType.BigInt);
                        command.Parameters.Add("@fecha", SqlDbType.DateTime);
                        command.Parameters.Add("@cant", SqlDbType.Decimal);
                        command.Parameters.Add("@imp", SqlDbType.Decimal);
                        command.Parameters.Add("@idp", SqlDbType.Int);

                        command.Parameters["@cb"].Value = entradaAlmacen.Codigo_barra;
                        command.Parameters["@fecha"].Value = entradaAlmacen.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
                        command.Parameters["@cant"].Value = entradaAlmacen.Cantidad;
                        command.Parameters["@imp"].Value = entradaAlmacen.Importe;
                        command.Parameters["@idp"].Value = entradaAlmacen.Id_proveedor;

                        try
                        {
                            rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected == 1)
                            {
                                //hacer el update en prodcuto
                                String sqlUpdate = "UPDATE Producto SET cantidad_actual = @ca WHERE codigo_barra = @cb;";
                                using (SqlCommand commandUpdate = new SqlCommand(sqlUpdate, connection, tran))
                                {
                                    commandUpdate.Parameters.Add("@ca", SqlDbType.Decimal);
                                    commandUpdate.Parameters.Add("@cb", SqlDbType.BigInt);

                                    commandUpdate.Parameters["@ca"].Value = producto.Cantidad_actual;
                                    commandUpdate.Parameters["@cb"].Value = producto.Codigo_barra;


                                    int rowsAffectedU = commandUpdate.ExecuteNonQuery();

                                    if (rowsAffectedU == 1)
                                    {
                                        tran.Commit();
                                        success = true;
                                    }
                                    else
                                    {
                                        tran.Rollback();
                                        success = false;
                                    }
                                }
                            }
                            else
                            {
                                tran.Rollback();
                                success = false;
                            }
                        }
                        catch (SqlException ex)
                        {
                            for (int i = 0; i < ex.Errors.Count; i++)
                            {
                                errorMessages.Append("Index #" + i + "\n" +
                                    "Message: " + ex.Errors[i].Message + "\n" +
                                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                    "Source: " + ex.Errors[i].Source + "\n" +
                                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                            }
                            this.errorUltimaConsulta = true;
                            this.mensajeError = errorMessages.ToString();
                            tran.Rollback();
                            success = false;
                        }
                    }
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
                            entradasAlmacen.Add(new EntradaAlmacen(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), decimal.ToDouble(reader.GetDecimal(3)), decimal.ToDouble(reader.GetDecimal(4)), reader.GetInt32(5)));
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
                            entradasAlmacen.Add(new EntradaAlmacen(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), decimal.ToDouble(reader.GetDecimal(3)), decimal.ToDouble(reader.GetDecimal(4)), reader.GetInt32(5)));
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
