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
    class EmpleadoDAO:DbContext
    {
        public bool Create(Empleado empleado)
        {
            this.LimpiarError();
            bool success = false;
            String sql = "INSERT INTO Empleado (nombre, ap_materno, ap_paterno, telefono, sueldo, tipo_empleado, clave, usuario) " +
                "VALUES (@nombre, @am, @ap, @tel, @sue, @tip, @cla, @usu);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@nombre", SqlDbType.VarChar);
                    command.Parameters.Add("@am", SqlDbType.VarChar);
                    command.Parameters.Add("@ap", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@sue", SqlDbType.Decimal);
                    command.Parameters.Add("@tip", SqlDbType.VarChar);
                    command.Parameters.Add("@cla", SqlDbType.VarChar);
                    command.Parameters.Add("@usu", SqlDbType.VarChar);

                    command.Parameters["@nombre"].Value = empleado.Nombre;
                    command.Parameters["@am"].Value = empleado.A_paterno;
                    command.Parameters["@ap"].Value = empleado.A_materno;
                    command.Parameters["@tel"].Value = empleado.Telefono;
                    command.Parameters["@sue"].Value = empleado.Sueldo;
                    command.Parameters["@tip"].Value = empleado.Tipo_empleado;
                    command.Parameters["@cla"].Value = empleado.Clave;
                    command.Parameters["@usu"].Value = empleado.Usuario;
                    
                    int rowsAffected = 0;

                    try
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        String msg = e.Message;
                        if (e.Number == 2627) msg = "Nombre de usuario en uso.";
                        this.MensajeError = msg;
                        this.errorUltimaConsulta = true;
                    }
                    

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public bool UpdateInfo(Empleado empleado, long id) //Update by id
        {
            //String sql = "INSERT INTO Empleado (id_empleado, nombre, ap_materno, ap_paterno, telefono, sueldo, tipo_empleado, clave) " +
            //    "VALUES (@id, @nombre, @am, @ap, @tel, @sue, @tip, @cla);";
            bool success = false;
            String sql = "UPDATE Empleado SET nombre = @nombre, ap_paterno = @ap, ap_materno = @am," +
                " telefono = @tel, sueldo = @sue, tipo_empleado = @tip, usuario = @usu WHERE id_empleado = @id;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters.Add("@nombre", SqlDbType.VarChar);
                    command.Parameters.Add("@ap", SqlDbType.VarChar);
                    command.Parameters.Add("@am", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@sue", SqlDbType.Decimal);
                    command.Parameters.Add("@tip", SqlDbType.VarChar);
                    command.Parameters.Add("@usu", SqlDbType.VarChar);

                    command.Parameters["@id"].Value = id;
                    command.Parameters["@nombre"].Value = empleado.Nombre;
                    command.Parameters["@am"].Value = empleado.A_paterno;
                    command.Parameters["@ap"].Value = empleado.A_materno;
                    command.Parameters["@tel"].Value = empleado.Telefono;
                    command.Parameters["@sue"].Value = empleado.Sueldo;
                    command.Parameters["@tip"].Value = empleado.Tipo_empleado;
                    command.Parameters["@usu"].Value = empleado.Usuario;

                    int rowsAffected = 0;

                    try
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        String msg = e.Message;
                        if (e.Number == 2627) msg = "Nombre de usuario en uso.";
                        this.MensajeError = msg;
                        this.errorUltimaConsulta = true;
                    }

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public List<Empleado> ReadAll()
        {
            List<Empleado> empleados = new List<Empleado>();
            String sql = "SELECT * FROM Empleado;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleados.Add(new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), decimal.ToDouble(reader.GetDecimal(5)), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                }
            }

            return empleados;
        }
        
        public Empleado ReadById(int id)
        {
            Empleado empleado = null;

            String sql = "SELECT * FROM Empleado WHERE id_empleado = @id;";

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
                            empleado = new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), decimal.ToDouble(reader.GetDecimal(5)), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        }
                    }
                }
            }

            return empleado;
        }

        public List<Empleado> ReadByName(String idOrName)
        {
            List<Empleado> empleados = new List<Empleado>();
            idOrName = "%" + idOrName + "%";
            String sql = "SELECT * FROM Empleado WHERE usuario LIKE @condicion2;";

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
                            empleados.Add(new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), decimal.ToDouble(reader.GetDecimal(5)), reader.GetString(6), reader.GetString(7), reader.GetString(8)));
                        }
                    }
                }
            }

            return empleados;
        }

        public bool Delete(int id)
        {
            bool success = false;
            String sql = "DELETE FROM Empleado WHERE id_empleado = @id";

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

        public Empleado ReadByUsuario(string usuario)
        {
            Empleado empleado = null;

            String sql = "SELECT * FROM Empleado WHERE usuario = @usu COLLATE Modern_Spanish_CS_AS;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@usu", SqlDbType.VarChar);
                    command.Parameters["@usu"].Value = usuario;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleado = new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), decimal.ToDouble(reader.GetDecimal(5)), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        }
                    }
                }
            }

            return empleado;
        }
    }
}
