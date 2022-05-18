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
    public partial class FrmVentas : Form
    {
        public FrmCVentasController controlador;
        public FrmVentas()
        {
            
            InitializeComponent();

            controlador = new FrmCVentasController(this);

            dgv_TablaVentas.AllowUserToAddRows = false;
            dgv_TablaVentas.CurrentCell = null;            
            dgv_TablaVentas.AllowUserToResizeColumns = false;
            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            dgv_TablaVentas.Columns[1].Width = 30;//Restar
            dgv_TablaVentas.Columns[2].Width = 50;//Cantidad
            dgv_TablaVentas.Columns[3].Width = 30;//Sumar
            dgv_TablaVentas.Columns[4].Width = 300;//Descripcion
            dgv_TablaVentas.Columns[5].Width = 80;//Precio
            col_Cantidad.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaVentas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaVentas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_TablaVentas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        } 
    }
}
