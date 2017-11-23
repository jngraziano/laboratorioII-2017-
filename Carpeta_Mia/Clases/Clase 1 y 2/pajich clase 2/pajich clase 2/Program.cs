using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Program
    {
        static void Main(string[] args)
        {


            if (!Validadora.ValidarNumeros(5, -50, -100))
            //el ! significa valores booleanos osea true o false
            {
                Console.Write("Fuera de rango");
            }
            else
            {
                Console.Write("Dentro del rango");
            }
            Console.ReadLine();
        }
  }
}
