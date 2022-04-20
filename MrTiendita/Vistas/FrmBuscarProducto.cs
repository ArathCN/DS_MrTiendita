using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Vistas
{
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            //InitializeComponent();
            //dgv_TablaVentas.AllowUserToAddRows = false;
            //dgv_TablaVentas.CurrentCell = null;
            //int indexNuevoProducto;
            //for (int i = 0; i < 3; i++)
            //{
            //    dgv_TablaVentas.Rows.Add();
            //    indexNuevoProducto = dgv_TablaVentas.RowCount - 1;
            //    Console.WriteLine(indexNuevoProducto);
            //    dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Cantidad"].Value = "2";
            //    dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Descripcion"].Value = "Leche Lala Deslactosada 1L";
            //    dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Precio"].Value = "$25.99";
            //    dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Subtotal"].Value = "$62.00";
            //    dgv_TablaVentas.Rows[indexNuevoProducto].Cells["col_Codigo"].Value = "123456789012";
            //}
            //dgv_TablaVentas.AllowUserToResizeColumns = false;
            //AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            //dgv_TablaVentas.Columns[0].Width = 30;//Restar
            //dgv_TablaVentas.Columns[1].Width = 50;//Cantidad
            //dgv_TablaVentas.Columns[2].Width = 30;//Sumar
            //dgv_TablaVentas.Columns[3].Width = 300;//Descripcion
            //dgv_TablaVentas.Columns[4].Width = 80;//Precio
            //col_Cantidad.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_TablaVentas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_TablaVentas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgv_TablaVentas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
    }
}
