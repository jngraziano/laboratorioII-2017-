using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 3;
            //int [] vectores = new int [cant];
            //int [] positivos = new int [cant];
            //int [] negativos=new int [cant];
            System.Collections.Stack pila = new System.Collections.Stack();
            System.Collections.Stack positivos = new System.Collections.Stack();
            System.Collections.Stack negativos = new System.Collections.Stack();
            
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese numero {0}", i + 1);
                pila.Push(Valor1.Validar(int.Parse(Console.ReadLine())));
                
                
                
                if((int)pila.Peek()>=0)
                {
                    positivos.Push(pila.Peek());
                }
                else
                {
                    negativos.Push(pila.Peek());
                
                }

                
            
            }

            Console.WriteLine("\nNormal:\n");
            foreach (int valor in pila)
            {
                if (valor == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("{0}\n", valor);

                }
            
            }
            Console.WriteLine("\nPositivos:\n");
            foreach (int valor in positivos)
            {
                if (valor == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("{0}\n", valor);

                }
            
            }
            Console.WriteLine("\nNegativos:\n");
            foreach (int valor in negativos)
            {
                if (valor == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("{0}\n", valor);
                
                }
            }

            int cantidad = pila.Count;
            int cantidad2 = positivos.Count;
            int cantidad3 = negativos.Count;

            for (int i = 0; i < cantidad; i++)
            {
                pila.Pop();
            }

            

            for (int i = 0; i < cantidad2; i++)
            {
                positivos.Pop();
            }



            for (int i = 0; i < cantidad3; i++)
            {
                negativos.Pop();
            }
            Console.ReadKey();
            Console.WriteLine("pila: {0}\npositivos: {1}\nnegativos: {2}\n", pila.Count, positivos.Count, negativos.Count);

           


            Console.ReadKey();
        
        }


    }
}
