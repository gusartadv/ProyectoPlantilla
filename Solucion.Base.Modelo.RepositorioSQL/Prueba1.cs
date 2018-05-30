using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Solucion.Base.Modelo.RepositorioSQL
{
    public class Prueba1 : Conexion
    {
        public string busqeda(int busqueda, int Codigo)
        {
            SqlCommand cmd = openconection("Sparea");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busqueda", busqueda);
            cmd.Parameters.AddWithValue("@codigo", Codigo);
            return "";
        }
        public int nuevo(string descripcion, int Codigo,int ejecucion)
        {
            int id;
            SqlCommand cmd = openconection("Sparea");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@codigo", Codigo);
            cmd.Parameters.AddWithValue("@ejecucion", ejecucion);
            id=cmd.ExecuteNonQuery();
            return id;
        }
    }
}
