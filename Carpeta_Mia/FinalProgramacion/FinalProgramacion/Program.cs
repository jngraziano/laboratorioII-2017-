using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cuenta> listaCuentas = new List<Cuenta>();
            
            Banco objBanco1 = new Banco();
            Banco objBanco2 = new Banco();

            Cuenta cuenta1 = new Cuenta(100f, 1000);
            Cuenta cuenta2 = new Cuenta(200f, 2000);
            Cuenta cuenta3 = new Cuenta(300f, 3000);
            Cuenta cuenta4 = new Cuenta(400f, 1000);

            objBanco1.ListaCuenta.Add(cuenta1);
            objBanco1.ListaCuenta.Add(cuenta2);


            objBanco2.ListaCuenta.Add(cuenta3);
            objBanco2.ListaCuenta.Add(cuenta4);

            listaCuentas = objBanco1 + objBanco2;

            Console.ReadLine();





        
        }
    }
}
