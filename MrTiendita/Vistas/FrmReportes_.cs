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
            dgv_TablaReporteVentas.AllowUserToAddRows = false;
            dgv_TablaReporteVentas.CurrentCell = null;
            dgv_TablaEntradas.AllowUserToAddRows = false;
            dgv_TablaEntradas.CurrentCell = null;

            int indexNuevoProducto;
            for (int i = 0; i < 15; i++)
            {
                dgv_TablaReporteVentas.Rows.Add();
                indexNuevoProducto = dgv_TablaReporteVentas.RowCount - 1;
                Console.WriteLine(indexNuevoProducto);
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_IDVenta"].Value = "1078";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_CodigoBarras"].Value = "1112223334445";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_Descripcion"].Value = "Leche Lala Deslactosada 1L";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_IDEmpleado"].Value = "admin admin";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_MetodoPago"].Value = "Efectivo";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_Fecha"].Value = "02/05/2022 08:19:43 PM";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_Cantidad"].Value = "23";
                dgv_TablaReporteVentas.Rows[indexNuevoProducto].Cells["col_Importe"].Value = "$1,000.00";
            }

            int indexNuevoEntrada;
            for (int i = 0; i < 15; i++)
            {
                dgv_TablaEntradas.Rows.Add();
                indexNuevoEntrada = dgv_TablaEntradas.RowCount - 1;
                Console.WriteLine(indexNuevoEntrada);
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_IDEntrada"].Value = "1078";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_CodigoBarrasEntrada"].Value = "1112223334445";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_DescripcionEntrada"].Value = "Leche Lala Deslactosada 1L";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_CantidadEntrada"].Value = "40";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_FechaEntrada"].Value = "02/05/2022 08:19:43 PM";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_PrecioCompra"].Value = "$1,000.00";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_PrecioVenta"].Value = "$1,000.00";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_ImporteEntrada"].Value = "$1,000.00";
            }

            dgv_TablaReporteVentas.AllowUserToResizeColumns = false;
            dgv_TablaEntradas.AllowUserToResizeColumns = false;
            AjustarColumnas();
            FrmReportesController controller = new FrmReportesController(this);
        }

        public void AjustarColumnas()
        {
            dgv_TablaReporteVentas.Columns[0].Width = 20;//ID de venta
            dgv_TablaReporteVentas.Columns[1].Width = 40;//Código de barras
            dgv_TablaReporteVentas.Columns[2].Width = 90;//Descripción
            dgv_TablaReporteVentas.Columns[3].Width = 45;//ID de empleado
            dgv_TablaReporteVentas.Columns[4].Width = 40;//Metodo de pago
            dgv_TablaReporteVentas.Columns[5].Width = 50;//Fecha
            dgv_TablaReporteVentas.Columns[6].Width = 20;//Cantidad
            dgv_TablaReporteVentas.Columns[7].Width = 50;//Importe

            dgv_TablaEntradas.Columns[0].Width = 20;//ID de entrada
            dgv_TablaEntradas.Columns[1].Width = 40;//Código de barras
            dgv_TablaEntradas.Columns[2].Width = 90;//Descripción
            dgv_TablaEntradas.Columns[3].Width = 20;//Cantidad entrada
            dgv_TablaEntradas.Columns[4].Width = 50;//Fecha entrada
            dgv_TablaEntradas.Columns[5].Width = 40;//Precio compra
            dgv_TablaEntradas.Columns[6].Width = 40;//Precio venta
            dgv_TablaEntradas.Columns[7].Width = 50;//Importe

        }
    }
}
