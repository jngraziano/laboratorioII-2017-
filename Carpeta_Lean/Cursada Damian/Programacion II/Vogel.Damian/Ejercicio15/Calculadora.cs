using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public float resultado;
        
       
        public static float Calcular (int i, int y, char b)
        {
                //float resultado;
                    if(b == '+')
                     {
                    return  i + y;
                     }
                    
                 if(b == '-')
                         {
                             return i-y;    
                         }
            
                 if(b == '*')
                        {     
                             return i*y;
                         }
                
                 if (b == '/')                                                                           
                         {
                             if (!Validar(y))
                             {
                                 Console.WriteLine("No puede ser 0");
                                 Console.ReadKey();
                             }
                             return = i / y;  
                        }
                           
                return ;
                
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
            
            public static void Mostrar()
                {
                    
                }
    
    
    
    }
}
