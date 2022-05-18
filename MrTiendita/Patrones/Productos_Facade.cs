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

namespace MrTiendita.Patrones
{
    /// <summary> Clase que implementa el patrón Facade en <see cref="Producto"/> </summary>
    class Productos_Facade
    {
        /// <summary> Instancia de la clase auxiliar que define métodos de acciones sobre <see cref="Producto"/>. </summary>
        private Productos productos = new Productos();

        /// <summary> Llama al método <see cref="Productos.Agregar(Producto)"/> </summary>
        /// <param name="producto">El producto a agregar a la base de datos.</param>
        /// <returns>Retorna lo mismo que <see cref="Productos.Agregar(Producto)"/></returns>
        public bool Agregar(Producto producto)
        {
            return productos.Agregar(producto);
        }

        /// <summary> Llama el método <see cref="Productos.Actualizar(Producto, long)"/> </summary>
        /// <param name="producto">Los datos nuevos a actualizar.</param>
        /// <param name="id">El id a buscar.</param>
        /// <returns>Retorna lo mismo que <see cref="Productos.Actualizar(Producto, long)"/></returns>
        public bool Modificar(Producto producto, long id)
        {
            return productos.Actualizar(producto, id);
        }

        /// <summary> Llaama al método <see cref="Productos.Eliminar(FrmInventario, DataGridViewCellEventArgs)"/> </summary>
        /// <param name="vista">El formulario con la tabla de productos a eliminar.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        public void Eliminar(FrmInventario vista, DataGridViewCellEventArgs e)
        {
            productos.Eliminar(vista, e);
        }

        /// <summary> Llama al método <see cref="Productos.Consultar(FrmInventario)"/> </summary>
        /// <param name="vista">Formulario con la tabla a desplegar los registros.</param>
        public void Consultar(FrmInventario vista)
        {
            productos.Consultar(vista);
        }
    }
}
