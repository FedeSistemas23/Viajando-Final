using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class CD_TraeNumReserva : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conn = new Conexion();

        public int TraerNumReserva()
        {
            try
            {
                cmd.Connection = conn.AbrirConexion();
                cmd.CommandText = "MostrarNumReserva";
                cmd.CommandType = CommandType.StoredProcedure;
                object result =  cmd.ExecuteScalar();

                return Convert.ToInt32(result);

            } catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.ToString());
                return 0;    
            }
        }
    }
}
