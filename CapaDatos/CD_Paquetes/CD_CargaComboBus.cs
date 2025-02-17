using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace CapaDatos
{
    public class CD_CargaComboBus : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        int asientos;
        List<string> Buses = new List<string>();
        public List<string> CargadorComboBusD(string destino)
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargaComboBus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Destino", destino);
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        Buses.Add(leer["NombreBus"].ToString());
                    }
                }
                return Buses;
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

