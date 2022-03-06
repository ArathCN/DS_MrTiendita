using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Componentes
{
    /// <summary>Clase de Validación de Formulario.</summary>
    static public class ValidacionFormulario
    {
        /// <summary>Validar la etiqueta especificada.</summary>
        /// <param name="etiqueta">La etiqueta.</param>
        /// <param name="mensaje">El mensaje.</param>
        /// <param name="dato">El dato.</param>
        /// <param name="datoSalida">El dato de salida.</param>
        /// <param name="opciones">Las opciones.</param>
        /// <returns>Si es valido.</returns>
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

        /// <summary> Validar la etiqueta especificada. </summary>
        /// <param name="etiqueta">The etiqueta.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <param name="dato">The dato.</param>
        /// <param name="datoSalida">The dato salida.</param>
        /// <param name="opciones">The opciones.</param>
        /// <returns>Si es válido.</returns>
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

        /// <summary> Validar la etiqueta especificada. </summary>
        /// <param name="etiqueta">The etiqueta.</param>
        /// <param name="mensaje">The mensaje.</param>
        /// <param name="dato">The dato.</param>
        /// <param name="opciones">The opciones.</param>
        /// <param name="patron">The patron.</param>
        /// <returns>Booleano.</returns>
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
