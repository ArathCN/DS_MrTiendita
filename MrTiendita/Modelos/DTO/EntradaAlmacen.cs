using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    public class EntradaAlmacen
    {
        private int id_entrada;
        private long codigo_barra;
        private DateTime fecha; //Formato para fechas en SQL Server yyyy-mm-dd hh:mm:ss
        private double cantidad;
        private double importe;
        private int id_proveedor;

        public EntradaAlmacen()
        {
        }

        public EntradaAlmacen(int id_entrada, long codigo_barra, DateTime fecha, double cantidad, double importe, int proveedor)
        {
            this.id_entrada = id_entrada;
            this.codigo_barra = codigo_barra;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.importe = importe;
            this.Id_proveedor = proveedor;
        }

        public int Id_entrada { get => this.id_entrada; set => this.id_entrada = value; }
        public long Codigo_barra { get => this.codigo_barra; set => this.codigo_barra = value; }
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        public double Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public double Importe { get => this.importe; set => this.importe = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
    }
}
