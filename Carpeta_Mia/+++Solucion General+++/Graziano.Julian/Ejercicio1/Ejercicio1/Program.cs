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

            Console.Title = "Ejercicio1";
            
            int []nota= new int[5];
            int i;
            int maxnota=0;
            int minnota=0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese n {0}", i+1);
                nota[i] = int.Parse(Console.ReadLine());
                
                if (maxnota < nota[i])
                {
                    maxnota = nota[i];
                    //minnota = maxnota;


                }

                if (nota[i] < minnota)
                {
                    minnota = nota[i];
                    
                    //esta mal el minimo
                }
            }
            Console.WriteLine("max nota: {0}", maxnota);
            Console.WriteLine("min nota: {0}", minnota);
            Console.ReadKey();
        }
    }
}
