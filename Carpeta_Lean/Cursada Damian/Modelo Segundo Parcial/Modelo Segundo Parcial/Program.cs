using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Segundo_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("ABC123", Marca.Ford, 4, 6);
            Auto auto2 = new Auto("DEF456", Marca.Fiat, 4, 4);
            Moto moto1 = new Moto("GHI789", Marca.Zanella, 2, 1300);
            Moto moto2 = new Moto("JKL000", Marca.Honda, 2, 3600);
            
            Lavadero miLavadero = new Lavadero(12.5f, 9.8f);
            //INGRESAR LOS AUTOS Y LAS MOTOS

            miLavadero.vehiculos = miLavadero.IngresarAlLavadero(auto1);
            miLavadero.vehiculos = miLavadero.IngresarAlLavadero(auto2);
            miLavadero.vehiculos = miLavadero.IngresarAlLavadero(moto1);
            miLavadero.vehiculos = miLavadero.IngresarAlLavadero(moto2);



            double totalPorAuto = 0, totalPorMoto = 0, totalVehiculos = 0;
            totalPorAuto = miLavadero.MostrarTotalFacturado(Vehiculos.Auto);
            totalPorMoto = miLavadero.MostrarTotalFacturado(Vehiculos.Moto);
            totalVehiculos = miLavadero.MostrarTotalFacturado();
           
            
            Console.WriteLine("Facturado por Autos: {0}", totalPorAuto);
            Console.WriteLine("Facturado por Motos: {0}", totalPorMoto);
            Console.WriteLine("Facturado por Vehiculos: {0}", totalVehiculos);
            Console.WriteLine("Cantidad total de Vehiculos: {0}", miLavadero.cantidadVehiculos);
            
              //MOSTRAR TODOS LOS ATRIBUTOS DE LOS VEHICULOS INGRESADOS AL LAVADERO
            Console.WriteLine("Listado de vehiculos");

            foreach (Vehiculo item in miLavadero.vehiculos)
            {
                item.Mostrar();            
            }

            Console.ReadLine();
        
        }
    }
}
