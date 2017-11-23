using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL2C_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito deposito1 = new Deposito();
            Deposito deposito2 = new Deposito();

            Producto producto11 = new Producto("Producto11",6);
            Producto producto12 = new Producto("Producto12",8);
            Producto producto13 = new Producto("Producto13",2);
            Producto producto15 = new Producto("ProductoenComun", 1);
        
            Producto producto21 = new Producto("Producto21",4);
            Producto producto22 = new Producto("Producto22",6);
            Producto producto23 = new Producto("Producto23",8);
            Producto producto25 = new Producto("ProductoenComun", 10);

            deposito1 += producto11;
            deposito1 += producto12;
            deposito1 += producto15;
            deposito1 += producto13;

            deposito2 += producto21;
            deposito2 += producto22;
            deposito2 += producto25;
            deposito2 += producto23;

            Producto[] depositoSolucion = new Producto[10];
            depositoSolucion = deposito1 + deposito2;
            Console.ReadLine();
        }
    }
}
