using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace CapaSesion
{
    public class CS_VencimientoPassword
 
    {
        public static int CalcularDiasRestantes(DateTime fechaPrimerIngreso, int venceCada)
        {
            // Calcula la fecha en la que expira la contraseña
            DateTime fechaVencimiento = fechaPrimerIngreso.AddDays(venceCada);
            
            // Calcula la diferencia entre la fecha de vencimiento y la fecha actual
            TimeSpan difFechas = DateTime.Now- fechaVencimiento ;

            // Retorna los días restantes
            return difFechas.Days;
        }
    }
}
