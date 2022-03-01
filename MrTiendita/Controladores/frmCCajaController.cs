using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Constantes;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;
using MrTiendita.Componentes;

namespace MrTiendita.Controladores
{
    class frmCCajaController
    {
        private frmCCaja vista;
        private MovimientoDAO movimientoDAO;
        private CajaDAO cajaDAO;

        private Caja valorCaja;

        public frmCCajaController(frmCCaja vista)
        {
            this.vista = vista;
            this.movimientoDAO = new MovimientoDAO();
            this.cajaDAO = new CajaDAO();
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
            this.vista.cb_tipoMov2.SelectedIndexChanged += new EventHandler(cb_tipoMov2_SelectedIndexChanged);

            this.vista.tb_importe.TextChanged += delegate (object sender, EventArgs e)
            {
                double dato2;
                // Debe de ser un número de 0 - 100 con 2 decimales
                //String mensajeError = "De ser un número entre 1 y 10,000 con máximo dos decimales.";
                String mensajeError = "De ser un número de 1-10,000 con máximo dos decimales.";
                Dictionary<int, double> opciones2 = new Dictionary<int, double>()
                { 
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_IGUAL_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, mensajeError, this.vista.tb_importe.Text, out dato2, opciones2);
            };

            this.vista.tb_concepto.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Al menos 5 caracteres";
                Dictionary<int, int> opciones = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, mensajeError, this.vista.tb_concepto.Text, opciones);
            };
        }

        public void vista_Load(object sender, EventArgs e)
        {
            this.mostrarMovimientos();
            this.obtenerValorCaja();
        }

        private void cb_tipoMov2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipo = "";
            double total = 0;

            if (this.vista.cb_tipoMov2.SelectedIndex == 0)
            {
                this.vista.lbl_totaltxt.Text = "Total de efectivo:";
                tipo = TipoMovimiento.TODO;
            }
            if (this.vista.cb_tipoMov2.SelectedIndex == 1)
            {
                this.vista.lbl_totaltxt.Text = "Total de efectivo por entradas:";
                tipo = TipoMovimiento.ENTRADA;
            }
            if (this.vista.cb_tipoMov2.SelectedIndex == 2)
            {
                this.vista.lbl_totaltxt.Text = "Total de efectivo por salidas:";
                tipo = TipoMovimiento.SALIDA;
            }
            if (this.vista.cb_tipoMov2.SelectedIndex == 3)
            {
                this.vista.lbl_totaltxt.Text = "Total de efectivo por ventas:";
                tipo = TipoMovimiento.VENTA;
            }

            List<Movimiento> movimientos = this.movimientoDAO.readByType(tipo);
            this.vista.tablaMovimientos.Rows.Clear();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, movimiento.Importe);
                total += movimiento.Importe;
            }

            this.vista.lbl_total.Text = "$" + total.ToString();

            //hacer visibles las etiquetas para el total
            this.vista.lbl_totaltxt.Visible = true;
            this.vista.lbl_total.Visible = true;
        }

        public void btn_aceptar_Click(object sender, EventArgs e)
        {
            String _importe = this.vista.tb_importe.Text;
            String concepto = this.vista.tb_concepto.Text;
            int _tipo = this.vista.cb_tipoMov.SelectedIndex; //0 -> entrada   1->salida
            String tipo = "";
            String mensajeErrorImporte = "De ser un número de 1-10,000 con máximo dos decimales.";
            String mensajeErrorDesc = "Al menos 5 caracteres.";
            double importe, dinero = 0;
            bool res = false;

            Dictionary<int, double> opcionesImporte = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_IGUAL_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            Dictionary<int, int> opcionesDesc = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
            };

            //Comprobar que el tipo de mov se haya seleccionado, concepto no sea nulo y que importe sea numero no nulo mayor a 0.
            if (this.vista.cb_tipoMov.SelectedIndex == -1 ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, mensajeErrorDesc, this.vista.tb_concepto.Text, opcionesDesc) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, mensajeErrorImporte, this.vista.tb_importe.Text, out importe, opcionesImporte))
            {
                frmError error = new frmError("Se deben de llenar todos los campos correctamente");
                error.ShowDialog();
                return;
            }

            //Si es una entrada se suma la caja, si es una salida se resta
            //Si es salida comprobar que no se queira sacar más de lo que hay en la caja
            if (_tipo == 0)
            {
                tipo = TipoMovimiento.ENTRADA;
                dinero = double.Parse(this.valorCaja.Valor) + importe;
            }else if (_tipo == 1)
            {
                if (importe > double.Parse(this.valorCaja.Valor))
                {
                    frmError error = new frmError("No hay dinero suficiente en la caja");
                    error.ShowDialog();
                    return;
                }
                tipo = TipoMovimiento.SALIDA;
                dinero = double.Parse(this.valorCaja.Valor) - importe;
            }
            this.valorCaja.Valor = dinero.ToString();

            Movimiento movimiento = new Movimiento(-1, tipo, DateTime.Now, importe, dinero, concepto);

            res = this.movimientoDAO.create(movimiento);
            if (!res)
            {
                frmError error = new frmError("Hubo un error al registrar el movimiento.");
                error.ShowDialog();
                return;
            }

            res = this.cajaDAO.UpdateValue("Total", this.valorCaja.Valor);
            if (!res)
            {
                frmError error = new frmError("Hubo un error al actualizar el total de la caja.");
                error.ShowDialog();
                return;
            }

            frmExito mensajeExito = new frmExito("Se registrado el movimiento con éxito.");
            mensajeExito.ShowDialog();
            this.mostrarMovimientos();
            this.obtenerValorCaja();

            this.vista.cb_tipoMov.SelectedIndex = -1;
            this.vista.tb_importe.Text = "";
            this.vista.tb_concepto.Text = "";
        }

        //////////////////////////////
        ///Auxiliares
        //////////////////////////////

        private void mostrarMovimientos()
        {
            this.vista.tablaMovimientos.Rows.Clear();
            List<Movimiento> movimientos = this.movimientoDAO.readAll();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, movimiento.Importe);
            }
        }

        private void obtenerValorCaja()
        {
            //Obtener el valor de la caja
            this.valorCaja = this.cajaDAO.ReadByName("Total");
            if (this.valorCaja == null)
            {
                frmError error = new frmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                return;
            }

            this.vista.lbl_totalCaja.Text = this.valorCaja.Valor;
        }

    }
}
