using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioWeb
    {

        [OperationContract]
        ElementoComputacionServicio ObtenerElemento(string id);

    }
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

    [DataContract]
    public class ElementoComputacionServicio
    {
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
