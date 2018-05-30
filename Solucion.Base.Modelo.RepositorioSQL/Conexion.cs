using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solucion.Base.Modelo.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Messaging;

namespace Solucion.Base.Modelo.RepositorioSQL
{
    public class Conexion
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;


        public SqlCommand openconection(string stroreprocedure)
        {
            try
            {
                using(SqlConnection connectar=new SqlConnection(connStr))
                {
                   
                    SqlCommand cmd = new SqlCommand(stroreprocedure, connectar);
                    connectar.Open();
                return cmd;
                }
                
                
               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
