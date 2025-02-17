using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Bitacora : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public void InsertarBitacora(int usuario, string accion, string mensaje)
        {
            try
            {
                conexion.AbrirConexion();
                cmd.CommandText = "InsertarBitacora";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Accion", accion);
                cmd.Parameters.AddWithValue("@Mensaje", mensaje);
                cmd.ExecuteNonQuery();
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
