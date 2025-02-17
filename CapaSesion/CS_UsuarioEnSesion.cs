using System;
using System.Collections.Generic;

namespace CapaSesion
{
    public static class CS_UsuarioEnSesion
    {
        public static int Id_Usuario { get; set; }
        public static string Username { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string TipoDoc { get; set; }
        public static string NroDoc { get; set; }
        public static string Telefono { get; set; }
        public static string Celular { get; set; }
        public static string Calle { get; set; }
        public static string Nro { get; set; }
        public static string Localidad { get; set; }
        public static string Partido { get; set; }
        public static string Provincia { get; set; }
        public static string Pais { get; set; }
        public static string email { get; set; }
        public static bool UsuarioTemporal { get; set; }
        public static int VencimientoUsuarioTemporal { get; set; }
        public static string Familias { get; set; }
        public static List<int> Permisos { get; set; }
        public static int VencimientosPermisos { get; set; }
        public static bool Bloqueado { get; set; }
        public static int bloqueadoHasta { get; set; }
        public static bool DesbloqueoAutomatico { get; set; }
        public static int CadaCuantasHorasSeDesbloquea { get; set; }
        public static DateTime? fechaPrimerIngreso { get; set; }
        public static DateTime? fechaUltimoCambio { get; set; }
        public static string password { get; set; }
        public static int venceCada { get; set; }
        public static int intentos { get; set; }
        public static int digito { get; set; }
        public static int Digito { get; set; }
        public static int VencePass { get; set; }
        public static bool AvisarVencimientoPassword { get; set; }
        public static bool ContraseñasAnteriores { get; set; }
        public static bool Minuscula { get; set; }
        public static bool Mayuscula { get; set; }
        public static bool Numeros { get; set; }
        public static bool CaracterEspecial { get; set; }
        public static bool Minimo8Caracteres { get; set; }
        public static bool RealizarPreguntasSeguridad { get; set; }
        public static bool Autenticacion2pasos { get; set; }
        public static void LimpiarUsuario()
        {
            Id_Usuario = 0;
            Username = null;
            Nombre = null;
            Apellido = null;
            TipoDoc = null;
            NroDoc = null;
            Telefono = null;
            Celular = null;
            Calle = null;
            Nro = null;
            Localidad = null;
            Partido = null;
            Provincia = null;
            Pais = null;
            email = null;
            UsuarioTemporal = false;
            VencimientoUsuarioTemporal = 0;
            Familias = null;
           // Permisos.Clear(); 
            VencimientosPermisos = 0;
            Bloqueado = false;
            bloqueadoHasta = 0;
            DesbloqueoAutomatico = false;
            CadaCuantasHorasSeDesbloquea = 0;
            fechaPrimerIngreso = null; 
            fechaUltimoCambio = null; 
            password = null;
            venceCada = 0;
            intentos = 0;
            Digito = 0;
            VencePass = 0;
            AvisarVencimientoPassword = false;
            ContraseñasAnteriores = false;
            Minuscula = false;
            Mayuscula = false;
            Numeros = false;
            CaracterEspecial = false;
            Minimo8Caracteres = false;
            RealizarPreguntasSeguridad = false;
            Autenticacion2pasos = false;
        }
    }
}

