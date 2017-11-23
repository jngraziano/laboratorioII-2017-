using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            //Creo los instancio los objetos tipo tempera. 

            Tempera a = new Tempera(ConsoleColor.Blue, 3, "PELIKAN");
            Tempera b = new Tempera(ConsoleColor.Blue, 3, "PELIKAN");
            Tempera c = new Tempera(ConsoleColor.Green, 5, "Color FEO");
            //OK
            
            //Muestro los 3 objetos. 
           
            //Console.WriteLine(Tempera.Mostrar(a));
            
            //Console.WriteLine(Tempera.Mostrar(b));
            
            //Console.WriteLine(Tempera.Mostrar(c));

            //Console.ReadKey();
           
            //OK


            //Instancio el array de tempera con 3.
            Tempera[] arrayTempera = new Tempera[num];

            //Agrego las temperas al array de Tempera.
            arrayTempera.SetValue(a, 0);
            arrayTempera.SetValue(b, 1);
            arrayTempera.SetValue(c, 2);

            // Los muestro con un for.
            //for (int i = 0; i < arrayTempera.Length; i++)
            //{
            // Console.WriteLine(Tempera.Mostrar(arrayTempera[i]));   
            //}


            //Console.ReadKey();
            //OK

          
            //Los muestro con un foreach.
            //foreach (Tempera item in arrayTempera)
            //{
            //    Console.WriteLine(Tempera.Mostrar(item));
            //}
            //OK

            
            //Comparo la sobre carga == con Temperas.
            if (a == b)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintas");
            }


            //if (a != b)
            //{
            //    Console.WriteLine("Son Distintas");
            //}
            //else
            //{
            //    Console.WriteLine("Son Iguales");
            //}
            
            //OK
           
            //Suma de Temperas, sobre carga del +.
            //Tempera pruebaSuma = a + b; //Sumo dos paletas iguales.


            //Console.WriteLine(Tempera.Mostrar(pruebaSuma));//Muestro las sumas de las cantidades.

            //Tempera pruebaSuma1 = a + c; //Sumos dos paletas distintas.

            //Console.WriteLine(Tempera.Mostrar(pruebaSuma1));//Muestro las sumas de las cantidades, no tienen que cambiar.
            ////OK


            //Utilizo la asignacion implicita para instanciar un objeto paleta con el array (tamaño = 3).
            Paleta paleta = 3;

            //Asigno 3 temperas a la paleta!
            paleta = paleta + a;
            paleta = paleta + b;
            paleta = paleta + c;


            Tempera temperita = new Tempera(ConsoleColor.DarkGreen, 5, "Pepito");

            //Muestro la paleta!
            string prueba = (string)paleta;

            Console.WriteLine(prueba);

            
            
            //Probando la sobre carga del operador == (Paleta == tempera)
            //if (paleta == c)
            //{
            //    Console.WriteLine("Se encuenta la tempera en la paleta");
            //}
            //else
            //{
            //    Console.WriteLine("No se encuenta en la paleta");
            //}

            //if (paleta == temperita)
            //{
            //    Console.WriteLine("Se encuenta la tempera en la paleta");
            //}
            //else
            //{
            //    Console.WriteLine("No se encuenta en la paleta");
            //}

            //PRobando la sobrecarga del != (Paleta palera == Tempera temperita)


            //if (paleta != temperita)
            //{
            //    Console.WriteLine("No se encuenta la tempera en la paleta");
            //}
            //else
            //{
            //    Console.WriteLine("Se encuenta en la paleta");
            //}


            
            
            //Probamos la sobre carga del operador + (Paleta paleta + Paleta paleta2) suma de paletas.
            Paleta paleta2 = 3;

            paleta2 = paleta2 + temperita;


             Paleta sumaDePaletas = paleta + paleta2;

            prueba = (string)sumaDePaletas;

            Console.WriteLine(prueba);

            sumaDePaletas = sumaDePaletas - temperita;

            prueba = (string)sumaDePaletas;

            Console.WriteLine(prueba);


            Console.ReadKey();
      
        }
    }
}
