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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            dgv_TablaProveedores.AllowUserToAddRows = false;
            dgv_TablaProveedores.CurrentCell = null;
            int indexNuevoProducto;
            for (int i = 0; i < 3; i++)
            {
                dgv_TablaProveedores.Rows.Add();
                indexNuevoProducto = dgv_TablaProveedores.RowCount - 1;
                Console.WriteLine(indexNuevoProducto);
                dgv_TablaProveedores.Rows[indexNuevoProducto].Cells["col_Nombre"].Value = "Coca Cola S.A de C.V.";
                dgv_TablaProveedores.Rows[indexNuevoProducto].Cells["col_Telefono"].Value = "6221828945";
                dgv_TablaProveedores.Rows[indexNuevoProducto].Cells["col_Estado"].Value = "Activo";
            }
            dgv_TablaProveedores.AllowUserToResizeColumns = false;
            FrmEProveedorController controlador = new FrmEProveedorController(this);
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            dgv_TablaProveedores.Columns[0].Width = 300;//Nombre
            dgv_TablaProveedores.Columns[1].Width = 100;//Teléfono
            dgv_TablaProveedores.Columns[2].Width = 45;//Estado
            dgv_TablaProveedores.Columns[3].Width = 40;//Editar
            col_Editar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
