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
    class ProductoDAO:DbContext
    {
        public bool Create(Producto producto)
        {
            bool success = false;
            String sql = "INSERT INTO Producto (codigo_barra, descripcion, precio_venta, precio_compra, cantidad_actual, medida) " +
                "VALUES (@cb, @des, @pre, @precom, @ca, @med);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters.Add("@des", SqlDbType.VarChar);
                    command.Parameters.Add("@pre", SqlDbType.Decimal);
                    command.Parameters.Add("@precom", SqlDbType.Decimal);
                    command.Parameters.Add("@ca", SqlDbType.Decimal);
                    command.Parameters.Add("@med", SqlDbType.Bit);

                    command.Parameters["@cb"].Value = producto.Codigo_barra;
                    command.Parameters["@des"].Value = producto.Descripcion;
                    command.Parameters["@pre"].Value = producto.Precio_venta;
                    command.Parameters["@precom"].Value = producto.Precio_compra;
                    command.Parameters["@ca"].Value = producto.Cantidad_actual;
                    command.Parameters["@med"].Value = producto.Medida;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public bool UpdateInfo(Producto producto, long id) //Update by id
        {
            bool success = false;
            String sql = "UPDATE Producto SET codigo_barra = @cbn, descripcion = @des, precio_venta = @pre," +
                " precio_compra = @precom, cantidad_actual = @ca, medida = @med WHERE codigo_barra = @cb;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@des", SqlDbType.VarChar);
                    command.Parameters.Add("@pre", SqlDbType.Decimal);
                    command.Parameters.Add("@precom", SqlDbType.Decimal);
                    command.Parameters.Add("@can", SqlDbType.Int);
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters.Add("@cbn", SqlDbType.BigInt);
                    command.Parameters.Add("@ca", SqlDbType.Decimal);
                    command.Parameters.Add("@med", SqlDbType.Bit);

                    command.Parameters["@des"].Value = producto.Descripcion;
                    command.Parameters["@pre"].Value = producto.Precio_venta;
                    command.Parameters["@precom"].Value = producto.Precio_compra;
                    command.Parameters["@can"].Value = producto.Cantidad_actual;
                    command.Parameters["@cbn"].Value = producto.Codigo_barra;
                    command.Parameters["@cb"].Value = id;
                    command.Parameters["@ca"].Value = producto.Cantidad_actual;
                    command.Parameters["@med"].Value = producto.Medida;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public bool UpdateCantidad(List<Producto> productos) //Update by id
        {
            this.LimpiarError();
            bool success = true;
            String sql = "UPDATE Producto SET cantidad_actual = cantidad_actual - @ca WHERE codigo_barra = @cb;";
            StringBuilder errorMessages = new StringBuilder();
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlTransaction tran = connection.BeginTransaction("Venta" + DateTimeOffset.Now.ToUnixTimeSeconds()))
                {
                    for (int i = 0; i < productos.Count && success; i++)
                    {
                        using (SqlCommand command = new SqlCommand(sql, connection, tran))
                        {
                            command.Parameters.Add("@cb", SqlDbType.BigInt);
                            command.Parameters.Add("@ca", SqlDbType.Decimal);

                            command.Parameters["@cb"].Value = productos[i].Codigo_barra;
                            command.Parameters["@ca"].Value = productos[i].Cantidad_actual;

                            try
                            {
                                rowsAffected = command.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                for (int j = 0; j < ex.Errors.Count; j++)
                                {
                                    errorMessages.Append("Index #" + j + "\n" +
                                        "Message: " + ex.Errors[j].Message + "\n" +
                                        "LineNumber: " + ex.Errors[j].LineNumber + "\n" +
                                        "Source: " + ex.Errors[j].Source + "\n" +
                                        "Procedure: " + ex.Errors[j].Procedure + "\n");
                                }
                                this.errorUltimaConsulta = true;
                                this.mensajeError = errorMessages.ToString();
                                tran.Rollback();
                                success = false;
                            }


                            if (rowsAffected == 0 && success)
                            {
                                tran.Rollback();
                                success = false;
                            }

                        }
                    }
                    if (success) tran.Commit();

                }
            }
            return success;
        }

        public List<Producto> ReadAll()
        {
            List<Producto> productos = new List<Producto>();
            String sql = "SELECT * FROM Producto;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto(reader.GetInt64(0), reader.GetString(1), decimal.ToDouble(reader.GetDecimal(2)), decimal.ToDouble(reader.GetDecimal(3)), decimal.ToDouble(reader.GetDecimal(4)), reader.GetBoolean(5)));
                        }
                    }
                }
            }

            return productos;
        }

        public Producto ReadById(long id)
        {
            Producto producto = null;

            String sql = "SELECT * FROM Producto WHERE codigo_barra = @cb;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters["@cb"].Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                producto = new Producto(reader.GetInt64(0), reader.GetString(1), decimal.ToDouble(reader.GetDecimal(2)), decimal.ToDouble(reader.GetDecimal(3)), decimal.ToDouble(reader.GetDecimal(4)), reader.GetBoolean(5));
                            }
                        }
                    }
                }
            }

            return producto;
        }

        public List<Producto> ReadByName(String idOrName)
        {
            List<Producto> productos = new List<Producto>();
            idOrName = "%" + idOrName + "%";
            String sql = "SELECT * FROM Producto WHERE descripcion LIKE @condicion2;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@condicion2", SqlDbType.VarChar);
                    command.Parameters["@condicion2"].Value = idOrName;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto(reader.GetInt64(0), reader.GetString(1), decimal.ToDouble(reader.GetDecimal(2)), decimal.ToDouble(reader.GetDecimal(3)), decimal.ToDouble(reader.GetDecimal(4)), reader.GetBoolean(5)));
                        }
                    }
                }
            }

            return productos;
        }

        public bool Delete(long id)
        {
            bool success = false;
            String sql = "DELETE FROM Producto WHERE codigo_barra = @cb";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters["@cb"].Value = id;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }
    }
}
