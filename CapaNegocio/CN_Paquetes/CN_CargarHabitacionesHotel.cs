using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CargarHabitacionesHotel
    {
        CD_CargarHabitacionesHotel CargadorHabitaciones;
        CS_HabitacionesYRegimen HabitacionesYRegimen;
        public CN_CargarHabitacionesHotel()
        {
            CargadorHabitaciones=new CD_CargarHabitacionesHotel();
            HabitacionesYRegimen = new CS_HabitacionesYRegimen();
        }

        public CS_HabitacionesYRegimen CargarHabitacionesL(string hotel)
        {
            HabitacionesYRegimen= CargadorHabitaciones.CargarHabitacionesD(hotel);
            if (HabitacionesYRegimen!=null)
            {
                return HabitacionesYRegimen ;
            }else
            {
                return null;
            }
           
        }
    }
}
