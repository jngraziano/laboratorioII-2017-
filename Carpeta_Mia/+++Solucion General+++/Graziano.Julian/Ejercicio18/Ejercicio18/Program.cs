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
            char rta = 'e';
            Computadora CPU = new Computadora();

            CPU.setEstaEncendida(true);
            CPU.setMarca(EMarca.Apple);
            CPU.setPeso(39);
            CPU.setProcesador(EProcesador.Intel_Celeron_430);

            CPU.InformarEstado();
            Console.WriteLine("\n\nDesea Encender o Apagar (E/A)?: ");
            rta = char.Parse(Console.ReadLine());
            if (rta == 'e')
            {
                CPU.Encender();
                Console.ReadKey();
            
            }
            else if (rta == 'a')
            {
                CPU.Apagar();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error de letra indicada");
            
            }


            Console.Clear();
            Console.WriteLine("Informe con getters: ");

            Console.WriteLine("\n\nEsta encendida? {0}\nMarca: {1}\nPeso: {2}\nProcesador: {3}", CPU.getEstaEncendida(), CPU.getMarca(), CPU.getPeso(), CPU.getProcesador());
            Console.ReadKey();

        }
    }
}
