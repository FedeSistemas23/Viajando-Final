using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_EliminarProveedorHotel
    {
        CD_EliminarProveedorHotel Proveedor = new CD_EliminarProveedorHotel();
        public void ELiminarProveedorHotelL (int Id_Proveedor)
        {
            Proveedor.EliminarProveedorHotelD(Id_Proveedor);
        }
    }
}
