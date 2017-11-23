using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int aux = 0;
            int acu = 2;
            int maxnum=0;
            int minnum=0;
            bool devu = false;

            for (int i = 0; i < acu; i++)
            {
                Console.WriteLine("Ingrese n {0}: ", i + 1);
                aux=int.Parse(Console.ReadLine());
                devu = validar.Validar(aux, -100, 100);
                do
                {
                    if (validar.Validar(aux, -100, 100))
                    {
                        num = aux;
                        if (i == 0)
                        {
                            maxnum = num;
                            minnum = num;
                        }
                        if (maxnum < num)
                        {
                            maxnum = num;



                        }
                        if (minnum > num)
                        {
                            minnum = num;
                        
                        }

                        //Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Error de validacion. Reingrese: ");
                        num=int.Parse(Console.ReadLine());
                        devu = validar.Validar(num, -100, 100);
                    }
                } while (devu == false);
            }
           

            

            Console.WriteLine("Numero maximo: {0}",maxnum);
            Console.WriteLine("Numero minimo: {0}", minnum);
            Console.ReadKey();
        }
    }
}
