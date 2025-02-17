using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_IntentosFallidos : Conexion
    {
        public void ActualizaIntentosFallidosD(string Username, int nuevointento)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarIntentosFallidos", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@NuevoIntento", nuevointento);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n\n" + ex.Message);
            }
        }
    }
}
