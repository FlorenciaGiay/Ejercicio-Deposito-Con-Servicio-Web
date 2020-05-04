using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    /// <summary>
    /// Otra opcion. Usar valores para la ram y luego teniendo el int hacer int nro = 3; RAM valor1 = (RAM)nro; con un  try catch
    /// </summary>
    public enum RAM
    {
        Dos = 2,
        Cuatro = 4,
        Ocho = 8,
        Dieciseis = 16
    }

    public enum MemoriaRAM
    {
        Dos,
        Cuatro,
        Ocho,
        Dieciseis
    }

    public static class Extensiones
    {
        /// <summary>
        /// BUENISIMO!
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool ValidarMemoria(this string valor)
        {            
            return Enum.IsDefined(typeof(MemoriaRAM), valor);
        }
    }
}
