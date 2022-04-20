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
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_ApellidoPa"].Value = "De Haro";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_ApellidoMa"].Value = "De La Cruz";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Telefono"].Value = "6221828945";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Sueldo"].Value = "$1000.00";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_TipoEmpleado"].Value = "Encargado";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Clave"].Value = "AnaSofia27.";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Usuario"].Value = "AnaSofia";
                dgv_TablaEmpleados.Rows[indexNuevoProducto].Cells["col_Estado"].Value = "Activo";
            }
            dgv_TablaEmpleados.AllowUserToResizeColumns = false;
            AjustarColumnas();
        }

        private void AjustarColumnas()
        {
            dgv_TablaEmpleados.Columns[0].Width = 50;//Nombre
            dgv_TablaEmpleados.Columns[1].Width = 50;//Apellido paterno
            dgv_TablaEmpleados.Columns[2].Width = 50;//Apellido materno
            dgv_TablaEmpleados.Columns[3].Width = 40;//Teléfono
            dgv_TablaEmpleados.Columns[4].Width = 40;//Sueldo
            dgv_TablaEmpleados.Columns[5].Width = 40;//Tipo de empleado
            dgv_TablaEmpleados.Columns[6].Width = 45;//Contraseña
            dgv_TablaEmpleados.Columns[7].Width = 45;//Usuario
            dgv_TablaEmpleados.Columns[8].Width = 45;//Estado
            dgv_TablaEmpleados.Columns[9].Width = 40;//Editar
            col_Editar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado frmEditarEmpleado = new FrmEditarEmpleado("Agregar", 1);
            frmEditarEmpleado.Show();

        }
    }
}
