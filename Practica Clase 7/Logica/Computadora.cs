using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Computadora : ElementoDeComputacion
    {
        public string DescripcionProcesador { get; set; }
        public MemoriaRAM MemoriaRAM { get; set; }
        public string Fabricante { get; set; }

        public void CargarDatos(string modelo, string marca, int numerodeserie, string descripcionprocesador, MemoriaRAM memoriaram, string fabricante)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.NumeroDeSerie = numerodeserie;
            this.DescripcionProcesador = descripcionprocesador;
            this.MemoriaRAM = memoriaram;
            this.Fabricante = fabricante;
        }

        public override string ObtenerDescripcion()
        {
            return $"PC {this.Modelo} - {this.Marca} - {this.DescripcionProcesador} {this.MemoriaRAM} RAM - {this.Fabricante}";
        }
    }
}
