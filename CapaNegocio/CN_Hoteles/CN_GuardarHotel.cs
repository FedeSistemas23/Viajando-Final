using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_GuardarHotel
    {
        private CD_GuardarHotel NewHotel;
        public CN_GuardarHotel()
        {
            NewHotel = new CD_GuardarHotel();
        }

        public void GuardarHotelL(CS_AtributosHotel Hotel)
        {

            NewHotel.GuardarHotelD(Hotel);
        }
    }
}
