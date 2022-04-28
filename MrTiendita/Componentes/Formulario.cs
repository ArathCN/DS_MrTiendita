using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTiendita.Componentes
{
    public class Formulario
    {
        private List<Campo> campos;
        private bool completo;
        public Formulario()
        {
            Campo campo = new CampoDouble(
                textBox : new TextBox(),
                label : new Label(),
                opciones: null
                );
        }

        public void AgregarCampo(Campo campo)
        {
            this.campos.Add(campo);
        }

        public bool VerificarSiCompleto()
        {
            bool noCompleto = false;
            foreach (var campo in this.campos)
            {
                if (!campo.Completado) noCompleto = true;
            }
            return false;
        }
    }

    public interface ICampo
    {
    }

    public class Campo
    {
        protected Label etiqueta;
        protected TextBox textBox;
        protected bool completado;

        protected Campo() { }

        public Label Etiqueta { get => etiqueta; set => etiqueta = value; }
        public TextBox TextBox { get => textBox; set => textBox = value; }
        public bool Completado { get => completado; set => completado = value; }
    }

    public class CampoInt : Campo, ICampo
    {
        private int valor;
        private Dictionary<int, int> opciones;

        public CampoInt(TextBox textBox, Label label, Dictionary<int, int> opciones = null)
        {
            this.textBox = textBox;
            this.etiqueta = label;
            this.opciones = opciones;
            this.textBox.TextChanged += new EventHandler(this.Listener);
        }

        private CampoInt() { }

        public new int Valor { get => valor; set => valor = value; }
        
        public Dictionary<int, int> Opciones { get => opciones; set => opciones = value; }
        

        private void Listener(object sender, EventArgs e)
        {
            this.completado = ValidacionFormulario.Validar(this.etiqueta, "", this.textBox.Text, out this.valor, this.opciones);
        }
    }

    public class CampoLong : Campo, ICampo
    {
        private new long valor;
        private Dictionary<int, long> opciones;

        public CampoLong(TextBox textBox, Label label, Dictionary<int, long> opciones = null)
        {
            this.textBox = textBox;
            this.etiqueta = label;
            this.opciones = opciones;
            this.textBox.TextChanged += new EventHandler(this.Listener);
        }

        private CampoLong() { }

        public new long Valor { get => valor; set => valor = value; }

        public Dictionary<int, long> Opciones { get => opciones; set => opciones = value; }


        private void Listener(object sender, EventArgs e)
        {
            this.completado = ValidacionFormulario.Validar(this.etiqueta, "", this.textBox.Text, out this.valor, this.opciones);
        }
    }

    public class CampoDouble : Campo, ICampo
    {
        private double valor;
        private Dictionary<int, double> opciones;

        public CampoDouble(TextBox textBox, Label label, Dictionary<int, double> opciones = null)
        {
            this.textBox = textBox;
            this.etiqueta = label;
            this.opciones = opciones;
            this.textBox.TextChanged += new EventHandler(this.Listener);
        }

        private CampoDouble() { }

        public double Valor { get => valor; set => valor = value; }

        public Dictionary<int, double> Opciones { get => opciones; set => opciones = value; }

        private void Listener(object sender, EventArgs e)
        {
            this.completado = ValidacionFormulario.Validar(this.etiqueta, "", this.textBox.Text, out this.valor, this.opciones);
        }
    }

    public class CampoString : Campo, ICampo
    {
        private string valor;
        private Dictionary<int, int> opciones;

        public CampoString(TextBox textBox, Label label, Dictionary<int, int> opciones = null)
        {
            this.textBox = textBox;
            this.etiqueta = label;
            this.opciones = opciones;
            this.textBox.TextChanged += new EventHandler(this.Listener);
        }

        private CampoString() { }

        public new string Valor { get => valor; set => valor = value; }

        public Dictionary<int, int> Opciones { get => opciones; set => opciones = value; }


        private void Listener(object sender, EventArgs e)
        {
            this.completado = ValidacionFormulario.Validar(this.etiqueta, "", this.textBox.Text, this.opciones);
        }
    }
}
