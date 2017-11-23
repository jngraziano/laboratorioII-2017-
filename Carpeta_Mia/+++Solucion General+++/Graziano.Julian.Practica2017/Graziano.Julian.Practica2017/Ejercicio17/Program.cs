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
            Console.Title = "Ejercicio 17";

            #region Instancia Cuenta1
            Cuenta cuenta1 = new Cuenta();

            cuenta1.SetNombre("Robada");
            cuenta1.SetNumCuenta(123);
            cuenta1.SetSaldo(1060);
            cuenta1.SetTipoInteres(ETipoInteres.TIN);
            #endregion

            #region Muestra de datos Cuenta 1
            Console.WriteLine("CUENTA 1");
            Console.WriteLine("\nNombre: {0}", cuenta1.GetNombre());
            Console.WriteLine("\nNumero de Cuenta: {0}", cuenta1.GetNumCuenta());
            Console.WriteLine("\nSaldo: {0}", cuenta1.GetSaldo());
            Console.WriteLine("\nTipo de Interes: {0}", cuenta1.GetTipoInteres());
            #endregion

            Console.ReadKey();


        }
    }
}
