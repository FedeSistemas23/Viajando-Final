using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EliminarProveedorHotel : Conexion
    {
        readonly SqlCommand cmd = new SqlCommand();
        readonly Conexion conexion = new Conexion();
        public void EliminarProveedorHotelD(int id)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EliminarHotel";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_ProvedorHotel", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
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
