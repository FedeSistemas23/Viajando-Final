using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_EliminarPaquete
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public void EliminarPaqueteD(int id)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EliminarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Paquete", id);
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
