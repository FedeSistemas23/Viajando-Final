using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_GuardarBus
    {
        CD_GuardaBusD guardarBus = new CD_GuardaBusD();

        public void GuardarBusL(CS_AtributosBus bus)
        {
            guardarBus.GuardarBusD(bus);
        }
    }
}
