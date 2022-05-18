using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MrTiendita.Modelos.DTO;
using MrTiendita.Constantes;

namespace MrTiendita.Modelos.DAO
{
    /// <summary> Define métodos para acceder a datos tipo <see cref="Movimiento" /> en la base de datos. </summary>
    /// <seealso cref="MrTiendita.Modelos.DAO.DbContext" />
    class MovimientoDAO : DbContext
    {
        /// <summary> Initializes a new instance of the <see cref="MovimientoDAO"/> class. </summary>
        public MovimientoDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

        /// <summary> Crea un registro de <see cref="Movimiento"/> en la base de datos. </summary>
        /// <param name="movimiento">El movimiento a registrar.</param>
        /// <returns><see cref="Boolean"/> <c>true</c> si se registró correctamente, <c>false</c> si no se registró.</returns>
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
                    command.Parameters["@fec"].Value = movimiento.Fecha.ToString(this.formatoDatetime);
                    command.Parameters["@imp"].Value = movimiento.Importe;
                    command.Parameters["@caj"].Value = movimiento.Caja;
                    command.Parameters["@con"].Value = movimiento.Concepto;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        /// <summary> Consutal todos los registros <see cref="Movimiento"/> en la base de datos. </summary>
        /// <returns><see cref="List{Movimiento}"/> que contiene los registros de movimientos encontrados.
        /// Es vacía si no se encontró ninguno.</returns>
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

        public List<Movimiento> ReadBetweenDates(DateTime inicio, DateTime final)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            String sql = "SELECT * FROM Movimientos WHERE fecha >= @fechaInicio AND fecha <= @fechaFin;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
                    command.Parameters.Add("@fechaFin", SqlDbType.DateTime);

                    command.Parameters["@fechaInicio"].Value = inicio.ToString(this.formatoDatetime);
                    command.Parameters["@fechaFin"].Value = final.ToString(this.formatoDatetime);

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

        /// <summary> Consulta registros <see cref="Movimiento"/> de la base de datos según el tipo de movimiento. </summary>
        /// <param name="tipo">Tipo de movimiento a buscar.</param>
        /// <returns><see cref="List{Movimiento}"/> que contiene los registros de movimientos encontrados.
        /// Es vacía si no se encontró ninguno.</returns>
        public List<Movimiento> ReadByType(String tipo)
        {
            string consulta = "SELECT * FROM Movimientos WHERE tipo = @tip;";
            if (tipo == TipoMovimiento.TODO) consulta = "SELECT * FROM Movimientos;";
            List<Movimiento> movimientos = new List<Movimiento>();

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(consulta, connection))
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

        public List<Movimiento> Read(String tipo, DateTime inicio, DateTime final)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            String sql = "SELECT * FROM Movimientos WHERE tipo = @tip AND fecha >= @fechaInicio AND fecha <= @fechaFin;";
            if (tipo == TipoMovimiento.TODO) sql = "SELECT * FROM Movimientos WHERE fecha >= @fechaInicio AND fecha <= @fechaFin;";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
                    command.Parameters.Add("@fechaFin", SqlDbType.DateTime);
                    command.Parameters.Add("@tip", SqlDbType.VarChar);

                    command.Parameters["@fechaInicio"].Value = inicio.ToString(this.formatoDatetime);
                    command.Parameters["@fechaFin"].Value = final.ToString(this.formatoDatetime);
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

        public bool Create(Movimiento movimiento, Caja caja)
        {
            bool success = false;
            String sqlMov = "INSERT INTO Movimientos (tipo, fecha, importe, caja, concepto) " +
                "VALUES (@tipo, @fec, @imp, @caj, @con);";
            String sqlCaja = "UPDATE Caja SET valor = @val WHERE atributo = @att";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlTransaction tran = connection.BeginTransaction(
                    "Movimiento" + movimiento.Tipo + DateTimeOffset.Now.ToUnixTimeSeconds()
                    )
                )
                {
                    using (SqlCommand commandMov = new SqlCommand(sqlMov, connection, tran))
                    {
                        commandMov.Parameters.Add("@tipo", SqlDbType.VarChar);
                        commandMov.Parameters.Add("@fec", SqlDbType.DateTime);
                        commandMov.Parameters.Add("@imp", SqlDbType.Decimal);
                        commandMov.Parameters.Add("@caj", SqlDbType.Decimal);
                        commandMov.Parameters.Add("@con", SqlDbType.VarChar);


                        commandMov.Parameters["@tipo"].Value = movimiento.Tipo;
                        commandMov.Parameters["@fec"].Value = movimiento.Fecha.ToString(this.formatoDatetime);
                        commandMov.Parameters["@imp"].Value = movimiento.Importe;
                        commandMov.Parameters["@caj"].Value = movimiento.Caja;
                        commandMov.Parameters["@con"].Value = movimiento.Concepto;

                        using (SqlCommand commandCaja = new SqlCommand(sqlCaja, connection, tran))
                        {
                            commandCaja.Parameters.Add("@val", SqlDbType.VarChar);
                            commandCaja.Parameters.Add("@att", SqlDbType.VarChar);

                            commandCaja.Parameters["@val"].Value = caja.Valor;
                            commandCaja.Parameters["@att"].Value = caja.Atributo;

                            try
                            {
                                commandMov.ExecuteNonQuery();
                                commandCaja.ExecuteNonQuery();
                                tran.Commit();
                                success = true;
                            }
                            catch (Exception ex)
                            {
                                this.errorUltimaConsulta = true;
                                success = false;
                                this.mensajeError = ex.GetType() + "  ->  " + ex.Message;
                                Console.WriteLine(ex.StackTrace);


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
    }
}
