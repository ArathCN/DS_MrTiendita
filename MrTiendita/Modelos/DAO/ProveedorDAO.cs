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
    public class ProveedorDAO:DbContext
    {
        public bool create(Proveedor proveedor)
        {
            bool success = false;
            String sql = "INSERT INTO Proveedor (nombre, telefono, metodo_pago) " +
                "VALUES (@nom, @tel, @met);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@nom", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@met", SqlDbType.VarChar);
                    

                    command.Parameters["@nom"].Value = proveedor.Nombre;
                    command.Parameters["@tel"].Value = proveedor.Telefono;
                    command.Parameters["@met"].Value = proveedor.Metodo_pago;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public bool updateInfo(Proveedor proveedor, int id)
        {
            bool success = false;
            String sql = "UPDATE Proveedor SET nombre = @nom, telefono = @tel, metodo_pago = @met WHERE id_proveedor = @id;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@nom", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@met", SqlDbType.VarChar);
                    command.Parameters.Add("@id", SqlDbType.Int);

                    command.Parameters["@nom"].Value = proveedor.Nombre;
                    command.Parameters["@tel"].Value = proveedor.Telefono;
                    command.Parameters["@met"].Value = proveedor.Metodo_pago;
                    command.Parameters["@id"].Value = id;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public List<Proveedor> readAll()
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

        public Proveedor readById(int id)
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

        public List<Proveedor> readByName(String idOrName)
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

        public bool delete(int id)
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
    }
}
