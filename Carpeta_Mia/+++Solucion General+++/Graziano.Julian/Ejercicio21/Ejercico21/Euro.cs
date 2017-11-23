using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico21
{
    class Euro
    {
        public double valor;
      

    
        
        public static Euro operator +(Euro E, Dolar D)

        {
            Euro resultado = new Euro();

            resultado.valor= E.valor + (D.valor/ 1.3642);  

            
            return resultado;
            
            
        
        }
        public static Euro operator -(Euro E, Dolar D)
        {
            Euro resultado = new Euro();

            resultado.valor = E.valor - (D.valor / 1.3642);


            return resultado;



        }
        public static Euro operator *(Euro E, Dolar D)
        {
            Euro resultado = new Euro();

            resultado.valor = E.valor * (D.valor / 1.3642);


            return resultado;



        }
        public static Euro operator /(Euro E, Dolar D)
        {
            Euro resultado = new Euro();
            

            resultado.valor = E.valor / (D.valor / 1.3642); 


            


            return resultado;



        }

        public static double ValidarEuro(double a)
        {
            while(a==0)
            {
                Console.WriteLine("\nError. No puede ser 0. Reingrese: ");
                a=double.Parse(Console.ReadLine());
            
            }

            return a;
        
        }

    }
}
