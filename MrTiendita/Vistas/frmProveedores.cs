﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrTiendita.Controladores;

namespace MrTiendita.Vistas
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            //tablaProveedores.Rows.Add("Distribuidoras Bimbo", "6625018945", "Efectivo");
            widthColumnas();
            tablaProveedores.AllowUserToAddRows = false;
            frmEProveedorController controlador = new frmEProveedorController(this);
        }

        public void widthColumnas()
        {
            tablaProveedores.Columns[0].Width = 230;
            tablaProveedores.Columns[1].Width = 135;
            tablaProveedores.Columns[2].Width = 170;
            //tablaProductos.Columns[4].Width = 39;
            //tablaProductos.Columns[5].Width = 39;
        }

    }
}
