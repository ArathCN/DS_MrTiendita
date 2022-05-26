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
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProductoController controlador;
        public FrmCVentasController controlador2;

        public FrmBuscarProducto(FrmCVentasController controlador2)
        {
            InitializeComponent();
            this.controlador2 = controlador2;
            controlador = new FrmBuscarProductoController(this);


            sombra.SetShadowForm(this);
            dgv_TablaProductos.AllowUserToAddRows = false;
            dgv_TablaProductos.CurrentCell = null;            
            dgv_TablaProductos.AllowUserToResizeColumns = false;
            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            dgv_TablaProductos.Columns[2].Width = 60;//Nombre
            dgv_TablaProductos.Columns[3].Width = 50;//Categoria
            dgv_TablaProductos.Columns[4].Width = 20;//Precio
            dgv_TablaProductos.Columns[5].Width = 35;//Cantidad a agregar
            dgv_TablaProductos.Columns[6].Width = 60;//Icono agregar al carrito
            col_CantidadAgregar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Precio.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_AgregarCarrito.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_Productos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
