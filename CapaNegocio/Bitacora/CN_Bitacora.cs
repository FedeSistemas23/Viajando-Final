using CapaDatos;

namespace CapaNegocio
{
    public class CN_Bitacora
    {
        CD_Bitacora bitacora = new CD_Bitacora();
        public void GuardarBitacora(int usuario, string accion, string mensaje)
        {
            bitacora.InsertarBitacora(usuario, accion, mensaje);
        }
    }
}
