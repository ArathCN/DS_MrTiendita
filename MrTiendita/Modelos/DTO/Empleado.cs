using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    public class Empleado
    {
        private int id_empleado;
        private String nombre;
        private String a_paterno;
        private String a_materno;
        private int telefono;
        private decimal sueldo;
        private String tipo_empleado;
        private String clave;

        public Empleado()
        {
        }

        public Empleado(int id_empleado, string nombre, string a_paterno, string a_materno, int telefono, decimal sueldo, string tipo_empleado, string clave)
        {
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.a_paterno = a_paterno;
            this.a_materno = a_materno;
            this.telefono = telefono;
            this.sueldo = sueldo;
            this.tipo_empleado = tipo_empleado;
            this.clave = clave;
        }

        public int Id_empleado { get => this.id_empleado; set => this.id_empleado = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string A_paterno { get => this.a_paterno; set => this.a_paterno = value; }
        public string A_materno { get => this.a_materno; set => this.a_materno = value; }
        public int Telefono { get => this.telefono; set => this.telefono = value; }
        public decimal Sueldo { get => this.sueldo; set => this.sueldo = value; }
        public string Tipo_empleado { get => this.tipo_empleado; set => this.tipo_empleado = value; }
        public string Clave { get => this.clave; set => this.clave = value; }
    }
}
