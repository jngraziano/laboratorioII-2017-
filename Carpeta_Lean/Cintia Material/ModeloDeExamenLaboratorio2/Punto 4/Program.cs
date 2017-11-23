using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Realizar el codigo necesario para utilizar estas lineas de codigo en el main
            //ProdImpuesto ProUno = (Prodimpuesto)"Jose";

            ProdImpuesto ProUno = (ProdImpuesto)"Jose";
            ProUno.Mostrar();

            Console.ReadKey();
        }
    }
    public class ProdImpuesto
    {

        public string nombre;

        public ProdImpuesto(string nombre)
        {
            this.nombre = nombre;
        }

        

        public static explicit  operator ProdImpuesto(string dato)
        {
        
            return new ProdImpuesto(dato);
        }

       
    }

}

