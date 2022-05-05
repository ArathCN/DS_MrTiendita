using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using MrTiendita.Patrones;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MrTiendita.Controladores
{
    public class FrmTableroController
    {
        private FrmTablero vista;
        private ProductoDAO productoDAO;
        private VentaDAO ventaDAO;
        private CajaDAO cajaDAO;
        private Caja valorCaja;

        public FrmTableroController(FrmTablero vista)
        {
            this.vista = vista;

            this.productoDAO = new ProductoDAO();
            this.ventaDAO = new VentaDAO();
            this.cajaDAO = new CajaDAO();

            this.vista.Load += new EventHandler(Vista_Load);
        }

        private void Vista_Load(object sender, EventArgs e)
        {
            ModificarNotificacion(this.vista.flp_ListaNotificaciones);
            ObtenerValorCaja();
            //CargarGrafica();
        }

        public void ObtenerValorCaja()
        {
            this.valorCaja = this.cajaDAO.ReadByName("Total");
            if (this.valorCaja == null)
            {
                FrmError error = new FrmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                return;
            }
            this.vista.lbl_EfetivoCaja.Text = "$"+this.valorCaja.Valor;
        }

        public void ModificarNotificacion(FlowLayoutPanel Contenedor)
        {
            Contenedor.Controls.Clear();
            List<Producto> productos = productoDAO.ReadAll();
            if (Properties.Settings.Default.siMinimoGlobal)
            {
                double minimoGlobal = Properties.Settings.Default.minimoGlobal;
                MessageBox.Show($"El mínimo global es: {minimoGlobal}");
                //Por cada elementos de productos comparar minimoGlobal con cantidad
                foreach (Producto producto in productos)
                {
                    if (producto.Cantidad_actual < minimoGlobal)
                    {
                        Notificacion notificacion = new Notificacion();
                        notificacion.NombreProducto = producto.Descripcion;
                        Contenedor.Controls.Add(notificacion);
                        notificacion.Dock = DockStyle.Top;
                    }
                }
            }
            else
            {
                //Por cada elemento de productos comparar cantidad con minimo
                foreach (Producto producto in productos)
                {
                    if (producto.Cantidad_actual < producto.Minimo)
                    {
                        Notificacion notificacion = new Notificacion();
                        notificacion.NombreProducto = producto.Descripcion;
                        Contenedor.Controls.Add(notificacion);
                        notificacion.Dock = DockStyle.Top;
                    }
                }
            }
            
            
        }

        //public void CargarGrafica()
        //{
        //    DateTime hoy_ = DateTime.Now;
        //    DateTime hoy = new DateTime(hoy_.Year, hoy_.Month, hoy_.Day, 0, 0, 0);

        //    int diaSemana = (int)hoy.DayOfWeek;
        //    if (diaSemana == 0) diaSemana = 7;
        //    diaSemana--;
        //    DateTime inicio = hoy.AddDays(-diaSemana);
        //    DateTime final = hoy.AddDays(6 - diaSemana);
        //    List<Venta> ventasSemana = this.ventaDAO.ReadBetweenDatesByNumber(inicio, final);
        //    for (int i = 0; i < ventasSemana.Count; i++)
        //    {
        //        Series serie = this.vista.chart_Ventas.Series.Add(ventasSemana[i].Fecha.ToString());
        //        serie.Label = ventasSemana[i].Cantidad.ToString();
        //        serie.Points.Add(ventasSemana[i].Cantidad);
        //    }
        //}
    }
}
