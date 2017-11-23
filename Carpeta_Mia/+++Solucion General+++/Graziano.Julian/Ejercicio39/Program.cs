using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica miFabrica = new Fabrica("ACME"); 
            Operario op1 = new Operario("Juan", "Perez"); 
            Operario op2 = new Operario("Roberto", "Sanchez", 123); 
            Operario op3 = new Operario("Roberto", "Sanchez", 128); 
            Operario op4 = new Operario("Juan", "Bermudez", 120);

            Operario op5 = new Operario("Mirta", "Busnelli", 199);
            //AGREGO OPERARIOS A LA FABRICA
            miFabrica += op1;
            miFabrica += op2;
            miFabrica += op3;
            miFabrica += op4;
            miFabrica += op5;
            miFabrica += op1;
            miFabrica += op3;
            //MUESTRO LA FABRICA
            Console.WriteLine(miFabrica.Mostrar());
            //MUESTRO EL COSTO
            Fabrica.MostrarCosto(miFabrica);
            //SACO OPERARIOS
            miFabrica -= op1;
            miFabrica -= op3;
            miFabrica -= op1;
            //AUMENTO EL SUELDO A LOS OPERARIOS
            op2.setAumentarSalario(33);
            op4.setAumentarSalario(33);
            //MUESTRO LA FABRICA
            Console.WriteLine(miFabrica.Mostrar());
            //MUESTRO EL COSTO
            Fabrica.MostrarCosto(miFabrica);
            Console.ReadLine();
        }
    }
}
