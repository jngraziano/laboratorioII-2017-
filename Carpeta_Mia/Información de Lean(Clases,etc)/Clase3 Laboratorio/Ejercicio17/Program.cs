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
            Cuenta miCuenta1 = new Cuenta();

            miCuenta1.setNombre("Leandro");
            miCuenta1.setNroCuenta(12456);
            miCuenta1.setSaldo(9000);
            miCuenta1.setTipoInteres(EtipoInteres.TAE);

            Console.WriteLine("{0}{1}{2}{3}", miCuenta1.getNombre(), miCuenta1.getNroCuenta(), miCuenta1.getSaldo(), miCuenta1.getTipoInteres());
            Console.ReadKey();

        }
    }
}
