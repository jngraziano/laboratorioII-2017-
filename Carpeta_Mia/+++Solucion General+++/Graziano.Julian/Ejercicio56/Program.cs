using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio56
{
    class Program
    {
        static void Main(string[] args)
        {

        //    El procedimiento es el siguiente: Se crea un objeto FacturaC que por lo menos
        //    tendrá dos ítems distintos (se crearán dos objetos de tipo Item distintos).

            FacturaC miFacturaC = new FacturaC(123123, DateTime.Now, "queDatos", 60000);
            Item item1 = new Item(3333,2,"Pomelos",15);
            Item item2= new Item(2222,10,"Manzanas",20);


            miFacturaC.AgregarItem(item1);
            miFacturaC.AgregarItem(item2);

            Console.WriteLine(miFacturaC.Mostrar());
            Console.ReadKey();
            Console.WriteLine("\nMostrar el total: ");
            Console.WriteLine(miFacturaC.CalcularTotal().ToString());
            Console.ReadKey();

        }
    }
}
