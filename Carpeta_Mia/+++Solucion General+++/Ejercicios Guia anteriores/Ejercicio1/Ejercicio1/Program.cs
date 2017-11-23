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
            Console.Title= "Ejercicio 1 pero realizado con vectores";

            int [] numeros=new int [5];
            int i;
            int numfor = 2;
            //int valor1=11;
            //int valor2=2;
            //int valor3=10;
            //int valor4=22;
            //int valor5=15;
            int  maximo = 0;
            int  minimo = 0;
            float promedio = 0;
            int acum = 0;
            float acum2 = 0;

            //Console.Write("Ingrese numero: ");
            for (i = 0; i < numfor; i++)
            {
                Console.Write("Ingrese numero {0}:", i+1);
                numeros[i]=int.Parse(Console.ReadLine());
                if (numeros[i] > maximo)
                {
                    //acum = numeros[i];
                    maximo = numeros[i];
                    minimo = numeros[i];
                }
                if(numeros[i] < minimo)
                {
                    //acum = numeros[i];
                    minimo = numeros[i];
                }

                acum2 += numeros[i];
                promedio = acum2 % 5;

                
            }

            Console.Write("El maximo es {0}", maximo);
            Console.Write("\n\nEl minimo es {0}", minimo);
            Console.Write("\n\nEl promedio es {0}", promedio);
            Console.ReadKey();
            

        }
    }
}
