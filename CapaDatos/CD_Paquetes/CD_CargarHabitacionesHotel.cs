using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_CargarHabitacionesHotel : Conexion
    {
        // el metdo no debreia ser data table, deberia ser lista de enteros. Por que no llena datagrids llena numeric

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        CS_HabitacionesYRegimen habitacionesYRegimen = new CS_HabitacionesYRegimen();
        public CS_HabitacionesYRegimen CargarHabitacionesD(string hotel)
        {
            SqlDataReader leer;
            try
            {
                //habitacionesYRegimen=null;
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargarHabitaciones";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Hotel", hotel);
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        habitacionesYRegimen.Desayuno = Convert.ToBoolean(leer["Desayuno"].ToString());
                        habitacionesYRegimen.MediaPension = Convert.ToBoolean(leer["MediaPension"].ToString());
                        habitacionesYRegimen.PensionCompleta = Convert.ToBoolean(leer["PensionCompleta"].ToString());
                        habitacionesYRegimen.CantidadHabitaciones = Convert.ToInt32(leer["Cantidad_Habitaciones"].ToString());
                        habitacionesYRegimen.Single = Convert.ToInt32(leer["Single"].ToString());
                        habitacionesYRegimen.Doble = Convert.ToInt32(leer["Doble"].ToString());
                        habitacionesYRegimen.Triple = Convert.ToInt32(leer["Triple"].ToString());
                        habitacionesYRegimen.Cuadruple = Convert.ToInt32(leer["Cuadruple"].ToString());
                    }
                }
                return habitacionesYRegimen;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                // tabla.Clear();
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }
    }
}
