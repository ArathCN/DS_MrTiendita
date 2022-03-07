using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MrTiendita.Constantes;

namespace MrTiendita.Componentes
{
    /// <summary>
    /// Clase que define métodos para validar datos para <see cref="Int32"/>, <see cref="Int64"/>, <see cref="Double"/> y <see cref="String"/>.
    /// Usa las constantes de la clase <see cref="ValidacionDatosOpciones"/> para especificar opciones de validación.
    /// </summary>
    public static class ValidacionDatos
    {
        /// <summary><see cref="Boolean"/> que indica si la última validación fue exitosa o no cumplió con las opciones indicadas.</summary>
        public static bool esValido = false;

        /// <summary><see cref="String"/> que contiene el mensaje de error que generó la ultima validación.</summary>
        public static String mensajes = "";

        /// <summary>Comprueba si un valor <see cref="String"/> es vacío o no.</summary>
        /// <param name="dato"><see cref="String"/> a comprobar.</param>
        /// <returns><see cref="Boolean"/> true si la cadena no está vacía, false si está vacía.</returns>
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

        /// <summary>Comprueba si una cadena está vacía o no, usa <see cref="NoVacio(string)"/> para comprobar.</summary>
        /// <param name="dato"><see cref="String"/> a comprobar.</param>
        /// <returns><see cref="Boolean"/> true si la cadena no está vacía, false si está vacía.</returns>
        public static bool Cadena(String dato)
        {
            if (!ValidacionDatos.NoVacio(dato)) return false;

            return true;
        }

        /// <summary>Comprueba un <see cref="String"/> usando opciones de validación y una expresión regular como patrón.
        /// Si no se especifican opciones ni patrón es similar a <see cref="Cadena(string)"/>
        /// </summary>
        /// <param name="dato"><see cref="String"/> a comprobar.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/> que contiene las opciones como llaves y los límites como valores.
        /// Si no se especifica se usa el valor null.
        /// </param>
        /// <param name="patron">Expresión regular que debe de cumplir la cadena a comprobar.
        /// Si no se especifica se toma una cadena vacía como valor y no se comprueba el patrón.
        /// </param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
        public static bool Cadena(String dato, Dictionary<int, int> opciones = null, String patron = "")
        {
            if (!ValidacionDatos.NoVacio(dato)) return false;
            if (opciones != null)
            {
                if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MINIMO_CARACTERES))
                {
                    if (dato.Length < opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES])
                    {
                        ValidacionDatos.mensajes = "Número de caracteres minimo no superado: " +
                            opciones[ValidacionDatosOpciones.NUM_MINIMO_CARACTERES];
                        ValidacionDatos.esValido = true;
                        return false;
                    }
                }

                if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES))
                {
                    if (dato.Length > opciones[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES])
                    {
                        ValidacionDatos.mensajes = "Número de caracteres maximo superado:" +
                            opciones[ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES];
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

        /// <summary>Comprueba un si una cadena es valida como <see cref="Int64"/> y regresa el valor en dicho tipo.</summary>
        /// <param name="dato"><see cref="String"/> que se quiere validar.</param>
        /// <param name="datoSalida"><see cref="Int64"/> al que se regresa el valor convertido.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
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

        /// <summary>Comprueba un si una cadena es valida como <see cref="Int64"/> usando opciones de validación
        /// y regresa el valor en dicho tipo.
        /// Si no se especifican opciones es similar a <see cref="Numero(string, out long)"/>.
        /// </summary>
        /// <param name="dato"><see cref="String"/> que se quiere validar.</param>
        /// <param name="datoSalida"><see cref="Int64"/> al que se regresa el valor convertido.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/>  que contiene <see cref="ValidacionDatosOpciones"/> 
        /// como llaves y los límites <see cref="Int64"/> como valores.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
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
                    ValidacionDatos.mensajes = "El número de caracteres debe ser igual a " +
                        opciones[ValidacionDatosOpciones.NUM_CARACTERES];
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
                    ValidacionDatos.mensajes = "El número debe ser mayor o igual a " +
                        opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A];
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
                    ValidacionDatos.mensajes = "El número debe ser menor o igual que " +
                        opciones[ValidacionDatosOpciones.MENOR_IGUAL_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            ValidacionDatos.esValido = false;
            ValidacionDatos.mensajes = "";
            datoSalida = datoEnNumero;
            return true;
        }

        /// <summary>Comprueba un si una cadena es valida como <see cref="Double"/> y regresa el valor en dicho tipo.</summary>
        /// <param name="dato"><see cref="String"/> que se quiere validar.</param>
        /// <param name="datoSalida"><see cref="Double"/> al que se regresa el valor convertido.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
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

        /// <summary>Comprueba un si una cadena es valida como <see cref="Double"/> usando opciones de validación y regresa el valor en dicho tipo.
        /// Si no se especifican opciones es similar a <see cref="Numero(string, out double)"/>
        /// </summary>
        /// <param name="dato"><see cref="String"/> que se quiere validar.</param>
        /// <param name="datoSalida"><see cref="Double"/> al que se regresa el valor convertido.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/>  que contiene <see cref="ValidacionDatosOpciones"/> 
        /// como llaves y los límites <see cref="Double"/> como valores.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
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
                    ValidacionDatos.mensajes = "El número debe ser mayor o igual a " +
                        opciones[ValidacionDatosOpciones.MAYOR_IGUAL_A];
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
                    ValidacionDatos.mensajes = "El número debe ser menor o igual que " +
                        opciones[ValidacionDatosOpciones.MENOR_IGUAL_A];
                    ValidacionDatos.esValido = true;
                    return false;
                }
            }

            if (opciones.ContainsKey(ValidacionDatosOpciones.NUM_DECIMALES))
            {
                datoEnNumero = Math.Round(datoEnNumero, (int) opciones[ValidacionDatosOpciones.NUM_DECIMALES]);
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

        /// <summary>Comprueba un si una cadena es valida como <see cref="Int32"/> y regresa el valor en dicho tipo.</summary>
        /// <param name="dato"><see cref="String"/> que se quiere validar.</param>
        /// <param name="datoSalida"><see cref="Int32"/> al que se regresa el valor convertido.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
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

        /// <summary>Comprueba un si una cadena es valida como <see cref="Int32"/> usando opciones de validación y regresa el valor en dicho tipo.
        /// Si no se especifican opciones es similar a <see cref="Numero(string, out int)"/>
        /// </summary>
        /// <param name="dato"><see cref="String"/> que se quiere validar..</param>
        /// <param name="datoSalida"><see cref="Int32"/> al que se regresa el valor convertido.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/>  que contiene <see cref="ValidacionDatosOpciones"/> 
        /// como llaves y los límites <see cref="Int32"/> como valores.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
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
