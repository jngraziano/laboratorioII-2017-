using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Serializacion
{
    class Program
    {
        private const string FILE_NAME = "C:\\Datos.xml";

        static void Main(string[] args)
        {
            Dato p = new Dato("Pepe", 20);
            
            /*************************************
             * S�lo para un dato de tipo Dato    *
             * ***********************************/

            Console.WriteLine("Se crea el objeto 'P'...");
            Console.WriteLine();

            Console.WriteLine("P.Nombre : {0}",p.nombre);
            Console.WriteLine("P.Edad : {0}",p.edad);
            Console.ReadLine();

            try
            {
                //Creo un objeto que 'sabe' como escribir en XML
                using (XmlTextWriter writer = new XmlTextWriter("C:\\Datos.xml", 
                                                                System.Text.Encoding.UTF8))
                {
                    //Creo un objeto que 'sabe' como serializar a XML
                    //Le tengo que indicar que tipo de objeto se va a serializar
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));

                    //Utilizo el m�todo Serialize, pas�ndole el 'escritor' de XML
                    //y el objeto a serializar
                    ser.Serialize(writer, p);
                }

                Console.WriteLine("Objeto 'P' serializado...");
                Console.ReadLine();

                Console.WriteLine("Deserealizando al objeto 'P'...");
                Console.ReadLine();

                //Creo un objeto que 'sabe' como leer de XML
                using (XmlTextReader reader = new XmlTextReader(FILE_NAME))
                {
                    //Creo un objeto que 'sabe' como deserializar de XML
                    //Le tengo que indicar que tipo de objeto se va a deserializar
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));


                    //Utilizo el m�todo Deserialize, pas�ndole el 'lector' de XML
                    //Debo 'castear' al tipo de dato espec�fico, ya que 
                    //el m�todo Deserialize retorna un Object
                    Dato aux = (Dato)ser.Deserialize(reader);

                    Console.WriteLine(aux.ToString());
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fall� la deserializaci�n. Razones: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Saliendo del programa...");
                Console.ReadLine();
            }

        }
    }
}
