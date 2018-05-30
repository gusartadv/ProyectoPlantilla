using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Solucion.Base.Modelo.Entidades;
namespace WcfParam
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
 [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare)]
        int nuevo(string descripcion, int Codigo,int ejecucion);
      
        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class ExceptionService
    {
        [DataMember]
        public string CodigoError { get; set; }

        [DataMember]
        public string DescripcionError { get; set; }
    }
}
