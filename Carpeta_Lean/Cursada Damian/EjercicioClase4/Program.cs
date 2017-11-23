using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Auto primerAuto = new Auto("Ford");
            Auto segundoAuto = new Auto("Ford", "Negro");
            Auto tercerAuto = new Auto("Ford", "Negro", ETipoCombustible.Nafta);
            Auto cuartoAuto = new Auto("Ford", "Negro", ETipoCombustible.Nafta, 5.5f);


            Console.WriteLine(Auto.Mostrar(primerAuto));

            Console.ReadLine();

        
        }
    }
}
