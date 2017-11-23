using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        
        public static double Calcular(double a, double b, string c)
        {
            double result = 0;
            //double segunDo = 0;
            
            //bool valnum = false;
            switch (c)
            {
                case "+":
                    result=a+b;
                    break;
                case "-":
                    result=a-b;
                    
                    break;
                case "*":
                    result=a*b;
                    
                    break;
                case "/":
                    //valnum = Calculadora.Validar(b);
                    if (Calculadora.Validar(b) == true)
                    {
                        result = a / b;
                    }
                    else
                    {
                        while (Calculadora.Validar(b)== false)
                        {
                            Console.WriteLine("\nNose puede dividir por 0, reingrese: ");
                            b =double.Parse(Console.ReadLine());
                            result = a / b;
                        }
                    
                    }
                    
                    break;
                default: Console.WriteLine("\nNo es operador");
                    break;
            
            }

            return result;

           
        }//fin calcular

        private static bool Validar(double d)
        {

            if (d == 0)
            {
                return false;

            }
            else
            {
                return true;
            
            }




            //return _valnum;
        }
        public static void Mostrar(double resu)
        {
            Console.WriteLine("\n\nResultado es: {0}", resu);
            Console.ReadKey();
         
        }

    }
}
