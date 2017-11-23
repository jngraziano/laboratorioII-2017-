using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            //48. A partir del ejercicio 42, se pide crear una interfaz llamada
            //IMostrar‘ que posea un método llamado ‗Mostrar‘ que, en la clase
            //‗ClientePlus‘ donde será implementada, muestre la información de
            //ese cliente en la consola.

            Cliente cliente1 = new Cliente("20000", 123);
            ClientePlus cliente2 = new ClientePlus("Perez",321,"20000",22,"Juan",3000);
            //Cliente cliente3 = new Cliente("123123", 444);

            cliente1.GuardarEnDisco(cliente1);
            cliente2.GuardarEnDisco(cliente2);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("EJERCICIO 48: ");
            cliente2.Mostrar();
            Console.ReadKey();
        }
    }
}
