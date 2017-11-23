using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //MOSTRAR POR CONSOLA TODOS LOS ATRIBUTOS DE LAS MASCOTAS
            //INGRESADAS EN LA GUARDERIA

            // Crear tres gatos
            // Crear tres perros
            // Crear un Guardería
            Gato gato1 = new Gato("Bola de Nieve", 3, ERaza.Siames);
            Gato gato2 = new Gato("Pepito", 12, ERaza.Persa);
            Gato gato3 = new Gato("Negri", 1, ERaza.Egipcio);

            Perro perro1 = new Perro("SuperDog", 2, ERaza.Dogo);
            Perro perro2 = new Perro("Spike", 7, ERaza.PastorAleman);
            Perro perro3 = new Perro("Firulais", 20, ERaza.Doberman);

            Guarderia guarderia = new Guarderia(30F, 100F);
            
            // Ingresar las mascotas a la guardería
            guarderia.IngresarMascota(gato1);
            guarderia.IngresarMascota(gato2);
            guarderia = guarderia + gato3;

            guarderia.IngresarMascota(perro1);
            guarderia.IngresarMascota(perro2);
            guarderia = guarderia + perro3;

            // Mostrar el total Facturado
            // Mostrar el total Facturado por Gato
            // Mostrar el total Facturado por Perro

            guarderia.MostrarTotalFactura();
            guarderia.MostrarTotalFactura(EMascota.Gato);
            guarderia.MostrarTotalFactura(EMascota.Perro);
            Console.ReadKey();

            guarderia.ImprimirDatosListasMascotas();
            guarderia.SerializarListaMascota(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio51\Serializa.xml");
            guarderia.DeserializarListaMascota();
            guarderia.TraerDatosMascota();

            Console.ReadKey();






        }

        
    }
}
