using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
   public class CS_AtributosPasajeros
    {
        public int? Id_Pasajero {  get; set; }
        public int NroReserva { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string nacionalidad { get; set; }
        public string email { get; set; }
        public string Calle {  get; set; }
        public int Numero {  get; set; }
        public string Localidad {  get; set; }
        public string Partido { get; set; }
        public string Provincia { get; set; }
        public string Ascenso { get; set; } 

       //falta transformar los bool a bit en cv.
        public bool menor_de_3 { get; set; }
        public bool TieneObraSocial { get; set; }
        public string ObraSocial { get; set; }

        
    }
}
