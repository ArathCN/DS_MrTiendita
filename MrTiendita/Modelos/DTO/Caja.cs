using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTiendita.Modelos.DTO
{
    /// <summary>
    /// Clase para transportar datos sobre una caja.
    /// </summary>
    class Caja
    {
        /// <summary>
        /// The atributo
        /// </summary>
        private String atributo;

        /// <summary>
        /// The valor
        /// </summary>
        private String valor;

        /// <summary>
        /// Initializes a new instance of the <see cref="Caja"/> class.
        /// </summary>
        public Caja()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Caja"/> class.
        /// </summary>
        /// <param name="atributo">The atributo.</param>
        /// <param name="valor">The valor.</param>
        public Caja(String atributo, String valor)
        {
            this.atributo = atributo;
            this.valor = valor;
        }

        /// <summary>
        /// Gets or sets the atributo.
        /// </summary>
        /// <value>
        /// The atributo.
        /// </value>
        public string Atributo { get => atributo; set => atributo = value; }
        /// <summary>
        /// Gets or sets the valor.
        /// </summary>
        /// <value>
        /// The valor.
        /// </value>
        public string Valor { get => valor; set => valor = value; }
    }
}
