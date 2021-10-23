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
        private int id_proveedor;
        private int no_factura;
        private DateTime fecha; //Formato para fechas en SQL Server yyyy-mm-dd hh:mm:ss
        private int cantidad;
        private double importe;

        public EntradaAlmacen()
        {
        }

        public EntradaAlmacen(int id_entrada, long codigo_barra, int id_proveedor, int no_factura, DateTime fecha, int cantidad, double importe)
        {
            this.id_entrada = id_entrada;
            this.codigo_barra = codigo_barra;
            this.id_proveedor = id_proveedor;
            this.no_factura = no_factura;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.importe = importe;
        }

        public int Id_entrada { get => this.id_entrada; set => this.id_entrada = value; }
        public long Codigo_barra { get => this.codigo_barra; set => this.codigo_barra = value; }
        public int Id_proveedor { get => this.id_proveedor; set => this.id_proveedor = value; }
        public int No_factura { get => this.no_factura; set => this.no_factura = value; }
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public double Importe { get => this.importe; set => this.importe = value; }
    }
}
