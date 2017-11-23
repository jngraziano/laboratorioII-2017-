using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConstructorA objConst = new ConstructorA();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Mensaje);
            }
        }
    }
}
