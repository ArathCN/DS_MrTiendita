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
    class MovimientoDAO : DbContext
    {
        public MovimientoDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

        public bool create(Movimiento movimiento)
        {
            bool success = false;
            String sql = "INSERT INTO Movimientos (tipo, concepto, fecha, importe, caja) " +
                "VALUES (@tipo, @con, @fec, @imp, @caj);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@tipo", SqlDbType.VarChar);
                    command.Parameters.Add("@con", SqlDbType.VarChar);
                    command.Parameters.Add("@fec", SqlDbType.DateTime);
                    command.Parameters.Add("@imp", SqlDbType.Decimal);
                    command.Parameters.Add("@caj", SqlDbType.Decimal);


                    command.Parameters["@tipo"].Value = movimiento.Tipo;
                    command.Parameters["@con"].Value = movimiento.Concepto;
                    command.Parameters["@fec"].Value = movimiento.Fecha;
                    command.Parameters["@imp"].Value = movimiento.Importe;
                    command.Parameters["@caj"].Value = movimiento.Caja;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public List<Movimiento> readAll()
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            String sql = "SELECT * FROM Movimientos;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movimientos.Add(new Movimiento(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), decimal.ToDouble(reader.GetDecimal(4)), decimal.ToDouble(reader.GetDecimal(5))));
                        }
                    }
                }
            }

            return movimientos;
        }
    }
}
