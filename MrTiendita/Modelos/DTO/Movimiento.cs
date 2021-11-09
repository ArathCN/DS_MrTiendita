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
        private String concepto;
        private DateTime fecha;
        private double importe;
        private double caja;

        public Movimiento()
        {

        }

        public Movimiento(int id, String tipo, String concepto, DateTime fecha, double importe, double caja)
        {
            this.id_movimiento = id;
            this.tipo = tipo;
            this.concepto = concepto;
            this.fecha = fecha;
            this.importe = importe;
            this.caja = caja;
        }

        public int Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Importe { get => importe; set => importe = value; }
        public double Caja { get => caja; set => caja = value; }
    }
}
