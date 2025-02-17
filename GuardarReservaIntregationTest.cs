using CapaDatos;
using CapaNegocio;
using CapaSesion;

namespace TestProjectViajando
{
    [TestFixture]
    public class GuardarReservaIntregationTest
    {
        CN_GuardarReserva guardar;
        CS_Reserva reserva;
        //CD_GuardarReserva datos = new CD_GuardarReserva();
        [SetUp]
        public void SetUp()
        {

            // Arrange
          //  CD_GuardarReserva datos = new CD_GuardarReserva();
            guardar = new CN_GuardarReserva();
            reserva = new CS_Reserva
            {
                Id_Paquete = 6,
                CantidadPasajeros = 3,
                NombreVendedor = "Leandro",
                Destino = "Parana",
                FechaSalida = DateTime.Now,
                FechaReserva = DateTime.Now,
                FechaRegreso = DateTime.Now.AddDays(7)
            };
            guardar.GuardarReservaCN(reserva);
        }
        [Test]

        public void Verifica_SiSeGuardaCorrectamenteLaReserva()
        {
            // Act
            bool t = true;
            bool result = guardar.GuardarReservaCN(reserva);
            //  bool result = datos.GuardarReserva_CD(reserva);

            // Assert
            Assert.That(result, Is.EqualTo(t));
        }
    }
}
