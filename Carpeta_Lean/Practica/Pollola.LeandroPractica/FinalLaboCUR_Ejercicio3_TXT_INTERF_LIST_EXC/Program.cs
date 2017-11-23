using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio3_TXT_INTERF_LIST_EXC
{
    class Program
    {
        static void Main(string[] args)
        {
            //DOY DE ALTA ARTICULOS
            Articulo art1 = new Articulo(1, 400f);
            Articulo art2 = new Articulo(2, 400f);
            Articulo art3 = new Articulo(3, 5000f);

            //CREO PEDIDO DE VENTA
            PedidoDeVenta pedido1 = new PedidoDeVenta(DateTime.Now, 1);
            //AGREGO ARTICULOS
            pedido1.Items.Add(art1);
            pedido1.Items.Add(art2);
            pedido1.Items.Add(art3);

            //LE PASO LA RUTA Y NOMBRE ARCHIVO
            pedido1.GrabarTxt("\\Grabo.txt");

        }
    }
}
