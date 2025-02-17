using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EliminarBus : Conexion
    {
        public void EliminarBusD(int id_provedorbus)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarBus", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_ProvedorBus", id_provedorbus);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado o conectar a la base de datos.\n\n" + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
