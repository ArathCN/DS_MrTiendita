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
    public class FrmBuscarProductoController
    {
        private FrmBuscarProducto vista;
        private FrmCVentasController cventas;
        private ProductoDAO productoDAO;


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

        }

        private void Vista_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        protected void MostrarProductos()
        {
            this.vista.dgv_TablaProductos.Rows.Clear();
            List<Producto> productos = this.productoDAO.ReadAll();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1);
            }
        }

        private void Tb_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_BuscarProducto.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.dgv_TablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1);
            }
        }
        
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
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1);
                }
            }
            else {
                List<Producto> productos = this.productoDAO.ReadByCategoria(cadenaBusqueda);
                this.vista.dgv_TablaProductos.Rows.Clear();
                foreach (Producto xProducto in productos)
                {
                    this.vista.dgv_TablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Descripcion,
                    xProducto.Categoria,
                    xProducto.Precio_venta,
                    1);
                }
            }  
        }

       
        private void Dgv_TablaProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            

            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (this.vista.dgv_TablaProductos.CurrentCell.ColumnIndex == 4) 
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                }
            }
        }

        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Dgv_TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.dgv_TablaProductos.Rows[e.RowIndex].Cells["col_AgregarCarrito"].Selected)
            {
                int index = this.vista.dgv_TablaProductos.CurrentCell.RowIndex;
                //Console.WriteLine(index);
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
                //Console.Write(/*producto.Codigo_barra+*//*"  "+*/xProducto.Cantidad_actual);
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




 
 
 
 

 
 

