using CapaDatos;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboHotel
    {
        CD_CargaComboHotel Cargador = new CD_CargaComboHotel();
        List<string> Hoteles;
        public List<string> CargaComboHotelL(string destino)
        {
            Hoteles = Cargador.CargarComboHotelD(destino);
            if (Hoteles != null)
            {
                return Hoteles;
            }
            else
            {
                return null;
            }
        }
    }
}
