using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWeb
{
    public class Cliente
    {
        //Prueba de usar el metodo del servicio
        public void BuscarElemento(string id)
        {
            ServicioWebReferencia.ServicioWebClient client = new ServicioWebReferencia.ServicioWebClient();

            client.ObtenerElemento(id);
        }
    }
}
