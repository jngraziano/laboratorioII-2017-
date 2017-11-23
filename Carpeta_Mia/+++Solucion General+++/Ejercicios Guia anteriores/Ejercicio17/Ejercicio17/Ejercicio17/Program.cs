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
            Console.Title = "Ejercicio.17";

            Cuenta SuperCuenta = new Cuenta();

            SuperCuenta.SetNombre("Carlos");
            SuperCuenta.SetNroCuenta(15);
            SuperCuenta.SetSaldo(8000);
            SuperCuenta.SetTipoInteres(ETipoInteres.TIN);

            Console.WriteLine("Datos de cuenta: \n\nNombre: {0}\nNumero De Cuenta: {1}\nSaldo: {2}\nTipo de Interes: {3}",SuperCuenta.Get_Nombre(),SuperCuenta.Get_nroCuenta(),SuperCuenta.Get_saldo(),SuperCuenta.GetTipoInteres());
            
            Console.ReadLine();

        }
    }
}
