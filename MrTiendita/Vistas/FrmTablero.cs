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
    public partial class FrmTablero : Form
    {
        public FrmTablero()
        {
            InitializeComponent();
            ModificarNotificacion(flp_ListaNotificaciones);
        }

        public void ModificarNotificacion(FlowLayoutPanel Contenedor)
        {
            for (int i = 0; i < 10; i++)
            {
                Notificacion notificacion = new Notificacion();
                notificacion.NombreProducto = "Leche Lala Deslactosada 1L";
                notificacion.Dock = DockStyle.Top;
                Contenedor.Controls.Add(notificacion);
            }
        }

    }
}
