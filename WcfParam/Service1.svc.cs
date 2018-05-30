using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Solucion.Base.Modelo.Entidades;
using Solucion.Base.Modelo.RepositorioSQL;

namespace WcfParam
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
       

        public int nuevo(string descripcion, int Codigo, int ejecucion)
        {
            try
            {
                
                Prueba1 _prueba = new Prueba1();
                return _prueba.nuevo(descripcion, Codigo, ejecucion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
