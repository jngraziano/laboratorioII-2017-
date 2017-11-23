using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        //public float resultado;
        
       
        public static float Calcular (int i, int y, char b)
        {
                 float resultado = 0;
                    
                    if(b == '+')
                            {
                                resultado = i + y;
                            }
                    
                 if(b == '-')
                         {
                                resultado = i-y;    
                         }
            
                 if(b == '*')
                        {     
                             resultado = i*y;
                         }
                
                 if (b == '/')                                                                           
                         {
                             if (!Calculadora.Validar(y))
                             {
                                 Console.WriteLine("En la division el divisor no puede ser 0");
                                 Console.ReadKey();
                             }
                             resultado = i / y;
                          }


                 return resultado;
        }


            private static bool Validar(int y)
                {
                    bool rta = false;

                    if (y != 0)
                        {
                         return true;
                        }
                            return rta;
                }
            
            public static void Mostrar(float a)
                {
                    Console.WriteLine("El resultado es: {0}",a);
                    Console.ReadKey();
                }
    
    
    
    }
}
