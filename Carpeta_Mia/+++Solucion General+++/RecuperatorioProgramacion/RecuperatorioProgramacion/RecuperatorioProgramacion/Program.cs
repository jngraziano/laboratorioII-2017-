using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco objBancoUno = new Banco();
            Banco objBancoDos = new Banco();
            
            Cuenta cuentaUno = new Cuenta(123123, 10F);
            Cuenta cuentaDos = new Cuenta(323, 5F);
            Cuenta cuentaTres = new Cuenta(001, 100F);

            objBancoUno.listaCuentas.Add(cuentaUno);
            objBancoUno.listaCuentas.Add(cuentaDos);

            objBancoDos.listaCuentas.Add(cuentaUno);
            objBancoDos.listaCuentas.Add(cuentaTres);


            List<Cuenta> listaCuenta = new List<Cuenta>();

            listaCuenta = objBancoUno + objBancoDos;

            Console.WriteLine(listaCuenta.ToString());
            Console.ReadKey();

        }
    }
}
