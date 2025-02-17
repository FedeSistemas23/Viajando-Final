using CapaDatos;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboBus
    {
        CD_CargaComboBus bus = new CD_CargaComboBus();
        List<string> buses;

        public List<string> CargadorComboBusL(string destino)
        {
            buses = bus.CargadorComboBusD(destino);

            if (buses == null)
            {
                return null;
            }
            else
            {
                return buses;
            }
        }
    }
}
