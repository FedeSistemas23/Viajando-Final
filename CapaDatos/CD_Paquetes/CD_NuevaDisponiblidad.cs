using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_NuevaDisponiblidad : Conexion
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public void CambiarDispoD(int id, int nuevadispo)
        {
            try
            {
                cmd.Connection = AbrirConexion();
                cmd.CommandText = "CambiarDisponibilidad";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Paquete", id);
                cmd.Parameters.AddWithValue("Disponibilidad", nuevadispo);
                SqlDataReader leer = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                CerrarConexion();
            }

        }

    }

}
