using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Fruta;



namespace Graziano.Julian
{
    class Program
    {
        static void Main(string[] args)
        {
            Manzana manzana1 = new Manzana(0.21F, ConsoleColor.DarkRed, 20);
            Manzana manzana2 = new Manzana(0.22F, ConsoleColor.Green, 26);
            Manzana manzana3 = new Manzana(0.30F, ConsoleColor.Red, 15);

            Platano platano1 = new Platano(0.50F, ConsoleColor.Yellow, 50);
            Platano platano2 = new Platano(0.55F, ConsoleColor.Green, 10);
            Platano platano3 = new Platano(0.20F, ConsoleColor.Gray, 5);

            Cajon miCajon = new Cajon(5);

            miCajon += manzana1;
            miCajon += manzana2;
            miCajon += manzana3;

            miCajon += platano1;
            miCajon += platano2;
            miCajon += platano3;

            
            miCajon.ToString();
            Console.ReadKey();

            Manzana.OrdenarPorPesoAsc(manzana1,manzana2);
            

            Console.Clear();
            Console.WriteLine(miCajon.PrecioDeManzanas);
            Console.WriteLine(miCajon.PrecioDePlatanos);
            Console.WriteLine(miCajon.PrecioTotal);
            Console.ReadKey();


            Program.Serializar(manzana1);
            Program.Serializar(miCajon);


         
        }


        private static bool Serializar(ISerializable obj)
        {
            try
            {
                if (obj.SerializarXML())
                {
                    return true;

                }
                else
                {
                    throw new Exception();
                    
                    

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        
        }
    }
}
