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
    class VentaDAO:DbContext
    {
        public VentaDAO()
        {
            this.errorUltimaConsulta = false;
            this.mensajeError = null;
        }

        public bool create(Venta venta)
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
                    command.Parameters["@fec"].Value = venta.Fecha;
                    command.Parameters["@can"].Value = venta.Cantidad;
                    command.Parameters["@imp"].Value = venta.Importe;


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 1) success = true;
                }
            }
            return success;
        }

        public List<Venta> readAll()
        {
            return null;
        }
    }
}
