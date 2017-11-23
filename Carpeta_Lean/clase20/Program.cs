using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Eventos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIO AL OBJETO DE TIPO 'EMPLEADO'
            Empleado empleadoEvento = new Empleado();

            //ASOCIO EL EVENTO A SU MANEJADOR
            empleadoEvento.LimiteSueldo += new LimiteSueldoDel(SobreSueldo_Evento);

            //ASIGNO EL NOMBRE
            empleadoEvento.Nombre = "Juan";

            //ESTA ASIGNACION PROVOCA EL EVENTO
            empleadoEvento.Sueldo = 1500;
            
        }

        public static void SobreSueldo_Evento(Double importe, Empleado e) 
        {
            Console.WriteLine("Se ha sobrepasado, para el empleado {0}, el límite establecido de sueldo", 
                              e.Nombre);

            Console.WriteLine();

            Console.WriteLine("El importe de $ {0:#,###.00} no es válido!!!", importe);

            Console.WriteLine();

            Console.ReadLine();
 
        }
    }
}
