using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_MostrarProveedor
    {
        CD_MostrarProveedor Proveedor = new CD_MostrarProveedor();
        DataTable tabla = new DataTable();
        public DataTable MostrarProveedor()
        {
            
            tabla=null;
            tabla = Proveedor.Mostrar();
            if (tabla != null)
            {
                return tabla;
            }
            else
            {
                return null;
            }
        }
    }
}
