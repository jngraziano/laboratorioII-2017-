using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] aux = new Int32[27];
          

            for (int i = 0; i < aux.Length; i++)
            {
                aux[i] = i;
            }

            
            Console.WriteLine("\nMuestro al revez: ");
            
            Array.Reverse(aux);
            for (int i = 0; i < 27; i++)
            {
                
                Console.WriteLine(aux[i]);

            
            }
            //for (int i = aux.Length-1; i >= 0; i--)
            //{
            //    if (aux[i] % 7 == 0 && aux[i] != 0)
            //    {
            //        Console.WriteLine(aux[i]);
            //    }
            //}
            Console.ReadKey();

            


        }
    }
}
