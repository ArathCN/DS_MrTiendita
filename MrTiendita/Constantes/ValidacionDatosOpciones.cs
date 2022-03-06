
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Constantes
{
    /// <summary>
    /// Creamos la clase de tipo de validación de datos.
    /// </summary>
    public static class ValidacionDatosOpciones
    {
        public static int POSITIVO = 1;
        public static int NEGATIVO = 2;
        public static int MAYOR_A = 3;
        public static int MENOR_A = 4;
        public static int NUM_DECIMALES = 5;
        public static int NUM_DECIMALES_NO_ROUND = 11;
        public static int MAYOR_IGUAL_A = 6;
        public static int MENOR_IGUAL_A = 7;

        //para cadenas
        public static int NUM_MINIMO_CARACTERES = 8;
        public static int NUM_MAXIMO_CARACTERES = 9;
        public static int NUM_CARACTERES = 12;
        public static int PATRON = 10;
    }
}
