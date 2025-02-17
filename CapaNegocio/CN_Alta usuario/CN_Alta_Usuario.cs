using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_Alta_Usuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();

        public void AñadirAtributos(CS_AtributosUsuario usuario)
        {
            usuarioD.GuardarUsuarioD(usuario);
        }
    }
}
