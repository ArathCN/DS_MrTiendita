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
    public class FrmREntradasController
    {
        private FrmREntradas vista;
        private DateTime desde;
        private DateTime hasta;
        private EntradaAlmacenDAO entradaAlmacenDAO;
        public FrmREntradasController(FrmREntradas vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.vista.Load += new EventHandler(Vista_Load);
        }

        public void Vista_Load(object sender, EventArgs e)
        {
            //this.vista.lbl_prueba.Text = this.desde.ToString() + " -> " + this.hasta.ToString();
        }

        public void ActualizarEntradas(DateTime desde, DateTime hasta)
        {
            this.desde = desde;
            this.hasta = hasta;
            List<EntradaAlmacen> entradas = this.entradaAlmacenDAO.ReadBetweenDates(desde, hasta);
            this.vista.lbl_prueba.Text = this.desde.ToString() + " -> " + this.hasta.ToString();
            this.vista.tablaEntradas.Rows.Clear();
            foreach (EntradaAlmacen entrada in entradas)
            {
                this.vista.tablaEntradas.Rows.Add("--", entrada.Producto.Descripcion, entrada.Fecha, entrada.Codigo_barra, entrada.Cantidad, entrada.Producto.Precio_compra, entrada.Producto.Precio_venta, entrada.Importe);
            }
        }
    }
}
