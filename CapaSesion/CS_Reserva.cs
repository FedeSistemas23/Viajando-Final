using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace CapaSesion
{
    public class CS_Reserva
    {
        public int NroReserva { get; set; }
        public int Id_pasajero { get; set; }
        public int Id_Paquete { get; set; }
        public int? NroPago { get; set; }
        public int CantidadPasajeros { get; set; }
        public int Id_Vendedor { get; set; }
        public int? CantMenorTres { get; set; }
        public int? AsientosCama { get; set; }
        public int? AsientosSemiCama { get; set; }
        public int? Single { get; set; }
        public int? Doble { get; set; }
        public int? Triple { get; set; }
        public int? Cuadruple { get; set; }
        public string AscensoMicro { get; set; }
        public int? CamaSimple { get; set; }
        public int? CamaMatrimonial { get; set; }
        public bool Cotizar { get; set; }
        public double? Senia { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaSalida { get; set; }

        public DateTime FechaReserva = DateTime.Now;
        public DateTime FechaRegreso { get; set; }
        public string NombreTitular { get; set; }
        public string ApellidoTitular { get; set; }
        public bool AdicionalCama { get; set; }
        public int? Habitaciones { get; set; }
        public string NombreVendedor { get; set; }
        public string Destino { get; set; }

        public List<CS_Reserva> ListReserva = new List<CS_Reserva>();

        public List<CS_Reserva> AgregarLista(CS_Reserva reserva)
        {
            ListReserva.Add(reserva);
            var reservaNueva = ListReserva.Where(p => p.NroReserva == reserva.NroReserva).ToList();

            return reservaNueva;


        }



    }
}




    

