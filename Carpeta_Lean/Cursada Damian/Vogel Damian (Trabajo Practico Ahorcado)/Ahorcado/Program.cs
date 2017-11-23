using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahorcado.GUI;

namespace Ahorcado
{
    class Program
    {
        private static void Main(string[] args)
        {


            
            
            
            
            
            Juego miJuego = new Juego();
            
            

            Console.ReadKey();
            
            do
                     {
                        miJuego.Jugar();
                     } while (miJuego.DeboSeguirJugando);
            
            if (miJuego.Ganado)
                    {
                        Console.WriteLine("JUEGO GANADO :)");
                    }
            else
                    {
                        Console.WriteLine("JUEGO PERDIDO :( LA PALABRA CORRECTA ERA: {0}", miJuego.PalabraResuelta);
                    }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
