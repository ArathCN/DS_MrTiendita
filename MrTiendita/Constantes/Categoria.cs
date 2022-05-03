using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Constantes
{
    public static class Categorias
    {
        public static Categoria FRUTAS_VERDURAS = new Categoria(1, "Frutas y verduras");
        public static Categoria PANADERIA_TORTILLERIA = new Categoria(2, "Panadería y tortillería");
        public static Categoria CARNICERIA = new Categoria(3, "Carnicería");
        public static Categoria LACTEOS = new Categoria(4, "Lácteos");
        public static Categoria ABARROTES = new Categoria(5, "Abarrotes");
        public static Categoria LIMPIEZA_HOGAR = new Categoria(6, "Limpieza y hogar");
        public static Categoria HIGENE_PERSONAL_SALUD = new Categoria(7, "Higiene personal y salud");
        public static Categoria MASCOTAS = new Categoria(8, "Mascotas");
        public static Categoria REFRIGERADOS = new Categoria(9, "Refrigerados");
        public static Categoria SIN_CATEGORIA = new Categoria(0, "Sin categoría");
        //public static Categoria ABARROTES = "Abarrotes";
        //public static Categoria LIMPIEZA_HOGAR = "Limpieza y hogar";
        //public static Categoria HIGENE_PERSONAL_SALUD = "Higiene personal y salud";
        //public static Categoria MASCOTAS = "Mascotas";
        //public static Categoria REFRIGERADOS = "Refrigerados";
        //public static Categoria SIN_CATEGORIA = "Sin categoría";

        public static List<Categoria> CATEGORIAS = new List<Categoria>
        {
            FRUTAS_VERDURAS, PANADERIA_TORTILLERIA, CARNICERIA, LACTEOS, ABARROTES, LIMPIEZA_HOGAR, HIGENE_PERSONAL_SALUD,
            MASCOTAS, REFRIGERADOS, SIN_CATEGORIA
        };

    }

    public class Categoria
    {
        private int clave;
        private string nombre;

        public Categoria(int key, string nombre)
        {
            this.clave = key;
            this.nombre = nombre;
        }

        private Categoria() { }

        public int Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
