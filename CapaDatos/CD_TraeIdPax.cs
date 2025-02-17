using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_TraeIdPax: Conexion
    {
        Conexion con = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public int ObtenerIdPasajero()
        {
            try
            {
                cmd.Connection = con.AbrirConexion();
                cmd.CommandText = "ObtenerUltimoIdPax";
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al trar el numero de paasajero : " + ex.ToString()) ;
                return 0;
            }
        }

    }
}
