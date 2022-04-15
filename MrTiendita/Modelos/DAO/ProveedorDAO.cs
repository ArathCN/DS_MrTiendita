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
    /// Define métodos para acceder a datos tipo <see cref="Proveedor" /> en la base de datos.
    /// </summary>
    /// <seealso cref="MrTiendita.Modelos.DAO.DbContext" />
    public class ProveedorDAO : DbContext
    {
        /// <summary>
        /// Crea un registro en la base de datos del <see cref="Proveedor"/> especificado.
        /// </summary>
        /// <param name="proveedor">El proveedor a registrar.</param>
        /// <returns><see cref="Boolean"/>  <c>true</c> si el registro tiene exito, <c>false</c> si no se registró nada.</returns>
        public bool Create(Proveedor proveedor)
        {
            bool success = false;
            String sql = "INSERT INTO Proveedor (nombre, telefono) " +
                "VALUES (@nom, @tel);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@nom", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);


                    command.Parameters["@nom"].Value = proveedor.Nombre;
                    command.Parameters["@tel"].Value = proveedor.Telefono;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        /// <summary>
        /// Actualiza un registro de <see cref="Proveedor"/> en la base de datos segun el id especificado.
        /// </summary>
        /// <param name="proveedor">Datos nuevos del proveedor actualizar.</param>
        /// <param name="id">El id que se buscará.</param>
        /// <returns><see cref="Boolean"/> que es <c>true</c> si se modificó un registro, <c>false</c> si no se modificó ningún registro.</returns>
        public bool UpdateInfo(Proveedor proveedor, int id)
        {
            bool success = false;
            String sql = "UPDATE Proveedor SET nombre = @nom, telefono = @tel WHERE id_proveedor = @id;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@nom", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@id", SqlDbType.Int);

                    command.Parameters["@nom"].Value = proveedor.Nombre;
                    command.Parameters["@tel"].Value = proveedor.Telefono;
                    command.Parameters["@id"].Value = id;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        /// <summary>
        /// Consulta todos los registros <see cref="Proveedor"/> en la base de datos.
        /// </summary>
        /// <returns>Una <see cref="List{Proveedor}"/> que contiene a todos los productos de la base de datos,
        /// si no hay ninguno es una lista vacía.</returns>
        public List<Proveedor> ReadAll()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            String sql = "SELECT * FROM Proveedor;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proveedores.Add(new Proveedor(reader.GetInt32(0), reader.GetString(1), reader.GetInt64(2), reader.GetString(3)));
                        }
                    }
                }
            }

            return proveedores;
        }

        /// <summary>
        /// Consulta un <see cref="Proveedor"/> de la base de datos según el id.
        /// </summary>
        /// <param name="id">El id a buscar.</param>
        /// <returns><see cref="Proveedor"/> <c>true</c> si se encontró el proveedor, <c>false</c> si no</returns>
        public Proveedor ReadById(int id)
        {
            Proveedor proveedor = null;

            String sql = "SELECT * FROM Proveedor WHERE id_proveedor = @id;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proveedor = new Proveedor(reader.GetInt32(0), reader.GetString(1), reader.GetInt64(2), reader.GetString(3));
                        }
                    }
                }
            }

            return proveedor;
        }

        /// <summary>
        /// Consulta los registros <see cref="Proveedor"/> de la base de datos según el nombre.
        /// </summary>
        /// <param name="idOrName">Cadena que contiene el nombre o id de los proveedores que se quieren buscar.</param>
        /// <returns>Una <see cref="List{Proveedor}"/> que contiene a todos los proveedores de la base de datos,
        /// si no hay ninguno es una lista vacía.</returns>
        public List<Proveedor> ReadByName(String idOrName)
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            idOrName = "%" + idOrName + "%";
            String sql = "SELECT * FROM Proveedor WHERE nombre LIKE @condicion2;";

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
                            proveedores.Add(new Proveedor(reader.GetInt32(0), reader.GetString(1), reader.GetInt64(2), reader.GetString(3)));
                        }
                    }
                }
            }

            return proveedores;
        }

        /// <summary>
        /// Elimina un registro de <see cref="Proveedor"/> de la base de datos según el id.
        /// </summary>
        /// <param name="id">El id a buscar.</param>
        /// <returns><see cref="Boolean"/> <c>true</c> si se eliminó un registro, <c>false</c> si no se eliminó nada.</returns>
        public bool Delete(int id)
        {
            bool success = false;
            String sql = "DELETE FROM Proveedor WHERE id_proveedor = @id";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public Proveedor ReadByState(String estado)
        {
            Proveedor proveedor = null;

            String sql = "SELECT * FROM Proveedor WHERE estado = @est;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@est", SqlDbType.VarChar);
                    command.Parameters["@id"].Value = estado;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proveedor = new Proveedor(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt64(2),
                                reader.GetString(3)
                            );
                        }
                    }
                }
            }

            return proveedor;
        }
    }
}
