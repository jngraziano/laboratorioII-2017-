using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta miCuentita = new Cuenta();

            miCuentita.setNombre("Pepe");

            miCuentita.setNroCuenta(15698);

            miCuentita.setSaldo(-10);

            miCuentita.setTipoInteres(ETipoInteres.TAE);

           
            
            
            
            Console.WriteLine(miCuentita.getNombre());

            Console.WriteLine(miCuentita.getNroCuenta());

            Console.WriteLine(miCuentita.getSaldo());

            Console.WriteLine(miCuentita.getTipoInteres());

            Console.ReadKey();
        }
    }
}
