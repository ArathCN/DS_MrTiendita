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
    public class frmREntradasController
    {
        private frmREntradas vista;
        private DateTime desde;
        private DateTime hasta;
        private EntradaAlmacenDAO entradaAlmacenDAO;
        public frmREntradasController(frmREntradas vista)
        {
            this.vista = vista;
            this.entradaAlmacenDAO = new EntradaAlmacenDAO();
            this.vista.Load += new EventHandler(vista_Load);
        }

        public void vista_Load(object sender, EventArgs e)
        {
            //this.vista.lbl_prueba.Text = this.desde.ToString() + " -> " + this.hasta.ToString();
        }

        public void act(DateTime desde, DateTime hasta)
        {
            this.desde = desde;
            this.hasta = hasta;
            List<EntradaAlmacen> entradas = this.entradaAlmacenDAO.readBetweenDates(desde, hasta);
            this.vista.lbl_prueba.Text = this.desde.ToString() + " -> " + this.hasta.ToString();
            this.vista.tablaEntradas.Rows.Clear();
            foreach (EntradaAlmacen entrada in entradas)
            {
                this.vista.tablaEntradas.Rows.Add("--", entrada.Producto.Descripcion, entrada.Fecha, entrada.Codigo_barra, entrada.Cantidad, entrada.Producto.Precio_compra, entrada.Producto.Precio_venta, entrada.Importe);
            }
        }
    }
}
