using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_MostrarBuses
    {
        CD_MostrarBuses MostradorBuses;
        List<CS_AtributosBus> Buses;
        public CN_MostrarBuses()
        {
             MostradorBuses = new CD_MostrarBuses();
            Buses = new List<CS_AtributosBus> ();
        }
        
        public List<CS_AtributosBus> MostrarBusesL()
        {
            Buses=null;
            Buses = MostradorBuses.MostrarBusesD();
            if (Buses == null)
            {
                return null;
            }
            else
            {
                return Buses;
            }
        }
    }
}
