using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace EntidadesArchivos
{
    public class AdministradorDeArchivos
    {
        //Creo una constante con el path del archivo
        //private const string FILE_NAME = "D:\\octavio\\TestFile.txt";
        private const string RUTA_ARCHIVO = "datosEntidades.txt";


       public  static void Saludar()
        {
            //Crea una instancia de StreamWriter para escribir un texto a un archivo.
            try
            {
                //El bloque using asegura que el objeto invocará al método Dispose()
                // using (StreamWriter sw = new StreamWriter(@"D:\octavio\TestFile.txt"))
                using (StreamWriter sw = new StreamWriter("datosEntidades.txt"))
                {
                    // Agrega algún texto al archivo.

                    sw.Write("HOLA ");
                    sw.WriteLine("MUNDO Archivos.");
                    sw.WriteLine("-----------------------------");

                    // Objetos arbitrarios tambien pueden ser escritos en el archivo.

                    sw.Write("LA FECHA ES: ");
                    sw.WriteLine(DateTime.Now);
                }

                Console.WriteLine("El archivo fue escrito exitosamente.....");
                Console.ReadLine();

                // Crea una instancia de StreamReader para leer desde el archivo.
                using (StreamReader sr = new StreamReader(RUTA_ARCHIVO))
                {
                    String renglon;

                    // Lee y muestra líneas desde el comienzo del archivo 
                    // hasta el fin del mismo.

                    while ((renglon = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(renglon);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Datos recuperados desde el archivo.....");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error en el archivo ubicado en {0}", RUTA_ARCHIVO);
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
