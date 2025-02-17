using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_EliminarPasajero:Conexion
    {

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public void EliminarPasajeroD(int id_pasajero)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EliminarPasajero";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pasajero", id_pasajero);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
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
