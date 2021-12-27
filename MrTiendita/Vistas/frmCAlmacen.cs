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
    public partial class frmCAlmacen : Form
    {
        public frmCAlmacen()
        {
            InitializeComponent();
            widthColumnas();
            tablaProductos.AllowUserToAddRows = false;
            tablaProductos.CurrentCell = null;
            frmCAlmacenController controlador = new frmCAlmacenController(this);
        }

        public void widthColumnas()
        {
            tablaProductos.Columns[0].Width = 120;
            tablaProductos.Columns[1].Width = 73;
            tablaProductos.Columns[2].Width = 240;
            tablaProductos.Columns[3].Width = 85;
        }
    }
}
