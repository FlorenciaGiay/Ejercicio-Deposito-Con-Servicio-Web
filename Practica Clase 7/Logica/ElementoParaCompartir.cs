using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ElementoParaCompartir
    {
        public ElementoDeComputacion Elemento { get; set; }
        public string Tipo { get { return Elemento is Monitor ? "MONITOR" : "PC"; } }
    }
}
