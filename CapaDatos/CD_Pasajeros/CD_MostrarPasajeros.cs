using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_MostrarPasajeros : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        DataTable DTpasajeros = new DataTable();
        public DataTable Mostrar()
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "MostrarPasajeros";
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                DTpasajeros.Clear();
                DTpasajeros.Load(leer);
                return DTpasajeros;
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
        /*public DataTable Mostrar(int Id_Pasajero)
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "MostrarPasajeros";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Pasajero", Id_Pasajero);
                leer = cmd.ExecuteReader();
                DTpasajeros.Load(leer);
                return DTpasajeros;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
                DTpasajeros = null;
            }
        }*/
    }
}
