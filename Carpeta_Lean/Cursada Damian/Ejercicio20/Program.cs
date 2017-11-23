using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geometria;
using System.Threading.Tasks;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto a = new Punto(2, 5);

            Rectangulo r = new Rectangulo(a, new Punto(2, 5));

            Console.WriteLine(r.lado);

            Console.WriteLine(r.perimetro);

            Console.WriteLine(r.area);

            Console.ReadLine();
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
