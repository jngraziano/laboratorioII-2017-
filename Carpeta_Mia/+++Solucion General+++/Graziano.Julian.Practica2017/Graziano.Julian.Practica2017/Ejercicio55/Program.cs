using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            
            //Además se pide:
            //Crear dos clases (Auto y Moto) que hereden de Vehiculo y que posean cantidadAsientos (int) y Cilindrada
            //(int) como atributos respectivamente. Cada una de estas clases deberá implementar el método Mostrar para
            //poder visualizar desde consola todos sus atributos.
            //Por último se desea construir la clase Lavadero que tendrá una lista genérica de Vehiculos, un atributo
            //cantidadVehiculos (int), precioAuto (float) y precioMoto (float), que se inicializaran desde su constructor.
            //Los métodos que tendrá Lavadero son:
            //MostrarTotalFacturado: devolverá la ganancia del lavadero (Double), dicho método tendrá una
            //sobrecarga que reciba como parámetro la enumeración Vehiculos (con Auto y Moto como
            //enumerados) y retornará la ganancia del Lavadero por tipo de vehículo.
            //El método IngresarAlLavadero (que recibe como único parámetro un Vehiculo), agregará a la lista
            //dicho objeto e incrementara su contador de vehículos en uno.
            #endregion
            Auto auto1 = new Auto("ABC123", Emarcas.Ford, 4, 6);
            Auto auto2 = new Auto("DEF456", Emarcas.Fiat, 4, 4);
            Moto moto1 = new Moto("GHI789", Emarcas.Zanella, 2, 1300);
            Moto moto2 = new Moto("JKL000", Emarcas.Honda, 2, 3600);
            Lavadero miLavadero = new Lavadero(29, 30);
            //INGRESAR LOS AUTOS Y LAS MOTOS
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
        }
    }
}
