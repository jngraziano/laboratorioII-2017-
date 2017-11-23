using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoligrafoName;

namespace Ejercicio33_Boligrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo bolUno = new Boligrafo(7, "Rojo", "Bic");
            Boligrafo bolDos = new Boligrafo("Rojo", 7, "Bic");
            Boligrafo bolTres = new Boligrafo("Rojo", "Bic", 7);
            Boligrafo bolCuatro = new Boligrafo("Rojo", "Marca");



        }
    }
}
