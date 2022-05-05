using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Controladores;

namespace MrTiendita.Vistas
{
    public partial class FrmReportes_ : Form
    {
        public FrmReportes_()
        {
            InitializeComponent();
            dgv_TablaTodasVentas.AllowUserToAddRows = false;
            dgv_TablaTodasVentas.CurrentCell = null;
            dgv_TablaEntradas.AllowUserToAddRows = false;
            dgv_TablaEntradas.CurrentCell = null;
            dgv_TablaVentasCategoria.AllowUserToAddRows = false;
            dgv_TablaVentasCategoria.CurrentCell = null;


            dgv_TablaTodasVentas.AllowUserToResizeColumns = false;
            dgv_TablaEntradas.AllowUserToResizeColumns = false;
            dgv_TablaVentasCategoria.AllowUserToResizeColumns = false;
            AjustarColumnas();
            FrmReportesController controller = new FrmReportesController(this);
        }

        public void AjustarColumnas()
        {
            dgv_TablaTodasVentas.Columns[0].Width = 20;//ID de venta
            dgv_TablaTodasVentas.Columns[1].Width = 40;//Código de barras
            dgv_TablaTodasVentas.Columns[2].Width = 90;//Descripción
            dgv_TablaTodasVentas.Columns[3].Width = 45;//ID de empleado
            dgv_TablaTodasVentas.Columns[4].Width = 40;//Metodo de pago
            dgv_TablaTodasVentas.Columns[5].Width = 50;//Fecha
            dgv_TablaTodasVentas.Columns[6].Width = 20;//Cantidad
            dgv_TablaTodasVentas.Columns[7].Width = 50;//Importe

            dgv_TablaEntradas.Columns[0].Width = 20;//ID de entrada
            dgv_TablaEntradas.Columns[1].Width = 40;//Código de barras
            dgv_TablaEntradas.Columns[2].Width = 90;//Descripción
            dgv_TablaEntradas.Columns[3].Width = 20;//Cantidad entrada
            dgv_TablaEntradas.Columns[4].Width = 50;//Fecha entrada
            dgv_TablaEntradas.Columns[5].Width = 40;//Precio compra
            dgv_TablaEntradas.Columns[6].Width = 40;//Precio venta
            dgv_TablaEntradas.Columns[7].Width = 50;//Importe

            col_ProductosVendidos.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_TotalCategoria.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_GananciaCategoria.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_TablaVentasCategoria.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaVentasCategoria.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaVentasCategoria.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
