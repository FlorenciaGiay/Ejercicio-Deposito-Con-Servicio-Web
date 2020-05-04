using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class InfoProductoArgs : EventArgs
    {
        public string Tipo { get; set; }
        public ElementoDeComputacion Producto { get; set; }
        public string Operacion { get; set; }

        
    }
}
