using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    public class Producto
    {
        private long codigo_barra;
        private String descripcion;
        private double precio_venta;
        private double precio_compra;
        private double cantidad_actual;
        private bool medida; //false es medida por unidad, true por kilos

        public Producto()
        {

        }
        public Producto(long codigo_barra, string descripcion, double precio_venta, double precio_compra, double cantidad_actual, bool medida)
        {
            this.codigo_barra = codigo_barra;
            this.descripcion = descripcion;
            this.precio_venta = precio_venta;
            this.precio_compra = precio_compra;
            this.cantidad_actual = cantidad_actual;
            this.medida = medida;
        }

        public long Codigo_barra {
            get { return this.codigo_barra; }
            set { this.codigo_barra = value; }
        }

        public String Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public double Precio_venta
        {
            get { return this.precio_venta; }
            set { this.precio_venta = value; }
        }
        public double Cantidad_actual
        {
            get { return this.cantidad_actual; }
            set { this.cantidad_actual = value; }
        }

        public double Precio_compra { get => this.precio_compra; set => this.precio_compra = value; }

        public bool Medida { get => this.medida; set => this.medida = value; }
    }
}
