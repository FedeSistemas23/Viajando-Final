using CapaSesion;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_BuscarPaquete:Conexion
    {
        public DataTable BuscarPaqueteCD(CS_AtributosPaquete paquete)
        {

        
           SqlCommand cmd = new SqlCommand();
           DataTable dt = new DataTable();
           Conexion conn = new Conexion();
           SqlDataReader reader;
        
            try
            {
                cmd.Connection = conn.AbrirConexion();
                cmd.CommandText = "BuscarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@Destino", paquete.Destino);
                cmd.Parameters.AddWithValue("@FechaSalida", paquete.FechaSalida);
                cmd.Parameters.AddWithValue("@FechaRegreso", paquete.FechaRegreso);
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                return dt;

            } catch (Exception ex) 
            {
                Console.WriteLine( "MensajeErro BuscarPaqueteCD: Error al intentar buscar el paquete  " + ex.ToString());
                return null;
            }
            finally
            {
                cmd.Parameters.Clear ();
                conn.CerrarConexion();
            }
            
        }
    }
}
