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
    /// <summary>
    /// Define métodos para acceder a datos tipo <see cref="Producto" /> en la base de datos.
    /// </summary>
    /// <seealso cref="MrTiendita.Modelos.DAO.DbContext" />
    class ProductoDAO :DbContext
    {
        /// <summary>
        /// Crea un registro <see cref="Producto"/> en la base de datos.
        /// </summary>
        /// <param name="producto">El producto a registrar.</param>
        /// <returns><see cref="Boolean"/>  <c>true</c> si el registro tiene exito, <c>false</c> si no se registró.</returns>
        public bool Create(Producto producto)
        {
            bool success = false;
            String sql =
                "INSERT INTO Producto (codigo_barra, descripcion, precio_compra, cantidad_actual, medida, categoria, minimo, ganancia) " +
                "VALUES (@cb, @des, @precom, @ca, @med, @cat, @min, @gan);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters.Add("@des", SqlDbType.VarChar);
                    command.Parameters.Add("@precom", SqlDbType.Decimal);
                    command.Parameters.Add("@ca", SqlDbType.Decimal);
                    command.Parameters.Add("@med", SqlDbType.Bit);
                    command.Parameters.Add("@cat", SqlDbType.VarChar);
                    command.Parameters.Add("@min", SqlDbType.Decimal);
                    command.Parameters.Add("@gan", SqlDbType.Int);

                    command.Parameters["@cb"].Value = producto.Codigo_barra;
                    command.Parameters["@des"].Value = producto.Descripcion;
                    command.Parameters["@precom"].Value = producto.Precio_compra;
                    command.Parameters["@ca"].Value = producto.Cantidad_actual;
                    command.Parameters["@med"].Value = producto.Medida;
                    command.Parameters["@cat"].Value = producto.Categoria;
                    command.Parameters["@min"].Value = producto.Minimo;
                    command.Parameters["@gan"].Value = producto.Ganancia;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        /// <summary>
        /// Actualiza un registro <see cref="Producto"/> según el id.
        /// </summary>
        /// <param name="producto">Datos nuevos de producto.</param>
        /// <param name="id">El id a buscar.</param>
        /// <returns><see cref="Boolean"/>  <c>true</c> si la actualización tiene exito, <c>false</c> si no se efectuó.</returns>
        public bool UpdateInfo(Producto producto, long id) //Update by id
        {
            bool success = false;
            String sql = "UPDATE Producto SET codigo_barra = @cbn, descripcion = @des, precio_compra = @precom," +
                " cantidad_actual = @ca, medida = @med, categoria = @cat, minimo = @min, ganancia = @gan WHERE codigo_barra = @cb;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cbn", SqlDbType.BigInt);
                    command.Parameters.Add("@des", SqlDbType.VarChar);
                    command.Parameters.Add("@precom", SqlDbType.Decimal);
                    command.Parameters.Add("@ca", SqlDbType.Decimal);
                    command.Parameters.Add("@med", SqlDbType.Bit);
                    command.Parameters.Add("@cat", SqlDbType.VarChar);
                    command.Parameters.Add("@min", SqlDbType.Decimal);
                    command.Parameters.Add("@gan", SqlDbType.Int);
                    command.Parameters.Add("@cb", SqlDbType.BigInt);

                    command.Parameters["@cbn"].Value = producto.Codigo_barra;
                    command.Parameters["@des"].Value = producto.Descripcion;
                    command.Parameters["@precom"].Value = producto.Precio_compra;
                    command.Parameters["@ca"].Value = producto.Cantidad_actual;
                    command.Parameters["@med"].Value = producto.Medida;
                    command.Parameters["@cat"].Value = producto.Categoria;
                    command.Parameters["@min"].Value = producto.Minimo;
                    command.Parameters["@gan"].Value = producto.Ganancia;
                    command.Parameters["@cb"].Value = id;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        /// <summary>
        /// Actualiza la cantidad de varios <see cref="Producto"/> en una transacción.
        /// </summary>
        /// <param name="productos">Lista de productos a actualizar, sólo se necesita <see cref="Producto.cantidad_actual"/>
        /// y <see cref="Producto.codigo_barra"/> para el movimiento.</param>
        /// <returns><see cref="Boolean"/>  <c>true</c> si todas las actualizaciones tienen exito, <c>false</c> si ocurre algún error.
        /// Además, si no se pudo actualizar un producto no se actualizará ninguno.</returns>
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

        /// <summary>
        /// Consulta todos los registros <see cref="Producto"/> en la base de datos.
        /// </summary>
        /// <returns>Una <see cref="List{Producto}"/> que contiene a todos los productos de la base de datos,
        /// si no hay ninguno es una lista vacía.</returns>
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
                            productos.Add(
                                new Producto(
                                    reader.GetInt64(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    decimal.ToDouble(reader.GetDecimal(3)),
                                    decimal.ToDouble(reader.GetDecimal(4)),
                                    reader.GetBoolean(5),
                                    reader.GetString(6),
                                    decimal.ToDouble(reader.GetDecimal(7))
                                )
                            );
                        }
                    }
                }
            }

            return productos;
        }

        /// <summary>
        /// Consulta un <see cref="Producto"/> de la base de datos según el id.
        /// </summary>
        /// <param name="id">El id a buscar.</param>
        /// <returns><see cref="Producto"/> <c>true</c> si se encontró el prodcuto, <c>false</c> si no</returns>
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
                                new Producto(
                                    reader.GetInt64(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    decimal.ToDouble(reader.GetDecimal(3)),
                                    decimal.ToDouble(reader.GetDecimal(4)),
                                    reader.GetBoolean(5),
                                    reader.GetString(6),
                                    decimal.ToDouble(reader.GetDecimal(7))
                                );
                            }
                        }
                    }
                }
            }

            return producto;
        }

        /// <summary>
        /// Consulta los registros <see cref="Producto"/> de la base de datos según el nombre.
        /// </summary>
        /// <param name="idOrName">Cadena que contiene el nombre o id de los productos que se quieren buscar.</param>
        /// <returns>Una <see cref="List{Producto}"/> que contiene a todos los productos de la base de datos,
        /// si no hay ninguno es una lista vacía.</returns>
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
                            productos.Add(
                                new Producto(
                                    reader.GetInt64(0),
                                    reader.GetString(1),
                                    reader.GetInt32(2),
                                    decimal.ToDouble(reader.GetDecimal(3)),
                                    decimal.ToDouble(reader.GetDecimal(4)),
                                    reader.GetBoolean(5),
                                    reader.GetString(6),
                                    decimal.ToDouble(reader.GetDecimal(7))
                                )
                            );
                        }
                    }
                }
            }

            return productos;
        }

        /// <summary>
        /// Elimina un registro de <see cref="Producto"/> de la base de datos según el id.
        /// </summary>
        /// <param name="id">El id a buscar.</param>
        /// <returns><see cref="Boolean"/> <c>true</c> si se eliminó un registro, <c>false</c> si no se eliminó nada.</returns>
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
