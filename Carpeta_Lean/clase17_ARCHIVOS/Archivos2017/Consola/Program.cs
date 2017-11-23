using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EntidadesArchivos;
using Entidades;
using System.Xml.Serialization;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Runtime.Serialization.Json;

namespace Consola
{
    class Program
    {
        //Creo una constante con el path del archivo
        //private const string FILE_NAME = "D:\\octavio\\TestFile.txt";
        private const string FILE_NAME = "datosProgram.txt";

        static void Main(string[] args)
        {
            //Program.Saludar();
           // AdministradorDeArchivos.Saludar();
            Aula nuevaAula = new Aula(222,true,"lab inf");
           // nuevaAula.Numero = 555;

            nuevaAula.ListadoDePersonas.Add(new Persona("alguien", "sinapellido"));
            Persona personaUno = new Persona("alguien", "sinapellido");
            personaUno.nombre = "juan";
            personaUno.apellido = "dario";
            nuevaAula.ListadoDePersonas.Add(personaUno);
            personaUno.Dni = 2323;
            nuevaAula.ListadoDePersonas.Add(personaUno);
            nuevaAula.ListadoDePersonas.Add(new Persona("alguien","sinapellido"));
           
            serializarAula(nuevaAula);







            Aula AulaDos = new Aula(777, true, "polimorfica");
            Profesor profe= new Profesor();
            profe.Dni = 1;
            profe.nombre = "profesor";
            profe.apellido = "profesor";
            profe.Titulo = "profesor";
            Alumno alum= new Alumno();
            alum.Dni = 2;
            alum.nombre = "alumno";
            alum.apellido = "alumno";
            alum.Legajo = 123;
            Persona pers= new Persona();
            pers.Dni = 3;
            pers.nombre = "persona";
            pers.apellido = "persona";

            AulaDos.ListadoDePersonas.Add(profe);
            AulaDos.ListadoDePersonas.Add(alum);
            AulaDos.ListadoDePersonas.Add(pers);
            AulaDos.serializarMe();


        }





        static bool serializarAula(Aula aulaParametro)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Aula));

                using (StreamWriter escritor = new StreamWriter(aulaParametro.Numero+"aula.xml"))
                {
                    serializador.Serialize(escritor, aulaParametro);
                }  
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
            return true;        
        }








        static void DesSerializarPersonaBinario()
        {           
            IFormatter formateador = new BinaryFormatter();
            using (Stream archivo = new FileStream("persona.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Persona personaDos = (Persona)formateador.Deserialize(archivo);            
            }         
          
        }
        static void serializarPersonaBinario()
        {
            Persona personaUno = new Persona("alguien", "sinapellido");
            personaUno.nombre = "datos ";
            personaUno.apellido = "binario";
            IFormatter formateador = new BinaryFormatter();
            using (Stream archivo = new FileStream("persona.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formateador.Serialize(archivo, personaUno);
            }        
      
        }

        static void serializarPersonaXML(Persona personaParmetro)
        {
          
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));
            using (StreamWriter escritor = new StreamWriter("persona.xml"))
            {
                serializador.Serialize(escritor, personaParmetro);               
            }  
        }

        static Persona DesSerializarPersonaXML()
        {
           
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));

            using (StreamReader lector = new StreamReader("persona.xml"))
            {
                return (Persona)serializador.Deserialize(lector);               
            }

        }

        static void Saludar()
        {
            //Crea una instancia de StreamWriter para escribir un texto a un archivo.
            try
            {
                //El bloque using asegura que el objeto invocará al método Dispose()
                // using (StreamWriter sw = new StreamWriter(@"D:\octavio\TestFile.txt"))
                using (StreamWriter sw = new StreamWriter("datosProgram.txt"))
                {
                    // Agrega algún texto al archivo.

                    sw.Write("Este es el ");
                    sw.WriteLine("Encabezado para el archivo.");
                    sw.WriteLine("-----------------------------");

                    // Objetos arbitrarios tambien pueden ser escritos en el archivo.

                    sw.Write("LA FECHA ES: ");
                    sw.WriteLine(DateTime.Now);
                }

                Console.WriteLine("El archivo fue escrito exitosamente.....");
                Console.ReadLine();

                // Crea una instancia de StreamReader para leer desde el archivo.
                using (StreamReader sr = new StreamReader(FILE_NAME))
                {
                    String line;

                    // Lee y muestra líneas desde el comienzo del archivo 
                    // hasta el fin del mismo.

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Datos recuperados desde el archivo.....");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error en el archivo ubicado en {0}", FILE_NAME);
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Pulse cualquier tecla para salir...");
                Console.ReadLine();
            }
        }



    }
}
