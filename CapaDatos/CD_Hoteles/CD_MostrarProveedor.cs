using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_MostrarProveedor : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        DataTable tabla = new DataTable();
        public DataTable Mostrar()
        {
            
            SqlDataReader leer;
            try
            {
                
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "MostrarProveedorHotel";
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    // Cargar el DataTable directamente desde el SqlDataReader
                    tabla.Load(leer);
                }
                else
                {
                    return null; // Si no hay filas, devolver null o manejar el caso según sea necesario
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return tabla;
        }
    }
}
