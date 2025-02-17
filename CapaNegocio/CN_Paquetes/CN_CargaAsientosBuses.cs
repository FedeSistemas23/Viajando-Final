using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_CargaAsientosBuses
    {
        CD_CargaAsientosBus CargadorAsientos= new CD_CargaAsientosBus();
        List<int> asientos = new List<int>();
        public List<int> CargaAsientosBusL(string nombrebus)
        {            
            asientos= CargadorAsientos.CargaAsientosBusD(nombrebus);
            if(asientos.Count == 0)
            {
                return null;
            }
            else
            {
                return asientos;
            }
        }
    }
}
