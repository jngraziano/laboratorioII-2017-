using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace Final_2016_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reemplazar por sus datos personales
            Console.Title = "Me llamo POLLOLA, LEANDRO y curso en la División 2º[D]";

            // Instancia de estacionamiento
            Estacionamiento estacionamiento = new Estacionamiento(5);

            // Instancias de los Vehículos
            Camion c1 = new Camion(Vehiculo.EMarca.Scania, "ASD012", ConsoleColor.Black);
            Camion c2 = new Camion(Vehiculo.EMarca.Iveco, "ASD913", ConsoleColor.Red);
            Moto m1 = new Moto(Vehiculo.EMarca.BMW, "HJK789", ConsoleColor.White);
            Moto m2 = new Moto(Vehiculo.EMarca.Yamaha, "IOP852", ConsoleColor.Blue);
            Automovil a1 = new Automovil(Vehiculo.EMarca.Scania, "IOP852", ConsoleColor.Green);
            Automovil a2 = new Automovil(Vehiculo.EMarca.Chevrolet, "QWE968", ConsoleColor.Gray);
            Automovil a3 = new Automovil(Vehiculo.EMarca.Ford, "TYU426", ConsoleColor.DarkBlue);

            // Agrego 6 ítems (a1 y a3 no deberían poder agregarse) y muestro
            try
            {
                estacionamiento += c1;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                estacionamiento += c2;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                estacionamiento += m1;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                estacionamiento += m2;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                estacionamiento += a1;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                estacionamiento += a2;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                estacionamiento += a3;
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(estacionamiento.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Quito un item y muestro
            estacionamiento -= c1;

            Console.WriteLine(estacionamiento.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Motos
            Console.WriteLine(Estacionamiento.Mostrar(estacionamiento, Estacionamiento.ETipo.Moto));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Camiones
            Console.WriteLine(Estacionamiento.Mostrar(estacionamiento, Estacionamiento.ETipo.Camion));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Automoviles
            Console.WriteLine(Estacionamiento.Mostrar(estacionamiento, Estacionamiento.ETipo.Automovil));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Guardo el Estacionamiento
            Console.WriteLine("Guardando Estacionamiento...");
            try
            {
                estacionamiento.guardar("estacionamiento.xml");
            }
            catch (ErrorArchivoException e)
            {
                Console.WriteLine(e.Message + ":" + e.InnerException.Message);
            }
            Console.WriteLine("<---------------------------------------------->");
            // Leo y muestro un Automovil
            Console.WriteLine("Leyendo Estacionamiento...");
            try
            {
                Estacionamiento lecturaEstacionamiento;
                estacionamiento.leer("estacionamiento.xml", out lecturaEstacionamiento);
                estacionamiento = lecturaEstacionamiento;
                Console.WriteLine(estacionamiento.ToString());
            }
            catch (ErrorArchivoException e)
            {
                Console.WriteLine(e.Message + ":" + e.InnerException.Message);
            }
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();

            // Guardo un Automovil
            Console.WriteLine("Guardando Auto...");
            try
            {
                a1.guardar("auto.bin");
            }
            catch (ErrorArchivoException e)
            {
                Console.WriteLine(e.Message + ":" + e.InnerException.Message);
            }
            Console.WriteLine("<---------------------------------------------->");
            // Leo y muestro un Automovil
            Console.WriteLine("Leyendo Auto...");
            try
            {
                Automovil lecturaAuto;
                a1.leer("auto.bin", out (lecturaAuto));
                a1 = lecturaAuto;
                Console.WriteLine(a1.Mostrar());
            }
            catch (ErrorArchivoException e)
            {
                Console.WriteLine(e.Message + ":" + e.InnerException.Message);
            }
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
        }
    }
}
