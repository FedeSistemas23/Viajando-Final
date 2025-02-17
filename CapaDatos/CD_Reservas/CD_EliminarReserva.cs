using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos
{
    public class CD_EliminarReserva
    {

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public bool EliminarReservaCD(int NroReserva)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EliminarReserva";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NroReserva",NroReserva);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
               
            }
            finally
            {
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
                
            }

        }


    }
}
