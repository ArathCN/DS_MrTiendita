using MrTiendita.Modelos.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DAO
{
    /// <summary>
    /// Define métodos para acceder a datos tipo <see cref="Venta" /> en la base de datos.
    /// </summary>
    /// <seealso cref="MrTiendita.Modelos.DAO.DbContext" />
    class VentaDAO :DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VentaDAO"/> class.
        /// </summary>
        public VentaDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

        /// <summary>
        /// Crea un registro <see cref="Venta"/> en la base de datos.
        /// </summary>
        /// <param name="venta">La venta a registrar.</param>
        /// <returns><see cref="Boolean"/>  <c>true</c> si el registro tiene exito, <c>false</c> si no se registró.</returns>
        public bool Create(Venta venta)
        {
            bool success = false;
            String sql = "INSERT INTO Venta (codigo_barra, id_empleado, metodo_pago, fecha, cantidad, importe) " +
                "VALUES (@cb, @ide, @met, @fec, @can, @imp);";

            using (SqlConnection connection = new SqlConnection(this.stringConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@cb", SqlDbType.BigInt);
                    command.Parameters.Add("@ide", SqlDbType.Int);
                    command.Parameters.Add("@met", SqlDbType.VarChar);
                    command.Parameters.Add("@fec", SqlDbType.DateTime);
                    command.Parameters.Add("@can", SqlDbType.Int);
                    command.Parameters.Add("@imp", SqlDbType.Decimal);

                    command.Parameters["@cb"].Value = venta.Codigo_barra;
                    command.Parameters["@ide"].Value = venta.Id_empleado;
                    command.Parameters["@met"].Value = venta.Metodo_pago;
                    command.Parameters["@fec"].Value = venta.Fecha.ToString(this.formatoDatetime);
                    command.Parameters["@can"].Value = venta.Cantidad;
                    command.Parameters["@imp"].Value = venta.Importe;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        /// <summary>
        /// Consulta todos los registros <see cref="Venta"/> en la base de datos.
        /// </summary>
        /// <returns>Una <see cref="List{Venta}"/> que contiene a todos las ventas de la base de datos,
        /// si no hay ninguno es una lista vacía.</returns>
        public List<Venta> ReadAll()
        {
            return null;
        }

        /// <summary>
        /// Consulta registros de <see cref="Venta"/> que se hayan realizado entre las fechas especificadas.
        /// </summary>
        /// <param name="inicio">Fecha límite de inicio.</param>
        /// <param name="final">Fecha límite final.</param>
        /// <returns><see cref="List{Venta}"/> con los registros encontrados, vacía si no se encontró ninguno.</returns>
        public List<Venta> ReadBetweenDates(DateTime inicio, DateTime final)
        {
            List<Venta> ventas = new List<Venta>();
            String sql = "SELECT * FROM Venta WHERE fecha >= @fechaInicio AND fecha <= @fechaFin;";

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
                            ventas.Add(
                                new Venta(
                                    reader.GetInt32(0),
                                    reader.GetInt64(1),
                                    reader.GetInt32(2),
                                    reader.GetString(3),
                                    reader.GetDateTime(4),
                                    decimal.ToDouble(reader.GetDecimal(5)),
                                    decimal.ToDouble(reader.GetDecimal(6))
                                )
                            );
                        }
                    }
                }
            }

            return ventas;
        }
    }
}
