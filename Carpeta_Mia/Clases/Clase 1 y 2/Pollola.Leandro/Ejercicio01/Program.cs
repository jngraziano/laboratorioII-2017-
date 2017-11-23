using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int Nro;
            int Acum;
            int Max;
            int Min;
            int CantNum;

            CantNum = 2;
            Max = 0;
            Min = 0;
            Acum = 0;

            for (int i = 1; i < CantNum; i++)
            {
                Console.Write("Ingrese el {0} Nro: ", i);
                Nro = int.Parse(Console.ReadLine());
                Acum += Nro;
                if  (i==1)
                {
                    Max = Nro;
                    Min = Nro;
                }
                else   
                {
                    if (Nro >= Max)
                       {
                           Max = Nro;
                       }
                    if(Nro <=  Min)
                    {
                        Min = Nro;
                    }
                }

            }

            Console.WriteLine("El mayor numero es {0}", Max);
            Console.WriteLine("El menor numero es {0}", Min);
            Console.WriteLine("El promedio es {0}", (float)Acum /CantNum);

            Console.ReadLine();
        }
    }
}
