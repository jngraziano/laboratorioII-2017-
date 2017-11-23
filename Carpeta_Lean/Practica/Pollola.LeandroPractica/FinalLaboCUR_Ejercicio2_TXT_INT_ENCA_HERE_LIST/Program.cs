using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio2_TXT_INT_ENCA_HERE_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            FacturaDeCompra facCom1 = new FacturaDeCompra(10);
            FacturaDeCompra facCom2 = new FacturaDeCompra(10);
            FacturaDeCompra facCom3 = new FacturaDeCompra(10);

            FacturaDeVenta facVen1 = new FacturaDeVenta(20);
            FacturaDeVenta facVen2 = new FacturaDeVenta(20);
            FacturaDeVenta facVen3 = new FacturaDeVenta(20);

            List<Factura> lista = new List<Factura>();
            lista.Add(facCom1);
            lista.Add(facCom2);
            lista.Add(facCom3);

            lista.Add(facVen1);
            lista.Add(facVen2);
            lista.Add(facVen3);

            MostrarTotalFacturado(lista, eTipoComprobante.Venta);

            MostrarTotalFacturado(lista, eTipoComprobante.Compra);

        }

        public static void MostrarTotalFacturado(List<Factura> lista, eTipoComprobante tipo)
        {
            decimal acumulado = 0;

            foreach (Factura fac in lista)
            {
                if (fac is FacturaDeCompra && tipo == eTipoComprobante.Compra)
                {
                    acumulado += fac.TotalFacturado;
                }
                else if (fac is FacturaDeVenta && tipo == eTipoComprobante.Venta)
                {
                    acumulado += fac.TotalFacturado;
                }
            }

            Console.WriteLine("Monto: {0}", acumulado);
        }
    }
}
