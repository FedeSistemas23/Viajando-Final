using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_BloquearUsuario : Conexion
    {
        public void BloquearUsuarioD(string Username)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("BloquearUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", Username);
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
