using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{

    public class CD_MostrarPaquete : Conexion
    {
        public List<CS_AtributosPaquete> MostrarPaquetes()
        {
            List<CS_AtributosPaquete> Paquetes = new List<CS_AtributosPaquete>();

            try
            {
                using (SqlConnection connection = AbrirConexion()) // Asegura que la conexión se cierra correctamente
                {
                    using (SqlCommand cmd = new SqlCommand("MostrarPaquete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            if (leer.HasRows)
                            {
                                while (leer.Read())
                                {


                                    CS_AtributosPaquete paquete = new CS_AtributosPaquete
                                    {
                                        Id_Paquete = Convert.ToInt32(leer["Id_Paquete"]),
                                        FechaSalida = Convert.ToDateTime(leer["FechaSalida"]),
                                        FechaRegreso = Convert.ToDateTime(leer["FechaRegreso"]),
                                        CantidadDias = Convert.ToInt32(leer["CantidadDias"]),
                                        CantidadNoches = Convert.ToInt32(leer["CantidadNoches"]),
                                        Regimen = leer["Regimen"].ToString(),
                                        ProveedorHotel = leer["ProveedorHotel"].ToString(),
                                        ProveedorBus = leer["ProveedorBus"].ToString(),
                                        GastosAdministrativos = Convert.ToDecimal(leer["GastosAdministrativos"]),
                                        PrecioLista = Convert.ToDecimal(leer["PrecioLista"]),
                                        PrecioEfectivo = Convert.ToDecimal(leer["PrecioEfectivo"]),
                                        Coste = Convert.ToDecimal(leer["Coste"]),
                                        Disponibilidad = Convert.ToInt32(leer["Disponibilidad"]),
                                        CantidadDeHab = Convert.ToInt32(leer["CantidadDeHab"]),
                                        Single = Convert.ToInt32(leer["Single"]),
                                        Doble = Convert.ToInt32(leer["Doble"]),
                                        Triple = Convert.ToInt32(leer["Triple"]),
                                        Cuadruple = Convert.ToInt32(leer["Cuadruple"]),
                                        TipoBus = leer["TipoBus"].ToString(),
                                        CantidadAsientos = Convert.ToInt32(leer["CantidadAsientos"]),
                                        AsientosCama = Convert.ToInt32(leer["CantidadCamas"]),
                                        AsientosSemicama = Convert.ToInt32(leer["CantidadSemicamas"]),
                                        Destino = leer["Destino"].ToString(),
                                    };

                                    // Añadir el objeto paquete a la lista de paquetes
                                    Paquetes.Add(paquete);
                                }
                            }
                            else
                            {
                                return null; // Si no hay filas, devolver null o manejar el caso según sea necesario
                            }
                        }
                    }
                }
                return Paquetes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n\n" + ex.Message);
            }
        }
    }
}
