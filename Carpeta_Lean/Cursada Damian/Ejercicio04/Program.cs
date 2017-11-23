using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";


            double cont = 0;
            double i = 0, j = 0;
            double acum = 0;
            bool flag = false;


           // Console.WriteLine("Ingrese numero:");
           // numero = Double.Parse(Console.ReadLine());

            for (i = 1; ; i++)
            {
                acum = 0;
                flag = true;


                for (j =1 ;j<i ; j++)
                {
                  
                    if (i % j == 0)
                    {
                        acum += j; 
                    }
                
                }

                if (acum == i && flag == true)
                {
                    Console.WriteLine(i);
                    cont += 1;
                    flag = false;
                }        
                    
                
                if (cont == 4)
                {
                    Console.ReadKey();
                    break;
                }
            
            }
        }
    }
}