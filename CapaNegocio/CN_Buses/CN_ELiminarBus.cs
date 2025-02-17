using CapaDatos;

namespace CapaNegocio
{
    public class CN_ELiminarBus
    {
        CD_EliminarBus EliminarBus = new CD_EliminarBus();
        public void ELiminarBusL(int id_provedorbus)
        {
            EliminarBus.EliminarBusD(id_provedorbus);
        }
    }
}
