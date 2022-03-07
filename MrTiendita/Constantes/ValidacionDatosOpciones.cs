
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Componentes;

namespace MrTiendita.Constantes
{
    /// <summary>
    /// Clase que contiene constantes de opciones para la validación de datos en <see cref="ValidacionDatos"/>.
    /// </summary>
    public static class ValidacionDatosOpciones
    {
        /// <summary>
        /// Constante opción POSITIVO = 1.
        /// </summary>
        public static int POSITIVO = 1;
        /// <summary>
        /// Constante opción NEGATIVO = 2.
        /// </summary>
        public static int NEGATIVO = 2;
        /// <summary>
        /// Constante opción MAYOR_A = 3.
        /// </summary>
        public static int MAYOR_A = 3;
        /// <summary>
        /// Constante opción MENOR_A = 4.
        /// </summary>
        public static int MENOR_A = 4;
        /// <summary>
        /// Constante opción NUM_DECIMALES = 5, esta opción redondea el número a validar.
        /// </summary>
        public static int NUM_DECIMALES = 5;
        /// <summary>
        /// Constante opción NUM_DECIMALES_NO_ROUND = 11, esta opción sólo limita el número de decimales.
        /// </summary>
        public static int NUM_DECIMALES_NO_ROUND = 11;
        /// <summary>
        /// Constante opción MAYOR_IGUAL_A = 6.
        /// </summary>
        public static int MAYOR_IGUAL_A = 6;
        /// <summary>
        /// Constante opción MENOR_IGUAL_A = 7.
        /// </summary>
        public static int MENOR_IGUAL_A = 7;

        /// <summary>
        /// Constante opción NUM_MINIMO_CARACTERES = 8.
        /// </summary>
        public static int NUM_MINIMO_CARACTERES = 8;
        /// <summary>
        /// Constante opción NUM_MAXIMO_CARACTERES = 9.
        /// </summary>
        public static int NUM_MAXIMO_CARACTERES = 9;
        /// <summary>
        /// Constante opción NUM_CARACTERES = 12.
        /// </summary>
        public static int NUM_CARACTERES = 12;
        /// <summary>
        /// Constante opción PATRON = 10.
        /// </summary>
        public static int PATRON = 10;
    }
}
