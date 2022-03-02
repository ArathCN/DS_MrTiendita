using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;

namespace MrTiendita.Controladores
{
    public class FrmRVentasController
    {
        private FrmRVentas vista;
        private DateTime desde;
        private DateTime hasta;
        private VentaDAO ventaDAO;

        public FrmRVentasController(FrmRVentas vista)
        {
            this.vista = vista;
            this.ventaDAO = new VentaDAO();
        }

        public void ActualizarVentas(DateTime desde, DateTime hasta)
        {
            this.desde = desde;
            this.hasta = hasta;
            List<Venta> ventas = this.ventaDAO.ReadBetweenDates(desde, hasta);
            this.vista.lbl_prueba.Text = this.desde.ToString() + " -> " + this.hasta.ToString();
            this.vista.tablaVentas.Rows.Clear();
            foreach (Venta venta in ventas)
            {
                this.vista.tablaVentas.Rows.Add(
                    "--",
                    venta.Codigo_barra,
                    venta.Id_empleado,
                    venta.Metodo_pago,
                    venta.Fecha,
                    venta.Cantidad,
                    venta.Importe);
            }
        }
    }
}
