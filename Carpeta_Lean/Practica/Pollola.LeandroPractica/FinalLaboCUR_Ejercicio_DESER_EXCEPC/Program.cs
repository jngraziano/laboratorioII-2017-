using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio_DESER_EXCEPC
{
    class Program
    {
        static void Main(string[] args)
        {
            PedidoDeVenta.Deserializar(AppDomain.CurrentDomain.BaseDirectory + "Error Deserialize.txt");
        }
    }
}
