using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Destino : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        DataTable tabla = new DataTable();

        public void GuardarDestinoD(string nombre, string localidad, string partido, string provincia)
        {
            
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "GuardarDestino";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Localidad", localidad);
                cmd.Parameters.AddWithValue("@Partido", partido);
                cmd.Parameters.AddWithValue("@Provincia", provincia);
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
        public List<CS_Destino> MostrarDestinos()
        {
            List<CS_Destino> Destinos = new List<CS_Destino>(); 
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "MostrarDestinos";
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        CS_Destino destino = new CS_Destino()
                        {
                            Id_Destino = Convert.ToInt32(leer["Id_Destino"]),
                            Nombre= leer["Nombre"].ToString(),
                            Localidad = leer["Localidad"].ToString(),
                            Partido = leer["Partido"].ToString(),
                            Provincia = leer["Provincia"].ToString(),
                        };
                        Destinos.Add(destino);
                    }
                }
                
                return Destinos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        public void EliminarDestinosD(int id)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EliminarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Paquete", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
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

        public void EditarDestinoD(int id_destino, string nombre, string localidad, string partido, string provincia)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EditarDestino";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Destino", id_destino);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Localidad", localidad);
                cmd.Parameters.AddWithValue("@Partido", partido);
                cmd.Parameters.AddWithValue("@Provincia", provincia);
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
