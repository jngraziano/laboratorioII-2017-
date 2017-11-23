using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Realizar la clase Bolígrafo que posea tres atributos privados _marca (String), _color (string),
            //_canitdadTinta (int).
            //a. Colocarla en un “namespace” distinto al Program
           
            
            List<Boligrafo> miLista = new List<Boligrafo>();
            Boligrafo Unboligrafo = new Boligrafo("blanco", "bic", 60);
            Unboligrafo.Escribir(70);
            if (Unboligrafo.RecargarTinta(90))
                Console.WriteLine("Boligrafo Recargado");
            else
                Console.WriteLine("No se pudo recargar");
            Unboligrafo.Escribir(30);
            if (Unboligrafo.RecargarTinta())
                Console.WriteLine("Boligrafo Recargado");
            else
                Console.WriteLine("No se pudo recargar");
            miLista = miLista + Unboligrafo;
            Boligrafo boligrafo2 = new Boligrafo("rojo", "Silvapen", 50);
            miLista.Add(boligrafo2);
            Console.WriteLine(" Muestro :");
            Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine();
            Console.WriteLine(" Sumo :");
            Boligrafo Otrobligrafo = new Boligrafo("verde", "Parker", 60);
            miLista = miLista + Otrobligrafo;
            
            Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine();
            Console.WriteLine(" Resto :");
            Boligrafo BoligrafoTres = new Boligrafo("verde", "Parker",40);
            miLista = miLista - BoligrafoTres;
            Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine();
        }
    }
}
