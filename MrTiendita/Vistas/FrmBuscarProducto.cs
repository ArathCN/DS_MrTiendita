﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Vistas
{
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
            sombra.SetShadowForm(this);
            dgv_TablaProductos.AllowUserToAddRows = false;
            dgv_TablaProductos.CurrentCell = null;
            int indexNuevoProducto;
            for (int i = 0; i < 3; i++)
            {
                dgv_TablaProductos.Rows.Add();
                indexNuevoProducto = dgv_TablaProductos.RowCount - 1;
                Console.WriteLine(indexNuevoProducto);
                dgv_TablaProductos.Rows[indexNuevoProducto].Cells["col_Nombre"].Value = "Leche Lala Deslactosada 1L";
                dgv_TablaProductos.Rows[indexNuevoProducto].Cells["col_Categoria"].Value = "Higiene personal y salud";
                dgv_TablaProductos.Rows[indexNuevoProducto].Cells["col_Precio"].Value = "$27.80";
                dgv_TablaProductos.Rows[indexNuevoProducto].Cells["col_CantidadAgregar"].Value = "1";
            }
            dgv_TablaProductos.AllowUserToResizeColumns = false;
            PermitirCantidad();
            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            dgv_TablaProductos.Columns[0].Width = 60;//Nombre
            dgv_TablaProductos.Columns[1].Width = 50;//Categoria
            dgv_TablaProductos.Columns[2].Width = 20;//Precio
            dgv_TablaProductos.Columns[3].Width = 35;//Cantidad a agregar
            dgv_TablaProductos.Columns[4].Width = 60;//Icono agregar al carrito
            col_CantidadAgregar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_AgregarCarrito.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_TablaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void PermitirCantidad()
        {
            for (int i = 0; i < dgv_TablaProductos.Rows.Count - 1; i++)
            {
                dgv_TablaProductos.Rows[i].Cells["col_CantidadAgregar"].ReadOnly = false;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
