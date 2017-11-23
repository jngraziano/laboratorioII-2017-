using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";

            #region Variables
            int[] nota = new int[5];
            int maximo = 0;
            int minimo = 0;
            //int aux = 0;
            #endregion

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nIngrese un numero {0}: ",i+1);
                nota[i]=int.Parse(Console.ReadLine());
                if (nota[i] > maximo)
                {
                    maximo = nota[i];
                                    
                }
               
                else if (nota[i] < minimo)
                {
                    minimo = nota[i];
                
                }
                     
            }
            Console.WriteLine("\n\nFIN DE LA CARGA");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("PRINT: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", nota[i]);
            
            }
            Console.WriteLine("\n\nIngrese una tecla para ver Mayor y Menor");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("MAXIMO");
            Console.WriteLine("\n{0}", maximo);
            Console.WriteLine("\n\nMINIMO");
            Console.WriteLine("\n{0}", minimo);
            Console.ReadKey();

        }
    }
}
