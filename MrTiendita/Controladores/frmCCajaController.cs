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
    class FrmCCajaController
    {
        private FrmCCaja vista;
        private MovimientoDAO movimientoDAO;
        private CajaDAO cajaDAO;

        private Caja valorCaja;

        public FrmCCajaController(FrmCCaja vista)
        {
            this.vista = vista;
            this.movimientoDAO = new MovimientoDAO();
            this.cajaDAO = new CajaDAO();
            this.vista.Load += new EventHandler(Vista_Load);
            this.vista.btn_aceptar.Click += new EventHandler(Btn_aceptar_Click);
            this.vista.cb_tipoMov2.SelectedIndexChanged += new EventHandler(Cb_tipoMov2_SelectedIndexChanged);

            this.vista.tb_importe.TextChanged += delegate (object sender, EventArgs e)
            {
                double datoEvaluar;
                String mensajeError = "Debe ser un número de 1-10,000 con máximo dos decimales.";
                Dictionary<int, double> longitudCadenas = new Dictionary<int, double>()
                { 
                    {ValidacionDatosOpciones.MAYOR_A, 0},
                    {ValidacionDatosOpciones.MENOR_IGUAL_A, 10000},
                    {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, mensajeError, this.vista.tb_importe.Text, out datoEvaluar, longitudCadenas);
            };

            this.vista.tb_concepto.TextChanged += delegate (object sender, EventArgs e)
            {
                String mensajeError = "Escriba al menos 5 caracteres";
                Dictionary<int, int> longitudCadenas = new Dictionary<int, int>()
                {
                    {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                    {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
                };
                ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, mensajeError, this.vista.tb_concepto.Text, longitudCadenas);
            };
        }

        public void Vista_Load(object sender, EventArgs e)
        {
            this.MostrarMovimientos();
            this.ObtenerValorCaja();
        }

        private void Cb_tipoMov2_SelectedIndexChanged(object sender, EventArgs e)
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

            List<Movimiento> movimientos = this.movimientoDAO.ReadByType(tipo);
            this.vista.tablaMovimientos.Rows.Clear();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, movimiento.Importe);
                total += movimiento.Importe;
            }

            this.vista.lbl_total.Text = "$" + total.ToString();

            //Hacer visibles las etiquetas para el total
            this.vista.lbl_totaltxt.Visible = true;
            this.vista.lbl_total.Visible = true;
        }

        public void Btn_aceptar_Click(object sender, EventArgs e)
        {
            String importeCadena = this.vista.tb_importe.Text;
            String concepto = this.vista.tb_concepto.Text;
            int tipoIndice = this.vista.cb_tipoMov.SelectedIndex; //0 -> entrada   1->salida
            String tipo = "";
            String mensajeErrorImporte = "Debe ser un número de 1-10,000 con máximo dos decimales.";
            String mensajeErrorDescripcion = "Escriba al menos 5 caracteres.";
            double importe, dinero = 0;
            bool esValido = false;

            Dictionary<int, double> opcionesImporte = new Dictionary<int, double>()
            {
                {ValidacionDatosOpciones.MAYOR_A, 0},
                {ValidacionDatosOpciones.MENOR_IGUAL_A, 10000},
                {ValidacionDatosOpciones.NUM_DECIMALES_NO_ROUND, 2}
            };
            Dictionary<int, int> opcionesDescripcion = new Dictionary<int, int>()
            {
                {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 5},
                {ValidacionDatosOpciones.NUM_MAXIMO_CARACTERES, 100}
            };

            //Comprobar que el tipo de movimiento se haya seleccionado, concepto no sea nulo y que importe sea numero no nulo mayor a 0.
            if (this.vista.cb_tipoMov.SelectedIndex == -1 ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorDesc, mensajeErrorDescripcion, concepto, opcionesDescripcion) ||
                !ValidacionFormulario.Validar(this.vista.lbl_ErrorImporte, mensajeErrorImporte, importeCadena, out importe, opcionesImporte))
            {
                FrmError error = new FrmError("Se deben de llenar todos los campos correctamente");
                error.ShowDialog();
                return;
            }

            //Si es una entrada se suma la caja, si es una salida se resta
            //Si es salida comprobar que no se quiera sacar más de lo que hay en la caja
            if (tipoIndice == 0)
            {
                tipo = TipoMovimiento.ENTRADA;
                dinero = double.Parse(this.valorCaja.Valor) + importe;
            } 
            else if (tipoIndice == 1)
            {
                if (importe > double.Parse(this.valorCaja.Valor))
                {
                    FrmError error = new FrmError("No hay dinero suficiente en la caja");
                    error.ShowDialog();
                    return;
                }
                tipo = TipoMovimiento.SALIDA;
                dinero = double.Parse(this.valorCaja.Valor) - importe;
            }
            this.valorCaja.Valor = dinero.ToString();

            Movimiento movimiento = new Movimiento(-1, tipo, DateTime.Now, importe, dinero, concepto);

            esValido = this.movimientoDAO.Create(movimiento);
            if (!esValido)
            {
                FrmError error = new FrmError("Hubo un error al registrar el movimiento.");
                error.ShowDialog();
                return;
            }

            esValido = this.cajaDAO.UpdateValue("Total", this.valorCaja.Valor);
            if (!esValido)
            {
                FrmError error = new FrmError("Hubo un error al actualizar el total de la caja.");
                error.ShowDialog();
                return;
            }

            FrmExito mensajeExito = new FrmExito("Se registrado el movimiento con éxito.");
            mensajeExito.ShowDialog();
            this.MostrarMovimientos();
            this.ObtenerValorCaja();

            this.vista.cb_tipoMov.SelectedIndex = -1;
            this.vista.tb_importe.Text = "";
            this.vista.tb_concepto.Text = "";
        }

        ///Métodos auxiliares
        private void MostrarMovimientos()
        {
            this.vista.tablaMovimientos.Rows.Clear();
            List<Movimiento> movimientos = this.movimientoDAO.ReadAll();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(movimiento.Tipo, movimiento.Concepto, movimiento.Fecha, movimiento.Importe);
            }
        }

        private void ObtenerValorCaja()
        {
            //Obtener el valor de la caja
            this.valorCaja = this.cajaDAO.ReadByName("Total");
            if (this.valorCaja == null)
            {
                FrmError error = new FrmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                return;
            }

            this.vista.lbl_totalCaja.Text = this.valorCaja.Valor;
        }

    }
}
