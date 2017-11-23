using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            char rta = 's';
            int op;
            //Agregar un constructor que reciba como parámetros todos sus
            //atributos y los métodos:
            //1- InformarEstado: informa el estado actual de la computadora
            //(marca, procesador, si está encendida o no, etc.).
            //2- Encender.
            //3- Apagar
            //Nota: Las clases, los enumerados y el Program deben estar en
            //namespaces distintos.

            Computadora compu1 = new Computadora();

            compu1.setEstaEncendida(false);
            compu1.setMarca(EMarca.Apple);
            compu1.setPeso(3);
            compu1.setProcesador(EProcesador.Intel_Core_i7);

            do
            {
                Console.Clear();
                Console.WriteLine("COMPUTADORA");
                Console.WriteLine("\n\n1 - Informar Estado.");
                Console.WriteLine("\n2 - Encender.");
                Console.WriteLine("\n3 - Apagar.");
                Console.WriteLine("\n4 - Salir.");
                Console.WriteLine("\n\nIngrese Opcion Deseada: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("DATOS COMPUTADORA");
                        compu1.Mostrar();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("ENCENDER EL EQUIPO");
                        if (compu1.getEstaEncendida() == true)
                        {
                            Console.WriteLine("\n\nEstado actual.........ENCENDIDA");
                            Console.WriteLine("\nEl equipo ya se encuentra encendido");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("\n\nEstado actual.........APAGADA");
                            Console.WriteLine("\nEl equipo se encuentra apagado.\nDesea Encenderlo?: ");
                            char rta2 = char.Parse(Console.ReadLine());
                            if (rta2 == 's')
                            { compu1.setEstaEncendida(true); Console.WriteLine("\nSe encendio el equipo"); break; }
                            else if (rta2 == 'n') { Console.WriteLine("\nNo se encendio el equipo."); Console.ReadKey(); break; }
                            else { Console.WriteLine("\nError letra ingresada."); break; }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("APAGAR EL EQUIPO");
                        if (compu1.getEstaEncendida() == true)
                        {
                            Console.WriteLine("\n\nEstado actual.........ENCENDIDA");
                            Console.WriteLine("\nEl equipo se encuentra encendido.\nDesea Apagarlo?: ");
                            char rta2 = char.Parse(Console.ReadLine());
                            if (rta2 == 's')
                            { compu1.setEstaEncendida(false); Console.WriteLine("\nSe apago el equipo"); Console.ReadKey(); break; }
                            else if (rta2 == 'n') { Console.WriteLine("\nNo se apago el equipo."); Console.ReadKey(); break; }
                            else { Console.WriteLine("\nError letra ingresada."); break; }
                        }
                        else
                        {
                            Console.WriteLine("\n\nEstado actual.........APAGADA");
                            Console.WriteLine("\nEl equipo ya se encuentra apagado.");
                            Console.ReadKey();                          
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Desea salir?: ");
                        rta = char.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                
                }


            } while (rta != 'n');
        }
    }
}
