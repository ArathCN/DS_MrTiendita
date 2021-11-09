using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrTiendita.Modelos.DAO;
using MrTiendita.Modelos.DTO;
using MrTiendita.Vistas;

namespace MrTiendita.Controladores
{
    class frmCCajaController
    {
        private frmCCaja vista;
        private MovimientoDAO movimientoDAO;
        private CajaDAO cajaDAO;

        public frmCCajaController(frmCCaja vista)
        {
            this.vista = vista;
            this.movimientoDAO = new MovimientoDAO();
            this.cajaDAO = new CajaDAO();
            this.vista.Load += new EventHandler(vista_Load);
            this.vista.btn_aceptar.Click += new EventHandler(btn_aceptar_Click);
        }

        public void vista_Load(object sender, EventArgs e)
        {
            this.mostrarMovimientos();
        }

        public void btn_aceptar_Click(object sender, EventArgs e)
        {
            String _importe = this.vista.tb_importe.Text;
            double importe;
            int _tipo = this.vista.cb_tipoMov.selectedIndex; //0 -> entrada   1->salida
            String tipo = "";
            double dinero = 0;
            Caja caja = null;
            bool res = false;

            //comprobar que se hayan puesto valores en ambos
            if (String.IsNullOrEmpty(_importe) || _tipo == -1)
            {
                frmError error = new frmError("Se deben de llenar todos los campos");
                error.ShowDialog();
                return;
            }

            //comprobar que el importe sea decimal
            if (!Double.TryParse(_importe, out importe))
            {
                frmError error = new frmError("El importe debe ser un numero decimal.");
                error.ShowDialog();
                return;
            }

            //concepto se es entrada puede ser "Venta" o "Directo"
            //Si es salida "Directo"
            caja = this.cajaDAO.readByName("Total");
            if (caja == null)
            {
                frmError error = new frmError("No se pudo obtener la información sobre la caja.");
                error.ShowDialog();
                return;
            }

            if (_tipo == 0)
            {
                tipo = "Entrada";
                dinero = double.Parse(caja.Valor) + importe;
            }
            if (_tipo == 1)
            {
                tipo = "Salida";
                dinero = double.Parse(caja.Valor) - importe;
            }
            
            Movimiento movimiento = new Movimiento(-1, tipo, "Directo", DateTime.Now, importe, dinero);

            res = this.movimientoDAO.create(movimiento);
            if (!res)
            {
                frmError error = new frmError("Hubo un error al registrar el movimiento.");
                error.ShowDialog();
                return;
            }

            res = this.cajaDAO.updateValue("Total", dinero.ToString());
            if (!res)
            {
                frmError error = new frmError("Hubo un error al actualizar el total de la caja.");
                error.ShowDialog();
                return;
            }

            frmExito mensajeExito = new frmExito("Se registrado el movimiento con éxito.");
            mensajeExito.ShowDialog();
            this.mostrarMovimientos();
        }

        //////////////////////////////
        ///Auxiliares
        //////////////////////////////

        public void mostrarMovimientos()
        {
            this.vista.tablaMovimientos.Rows.Clear();
            List<Movimiento> movimientos = this.movimientoDAO.readAll();
            foreach (Movimiento movimiento in movimientos)
            {
                this.vista.tablaMovimientos.Rows.Add(movimiento.Tipo, movimiento.Fecha, movimiento.Importe, movimiento.Caja);
            }
        }

    }
}
