using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        //F = C * (9/5) + 32
        //C = (F-32) * 5/9
        //F = K * 9/5 – 459.67 
        //K = (F + 459.67) * 5/9

        static void Main(string[] args)
        {
            Celcius c = new Kelvin(20);
            Kelvin k = new Fahrenheit(30);
            Fahrenheit f = new Celcius(10);
        }
    }  
}
