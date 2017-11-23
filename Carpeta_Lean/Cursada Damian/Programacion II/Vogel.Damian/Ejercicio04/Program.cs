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


            double numero = 0;
            double i = 0, j = 0;
            double acum = 0;

           // Console.WriteLine("Ingrese numero:");
           // numero = Double.Parse(Console.ReadLine());

            for (i = 1; ; i++)
            {
                acum = 0;
                
                for (j =1 ; ; j++)
                {
                    if (j % i == 0)
                    {
                        acum += j; 
                    }
                
                    if (acum == j && i>5)
                        {
                            Console.WriteLine(i);
                            i++;
                            //break; 
                       
                        
                        }        
                    
                
                
                
                }
            }
        }
    }
}