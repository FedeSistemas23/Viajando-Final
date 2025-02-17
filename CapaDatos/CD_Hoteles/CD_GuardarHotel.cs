using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_GuardarHotel : Conexion
    {

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        DataTable tabla = new DataTable();

        public void GuardarHotelD(CS_AtributosHotel Hotel)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "GuardarHotel";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Hotel", Hotel.NombreDelHotel);                
                cmd.Parameters.AddWithValue("@NombreTitularHotel", Hotel.NombreTitularHotel);
                cmd.Parameters.AddWithValue("@ApellidoTitularHotel", Hotel.ApellidoTitularHotel);
                cmd.Parameters.AddWithValue("@Cuit", Hotel.Cuit);
                cmd.Parameters.AddWithValue("@Calle", Hotel.Calle);
                cmd.Parameters.AddWithValue("@Numero", Hotel.Numero);
                cmd.Parameters.AddWithValue("@Localidad", Hotel.Localidad);
                cmd.Parameters.AddWithValue("@Partido", Hotel.Partido);
                cmd.Parameters.AddWithValue("@Provincia", Hotel.Provincia);
                cmd.Parameters.AddWithValue("@Email", Hotel.Email);
                cmd.Parameters.AddWithValue("@Telefono", Hotel.Telefono);
                cmd.Parameters.AddWithValue("@Celular", Hotel.Celular);
                cmd.Parameters.AddWithValue("@Cantidad_Habitaciones", Hotel.CantidadDeHabitaciones);
                cmd.Parameters.AddWithValue("@Single", Hotel.Single);
                cmd.Parameters.AddWithValue("@Doble", Hotel.Doble);
                cmd.Parameters.AddWithValue("@Triple", Hotel.Triple);
                cmd.Parameters.AddWithValue("@Cuadruple", Hotel.Cuadruple);
                cmd.Parameters.AddWithValue("@Desayuno", Hotel.Desayuno);
                cmd.Parameters.AddWithValue("@MediaPension", Hotel.MediaPension);
                cmd.Parameters.AddWithValue("@PensionCompleta", Hotel.PensionCompleta);
                cmd.Parameters.AddWithValue("Destino", Hotel.Destino);
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
