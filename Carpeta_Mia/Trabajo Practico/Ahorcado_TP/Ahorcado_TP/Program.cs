using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahorcado.GUI;
using Ahorcado.Palabras;

namespace Ahorcado_TP
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 50;
            Pantalla pantalla = Pantalla.ObtenerInstancia("TP Programacion 2 - 2do D - Julian Graziano", 1, 1);
            pantalla.DibujarFigura(eErrores.SinErrores);
            Console.ReadKey();

           

            Juego miJuego = new Juego();
            
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
