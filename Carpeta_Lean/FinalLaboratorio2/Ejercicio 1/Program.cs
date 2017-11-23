using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respArt1 = false;
            bool respArt2 = false;
            bool respArt3 = false;

            Articulo art1 = new Articulo(1);
            Articulo art2 = new Articulo(2);
            Articulo art3 = new Articulo(3);

            PedidoDeVenta pedido1 = new PedidoDeVenta(DateTime.Now, 1);
            pedido1.Items.Add(art1);
            pedido1.Items.Add(art2);

            respArt1 = pedido1 - 1;
            respArt2 = 2 - pedido1;
            respArt3 = pedido1 - 4;


        }
    }
}
