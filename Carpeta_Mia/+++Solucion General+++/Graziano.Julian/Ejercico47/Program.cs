using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercico47
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato("Bola de Nieve",4);
            Pez pez1 = new Pez("Nemo",0);
            Araña araña1 = new Araña("Patona", 7);

            Console.WriteLine("\nGATO");
            gato1.Caminar();
            gato1.Comer();
            gato1.Jugar();

            Console.ReadKey();
            Console.WriteLine("\nPEZ");
            pez1.Caminar();
            pez1.Comer();
            pez1.Jugar();

            Console.ReadKey();
            Console.WriteLine("\nAraña");
            araña1.Caminar();
            araña1.Comer();
            araña1.Jugar();

            Console.ReadKey();

            Serializar(gato1);
            Serializar(pez1);
            Serializar(araña1);




        }

        public static bool Serializar(Mascota m)
        {
            m.Serealizador();

            return true;
        
        }
    }
}
