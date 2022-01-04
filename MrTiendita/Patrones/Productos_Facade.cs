using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;
using MrTiendita.Componentes;
using MrTiendita.Constantes;
using System.Windows.Forms;

namespace Acciones
{
    class Productos_Facade
    {
        private Productos productos = new Productos();
        public bool Agregar(Producto producto)
        {
            return productos.Agregar(producto);
        }
        public bool Modificar(Producto producto, long id)
        {
            return productos.Actualizar(producto, id);
        }
        public void Eliminar(frmEAlmacen vista, DataGridViewCellEventArgs e)
        {
            productos.Eliminar(vista, e);
        }
        public void Consultar(frmEAlmacen vista)
        {
            productos.Consultar(vista);
        }
    }
}
