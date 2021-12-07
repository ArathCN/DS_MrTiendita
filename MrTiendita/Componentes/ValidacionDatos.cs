using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (!String.IsNullOrEmpty(dato)) return true;
            else
            {
                ValidacionDatos.mensajes = "Dato vacío o nulo.";
                return false;
            } 
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
            

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (double_dato < opciones[ValidacionDatosOpciones.MAYOR_A]) {
                    ValidacionDatos.mensajes = "Dato no mayor al número minimo especificado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (double_dato > opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "Dato mayor al número maximo especificado.";
                    ValidacionDatos.error = true;
                    return false;
                }
            }

            dato_double = double_dato;
            return true;
        }
    }
}
