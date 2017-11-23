using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            string rtainicial;
            bool rtafinal=false;

            Console.Write("Desea constinuar?");
            rtainicial = Console.ReadLine();
            while (rtainicial != "s" && rtainicial != "n")
            {
                Console.WriteLine("\n\nError. Debe contestar s/n. Reingrese: ");
                rtainicial = Console.ReadLine();
                if (rtainicial == "s")
                {
                    rtafinal = true;
                }
                else
                {

                    rtafinal = false;


                }
                                                
            }

            return rtafinal;
            
        }

    }
}
