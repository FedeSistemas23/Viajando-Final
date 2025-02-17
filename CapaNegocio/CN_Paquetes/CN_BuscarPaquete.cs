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
    public class CN_BuscarPaquete
    {
        CD_BuscarPaquete paqueteCD = new CD_BuscarPaquete();  
        CS_AtributosPaquete CamposPaquete = new CS_AtributosPaquete();
        DataTable dt = new DataTable();

        public DataTable BuscarPaqueteCN(CS_AtributosPaquete parametros)
        {
            dt = paqueteCD.BuscarPaqueteCD(parametros);
            return dt;
        }
    }
}
