using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito depo1 = new Deposito("Deposito1");
            Deposito.GuardarXML(depo1);
        }
    }
}
