using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_CargaComboHotel : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        List<string> listaHoteles = new List<string>();
        public List<string> CargarComboHotelD(string destino)
        {
            SqlDataReader leer;
            try
            {
                listaHoteles.Clear();
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargaComboHoteles";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Destino", destino);
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        listaHoteles.Add(leer["Nombre_Hotel"].ToString());
                    }
                }
                else
                {
                    return null;
                }
                return listaHoteles;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                //listaHoteles = null;
                // listaHoteles.Clear();
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }
    }
}
