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

        public bool Create(Movimiento movimiento)
        {
            bool success = false;
            String sql = "INSERT INTO Movimientos (tipo, fecha, importe, caja, concepto) " +
                "VALUES (@tipo, @fec, @imp, @caj, @con);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@tipo", SqlDbType.VarChar);
                    command.Parameters.Add("@fec", SqlDbType.DateTime);
                    command.Parameters.Add("@imp", SqlDbType.Decimal);
                    command.Parameters.Add("@caj", SqlDbType.Decimal);
                    command.Parameters.Add("@con", SqlDbType.VarChar);


                    command.Parameters["@tipo"].Value = movimiento.Tipo;
                    command.Parameters["@fec"].Value = movimiento.Fecha;
                    command.Parameters["@imp"].Value = movimiento.Importe;
                    command.Parameters["@caj"].Value = movimiento.Caja;
                    command.Parameters["@con"].Value = movimiento.Concepto;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public List<Movimiento> ReadAll()
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
                            movimientos.Add(
                                new Movimiento(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetDateTime(2),
                                    decimal.ToDouble(reader.GetDecimal(3)),
                                    decimal.ToDouble(reader.GetDecimal(4)),
                                    reader.GetString(5)
                                )
                            );
                        }
                    }
                }
            }

            return movimientos;
        }

        public List<Movimiento> ReadByType(String tipo)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            String sql = "SELECT * FROM Movimientos WHERE tipo = @tip;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@tip", SqlDbType.VarChar);

                    command.Parameters["@tip"].Value = tipo;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movimientos.Add(
                                new Movimiento(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetDateTime(2),
                                    decimal.ToDouble(reader.GetDecimal(3)),
                                    decimal.ToDouble(reader.GetDecimal(4)),
                                    reader.GetString(5)
                                )
                            );
                        }
                    }
                }
            }

            return movimientos;
        }
    }
}
