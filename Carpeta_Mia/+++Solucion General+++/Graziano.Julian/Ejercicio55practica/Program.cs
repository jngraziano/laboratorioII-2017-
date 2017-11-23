using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("ABC123", Marca.Ford, 4, 6);
            Auto auto2 = new Auto("DEF456", Marca.Fiat, 4, 4);
            Moto moto1 = new Moto("GHI789", Marca.Zanella, 2, 1300);
            Moto moto2 = new Moto("JKL000", Marca.Honda, 2, 3600);
            Lavadero miLavadero = new Lavadero(12.5F, 9.8F);
            //INGRESAR LOS AUTOS Y LAS MOTOS
            miLavadero.IngresarAlLavadero(auto1);
            miLavadero.IngresarAlLavadero(auto2);
            miLavadero.IngresarAlLavadero(moto1);
            miLavadero.IngresarAlLavadero(moto2);

            double totalPorAuto = 0, totalPorMoto = 0, totalVehiculos = 0;
            totalPorAuto = miLavadero.MostrarTotalFacturado(Vehiculos.Auto);
            totalPorMoto = miLavadero.MostrarTotalFacturado(Vehiculos.Moto);
            totalVehiculos = miLavadero.MostrarTotalFacturado();
            Console.WriteLine("Facturado por Autos: {0}", totalPorAuto);
            Console.WriteLine("Facturado por Motos: {0}", totalPorMoto);
            Console.WriteLine("Facturado por Vehiculos: {0}", totalVehiculos);
            Console.WriteLine("Cantidad total de Vehiculos: {0}",
            miLavadero.cantidadVehiculos);
            Console.WriteLine("Listado de vehiculos");
            //MOSTRAR TODOS LOS ATRIBUTOS DE LOS VEHICULOS INGRESADOS AL LAVADERO
            auto1.Mostrar();
            Console.ReadKey();
            auto2.Mostrar();
            Console.ReadKey();
            moto1.Mostrar();
            Console.ReadKey();
            moto2.Mostrar();
            Console.ReadKey();

        }
    }
}
