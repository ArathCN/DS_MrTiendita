using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Constantes
{
    /// <summary> Creamos la clase para las categorías. </summary>
    public static class Categorias
    {
        /// <summary> La categoría de Todos. </summary>
        public static Categoria TODOS = new Categoria(0, "Todos");
        /// <summary> La categoría de Frutas y Verduras. </summary>
        public static Categoria FRUTAS_VERDURAS = new Categoria(1, "Frutas y verduras");
        /// <summary> La categoría de Panaderia y Tortilleria </summary>
        public static Categoria PANADERIA_TORTILLERIA = new Categoria(2, "Panadería y tortillería");
        /// <summary> La categoría de Carniceria </summary>
        public static Categoria CARNICERIA = new Categoria(3, "Carnicería");
        /// <summary> La categoría de Lacteos </summary>
        public static Categoria LACTEOS = new Categoria(4, "Lácteos");
        /// <summary> La categoría de Abarrotes </summary>
        public static Categoria ABARROTES = new Categoria(5, "Abarrotes");
        /// <summary> La categoría de Limpiezas y Hogar </summary>
        public static Categoria LIMPIEZA_HOGAR = new Categoria(6, "Limpieza y hogar");
        /// <summary> La categoría de Higene personal y Salud </summary>
        public static Categoria HIGENE_PERSONAL_SALUD = new Categoria(7, "Higiene personal y salud");
        /// <summary> La categoría de Mascotas </summary>
        public static Categoria MASCOTAS = new Categoria(8, "Mascotas");
        /// <summary> La categoría de Refrigerados </summary>
        public static Categoria REFRIGERADOS = new Categoria(9, "Refrigerados");
        /// <summary> La categoría ded Sin Categoría </summary>
        public static Categoria SIN_CATEGORIA = new Categoria(10, "Sin categoría");

        /// <summary> Lista de las categorias. </summary>
        public static List<Categoria> CATEGORIAS = new List<Categoria>
        {
            TODOS, FRUTAS_VERDURAS, PANADERIA_TORTILLERIA, CARNICERIA, LACTEOS, ABARROTES, LIMPIEZA_HOGAR, HIGENE_PERSONAL_SALUD,
            MASCOTAS, REFRIGERADOS, SIN_CATEGORIA
        };

    }

    /// <summary> Creamos la clase de la categoría. </summary>
    public class Categoria
    {
        /// <summary> La clave </summary>
        private int clave;
        /// <summary> El nombre </summary>
        private string nombre;

        /// <summary> Iniciamos una nueva instancia para la clase <see cref="Categoria"/>. </summary>
        /// <param name="key">La key.</param>
        /// <param name="nombre">El nombre.</param>
        public Categoria(int key, string nombre)
        {
            this.clave = key;
            this.nombre = nombre;
        }

        private Categoria() { }

        /// <summary> Gets o sets para clave. </summary>
        /// <value> La clave de la categoría. </value>
        public int Clave { get => clave; set => clave = value; }
        /// <summary> Gets o sets para el nombre. </summary>
        /// <value> El nombrecde la categoría. </value>
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
