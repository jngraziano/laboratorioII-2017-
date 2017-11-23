using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria._2016;

namespace Lampara
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampara lampara1 = new Lampara("comun", "333", "Osram");

            //Console.WriteLine("{0},{1},{2}",lampara1.Codigo,lampara1.Tipo,lampara1.Marca);

            //Console.ReadLine();
            Pintura pintura = new Pintura(20, "Pelikan");

            ClaseNueva a = new ClaseNueva(20, "pepito");

            a.Mostrar();

            Console.ReadLine();

            Producto producto = new Producto(123, "feo", 10);

            ClaseExtensora.Visualizador(producto);

            producto.Visualizador();

            Console.WriteLine(lampara1.Visualizador());

            Console.WriteLine(pintura.Visualizador());

            Console.ReadLine();


            DepositoPintura deposito = new DepositoPintura(3);

            deposito.Agregar(pintura);
        
            
        }
    }
}
