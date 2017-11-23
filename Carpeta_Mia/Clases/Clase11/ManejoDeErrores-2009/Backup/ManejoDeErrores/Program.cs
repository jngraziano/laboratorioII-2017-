using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManejoDeErrores
{
    class Program
    {
        public static void ArrojarExcepcion()
        {
            throw new MiClaseException("Error personalizado!!!", 
                                       "Class Program");
        }

        public static double Dividir(int numero1, int numero2)
        {
            double resultado=0;
            try
            {
                resultado = numero1 / numero2;
            }
            catch (Exception ex)
            {
                throw new MiClaseException("Error al intentar dividir!!!", 
                                            "Class Program.Dividir",ex);
            }

            return resultado;
        }

        public static void Main(string[] args)
        {
            try
            {
                ArrojarExcepcion();

                double res = Dividir(1, 0);

            }
            catch (MiClaseException ex) //CAPTURO EXCEPCION PERSONALIZADA
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("InnerException: {0}", ex.InnerException);
            }
            catch (Exception ex) //CAPTURO CUALQUIER EXCEPCION
            {
                Console.WriteLine(ex.Message);
            }
                            
            Console.ReadLine();

        }

    }


}

