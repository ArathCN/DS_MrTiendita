using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    class Movimiento
    {
        private int id_movimiento;
        private String tipo;
        private DateTime fecha;
        private double importe;
        private double caja;
        private String concepto;

        public Movimiento()
        {

        }

        public Movimiento(int id, String tipo, DateTime fecha, double importe, double caja, String concepto)
        {
            this.id_movimiento = id;
            this.tipo = tipo;
            this.fecha = fecha;
            this.importe = importe;
            this.caja = caja;
            this.Concepto = concepto;
        }

        public int Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Importe { get => importe; set => importe = value; }
        public double Caja { get => caja; set => caja = value; }
        public string Concepto { get => concepto; set => concepto = value; }
    }
}
