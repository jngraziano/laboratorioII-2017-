using System;
using System.Collections.Generic;
using System.Text;
using SC = System.Console;
using System.IO;
namespace UTN.Programacion2.Exepcion
{
    class Funciones
    {
        
        public static void Error()
        {
            string nombre="nada";
            
            int numero, numero2, resultado;

            List<Int16> miListaDeNaturales=null;

            try
            {
                
                do
                {

                    SC.Write("Ingrese numero1 : ");

                } while (!int.TryParse(SC.ReadLine(), out  numero));

                SC.Write("Ingrese numero 2: ");
                numero2 = int.Parse(SC.ReadLine());

                resultado = numero / numero2;

                miListaDeNaturales.Add(((Int16)resultado));

                SC.WriteLine("Ingrese nombre del archivo a leer: ");
                nombre = SC.ReadLine();

                using (StreamReader lector = new StreamReader(nombre))
                {
                    String linea;

                    while ((linea = lector.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("Datos recuperados desde el archivo.....");
                    Console.WriteLine("**********************************************"); 
                    Console.ReadLine();
                }
            }

            catch (DivideByZeroException ex)
            {
                SC.WriteLine(" ERROR !!! {0}", ex.Message);
                SC.WriteLine(" No se puede dividir por Cero ");
                SC.WriteLine(" Si se entera FONTE te asesina!!!!!");
                throw ex;

            }

            catch (FileNotFoundException ex)
            {
                SC.WriteLine(" ERROR !!! {0}", ex.Message);
                SC.ReadKey();
                throw new Exception("Che, no encontre el archivo archivo,---Modulo Funciones", ex);
            }

            catch (FormatException ex)
            {
                SC.WriteLine(" ERROR!!! {0}", ex.Message);
                throw ex;
            }
            catch (OverflowException ex)
            {
                SC.WriteLine(" Te zarpaste, desbordaste la variable!!!");

                throw ex;
            }
            catch(NullReferenceException ex)
            {

                SC.WriteLine(" ERROR !!!");
                SC.WriteLine(" Che negro, instancia el objeto!!!");

                throw ex;
            }
            catch (Exception ex)
            {

                SC.WriteLine(" Esta es una Excepcion genérica!!! {0}", ex.Message);

                throw ex;
            }
          
            finally
            {
                SC.Write("Bloque FINALLY, ");
                SC.WriteLine("por aca pasa siempre");
                SC.ReadKey();
            }        
        }
    }
}
