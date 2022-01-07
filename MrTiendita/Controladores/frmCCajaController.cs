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
        }

        public void vista_Load(object sender, EventArgs e)
        {
            this.mostrarMovimientos();
            this.obtenerValorCaja();
            this.vista.tb_concepto.MaxLength = 100;
            this.vista.tb_importe.MaxLength = 10;
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
            double importe;
            int _tipo = this.vista.cb_tipoMov.SelectedIndex; //0 -> entrada   1->salida
            String tipo = "";
            double dinero = 0;
            bool res = false;

            //Comprobar que el tipo de mov se haya seleccionado, concepto no sea nulo y que importe sea numero no nulo mayor a 0.
            if (this.vista.cb_tipoMov.SelectedIndex == -1 ||
                !ValidacionDatos.Cadena(concepto, new Dictionary<int, int>()
                { {ValidacionDatosOpciones.NUM_MINIMO_CARACTERES, 10} }) ||
                !ValidacionDatos.Numero(_importe, out importe, new Dictionary<int, double>()
                { {ValidacionDatosOpciones.MAYOR_A, 0},
                { ValidacionDatosOpciones.MENOR_IGUAL_A, 10000} }))
            {
                String mensaje = "Se deben de llenar todos los campos correctamente";
                if (ValidacionDatos.error)
                {
                    mensaje = ValidacionDatos.mensajes;
                }
                frmError error = new frmError(mensaje);
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

            res = this.cajaDAO.updateValue("Total", this.valorCaja.Valor);
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
            this.valorCaja = this.cajaDAO.readByName("Total");
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
