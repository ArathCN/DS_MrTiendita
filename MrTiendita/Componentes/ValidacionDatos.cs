using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MrTiendita.Constantes;

namespace MrTiendita.Componentes
{
    public static class ValidacionDatos
    {


        public static bool error = false;
        public static String mensajes = "";

        public static bool NoVacio(String dato)
        {
            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            if (!String.IsNullOrEmpty(dato)) return true;
            else
            {
                ValidacionDatos.mensajes = "Dato vacío o nulo.";
                return false;
            } 
        }

        public static bool Cadena(String dato)
        {
            if (!ValidacionDatos.NoVacio(dato)) return false;

            return true;
        }

        public static bool Cadena(String dato, Dictionary<int, int> opciones, String patron = "")
        {
            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado: " + opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES];
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES))
            {
                if (dato.Length > opciones[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres maximo superado:" + opciones[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES];
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (patron != "")
            {
                if(!Regex.Match(dato, patron, RegexOptions.IgnoreCase).Success)
                {
                    ValidacionDatos.mensajes = "La cadena";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            return true;
        }

        public static bool Numero(String dato, out long dato_long)
        {
            long long_dato;

            dato_long = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int64.TryParse(dato, out long_dato))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.error = true;
                return false;
            }

            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            dato_long = long_dato;
            return true;
        }

        public static bool Numero(String dato, out long dato_long, Dictionary<int, long> opciones)
        {
            long long_dato;

            dato_long = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int64.TryParse(dato, out long_dato))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.error = true;
                return false;
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (long_dato < opciones[ValidacionDatosOpciones.MAYOR_A])
                {
                    ValidacionDatos.mensajes = "Dato no mayor al número minimo especificado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (long_dato > opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "Dato mayor al número maximo especificado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            dato_long = long_dato;
            return true;
        }

        public static bool Numero(String dato, out double dato_double)
        {

            double double_dato;

            dato_double = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Double.TryParse(dato, out double_dato))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.error = true;
                return false;
            }

            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            dato_double = double_dato;
            return true;
        }

        public static bool Numero(String dato, out double dato_double, Dictionary<int, Double> opciones)
        {

            double double_dato;

            dato_double = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Double.TryParse(dato, out double_dato))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.error = true;
                return false;
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (double_dato <= opciones[ValidacionDatosOpciones.MAYOR_A]) {
                    ValidacionDatos.mensajes = "El número debe ser mayor a " + opciones[ValidacionDatosOpciones.MAYOR_A];
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_IGUAL_A))
            {
                if (double_dato < opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser mayor o igual a " + opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A];
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (double_dato >= opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser menor que " + opciones[ValidacionDatosOpciones.MENOR_A];
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_IGUAL_A))
            {
                if (double_dato > opciones[ValidacionDatosOpciones.MENOR_IGUAL_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser menor o igual que " + opciones[ValidacionDatosOpciones.MENOR_IGUAL_A];
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_DECIMALES))
            {
                double_dato = Math.Round(double_dato, (int) opciones[ValidacionDatosOpciones.NUM_DECIMALES]);
            }

            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            dato_double = double_dato;
            return true;
        }

        public static bool Numero(String dato, out int dato_int)
        {

            int int_dato;

            dato_int = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int32.TryParse(dato, out int_dato))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.error = true;
                return false;
            }

            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            dato_int = int_dato;
            return true;
        }

        public static bool Numero(String dato, out int dato_int, Dictionary<int, int> opciones)
        {
            int int_dato;

            dato_int = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int32.TryParse(dato, out int_dato))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.error = true;
                return false;
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (int_dato < opciones[ValidacionDatosOpciones.MAYOR_A])
                {
                    ValidacionDatos.mensajes = "Dato no mayor al número minimo especificado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (int_dato > opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "Dato mayor al número maximo especificado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            ValidacionDatos.error = false;
            ValidacionDatos.mensajes = "";
            dato_int = int_dato;
            return true;
        }
    }
}
