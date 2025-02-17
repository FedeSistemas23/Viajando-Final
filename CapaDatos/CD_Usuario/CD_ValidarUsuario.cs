using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{


    public class CD_ValidarUsuario : Conexion
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public bool ValidarUsuarioD(string username)
        {

            try
            {
                cmd.Connection = conn.AbrirConexion();
                cmd.CommandText = "ValidarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        CS_UsuarioEnSesion.Id_Usuario = leer.GetInt32(leer.GetOrdinal("IdUsuario"));
                        CS_UsuarioEnSesion.Username = leer["Username"].ToString();
                        CS_UsuarioEnSesion.password = leer["Password"].ToString();
                        CS_UsuarioEnSesion.email = leer["Email"].ToString();

                        // Cargar Intentos Fallidos (valor predeterminado en caso de null)
                        CS_UsuarioEnSesion.intentos = leer.IsDBNull(leer.GetOrdinal("Intentos")) ? 0 : leer.GetInt32(leer.GetOrdinal("Intentos"));

                        // Cargar Fecha Último Cambio (valor predeterminado)
                        CS_UsuarioEnSesion.fechaUltimoCambio = leer.IsDBNull(leer.GetOrdinal("FechaUltimoCambio")) ? DateTime.Now : leer.GetDateTime(leer.GetOrdinal("FechaUltimoCambio"));

                        // Cargar Vence Cada
                        CS_UsuarioEnSesion.venceCada = leer.GetInt32(leer.GetOrdinal("VencePass"));
                        CS_UsuarioEnSesion.Bloqueado = leer.GetBoolean(leer.GetOrdinal("Bloqueado"));

                        // Cargar Bloqueado Hasta (valor predeterminado)
                        CS_UsuarioEnSesion.bloqueadoHasta = leer.IsDBNull(leer.GetOrdinal("BloqueadoHasta")) ? 0 : leer.GetInt32(leer.GetOrdinal("BloqueadoHasta"));
                        // Cargar Fecha Primer Ingreso (valor predeterminado)
                        CS_UsuarioEnSesion.fechaPrimerIngreso = leer["FechaPrimerIngreso"] == DBNull.Value
                            ? (DateTime?)null
                               : Convert.ToDateTime(leer["FechaPrimerIngreso"]);

                        // Cargar otros atributos si existen en la tabla
                        CS_UsuarioEnSesion.venceCada = leer.IsDBNull(leer.GetOrdinal("VenceUsuario")) ? 0 : leer.GetInt32(leer.GetOrdinal("VenceUsuario"));
                        //CS_UsuarioEnSesion.Bloqueado = leer.GetBoolean(leer.GetOrdinal("Bloqueado"));
                        CS_UsuarioEnSesion.Autenticacion2pasos = leer.GetBoolean(leer.GetOrdinal("Autenticacion2pasos"));
                        // Agrega aquí más propiedades según sea necesario
                    }
                    return true; // Usuario válido
                }
                return false; // Usuario no encontrado
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
        }
    }
}

