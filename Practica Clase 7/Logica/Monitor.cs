using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Monitor : ElementoDeComputacion
    {
        public short AnoDeFabricacion { get; set; }
        public bool EsNuevo { get { return (this.AnoDeFabricacion == DateTime.Today.Year) ? true : false; } }
        public Nullable<int> Pulgadas { get; set; }

        public void CargarDatos(string modelo, string marca, int numerodeserie, short anodefabricacion, Nullable<int> pulgadas)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.NumeroDeSerie = numerodeserie;
            this.AnoDeFabricacion = anodefabricacion;
            this.Pulgadas = pulgadas;
        }

        public override string ObtenerDescripcion()
        {
            return (Pulgadas != null) ? $"MONITOR {this.Marca} - {this.Modelo} {this.Pulgadas}" : $"MONITOR {this.Marca} - {this.Modelo}";
        }
    }
}
