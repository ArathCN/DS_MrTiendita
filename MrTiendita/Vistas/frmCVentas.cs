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
    public partial class frmCVentas : Form
    {
        public frmCVentas()
        {
            InitializeComponent();
            widthColumnas();
            tablaVentas.AllowUserToAddRows = false;
            tablaVentas.CurrentCell = null;
            frmCVentasController controller = new frmCVentasController(this);


        }

        public void widthColumnas()
        {
            tablaVentas.Columns[0].Width = 30;//Sumar
            tablaVentas.Columns[1].Width = 30;//Cantidad
            tablaVentas.Columns[2].Width = 30;//Restar
            tablaVentas.Columns[3].Width = 365;//Descripcion
            tablaVentas.Columns[4].Width = 140;//Precio
        }
    }
}
