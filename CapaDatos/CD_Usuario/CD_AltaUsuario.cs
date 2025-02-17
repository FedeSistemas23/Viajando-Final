using CapaSesion;
using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_AltaUsuario : Conexion
    {
        public void GuardarUsuarioD(CS_AtributosUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand("AltaUsuario", conexion))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Asignar parámetros al procedimiento almacenado
                        command.Parameters.AddWithValue("@Username", usuario.Username);
                        command.Parameters.AddWithValue("@Password", usuario.password);
                        command.Parameters.AddWithValue("@Digito", usuario.Digito);
                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Email", usuario.Email);
                        command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                        command.Parameters.AddWithValue("@TipoDocumento", usuario.TipoDocumento);
                        command.Parameters.AddWithValue("@NumDocumento", usuario.NumDocumento);
                        command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        command.Parameters.AddWithValue("@Celular", usuario.Celular);
                        command.Parameters.AddWithValue("@Calle", usuario.Calle);
                        command.Parameters.AddWithValue("@NumCalle", usuario.NumCalle);
                        command.Parameters.AddWithValue("@Localidad", usuario.Localidad);
                        command.Parameters.AddWithValue("@Partido", usuario.Partido);
                        command.Parameters.AddWithValue("@Provincia", usuario.Provincia);
                        command.Parameters.AddWithValue("@Pais", usuario.pais);
                        command.Parameters.AddWithValue("@Familia", usuario.Familia);
                        command.Parameters.AddWithValue("@Intentos", usuario.intentos);
                        command.Parameters.AddWithValue("@VencePass", usuario.VencePass);
                        command.Parameters.AddWithValue("@AvisarVencimientoPassword", usuario.AvisarVencimientoPassword);
                        command.Parameters.AddWithValue("@ContraseñasAnteriores", usuario.ContraseñasAnteriores);
                        command.Parameters.AddWithValue("@Minuscula", usuario.Minuscula);
                        command.Parameters.AddWithValue("@Mayuscula", usuario.Mayuscula);
                        command.Parameters.AddWithValue("@Numeros", usuario.Numeros);
                        command.Parameters.AddWithValue("@CaracterEspecial", usuario.CaracterEspecial);
                        command.Parameters.AddWithValue("@Minimo8Caracteres", usuario.Minimo8Caracteres);
                        command.Parameters.AddWithValue("@RealizarPreguntasSeguridad", usuario.RealizarPreguntasSeguridad);
                        command.Parameters.AddWithValue("@Autenticacion2pasos", usuario.Autenticacion2pasos);
                        command.Parameters.AddWithValue("@Bloqueado", usuario.Bloqueado);
                        command.Parameters.AddWithValue("@BloqueadoHasta", usuario.BloqueadoHasta);
                        command.Parameters.AddWithValue("@UsuarioTemporal", usuario.UsuarioTemporal);
                        command.Parameters.AddWithValue("@VenceUsuario", usuario.VenceUsuario);
                        command.Parameters.AddWithValue("@VencenPermisos", usuario.VencenPermisos);
                        //command.Parameters.AddWithValue("@FechaPrimerIngreso", usuario.fechaPrimerIngreso);
                        //command.Parameters.AddWithValue("@FechaUltimoCambio", usuario.fechaUltimoCambio);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar el procedimiento almacenado o conectar a la base de datos.\n\n" + ex.Message);

            }finally
            {
                CerrarConexion();
            }
        }
    }
}
