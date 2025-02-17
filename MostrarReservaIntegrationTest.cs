using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;
using System.Data;

namespace TestProjectViajando
{


    [TestFixture]
    internal class MostrarReservaIntegrationTest
    {
        

        CN_MostrarReserva MostrarReservaN= new CN_MostrarReserva();
        CD_MostrarReserva mostrarReservaD= new CD_MostrarReserva();
       

        [SetUp]
        public void setup()
        {
          MostrarReservaN.MostrarReservaCN();

        }



        [Test]
        public void EldatatableExiste()
        {
            DataTable tabla = MostrarReservaN.MostrarReservaCN();
            Assert.That(tabla != null);


        }
    }
   

}
