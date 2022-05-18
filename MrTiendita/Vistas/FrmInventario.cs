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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
            FrmInventarioController controller = new FrmInventarioController(this);
            dgv_TablaProductos.AllowUserToAddRows = false;
            dgv_TablaProductos.CurrentCell = null;            
            dgv_TablaProductos.AllowUserToResizeColumns = false;
            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            dgv_TablaProductos.Columns[0].Width = 50;//Codigo de barras
            dgv_TablaProductos.Columns[1].Width = 90;//Descripcion
            dgv_TablaProductos.Columns[2].Width = 45;//Precio venta
            dgv_TablaProductos.Columns[3].Width = 45;//Precio compra
            dgv_TablaProductos.Columns[4].Width = 30;//Ganancia
            dgv_TablaProductos.Columns[5].Width = 65;//Categoria
            dgv_TablaProductos.Columns[6].Width = 30;//Cantidad actual
            dgv_TablaProductos.Columns[7].Width = 25;//Minimo
            dgv_TablaProductos.Columns[8].Width = 20;//Editar
            dgv_TablaProductos.Columns[9].Width = 50;//Borrar

            col_CantidadActual.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_PrecioVenta.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_PrecioCompra.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Ganancia.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Editar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Borrar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Minimo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_TablaProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
