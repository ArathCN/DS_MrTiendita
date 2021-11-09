using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    class Caja
    {
        private String atributo;
        private String valor;

        public Caja()
        {

        }

        public Caja(String atributo, String valor)
        {
            this.atributo = atributo;
            this.valor = valor;
        }

        public string Atributo { get => atributo; set => atributo = value; }
        public string Valor { get => valor; set => valor = value; }
    }
}
