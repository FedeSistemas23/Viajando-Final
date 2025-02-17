using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_CargarComboDestino
    {
        CD_CargarComboDestinos Destino = new CD_CargarComboDestinos();
        public List<string> CargarComboDestinosL()
        {
            List<string> destino = new List<string>();
            destino= Destino.CargarComboDestinosD();
            
            if (destino != null)
            {
                return destino;
            }
            else
            {
                return null;
            }
        }
    }
}
