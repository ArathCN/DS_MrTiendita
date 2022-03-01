using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Componentes
{
    static public class ValidacionFormulario
    {
        static public bool Validar(Label etiqueta, String mensaje, String dato, out double dato_double, Dictionary<int, double> opciones = null)
        {
            bool EsValido = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out dato_double, opciones)) {
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
                if (!ValidacionDatos.Numero(dato, out dato_double))
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

        static public bool Validar(Label etiqueta, String mensaje, String dato, out long dato_double, Dictionary<int, long> opciones = null)
        {
            bool EsValido = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out dato_double, opciones))
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
                if (!ValidacionDatos.Numero(dato, out dato_double))
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

        static public bool Validar(Label etiqueta, String mensaje, String dato, Dictionary<int, int> opciones = null, String patron = null)
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
