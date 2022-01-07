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
        static public bool Validar(Label lbl, String mensaje, String dato, out double dato_double, Dictionary<int, double> opciones = null)
        {
            bool res = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out dato_double, opciones)) {
                    lbl.Text = mensaje;
                    lbl.Visible = true;
                }
                else
                {
                    lbl.Text = "";
                    lbl.Visible = false;
                    res = true;
                }
            else
                if (!ValidacionDatos.Numero(dato, out dato_double))
                {
                    lbl.Text = mensaje;
                    lbl.Visible = true;
                }
                else {
                    lbl.Text = "";
                    lbl.Visible = false;
                    res = true;
                } 

            return res;
        }

        static public bool Validar(Label lbl, String mensaje, String dato, out long dato_double, Dictionary<int, long> opciones = null)
        {
            bool res = false;
            if (opciones != null)
                if (!ValidacionDatos.Numero(dato, out dato_double, opciones))
                {
                    lbl.Text = mensaje;
                    lbl.Visible = true;
                }
                else
                {
                    lbl.Text = "";
                    lbl.Visible = false;
                    res = true;
                }
            else
                if (!ValidacionDatos.Numero(dato, out dato_double))
            {
                lbl.Text = mensaje;
                lbl.Visible = true;
            }
            else
            {
                lbl.Text = "";
                lbl.Visible = false;
                res = true;
            }

            return res;
        }

        static public bool Validar(Label lbl, String mensaje, String dato, Dictionary<int, int> opciones = null, String patron = null)
        {
            bool res = false;
            if (patron == null) patron = "";
            if (!ValidacionDatos.Cadena(dato, opciones, patron))
            {
                lbl.Text = mensaje;
                lbl.Visible = true;
            }
            else
            {
                lbl.Text = "";
                lbl.Visible = false;
                res = true;
            }

            return res;
        }
    }
}
