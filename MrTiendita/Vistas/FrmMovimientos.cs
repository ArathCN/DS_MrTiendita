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
    public partial class FrmMovimientos : Form
    {
        public bool esAtajo = false;
        public FrmMovimientos(bool esAtajo)
        {
            InitializeComponent();
            this.esAtajo = esAtajo;
            FrmMovimientosController controller = new FrmMovimientosController(this);
            tablaMovimientos.AllowUserToAddRows = false;
            tablaMovimientos.CurrentCell = null;

            dgv_TablaEntradas.AllowUserToAddRows = false;
            dgv_TablaEntradas.CurrentCell = null;

            dgv_TablaSalidas.AllowUserToAddRows = false;
            dgv_TablaSalidas.CurrentCell = null;            

            tablaMovimientos.AllowUserToResizeColumns = false;
            dgv_TablaEntradas.AllowUserToResizeColumns = false;
            dgv_TablaSalidas.AllowUserToResizeColumns = false;

            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            tablaMovimientos.Columns[0].Width = 100;//Tipo de movimiento
            tablaMovimientos.Columns[1].Width = 250;//Descripcion
            tablaMovimientos.Columns[2].Width = 150;//Fecha
            tablaMovimientos.Columns[3].Width = 80;//Importe

            dgv_TablaEntradas.Columns[0].Width = 300;//Descripcion entrada
            dgv_TablaEntradas.Columns[1].Width = 100;//Importe

            dgv_TablaSalidas.Columns[0].Width = 300;//Descripcion salida
            dgv_TablaSalidas.Columns[1].Width = 100;//Importe

            dgv_TablaEntradas.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_TablaSalidas.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_TablaEntradas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_TablaSalidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
    }
}
