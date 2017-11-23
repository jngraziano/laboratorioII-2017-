using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";;
            miLibro[2] = "Cómo escribir expresiones con C#"; 

            miLibro[-1] = "Genero un índice erroneo";


            Console.WriteLine("Titulo: {0}", miLibro.Titulo);
            Console.WriteLine("Autor: {0}", miLibro.Autor);

            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)
                Console.WriteLine("Capitulo {0}: {1}", miLibro[i].Numero, miLibro[i].Titulo);


            Console.ReadLine();

        }
    }
}
