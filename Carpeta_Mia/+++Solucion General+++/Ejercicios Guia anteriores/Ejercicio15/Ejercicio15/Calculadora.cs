using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static float resultado;
        public static float Calcular(int primer, int segundo, char operacion)
        {
            
            //Validar(segundo);
            switch(operacion)
            {

            case '+':
                
               resultado=primer+segundo;

            break;
            case '-':
                 resultado=primer-segundo;
            break;
            case '*':
                resultado=primer*segundo;
            break;
            case '/':
                    if(Validar(segundo))
                    {
                    resultado=primer/segundo;
                    }
                    break;
                default:
                    break;
            }
        return resultado;
            
            
            
            
        }

         static bool Validar(int segundo)
        {
            if(segundo != 0)
            {
             return true;
            }
             else
            {
                Console.Write("No se puede dividir por 0");
                return false;
            }
        }
     public static void Mostrar(float resultado)
     {
        Console.Write(resultado);
     }

    }
}
