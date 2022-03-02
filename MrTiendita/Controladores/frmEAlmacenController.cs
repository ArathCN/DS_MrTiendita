using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using System.Windows.Forms;
using MrTiendita.Vistas;
using Acciones;

namespace MrTiendita.Controladores
{
    class FrmEAlmacenController
    {
        private FrmEAlmacen vista;
        private ProductoDAO productoDAO;
        private Productos_Facade Productos = new Productos_Facade();

        public FrmEAlmacenController(FrmEAlmacen vista){
            this.vista = vista;
            this.productoDAO = new ProductoDAO();
            this.vista.tablaProductos.CellContentClick += new DataGridViewCellEventHandler(TablaProductos_CellContentClick);
            this.vista.Load += new EventHandler(Vista_load);
            this.vista.tb_busqueda.TextChanged += new EventHandler(Tb_busqueda_TextChanged);
            this.vista.btn_nuevoProducto.Click += new EventHandler(Btn_nuevoProducto_Click);
        }

        private void Vista_load(object sender, EventArgs e)
        {
            Productos.Consultar(this.vista);
        }

        private void Tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            String cadenaBusqueda = this.vista.tb_busqueda.Text;
            List<Producto> productos = this.productoDAO.ReadByName(cadenaBusqueda);
            this.vista.tablaProductos.Rows.Clear();
            foreach (Producto xProducto in productos)
            {
                this.vista.tablaProductos.Rows.Add(
                    xProducto.Codigo_barra,
                    xProducto.Cantidad_actual,
                    xProducto.Descripcion,
                    xProducto.Precio_venta,
                    xProducto.Precio_compra);
            }
        }

        private void TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.vista.tablaProductos.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                Productos.Eliminar(this.vista, e);
            }
            else if (this.vista.tablaProductos.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                this.ActualizarProducto(e);
            }
        }

        private void Btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            FrmProducto editar = new FrmProducto("agregar", -1);
            editar.ShowDialog();
            Productos.Consultar(this.vista);
        }

        private void ActualizarProducto(DataGridViewCellEventArgs e)
        {
            String idCadena = this.vista.tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            long id = long.Parse(idCadena);
            FrmProducto editar = new FrmProducto("editar", id);
            editar.ShowDialog();
            Productos.Consultar(this.vista);
        }
    }
}
