using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sy

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            
            
            Centralita centralita = new Centralita("Telefonica");

            Local primeraLocal = new Local("42995243", 30, "42994324", 2.65f);
            Provincial primeraProv = new Provincial("43120541",Franja.Franja_1,21,"43125062");
            Local segundaLocal = new Local("42990611", 45, "42993232", 1.99f);
            Provincial segundaProv = new Provincial(Franja.Franja_3, primeraProv);

            centralita.RutaDelArchivo = AppDomain.CurrentDomain.BaseDirectory + "\\Centralita.xml";

            if (centralita.DeSerializarse())
            {
                Console.WriteLine("Se deserializo correctamente");
            }
            else
                    {
                        Console.WriteLine("No se deserializo");
                    }      



            //centralita.Llamadas.Add(primeraLocal);
            //centralita.Llamadas.Add(primeraProv);
            //centralita.Llamadas.Add(segundaLocal);
            //centralita.Llamadas.Add(segundaProv);
            centralita = centralita + primeraLocal;
            centralita = centralita + segundaLocal;
            centralita = centralita + primeraProv;
            centralita = centralita + segundaProv;


            Console.WriteLine(centralita.ToString());

            centralita.OrdenarLlamadas();

            Console.WriteLine(centralita.ToString());

            Local terceraLocal = new Local("42995243", 30, "42994324", 2.65f); //Igual a primera local,debe arrojar error.

            centralita = centralita + terceraLocal;

            Console.ReadKey();

            



        }
    }
}
