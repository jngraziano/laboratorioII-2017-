using System;
using System.Collections.Generic;
using System.Text;
using SC = System.Console;
using System.IO;
using System.Data.SqlClient;
namespace UTN.Programacion2.Exepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Funciones.Error();

            }
            catch (Exception ex)
            {
                SC.WriteLine("Ocurrió un error, Conmuniquese con el Administrador");
                SC.ReadKey();
                using (StreamWriter EscritorDeErrores = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Errores.txt",true))
                {
                    
                    EscritorDeErrores.Write(ex.Message);                    

                    // Objetos arbitrarios tambien pueden ser escritos en el archivo.

                    EscritorDeErrores.Write("lA FECHA ES: ");
                    EscritorDeErrores.WriteLine(DateTime.Now);

                }

            }
            finally
            {
                SC.WriteLine("Termino la aplicación...");
                SC.ReadKey();
            }
        }
    }
}
