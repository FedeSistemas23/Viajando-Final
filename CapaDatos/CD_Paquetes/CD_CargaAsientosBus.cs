using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_CargaAsientosBus : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        List<int> Asientos = new List<int>();
        public List<int> CargaAsientosBusD(string nombrebus)
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection= conexion.AbrirConexion();
                cmd.CommandText = "CargaAsientos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreBus", nombrebus);
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        int CantidadAsientos = leer.GetInt32(0);
                        Asientos.Add(CantidadAsientos);
                        int Camas = leer.GetInt32(1);
                        Asientos.Add(Camas);
                        int Semicamas = leer.GetInt32(2);
                        Asientos.Add(Semicamas);
                    }
                }
                else
                {
                    return null;
                }
                return Asientos;
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
