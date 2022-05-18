using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Vistas;
using MrTiendita.Constantes;
using MrTiendita.Componentes;
using System.Configuration;

namespace MrTiendita.Controladores
{
    public class FrmConfiguracionesController
    {
        private FrmConfiguraciones vista;

        private String rutaReportes;
        private int lada;
        private double sueldoCajero;
        private double sueldoEncargado;
        private double cantidadMinima;
        private bool siNotificar;
        private bool siMinimoGlobal;
        private bool siGanancia;
        private int ganancia;
        private bool siErrorMinimoGlobal;
        private bool siErrorGanancia;

        public FrmConfiguracionesController(FrmConfiguraciones vista)
        {
            this.vista = vista;
            this.siErrorMinimoGlobal = false;
            this.siErrorGanancia = false;

            this.vista.Load += new EventHandler(vista_Load);
            this.vista.btn_CambiarRuta.Click += new EventHandler(btn_CambiarRuta_Click);
            this.vista.tb_SueldoCajeros.TextChanged += new EventHandler(tb_SueldoCajeros_TextChanged);
            this.vista.tb_SueldoEncargados.TextChanged += new EventHandler(tb_SueldoEncargados_TextChanged);
            this.vista.tb_LadaTel.TextChanged += new EventHandler(tb_LadaTel_TextChanged);
            this.vista.tb_CantidadMin.TextChanged += new EventHandler(tb_CantidadMin_TextChanged);
            this.vista.check_CantidadMinima.OnChange += new EventHandler(check_CantidadMinima_OnChange);
            this.vista.check_ProductoAgotado.OnChange += new EventHandler(check_ProductoAgotado_OnChange);
            this.vista.cb_siGanancia.OnChange += new EventHandler(cb_siGanancia_OnChange);
            this.vista.cb_GananciaPorcentaje.SelectedIndexChanged += new EventHandler(tb_Ganancia_TextChanged);
            this.vista.btn_GuardarDatos.Click += new EventHandler(btn_GuardarDatos_Click);
        }

        private void vista_Load(object sender, EventArgs e)
        {
            //Obtenemos las configuraciones que ya están establecidas
            this.rutaReportes = Properties.Settings.Default.RutaTickets;
            this.sueldoCajero = Properties.Settings.Default.sueldoCajeros;
            this.sueldoEncargado = Properties.Settings.Default.sueldoEncargados;
            this.cantidadMinima = Properties.Settings.Default.minimoGlobal;
            this.siNotificar = Properties.Settings.Default.siNotificar;
            this.siMinimoGlobal = Properties.Settings.Default.siMinimoGlobal;
            this.lada = Properties.Settings.Default.lada;
            this.siGanancia = Properties.Settings.Default.siGanancia;
            this.ganancia = Properties.Settings.Default.ganancia;


            //Las mostramos en sus respectivos textbox's
            this.vista.tb_Ruta.Text = this.rutaReportes;
            if (this.sueldoCajero != 0)  this.vista.tb_SueldoCajeros.Text = this.sueldoCajero.ToString(new CultureInfo("es-MX"));
            if (this.sueldoEncargado != 0)  this.vista.tb_SueldoEncargados.Text = this.sueldoEncargado.ToString(new CultureInfo("es-MX"));
            if (this.lada != 0) this.vista.tb_LadaTel.Text = this.lada.ToString();

            if (this.siMinimoGlobal)
            {
                this.vista.check_CantidadMinima.Checked = true;
                this.vista.tb_CantidadMin.Text = this.cantidadMinima.ToString(new CultureInfo("es-MX"));
                this.vista.tb_CantidadMin.Enabled = true;
            }

            if (this.siGanancia)
            {
                this.vista.cb_siGanancia.Checked = true;
                this.vista.cb_GananciaPorcentaje.SelectedItem = this.ganancia.ToString() + "%";
                this.vista.cb_GananciaPorcentaje.Enabled = true;
            }
            this.vista.check_CantidadMinima.Checked = this.siMinimoGlobal;
            this.vista.check_ProductoAgotado.Checked = this.siNotificar;
            

        }

        private void btn_CambiarRuta_Click(object sender, EventArgs e)
        {
            if (this.vista.folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.rutaReportes = this.vista.folderBrowserDialog.SelectedPath;
                this.vista.tb_Ruta.Text = this.rutaReportes;
            }
        }

        private void tb_SueldoCajeros_TextChanged(object sender, EventArgs e)
        {
            bool siValido;
            String str_sueldoCajeros = this.vista.tb_SueldoCajeros.Text;
            double dob_sueldoCajeros;
            Dictionary<int, double> opcionesSueldos = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };            
            siValido = ValidacionFormulario.Validar(
                    this.vista.lbl_errorSueldoCajeros, "", str_sueldoCajeros, out dob_sueldoCajeros, opcionesSueldos);
            if (siValido) this.sueldoCajero = dob_sueldoCajeros;
            else if (String.IsNullOrEmpty(str_sueldoCajeros))
            {
                this.sueldoCajero = 0;
                this.vista.lbl_errorSueldoCajeros.Visible = false;
            }
                

        }

