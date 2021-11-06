using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    public class Proveedor
    {
        private int id_proveedor;
        private String nombre;
        private long telefono;

        public Proveedor(int id_proveedor, string nombre, long telefono)
        {
            this.id_proveedor = id_proveedor;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public int Id_proveedor { get => this.id_proveedor; set => this.id_proveedor = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public long Telefono { get => this.telefono; set => this.telefono = value; }
    }
}
