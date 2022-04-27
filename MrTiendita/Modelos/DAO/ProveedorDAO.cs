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
            String sqlProveedorOriginal = "INSERT INTO Proveedor (nombre, telefono) " +
                "VALUES (@nom, @tel);";
            String sqlProveedorVistaUsuario = "INSERT INTO ProveedorUserView (id_Proveedor) VALUES (@id);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();

                using (SqlTransaction tran = connection.BeginTransaction("AltaProveedor" + DateTimeOffset.Now.ToUnixTimeSeconds()))
                {
                    using (SqlCommand commandProveedorOriginal = new SqlCommand(sqlProveedorOriginal, connection))
                    {
                        commandProveedorOriginal.Parameters.Add("@nom", SqlDbType.VarChar);
                        commandProveedorOriginal.Parameters.Add("@tel", SqlDbType.BigInt);


                        commandProveedorOriginal.Parameters["@nom"].Value = proveedor.Nombre;
                        commandProveedorOriginal.Parameters["@tel"].Value = proveedor.Telefono;


                        using (SqlCommand commandProveedorVistaUsuario = new SqlCommand(sqlProveedorVistaUsuario, connection))
                        {
                            commandProveedorVistaUsuario.Parameters.Add("@id", SqlDbType.Int);

                            commandProveedorVistaUsuario.Parameters["@nom"].Value = proveedor.Id_proveedor;

                            try
                            {
                                commandProveedorOriginal.ExecuteNonQuery();
                                commandProveedorVistaUsuario.ExecuteNonQuery();
                                tran.Commit();
                                success = true;
                            }
                            catch (Exception ex)
                            {
                                this.errorUltimaConsulta = true;
                                success = false;
                                this.mensajeError = ex.GetType() + "  ->  " + ex.Message;


                                // Attempt to roll back the transaction.
                                try
                                {
                                    tran.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    this.mensajeError = ex2.GetType() + "  ->  " + ex2.Message;
                                }
                            }
                            

                        }
                    }
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
            String sql = "SELECT PO.id_proveedor, PO.nombre, PO.telefono FROM ProveedorUserView AS PC" +
                " INNER JOIN Proveedor AS PO ON PC.id_Proveedor = PO.id_proveedor;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proveedores.Add(new Proveedor(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt64(2)
                                )
                            );
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

            String sql = "SELECT PO.id_proveedor, PO.nombre, PO.telefono FROM ProveedorUserView AS PC " +
                "INNER JOIN Proveedor AS PO ON PC.id_Proveedor = PO.id_proveedor " +
                "WHERE PO.id_proveedor = @id; ";

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
                            proveedor = new Proveedor(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt64(2)
                            );
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
            String sql = "SELECT PO.id_proveedor, PO.nombre, PO.telefono FROM ProveedorUserView AS PC " +
                "INNER JOIN Proveedor AS PO ON PC.id_Proveedor = PO.id_proveedor " +
                "WHERE PO.nombre LIKE @condicion2; ; ";

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
                            proveedores.Add(new Proveedor(
                                reader.GetInt32(0), 
                                reader.GetString(1),
                                reader.GetInt64(2)
                                )
                            );
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
            String sql = "DELETE FROM ProveedorUserView WHERE id_Proveedor = @id";

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

    }
}
