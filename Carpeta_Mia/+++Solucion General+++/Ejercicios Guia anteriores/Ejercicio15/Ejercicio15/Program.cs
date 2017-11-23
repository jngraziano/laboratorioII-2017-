using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado=Calculadora.Calcular(2,0,'/');
            Calculadora.Mostrar(resultado);
            Console.ReadLine();
            
        }
    }
}
