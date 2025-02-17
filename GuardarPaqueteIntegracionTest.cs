using CapaDatos;
using CapaNegocio;
using CapaSesion;
using interfazPpal;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace Viajando.IntegrationTests
{
    
    [TestFixture]
    public class GuardarPaqueteIntegrationTests
    {
        int id;
       
       [SetUp]
        public void SetUp()
        {
            CN_GuardarPaquete _guardarPaquete= new CN_GuardarPaquete(); 
            CS_AtributosPaquete paquete = new CS_AtributosPaquete()
            {

                FechaSalida = DateTime.Now,
                FechaRegreso = DateTime.Now,
                Destino = "Catamarca",
                CantidadDias = 7,
                CantidadNoches = 4,
                Regimen = "Media Pension",
                ProveedorHotel = "Cataratas",
                ProveedorBus = "Buses del Litoral",
                GastosAdministrativos = 25000,
                PrecioLista = 250000,
                PrecioEfectivo = 215000,
                Coste = 11000000,
                Disponibilidad = 60,
                CantidadDeHab = 30,
                Single = 3,
                Doble = 25,
                Triple = 2,
                Cuadruple =0,
                TipoBus = "Semicama",
                CantidadAsientos = 60,
                AsientosCama = 12,
                AsientosSemicama = 48,
            };
            _guardarPaquete.GuardarPaqueteL(paquete);
            //id = _guardarPaquete.Id;
        }

        [Test]
        public void GuardarPaquete_DeberiaGuardarCorrectamente()
        {
            
            CD_GuardarPaquete paquete= new CD_GuardarPaquete();           
            CS_AtributosPaquete nuevoPaquete = paquete.VerificarNuevoPaqueteD(id);
            
            string newdestino= nuevoPaquete.Destino;
            int cantidaddias = nuevoPaquete.CantidadDias;

            Assert.That(newdestino, Is.EqualTo("Chaco"));
            //Assert.That(cantidaddias, Is.EqualTo(7));

        }
    }
}
