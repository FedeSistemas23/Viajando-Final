using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
 public class ConversionesDeTipo
    {
      
            public double ConvertirTextoADouble(string valorTexto)
            {
                
                double valorConvertido;

                
                if (double.TryParse(valorTexto, out valorConvertido))
                {
                    return valorConvertido; 
                }
                else
                {
                    
                    return 0.0;
                  
                }
            }
        }
    }

