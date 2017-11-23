using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Articulo art1 = new Articulo(1,400f);
            Articulo art2 = new Articulo(2,400f);
            Articulo art3 = new Articulo(3,5000f);

            PedidoDeVenta pedido1 = new PedidoDeVenta(DateTime.Now, 1);
            pedido1.Items.Add(art1);
            pedido1.Items.Add(art2);
            pedido1.Items.Add(art3);

            pedido1.GrabarTxt("\\Grabo.txt");

            


        }
    }
}
