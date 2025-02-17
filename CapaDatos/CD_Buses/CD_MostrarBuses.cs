using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_MostrarBuses : Conexion
    {
        public List<CS_AtributosBus> MostrarBusesD()
        {
            List<CS_AtributosBus> buses = new List<CS_AtributosBus>();

            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("MostrarBuses", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            while (leer.Read())
                            {
                                CS_AtributosBus bus = new CS_AtributosBus
                                {
                                    Id_ProvedorBus = Convert.ToInt32(leer["Id_ProvedorBus"]),
                                    CantidadDeAsientos = Convert.ToInt32(leer["Cantidad_Asientos"]),
                                    Cama = Convert.ToInt32(leer["AsientosCamas"]),
                                    Semicama = Convert.ToInt32(leer["AsientosSemicamas"]),
                                    Calle = leer["Calle"].ToString(),
                                    Numero = Convert.ToInt32(leer["Numero"]),
                                    Localidad = leer["Localidad"].ToString(),
                                    Provincia = leer["Provincia"].ToString(),
                                    Telefono = leer["Telefono"].ToString(),
                                    Email = leer["Email"].ToString(),
                                    Destino = leer["Destino"].ToString(),
                                    NombreTitularBus = leer["NombreTitularBus"].ToString(),
                                    ApellidoTitularBus = leer["ApellidoTitularBus"].ToString(),
                                    Cuit = leer["Cuit"].ToString(),
                                    Celular = leer["Celular"].ToString(),
                                    NombreBus = leer["NombreBus"].ToString(),
                                };
                                buses.Add(bus);
                            }
                        }
                    }
                }

                return buses;
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
