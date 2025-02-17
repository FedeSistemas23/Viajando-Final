using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos
{
    public class CD_MostrarReserva:Conexion
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataReader leer;
        
        public DataTable MostarReservaCD(CS_Reserva reserva)
        {
            cmd.Connection = AbrirConexion();
            cmd.CommandText = "MostrarReserva";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NroReserva",reserva.NroReserva);
            cmd.Parameters.AddWithValue("@NombreTitular", reserva.NombreTitular);
            cmd.Parameters.AddWithValue("@ApellidoTitular", reserva.ApellidoTitular);
            cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
            cmd.Parameters.AddWithValue("@fechaRegreso", reserva.FechaRegreso);

            leer = cmd.ExecuteReader();
            dt.Load(leer);
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return dt;

            
        }

        public DataTable MostrarPorNroReserva(int nroReserva )
        {
            cmd.Connection = AbrirConexion();
            cmd.CommandText = "BuscarCoincidenciaReservas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@filtro", nroReserva);
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return dt;


        }
        public DataTable BuscarReservaPorNombre_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();
                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservasPorNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }
        public DataTable BuscarReservaPorApellido_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();

                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservaPorApellido";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }

        public DataTable BuscarReservaPorFechasalida_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();

                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservaPorFechaSalida";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }

        public DataTable BuscarReservaPorFechaReserva_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();

                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservaPorFechaReserva";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }

        public DataTable BuscarReservaPorDestino_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();

                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservaPorDestino";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }

        public DataTable BuscarReservaPorNumReserva_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();

                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservaPorNumReserva";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }

        public DataTable BuscarReservaPorFechaRegreso_CD()
        {

            try
            {
                DataTable tabla = new DataTable();
                CS_Reserva CD_reserva = new CS_Reserva();

                cmd.Connection = AbrirConexion();
                cmd.CommandText = "MostrarReservaPorFechaRegreso";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NombreTitular", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);
                return tabla;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar reserva: " + ex.Message);
                return null;
            }
        }
    }

}



 
