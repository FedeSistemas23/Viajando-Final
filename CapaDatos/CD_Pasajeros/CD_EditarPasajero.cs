using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EditarPasajero : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        

        public void EditarPasajeroD(CS_AtributosPasajeros pasajero)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EditarPasajero";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Pasajero", pasajero.Id_Pasajero);
                cmd.Parameters.AddWithValue("NroReserva", pasajero.NroReserva);
                cmd.Parameters.AddWithValue("Nombre", pasajero.nombre);
                cmd.Parameters.AddWithValue("Apellido", pasajero.apellido);
                cmd.Parameters.AddWithValue("TipoDoc", pasajero.TipoDocumento);
                cmd.Parameters.AddWithValue("NroDoc", pasajero.NroDocumento);
                cmd.Parameters.AddWithValue("FecNac", pasajero.FechaNacimiento);
                cmd.Parameters.AddWithValue("Telefono", pasajero.telefono);
                cmd.Parameters.AddWithValue("Nacionalidad", pasajero.nacionalidad);
                cmd.Parameters.AddWithValue("Email", pasajero.email);
                cmd.Parameters.AddWithValue("Calle", pasajero.Calle);
                cmd.Parameters.AddWithValue("Nro", pasajero.Numero);
                cmd.Parameters.AddWithValue("Localidad", pasajero.Localidad);
                cmd.Parameters.AddWithValue("Partido", pasajero.Partido);
                cmd.Parameters.AddWithValue("Provincia", pasajero.Provincia);
                cmd.Parameters.AddWithValue("Ascenso", pasajero.Ascenso);
                cmd.Parameters.AddWithValue("EsMenor", pasajero.menor_de_3);
                cmd.Parameters.AddWithValue("ObraSocial", pasajero.ObraSocial);
                cmd.Parameters.AddWithValue("TieneObraSocial", pasajero.TieneObraSocial);               
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

