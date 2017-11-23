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
            
            List<nameBoligrafo.Boligrafo> miLista = new List<nameBoligrafo.Boligrafo>(); 
            nameBoligrafo.Boligrafo Unboligrafo = new nameBoligrafo.Boligrafo("blanco","bic",60); 
            Unboligrafo.Escribir(70); 
            if (Unboligrafo.RecargarTinta(90)) 
            Console.WriteLine("Boligrafo Recargado"); 
            else Console.WriteLine("No se pudo recargar"); 
            Unboligrafo.Escribir(30); 
            if (Unboligrafo.RecargarTinta()) 
            Console.WriteLine("Boligrafo Recargado"); 
            else Console.WriteLine("No se pudo recargar"); 
            miLista = miLista + Unboligrafo; 
            nameBoligrafo.Boligrafo boligrafo2 = new nameBoligrafo.Boligrafo("rojo","Silvapen",50); 
            miLista.Add(boligrafo2); 
            Console.WriteLine(" Muestro :");
            nameBoligrafo.Boligrafo.MostrarBoligrafos(miLista); 
            Console.ReadLine(); Console.WriteLine(" Sumo :"); 
            nameBoligrafo.Boligrafo Otrobligrafo = new nameBoligrafo.Boligrafo("verde", "Parker", 60); 
            miLista = miLista + Otrobligrafo;
            nameBoligrafo.Boligrafo.MostrarBoligrafos(miLista); 
            Console.ReadLine(); 
            Console.WriteLine(" Resto :"); 
            nameBoligrafo.Boligrafo BoligrafoTres = new nameBoligrafo.Boligrafo(40, "verde", "Parker"); 
            miLista = miLista - BoligrafoTres;
            nameBoligrafo.Boligrafo.MostrarBoligrafos(miLista); 
            Console.ReadLine(); }

        }
    }

