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
            dgv_TablaProveedores.AllowUserToResizeColumns = false;
            FrmEProveedorController controlador = new FrmEProveedorController(this);
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            dgv_TablaProveedores.Columns[1].Width = 500;//Nombre
            dgv_TablaProveedores.Columns[2].Width = 100;//Teléfono
            dgv_TablaProveedores.Columns[3].Width = 70;//Editar
            dgv_TablaProveedores.Columns[4].Width = 70;//Editar
            col_Editar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Borrar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
