using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class ElementoDeComputacion
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int NumeroDeSerie { get; set; }
        public string Identificador { get { return $"{this.Modelo}-{this.Marca}-{(this.NumeroDeSerie).ToString()}";} }

        public abstract string ObtenerDescripcion();
    }
}
