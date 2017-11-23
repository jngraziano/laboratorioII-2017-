using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 3";

            double i = 1;
            int j = 0;
            bool flag = false;


            double numero1 = 0;
           // double cont = 0;
            //double numero2 = 0;

            Console.WriteLine("Ingrese numero: ");
            numero1 = double.Parse(Console.ReadLine());

            #region validacion
            //while (numero1 % 2 == 0)
            //{
            //    Console.WriteLine("Error, no es un numero primo, reingrese");
            //    numero1 = double.Parse(Console.ReadLine());
            //}
            #endregion


            Console.WriteLine("PRIMOS!");
            for (i = numero1; i > 0; i--)
            {
                
                for (j = 2; j < i; j++)
                {
                    flag = false;
                    
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    Console.WriteLine(i);
                   
            }
            Console.ReadLine();
        }
    }
}
