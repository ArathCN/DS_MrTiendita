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
        public bool create(Empleado empleado)
        {
            bool success = false;
            String sql = "INSERT INTO Empleado (id_empleado, nombre, ap_materno, ap_paterno, telefono, sueldo, tipo_empleado, clave) " +
                "VALUES (@id, @nom, @am, @ap, @tel, @sue, @tip, @cla);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters.Add("@nom", SqlDbType.VarChar);
                    command.Parameters.Add("@am", SqlDbType.VarChar);
                    command.Parameters.Add("@ap", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@sue", SqlDbType.Decimal);
                    command.Parameters.Add("@tip", SqlDbType.VarChar);
                    command.Parameters.Add("@cla", SqlDbType.VarChar);

                    command.Parameters["@id"].Value = empleado.Id_empleado;
                    command.Parameters["@nom"].Value = empleado.Nombre;
                    command.Parameters["@am"].Value = empleado.A_paterno;
                    command.Parameters["@ap"].Value = empleado.A_materno;
                    command.Parameters["@tel"].Value = empleado.Telefono;
                    command.Parameters["@sue"].Value = empleado.Sueldo;
                    command.Parameters["@tip"].Value = empleado.Tipo_empleado;
                    command.Parameters["@cla"].Value = empleado.Clave;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public bool updateInfo(Empleado empleado, long id) //Update by id
        {
            //String sql = "INSERT INTO Empleado (id_empleado, nombre, ap_materno, ap_paterno, telefono, sueldo, tipo_empleado, clave) " +
            //    "VALUES (@id, @nom, @am, @ap, @tel, @sue, @tip, @cla);";
            bool success = false;
            String sql = "UPDATE Producto SET nombre = @nom, ap_paterno = @ap, ap_materno = @am," +
                " telefono = @tel, sueldo = @sue, tipo_empleado = @tip, clave = @cla WHERE id_empleado = @id;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters.Add("@idn", SqlDbType.Int);
                    command.Parameters.Add("@nom", SqlDbType.VarChar);
                    command.Parameters.Add("@am", SqlDbType.VarChar);
                    command.Parameters.Add("@ap", SqlDbType.VarChar);
                    command.Parameters.Add("@tel", SqlDbType.BigInt);
                    command.Parameters.Add("@sue", SqlDbType.Decimal);
                    command.Parameters.Add("@tip", SqlDbType.VarChar);
                    command.Parameters.Add("@cla", SqlDbType.VarChar);

                    command.Parameters["@id"].Value = id;
                    command.Parameters["@idn"].Value = empleado.Id_empleado;
                    command.Parameters["@nom"].Value = empleado.Nombre;
                    command.Parameters["@am"].Value = empleado.A_paterno;
                    command.Parameters["@ap"].Value = empleado.A_materno;
                    command.Parameters["@tel"].Value = empleado.Telefono;
                    command.Parameters["@sue"].Value = empleado.Sueldo;
                    command.Parameters["@tip"].Value = empleado.Tipo_empleado;
                    command.Parameters["@cla"].Value = empleado.Clave;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public List<Empleado> readAll()
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
                            empleados.Add(new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), decimal.ToDouble(reader.GetDecimal(5)), reader.GetString(6), reader.GetString(7)));
                        }
                    }
                }
            }

            return empleados;
        }

        public bool delete(long id)
        {
            bool success = false;
            String sql = "DELETE FROM Producto WHERE id_empleado = @id";

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
