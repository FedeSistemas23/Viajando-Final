using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_GuardarPaquete : Conexion
    {
        int idNuevoPaquete = 0;
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void GuardarPaqueteD(CS_AtributosPaquete paquete)
        {
            try
            {

                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "GuardarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                
                cmd.Parameters.AddWithValue("@Disponibilidad", paquete.Disponibilidad);
                cmd.Parameters.AddWithValue("@Single", paquete.Single);
                cmd.Parameters.AddWithValue("@Doble", paquete.Doble);
                cmd.Parameters.AddWithValue("@Triple", paquete.Triple);
                cmd.Parameters.AddWithValue("@Cuadruple", paquete.Cuadruple);
                cmd.Parameters.AddWithValue("@Regimen", paquete.Regimen);
                cmd.Parameters.AddWithValue("@FechaRegreso", paquete.FechaRegreso);
                cmd.Parameters.AddWithValue("@CantidadDias", paquete.CantidadDias);
                cmd.Parameters.AddWithValue("@CantidadNoches", paquete.CantidadNoches);
                cmd.Parameters.AddWithValue("@ProveedorHotel", paquete.ProveedorHotel);
                cmd.Parameters.AddWithValue("@ProveedorBus", paquete.ProveedorBus);
                cmd.Parameters.AddWithValue("@CantidadAsientos", paquete.CantidadAsientos);
                cmd.Parameters.AddWithValue("@CantidadCamas", paquete.AsientosCama);
                cmd.Parameters.AddWithValue("@CantidadSemicamas", paquete.AsientosSemicama);
                cmd.Parameters.AddWithValue("@GastosAdministrativos", paquete.GastosAdministrativos);
                cmd.Parameters.AddWithValue("@PrecioEfectivo", paquete.PrecioEfectivo);
                cmd.Parameters.AddWithValue("@PrecioLista", paquete.PrecioLista);
                cmd.Parameters.AddWithValue("@CantidadDeHab", paquete.CantidadDeHab);
                cmd.Parameters.AddWithValue("@Coste", paquete.Coste);
                cmd.Parameters.AddWithValue("@FechaSalida", paquete.FechaSalida);
                cmd.Parameters.AddWithValue("@TipoBus", paquete.TipoBus);
                cmd.Parameters.AddWithValue("@Destino", paquete.Destino);
                cmd.Parameters.AddWithValue("@Estado", paquete.Estado);
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

        public CS_AtributosPaquete VerificarNuevoPaqueteD(int id)
        {
            CS_AtributosPaquete nuevopaquete = new CS_AtributosPaquete();
            Conexion conexion = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "MostrarNuevoPaquete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Paquete", id);
            //Id_Paquete= Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    nuevopaquete = new CS_AtributosPaquete()
                    {
                        Destino = leer["Destino"].ToString(),
                        Disponibilidad = Convert.ToInt32(leer["Disponibilidad"]),
                        Single = Convert.ToInt32(leer["Single"]),
                        Doble = Convert.ToInt32(leer["Doble"]),
                        Triple = Convert.ToInt32(leer["Triple"]),
                        Cuadruple = Convert.ToInt32(leer["Cuadruple"]),
                        Regimen = leer["Regimen"].ToString(),
                        FechaRegreso = Convert.ToDateTime(leer["FechaRegreso"]),
                        CantidadDias = Convert.ToInt32(leer["CantidadDias"]),
                        CantidadNoches = Convert.ToInt32(leer["CantidadNoches"]),
                        ProveedorHotel = leer["ProveedorHotel"].ToString(),
                        ProveedorBus = leer["ProveedorBus"].ToString(),
                        CantidadAsientos = Convert.ToInt32(leer["CantidadAsientos"]),
                        AsientosCama = Convert.ToInt32(leer["CantidadCamas"]),
                        AsientosSemicama = Convert.ToInt32(leer["CantidadSemicamas"]),
                        GastosAdministrativos = Convert.ToDecimal(leer["GastosAdministrativos"]),
                        PrecioEfectivo = Convert.ToDecimal(leer["PrecioEfectivo"]),
                        PrecioLista = Convert.ToDecimal(leer["PrecioLista"]),
                        CantidadDeHab = Convert.ToInt32(leer["CantidadDeHab"]),
                        Coste = Convert.ToDecimal(leer["Coste"]),
                        FechaSalida = Convert.ToDateTime(leer["FechaSalida"]),
                        TipoBus = leer["TipoBus"].ToString(),
                    };
                    return nuevopaquete;
                }
            }
            return nuevopaquete;
        }
    }
}


