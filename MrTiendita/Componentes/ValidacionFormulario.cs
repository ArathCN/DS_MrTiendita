using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Constantes;

namespace MrTiendita.Componentes
{
    /// <summary>Clase que define métodos para validar datos e imprimir el error en una <see cref="Label"/>.</summary>
    static public class ValidacionFormulario
    {
        /// <summary>Comprueba si una cadena es valida como <see cref="Double"/>, regresa el valor en dicho tipo 
        /// y si hay un error lo imprime es una <see cref="Label"/> especificada.
        /// Además, se pueden incluir opciones de validación.</summary>
        /// <param name="etiqueta"><see cref="Label"/> en la que se mostrará el mensaje de error si hay uno.</param>
        /// <param name="mensaje"><see cref="String"/> que contiene el error a mostrar si ocurre un error.</param>
        /// <param name="dato"><see cref="String"/> a comprobar.</param>
        /// <param name="datoSalida"><see cref="Double"/> al que se regresa el valor convertido.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/>  que contiene <see cref="ValidacionDatosOpciones"/> 
        /// como llaves y los límites <see cref="Double"/> como valores.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
        static public bool Validar(
            Label etiqueta,
            String mensaje,
            String dato,
            out double datoSalida,
            Dictionary<int, double> opciones = null)
        {
            bool EsValido = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out datoSalida, opciones)) {
                    etiqueta.Text = mensaje;
                    etiqueta.Visible = true;
                }
                else
                {
                    etiqueta.Text = "";
                    etiqueta.Visible = false;
                    EsValido = true;
                }
            else
                if (!ValidacionDatos.Numero(dato, out datoSalida))
                {
                    etiqueta.Text = mensaje;
                    etiqueta.Visible = true;
                }
                else {
                    etiqueta.Text = "";
                    etiqueta.Visible = false;
                    EsValido = true;
                } 

            return EsValido;
        }

        /// <summary>Comprueba si una cadena es valida como <see cref="Int64"/>, regresa el valor en dicho tipo 
        /// y si hay un error lo imprime es una <see cref="Label"/> especificada.
        /// Además, se pueden incluir opciones de validación.</summary>
        /// <param name="etiqueta"><see cref="Label"/> en la que se mostrará el mensaje de error si hay uno.</param>
        /// <param name="mensaje"><see cref="String"/> que contiene el error a mostrar si ocurre un error.</param>
        /// <param name="dato"><see cref="String"/> a comprobar.</param>
        /// <param name="datoSalida"><see cref="Int64"/> al que se regresa el valor convertido.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/>  que contiene <see cref="ValidacionDatosOpciones"/> 
        /// como llaves y los límites <see cref="Int64"/> como valores.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
        static public bool Validar(
            Label etiqueta,
            String mensaje,
            String dato,
            out long datoSalida,
            Dictionary<int, long> opciones = null)
        {
            bool EsValido = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out datoSalida, opciones))
                {
                    etiqueta.Text = mensaje;
                    etiqueta.Visible = true;
                }
                else
                {
                    etiqueta.Text = "";
                    etiqueta.Visible = false;
                    EsValido = true;
                }
            else
                if (!ValidacionDatos.Numero(dato, out datoSalida))
            {
                etiqueta.Text = mensaje;
                etiqueta.Visible = true;
            }
            else
            {
                etiqueta.Text = "";
                etiqueta.Visible = false;
                EsValido = true;
            }

            return EsValido;
        }

        static public bool Validar(
            Label etiqueta,
            String mensaje,
            String dato,
            out int datoSalida,
            Dictionary<int, int> opciones = null)
        {
            bool EsValido = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out datoSalida, opciones))
                {
                    etiqueta.Text = mensaje;
                    etiqueta.Visible = true;
                }
                else
                {
                    etiqueta.Text = "";
                    etiqueta.Visible = false;
                    EsValido = true;
                }
            else
                if (!ValidacionDatos.Numero(dato, out datoSalida))
            {
                etiqueta.Text = mensaje;
                etiqueta.Visible = true;
            }
            else
            {
                etiqueta.Text = "";
                etiqueta.Visible = false;
                EsValido = true;
            }

            return EsValido;
        }

        /// <summary>Comprueba si una cadena <see cref="String"/> no es vacía
        /// y si hay un error lo imprime es una <see cref="Label"/> especificada.
        /// Además, se pueden incluir opciones de validación y una expresión regular como patrón.</summary>
        /// <param name="etiqueta"><see cref="Label"/> en la que se mostrará el mensaje de error si hay uno.</param>
        /// <param name="mensaje"><see cref="String"/> que contiene el error a mostrar si ocurre un error.</param>
        /// <param name="dato"><see cref="String"/> a comprobar.</param>
        /// <param name="opciones"><see cref="Dictionary{TKey, TValue}"/>  que contiene <see cref="ValidacionDatosOpciones"/> 
        /// como llaves y los límites <see cref="Int32"/> como valores.</param>
        /// <param name="patron"><see cref="String"/> que contiene una expresión regular que la cadena debe de cumplir.</param>
        /// <returns><see cref="Boolean"/> true si la cadena es valida, false si la cadena no es valida.</returns>
        static public bool Validar(
            Label etiqueta,
            String mensaje,
            String dato,
            Dictionary<int, int> opciones = null,
            String patron = null)
        {
            bool EsValido = false;
            if (patron == null) patron = "";
            if (!ValidacionDatos.Cadena(dato, opciones, patron))
            {
                etiqueta.Text = mensaje;
                etiqueta.Visible = true;
            }
            else
            {
                etiqueta.Text = "";
                etiqueta.Visible = false;
                EsValido = true;
            }
            return EsValido;
        }
    }
}
