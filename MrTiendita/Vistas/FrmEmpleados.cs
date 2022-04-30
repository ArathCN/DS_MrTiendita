using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MrTiendita.Vistas
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            
            InitializeComponent();

            dgv_TablaEmpleados.AllowUserToAddRows = false;
            dgv_TablaEmpleados.CurrentCell = null;
            int indexNuevoProducto;
            for (int i = 0; i < 3; i++)
            {
                dgv_TablaEmpleados.Rows.Add();
                indexNuevoProducto = dgv_TablaEmpleados.RowCount - 1;
                Console.WriteLine(indexNuevoProducto);
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Nombre"].Value = "Ana Sofía";
                //dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_ApellidoPa"].Value = "De Haro";
                //dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_ApellidoMa"].Value = "De La Cruz";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Telefono"].Value = "6221828945";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Sueldo"].Value = "$1000.00";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_TipoEmpleado"].Value = "Encargado";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Usuario"].Value = "AnaSofia";
            }
            dgv_TablaEmpleados.AllowUserToResizeColumns = false;
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            dgv_TablaEmpleados.Columns[0].Width = 200;//Nombre(s)
            dgv_TablaEmpleados.Columns[1].Width = 60;//Teléfono
            dgv_TablaEmpleados.Columns[2].Width = 60;//Sueldo
            dgv_TablaEmpleados.Columns[3].Width = 60;//Tipo de empleado
            dgv_TablaEmpleados.Columns[4].Width = 75;//Usuario
            dgv_TablaEmpleados.Columns[5].Width = 40;//Editar
            dgv_TablaEmpleados.Columns[6].Width = 40;//Borrar
            col_Editar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Borrar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
