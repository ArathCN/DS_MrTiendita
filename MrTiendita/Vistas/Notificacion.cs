using System;
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
    public partial class Notificacion : UserControl
    {
        public Notificacion()
        {
            InitializeComponent();
        }

        public string NombreProducto
        {
            get { return lbl_NombreProducto.Text; }
            set { lbl_NombreProducto.Text = value; }
        }
    }
}