        private void tb_SueldoEncargados_TextChanged(object sender, EventArgs e)
        {
            bool siValido;
            String str_sueldoEncargados = this.vista.tb_SueldoEncargados.Text;
            double dob_sueldoEncargados;
            String mensajeError = "Sueldo no valido...";
            Dictionary<int, double> opcionesSueldos = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            siValido = ValidacionFormulario.Validar(
                    this.vista.lbl_errorSueldoCajeros, mensajeError, str_sueldoEncargados, out dob_sueldoEncargados, opcionesSueldos);
            if (siValido) this.sueldoEncargado = dob_sueldoEncargados;
            else if (String.IsNullOrEmpty(str_sueldoEncargados))
            {
                this.sueldoEncargado = 0;
                this.vista.lbl_errorSueldoCajeros.Visible = false;
            }

        }

        private void tb_LadaTel_TextChanged(object sender, EventArgs e)
        {
            bool siValido;
            String str_lada = this.vista.tb_LadaTel.Text;
            int dob_lada;
            String mensajeError = "Lada no valido...";
            Dictionary<int, int> opcionesLada = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 99},
                {ValidacionDatosOpciones.MENOR_IGUAL_A, 999},
                {ValidacionDatosOpciones.NUM_CARACTERES, 3}
            };
            siValido = ValidacionFormulario.Validar(
                    this.vista.lbl_errorSueldoCajeros, mensajeError, str_lada, out dob_lada, opcionesLada);
            if (siValido) this.lada = dob_lada;
            else if (String.IsNullOrEmpty(str_lada))
            {
                this.lada = 0;
                this.vista.lbl_errorSueldoCajeros.Visible = false;
            }

        }

        private void tb_CantidadMin_TextChanged(object sender, EventArgs e)
        {
            bool siValido;
            String str_cantidadMinima = this.vista.tb_CantidadMin.Text;
            double dob_cantidadMinima;
            String mensajeError = "Cantidad minima no valida...";
            Dictionary<int, double> opcionesCantidad = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            siValido = ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorCantidadMin, mensajeError, str_cantidadMinima, out dob_cantidadMinima, opcionesCantidad);
            if (siValido)
            {
                this.cantidadMinima = dob_cantidadMinima;
                this.siErrorMinimoGlobal = false;
            }
            else this.siErrorMinimoGlobal = true;
        }
    
        private void check_CantidadMinima_OnChange(object sender, EventArgs e)
        {
            this.siMinimoGlobal = this.vista.check_CantidadMinima.Checked;
            if (this.siMinimoGlobal)
            {
                this.vista.tb_CantidadMin.Enabled = true;
                this.vista.tb_CantidadMin.Text = this.cantidadMinima.ToString(new CultureInfo("es-MX"));
            }else
                this.vista.tb_CantidadMin.Enabled = false;
        }

        private void check_ProductoAgotado_OnChange(object sender, EventArgs e)
        {
            this.siNotificar = this.vista.check_ProductoAgotado.Checked;
        }

        private void cb_siGanancia_OnChange(object sender, EventArgs e)
        {
            this.siGanancia = this.vista.cb_siGanancia.Checked;
            if (this.siGanancia)
            {
                this.vista.cb_GananciaPorcentaje.Enabled = true;
                this.vista.cb_GananciaPorcentaje.SelectedItem = this.ganancia.ToString() + "%";
            } else
                this.vista.cb_GananciaPorcentaje.Enabled = false;

        }

        private void tb_Ganancia_TextChanged(object sender, EventArgs e)
        {
            bool siValido;
            String str_ganancia = this.vista.cb_GananciaPorcentaje.SelectedItem.ToString().TrimEnd('%');
            int int_ganancia;
            Dictionary<int, int> opcionesCantidad = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.MAYOR_IGUAL_A, 0},
                {ValidacionDatosOpciones.MENOR_IGUAL_A, 100},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            siValido = ValidacionFormulario.Validar(
                    this.vista.lbl_ErrorGanancia, "", str_ganancia, out int_ganancia, opcionesCantidad);
            if (siValido)
            {
                this.ganancia = int_ganancia;
                this.siErrorGanancia = false;
            }
            else this.siErrorGanancia = true;
        }

        private void btn_GuardarDatos_Click(object sender, EventArgs e)
        {
            if ((this.siMinimoGlobal || this.siGanancia) && (this.siErrorGanancia || this.siErrorMinimoGlobal))
            {
                FrmError error = new FrmError("Se deben de llenar los campos de cantidad minima y porcentaje de ganancia.");
                error.ShowDialog();
                return;
            }

            Console.WriteLine("Ruta -> " + this.rutaReportes);
            Console.WriteLine("Cajeros -> " + this.sueldoCajero);
            Console.WriteLine("Encargados -> " + this.sueldoEncargado);
            Console.WriteLine("Lada -> " + this.lada);
            Console.WriteLine("Notificaciones -> " + this.siNotificar);
            Console.WriteLine("Minimo global -> " + this.siMinimoGlobal);
            Console.WriteLine("Minimo global -> " + this.cantidadMinima);
            
            Properties.Settings.Default.RutaTickets = this.rutaReportes;
            Properties.Settings.Default.sueldoCajeros = this.sueldoCajero;
            Properties.Settings.Default.sueldoEncargados = this.sueldoEncargado;
            Properties.Settings.Default.minimoGlobal = this.cantidadMinima;
            Properties.Settings.Default.siNotificar = this.siNotificar;
            Properties.Settings.Default.siMinimoGlobal = this.siMinimoGlobal;
            Properties.Settings.Default.lada = this.lada;
            Properties.Settings.Default.siGanancia = this.siGanancia;
            Properties.Settings.Default.ganancia = this.ganancia;
            Properties.Settings.Default.Save();
            FrmExito exito = new FrmExito("Se han actualizado los cambios");
            exito.Show();
        }
    }
}
