using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_GuardaBusD : Conexion
    {
        public void GuardarBusD(CS_AtributosBus bus)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("GuardarBus", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Cantidad_Asientos", bus.CantidadDeAsientos);
                        cmd.Parameters.AddWithValue("@AsientosCamas", bus.Cama);
                        cmd.Parameters.AddWithValue("@AsientosSemicamas", bus.Semicama);
                        cmd.Parameters.AddWithValue("@Calle", bus.Calle);
                        cmd.Parameters.AddWithValue("@Numero", bus.Numero);
                        cmd.Parameters.AddWithValue("@Localidad", bus.Localidad);
                        cmd.Parameters.AddWithValue("@Provincia", bus.Provincia);
                        cmd.Parameters.AddWithValue("@Telefono", bus.Telefono);
                        cmd.Parameters.AddWithValue("@Email", bus.Email);                        
                        cmd.Parameters.AddWithValue("@NombreTitularBus", bus.NombreTitularBus);
                        cmd.Parameters.AddWithValue("@ApellidoTitularBus", bus.ApellidoTitularBus);
                        cmd.Parameters.AddWithValue("@Cuit", bus.Cuit);
                        cmd.Parameters.AddWithValue("@Celular", bus.Celular);
                        cmd.Parameters.AddWithValue("@NombreBus", bus.NombreBus);
                        cmd.Parameters.AddWithValue("@Destino", bus.Destino);

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
