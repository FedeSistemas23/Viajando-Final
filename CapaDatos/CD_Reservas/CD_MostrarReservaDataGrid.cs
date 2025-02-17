using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos
{
    public class CD_MostrarReservaDataGrid:Conexion
    {
       
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            DataTable tabla = new DataTable();
            public DataTable MostrarReservaDgv_CD()
            {
                SqlDataReader leer;
                try
                {
                    cmd.Connection = conexion.AbrirConexion();
                    cmd.CommandText = "MostrarReservaDataGrid";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@NroReserva",NumReserva);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                    da.Fill(tabla);
                    
                    return tabla;

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
        }
    }


