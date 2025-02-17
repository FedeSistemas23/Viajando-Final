using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_BackUp : Conexion
    {

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();

        public void RealizarBackup(string rutaDestino)
        {
            try
            {
                conexion.AbrirConexion();
                cmd.CommandText = "RealizarBackUp";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ruta", rutaDestino);
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

