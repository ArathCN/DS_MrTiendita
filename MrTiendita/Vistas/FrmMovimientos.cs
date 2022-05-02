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
        public FrmMovimientos()
        {
            InitializeComponent();
            FrmMovimientosController controller = new FrmMovimientosController(this);
            dgv_TablaMovimientos.AllowUserToAddRows = false;
            dgv_TablaMovimientos.CurrentCell = null;

            dgv_TablaEntradas.AllowUserToAddRows = false;
            dgv_TablaEntradas.CurrentCell = null;

            dgv_TablaSalidas.AllowUserToAddRows = false;
            dgv_TablaSalidas.CurrentCell = null;


            int indexNuevoProducto;
            for (int i = 0; i < 15; i++)
            {
                dgv_TablaMovimientos.Rows.Add();
                indexNuevoProducto = dgv_TablaMovimientos.RowCount - 1;
                Console.WriteLine(indexNuevoProducto);
                dgv_TablaMovimientos.Rows[indexNuevoProducto].Cells["col_TipoMovimiento"].Value = "Entrada";
                dgv_TablaMovimientos.Rows[indexNuevoProducto].Cells["col_Descripcion"].Value = "Entrada de dinero de fondo de caja";
                dgv_TablaMovimientos.Rows[indexNuevoProducto].Cells["col_Fecha"].Value = "01/05/2022 01:35:09 PM";
                dgv_TablaMovimientos.Rows[indexNuevoProducto].Cells["col_Importe"].Value = "$10,000.00";
            }

            int indexNuevoEntrada;
            for (int i = 0; i < 5; i++)
            {
                dgv_TablaEntradas.Rows.Add();
                indexNuevoEntrada = dgv_TablaEntradas.RowCount - 1;
                Console.WriteLine(indexNuevoEntrada);
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_DescripcionCorteEntrada"].Value = "Entrada de dinero de fondo de caja el 01/05/2022 a las 5:00 PM";
                dgv_TablaEntradas.Rows[indexNuevoEntrada].Cells["col_ImporteCorteEntrada"].Value = "$1,000";
            }

            int indexNuevoSalida;
            for (int i = 0; i < 5; i++)
            {
                dgv_TablaSalidas.Rows.Add();
                indexNuevoSalida = dgv_TablaSalidas.RowCount - 1;
                Console.WriteLine(indexNuevoSalida);
                dgv_TablaSalidas.Rows[indexNuevoSalida].Cells["col_DescripcionCorteSalida"].Value = "Pago de proveedor el 01/05/2022 a las 5:00 PM";
                dgv_TablaSalidas.Rows[indexNuevoSalida].Cells["col_ImporteCorteSalida"].Value = "$500";
            }

            dgv_TablaMovimientos.AllowUserToResizeColumns = false;
            dgv_TablaEntradas.AllowUserToResizeColumns = false;
            dgv_TablaSalidas.AllowUserToResizeColumns = false;

            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            dgv_TablaMovimientos.Columns[0].Width = 100;//Tipo de movimiento
            dgv_TablaMovimientos.Columns[1].Width = 250;//Descripcion
            dgv_TablaMovimientos.Columns[2].Width = 150;//Fecha
            dgv_TablaMovimientos.Columns[3].Width = 80;//Importe

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
