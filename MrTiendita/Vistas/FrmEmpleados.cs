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
using MrTiendita.Controladores;

namespace MrTiendita.Vistas
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            
            InitializeComponent();

            tablaEmpleados.AllowUserToAddRows = false;
            tablaEmpleados.CurrentCell = null;            
            tablaEmpleados.AllowUserToResizeColumns = false;
            AjustarColumnas();
            FrmEmpleadosController controller = new FrmEmpleadosController(this);
        }

        private void AjustarColumnas()
        {
            tablaEmpleados.Columns[1].Width = 200;//Nombre(s)
            tablaEmpleados.Columns[2].Width = 60;//Teléfono
            tablaEmpleados.Columns[3].Width = 60;//Sueldo
            tablaEmpleados.Columns[4].Width = 60;//Tipo de empleado
            tablaEmpleados.Columns[5].Width = 75;//Usuario
            tablaEmpleados.Columns[6].Width = 40;//Editar
            tablaEmpleados.Columns[7].Width = 40;//Borrar
            col_Editar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_Borrar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
