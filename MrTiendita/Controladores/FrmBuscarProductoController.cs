using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using MrTiendita.Patrones;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace MrTiendita.Controladores
{
    /// <summary> Creación de la clase de tipo Controller para la busqueda de los productos. </summary>
    public class FrmBuscarProductoController
    {
        /// <summary> La vista. </summary>
        private FrmBuscarProducto vista;
        /// <summary> El controller de ventas. </summary>
        private FrmCVentasController cventas;
        /// <summary> El DAO de producto. </summary>
        private ProductoDAO productoDAO;

        /// <summary> Inicializa una nueva instancia de la clase <see cref="FrmBuscarProductoController"/>. </summary>
        /// <param name="vista">La vista.</param>
        public FrmBuscarProductoController(FrmBuscarProducto vista) 
        { 
            this.vista = vista;
            this.cventas = this.vista.controlador2;

            this.productoDAO = new ProductoDAO();

            this.vista.Load += new EventHandler(Vista_Load);

            this.vista.tb_BuscarProducto.TextChanged += new EventHandler(Tb_BuscarProducto_TextChanged);

            this.vista.cb_Categoria.TextChanged += new EventHandler (Cb_Categoria_TextChanged);

            this.vista.dgv_TablaProductos.CellContentClick += new DataGridViewCellEventHandler(Dgv_TablaProductos_CellContentClick);

            this.vista.dgv_TablaProductos.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(Dgv_TablaProductos_EditingControlShowing);

            this.vista.dgv_TablaProductos.CellFormatting += new DataGridViewCellFormattingEventHandler(Dgv_TablaProductos_CellFormatting);

        }

        /// <summary> Maneja el evento Load del control de Vista. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="EventArgs"/> que contiene los datos del evento.</param>
        private void Vista_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            this.vista.cb_Categoria.Items.Clear();
            foreach (Categoria categoria in Categorias.CATEGORIAS) 
            { this.vista.cb_Categoria.Items.Add(categoria.Nombre); }
        }
        
        /// <summary> Muestra los productos. </summary>
        protected void MostrarProductos()
        {
            this.vista.dgv_TablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Medida,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1
                    );
            }

        }

        /// <summary> Maneja el evento TextChanged del control Tb_BuscarProducto. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="EventArgs"/> que contiene los datos del evento.</param>
        private void Tb_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProducto.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Medida,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1
                    );
            }
        }

        /// <summary> Maneja el evento TextChanged del control Cb_Categoria. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="EventArgs"/>que contiene los datos del evento.</param>
        private void Cb_Categoria_TextChanged(object sender, EventArgs e) 
        {

            String cadenaBusqueda = this.vista.cb_Categoria.Text;

            if (cadenaBusqueda == "Todos")
            {

                this.vista.dgv_TablaProductos.Rows.Clear();
                List<Producto> productos1 = this.productoDAO.ReadAll();
                foreach (Producto xProducto in productos1)
                {
                    this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Medida,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1
                    );
                }
            }
            else {
                List<Producto> productos = this.productoDAO.ReadByCategoria(cadenaBusqueda);
                this.vista.dgv_TablaProductos.Rows.Clear();
                foreach (Producto xProducto in productos)
                {
                    this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Medida,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1
                    );
                }
            }  
        }

        /// <summary> Maneja el evento CellFormatting del control Dgv_TablaProductos. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="DataGridViewCellFormattingEventArgs"/> que contiene los datos del evento.</param>
        private void Dgv_TablaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) 
        {
            if (this.vista.dgv_TablaProductos.Columns[e.ColumnIndex].Name.Equals("col_CantidadAgregar"))
            {
                //Asegúrese de que el valor sea una cadena.
                String stringValue = e.Value as string;

                if (stringValue == null) return;

                e.Value = String.Format("{0:0.##}", e.Value);
            }
        }

        /// <summary> Maneja el evento EditingControlShowing del control Dgv_TablaProductos.</summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="DataGridViewEditingControlShowingEventArgs"/> que contiene los datos del evento.</param>
        private void Dgv_TablaProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (this.vista.dgv_TablaProductos.CurrentCell.ColumnIndex == 5) 
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                   
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);

                }
            }
        }

        /// <summary> Maneja el evento KeyPress del control Columns. </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="KeyPressEventArgs"/> que contiene los datos del evento.</param>
        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = this.vista.dgv_TablaProductos.CurrentCell.RowIndex;
            if (Equals(this.vista.dgv_TablaProductos.Rows[index].Cells["col_TipoMedida"].Value, true))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }        
        }

        /// <summary> Maneja el evento CellContentClick del control Dgv_TablaProductos.</summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e"> La instancia <see cref="DataGridViewCellEventArgs"/> que contiene los datos del evento.</param>
        private void Dgv_TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_AgregarCarrito"].Selected)
            {
                int index = this.vista.dgv_TablaProductos.CurrentCell.RowIndex;
                Producto xProducto = new Producto
                {
                    Codigo_barra = Int64.Parse(
                        this.vista.dgv_TablaProductos.Rows[index].Cells["col_CodigoBarra"].Value.ToString()),
                    Precio_venta = Convert.ToDouble(
                                this.vista.dgv_TablaProductos.Rows[index].Cells["col_Precio"].Value.ToString()),
                    Cantidad_actual = Convert.ToDouble(
                                this.vista.dgv_TablaProductos.Rows[index].Cells["col_CantidadAgregar"].Value.ToString())
                };

                Producto producto = this.productoDAO.ReadById(xProducto.Codigo_barra);
                if (xProducto.Cantidad_actual > producto.Cantidad_actual)
                {
                    Form mensajeError = new FrmError("No hay cantidad suficiente de este producto.");
                    mensajeError.ShowDialog();
                    return;
                }
                else {
                    long x = Int64.Parse(this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_CodigoBarra"].Value.ToString());
                    double a = Double.Parse(this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_CantidadAgregar"].Value.ToString());
                    this.cventas.AgregarProducto(x, a);
                }             
            }          
        }
    }
}
