using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 objeto = new Class1();
            try
            {
                objeto.PropAsigna = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
