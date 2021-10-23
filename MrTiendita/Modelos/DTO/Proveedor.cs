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
        private String metodo_pago;

        public Proveedor(int id_proveedor, string nombre, long telefono, string metodo_pago)
        {
            this.id_proveedor = id_proveedor;
            this.nombre = nombre;
            this.telefono = telefono;
            this.metodo_pago = metodo_pago;
        }

        public int Id_proveedor { get => this.id_proveedor; set => this.id_proveedor = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public long Telefono { get => this.telefono; set => this.telefono = value; }
        public string Metodo_pago { get => this.metodo_pago; set => this.metodo_pago = value; }
    }
}
