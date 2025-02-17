using CapaNegocio;
using CapaSesion;
using Loggin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectViajando
{
    [TestFixture]
    public class EliminarReserva_Test_Integracion
    {
        CN_ElimnarReserva eliminar = new CN_ElimnarReserva();
            
            [SetUp]
            public void SetUp()
            {

            eliminar.EliminarReservaCN(1009);

             }
            [Test]

            public void Verifica_SiSeGuardaCorrectamenteLaReserva()
            {
              
                bool t = true;
            bool result = eliminar.EliminarReservaCN(1008);
                

                
                Assert.That(result, Is.EqualTo(t));
            }
        }
}
