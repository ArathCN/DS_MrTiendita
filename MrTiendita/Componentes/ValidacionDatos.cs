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
        public static bool esValido = false;
        public static String mensajes = "";

        public static bool NoVacio(String dato)
        {
            ValidacionDatos.esValido = false;
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

        public static bool Cadena(String dato, Dictionary<int, int> opciones = null, String patron = "")
        {
            if (!ValidacionDatos.NoVacio(dato)) return false;
            if (opciones != null)
            {
                if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
                {
                    if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                    {
                        ValidacionDatos.mensajes = "Número de caracteres minimo no superado: " + opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES];
                        ValidacionDatos.esValido = true;
                        return false;
                    }
                }

                if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES))
                {
                    if (dato.Length > opciones[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES])
                    {
                        ValidacionDatos.mensajes = "Número de caracteres maximo superado:" + opciones[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES];
                        ValidacionDatos.esValido = true;
                        return false;
                    }
                }
            }

            if (patron != "")
            {
                if(!Regex.Match(dato, patron, RegexOptions.IgnoreCase).Success)
                {
                    ValidacionDatos.mensajes = "La cadena";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            return true;
        }

        public static bool Numero(String dato, out long datoSalida)
        {
            long datoEnNumero;

            datoSalida = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int64.TryParse(dato, out datoEnNumero))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.esValido = true;
                return false;
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }

        public static bool Numero(String dato, out long datoSalida, Dictionary<int, long> opciones)
        {
            long datoEnNumero;

            datoSalida = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int64.TryParse(dato, out datoEnNumero))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.esValido = true;
                return false;
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_CARACTERES))
            {
                if (dato.Length != opciones[ValidacionDatosOpciones.NUM_CARACTERES])
                {
                    ValidacionDatos.mensajes = "El número de caracteres debe ser igual a " + opciones[ValidacionDatosOpciones.NUM_CARACTERES];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (datoEnNumero <= opciones[ValidacionDatosOpciones.MAYOR_A])
                {
                    ValidacionDatos.mensajes = "Dato no mayor al número minimo especificado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_IGUAL_A))
            {
                if (datoEnNumero < opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser mayor o igual a " + opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (datoEnNumero >= opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "Dato mayor al número maximo especificado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_IGUAL_A))
            {
                if (datoEnNumero > opciones[ValidacionDatosOpciones.MENOR_IGUAL_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser menor o igual que " + opciones[ValidacionDatosOpciones.MENOR_IGUAL_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }

        public static bool Numero(String dato, out double datoSalida)
        {

            double datoEnNumero;

            datoSalida = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Double.TryParse(dato, out datoEnNumero))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.esValido = true;
                return false;
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }

        public static bool Numero(String dato, out double datoSalida, Dictionary<int, Double> opciones)
        {

            double datoEnNumero;

            datoSalida = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Double.TryParse(dato, out datoEnNumero))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.esValido = true;
                return false;
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (datoEnNumero <= opciones[ValidacionDatosOpciones.MAYOR_A]) {
                    ValidacionDatos.mensajes = "El número debe ser mayor a " + opciones[ValidacionDatosOpciones.MAYOR_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_IGUAL_A))
            {
                if (datoEnNumero < opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser mayor o igual a " + opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (datoEnNumero >= opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser menor que " + opciones[ValidacionDatosOpciones.MENOR_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_IGUAL_A))
            {
                if (datoEnNumero > opciones[ValidacionDatosOpciones.MENOR_IGUAL_A])
                {
                    ValidacionDatos.mensajes = "El número debe ser menor o igual que " + opciones[ValidacionDatosOpciones.MENOR_IGUAL_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_DECIMALES))
            {
                datoEnNumero = Math.Round(double_dato, (int) opciones[ValidacionDatosOpciones.NUM_DECIMALES]);
            }
            
            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND))
            {
                int numeroDecimales = (int)opciones[ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND];
                String expRegNumeroDecimales = "^[0-9]*(?:\\.[0-9]{1," + numeroDecimales + "})?$";
                
                if (!Regex.Match(dato, expRegNumeroDecimales).Success)
                {
                    ValidacionDatos.mensajes = "El número debe tener maximo " + numeroDecimales + " decimales.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }

        public static bool Numero(String dato, out int datoSalida)
        {

            int datoEnNumero;

            datoSalida = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int32.TryParse(dato, out datoEnNumero))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.esValido = true;
                return false;
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }

        public static bool Numero(String dato, out int datoSalida, Dictionary<int, int> opciones)
        {
            int datoEnNumero;

            datoSalida = -1;

            if (!ValidacionDatos.NoVacio(dato)) return false;

            if (!Int32.TryParse(dato, out datoEnNumero))
            {
                ValidacionDatos.mensajes = "Dato no numerico.";
                ValidacionDatos.esValido = true;
                return false;
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
            {
                if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                {
                    ValidacionDatos.mensajes = "Número de caracteres minimo no superado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MAYOR_A))
            {
                if (datoEnNumero < opciones[ValidacionDatosOpciones.MAYOR_A])
                {
                    ValidacionDatos.mensajes = "Dato no mayor al número minimo especificado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.MENOR_A))
            {
                if (datoEnNumero > opciones[ValidacionDatosOpciones.MENOR_A])
                {
                    ValidacionDatos.mensajes = "Dato mayor al número maximo especificado.";
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }
    }
}
