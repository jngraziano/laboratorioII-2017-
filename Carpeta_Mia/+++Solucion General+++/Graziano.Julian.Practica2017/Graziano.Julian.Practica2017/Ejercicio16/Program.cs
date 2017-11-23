using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            #region Pedido del ejercicio
            //Se pide crear 3 instancias de la clase ‗Alumno‘ (3 objetos),
            //colocarle nombre, apellido y legajo a cada uno de ellos.
            
            //El método CalcularFinal deberá colocar la nota del final sólo si
            //las notas 1 y 2 son mayores o iguales a 4, caso contrario la
            //inicializará con -1. Para darle un valor a la nota final utilice
            //el método de instancia Next de la clase Random.
            //Por último, el método Mostrar, expondrá en la consola todos los
            //datos de los alumnos, a excepción de la nota final. Este valor se
            //mostrará sólo si es distinto de -1.
            #endregion

            #region Instancias de la clase Alumno

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.legajo = 123;
            alumno2.legajo = 312;
            alumno3.legajo = 456;

            alumno1.nombre = "Jony";
            alumno2.nombre = "Emiliano";
            alumno3.nombre = "Matias";

            alumno1.apellido = "Valenzuela";
            alumno2.apellido = "Golbert";
            alumno3.apellido = "Perez";

            #endregion

            #region Carga de Notas
            alumno1.Estudiar(3,4);
            alumno2.Estudiar(7, 7);
            alumno3.Estudiar(9, 10);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine("FIN CARGA DE DATOS");
            Console.ReadKey();
            #endregion

            #region Muestra de los Alumnos
            alumno1.Mostrar();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            alumno2.Mostrar();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            alumno3.Mostrar();
            Console.ReadKey();
            #endregion

        }
    }
}
