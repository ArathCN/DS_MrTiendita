using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MARSS2.Controladores;

namespace MrTiendita.Vistas
{
    public partial class FrmConfiguraciones : Form
    {
        public FrmConfiguraciones()
        {
            InitializeComponent();
            FrmConfiguracionesController controller = new FrmConfiguracionesController(this);
        }
    }
}
