using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    public class Venta
    {
        private int id_venta;
        private long codigo_barra;
        private int id_empleado;
        private String metodo_pago;
        private DateTime fecha;
        private int cantidad;
        private float importe;

        public Venta(int id_venta, long codigo_barra, int id_empleado, string metodo_pago, DateTime fecha, int cantidad, float importe)
        {
            this.id_venta = id_venta;
            this.codigo_barra = codigo_barra;
            this.id_empleado = id_empleado;
            this.metodo_pago = metodo_pago;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.importe = importe;
        }

        public int Id_venta { get => this.id_venta; set => this.id_venta = value; }
        public long Codigo_barra { get => this.codigo_barra; set => this.codigo_barra = value; }
        public int Id_empleado { get => this.id_empleado; set => this.id_empleado = value; }
        public string Metodo_pago { get => this.metodo_pago; set => this.metodo_pago = value; }
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public float Importe { get => this.importe; set => this.importe = value; }
    }
}
