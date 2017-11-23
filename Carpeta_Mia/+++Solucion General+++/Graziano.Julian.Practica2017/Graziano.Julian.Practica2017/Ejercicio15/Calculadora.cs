using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        //Crear una clase llamada Calculadora que posea tres métodos
        //estáticos (de clase):
        //Calcular (público): Recibirá tres parámetros, el primer
        //número, el segundo número y la operación matemática. El
        //método devolverá el resultado de la operación.
        //Validar (Privado): Recibirá como parámetro el segundo
        //número. Este método se debe utilizar sólo cuando la
        //operación elegida sea la DIVISION. Este método devolverá
        //TRUE si el número es distinto de CERO.
        //Mostrar (público): Este método recibe como parámetro el
        //resultado de la operación y lo muestra por pantalla.
        //No posee valor de retorno.

        public static float Calcular(float a, float b, char opera)
        {
            float result=0;
            switch (opera)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (Validar(b))
                    {
                        result = a / b;
                    }
                    else { Console.WriteLine("\nNo se puede dividir por 0."); }
                    break;
                default: ; break;
            
            }

            return result;
        }

        private static bool Validar(float num)
        {
            if (num != 0)
            {
                return true;
            }
            else { return false; }
            //Validar (Privado): Recibirá como parámetro el segundo
            //número. Este método se debe utilizar sólo cuando la
            //operación elegida sea la DIVISION. Este método devolverá
            //TRUE si el número es distinto de CERO.
        
        }
       
        public static void Mostrar(float result)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nEl resultado es: ");
            sb.AppendLine(result.ToString());

            Console.WriteLine(sb.ToString());

            //Mostrar (público): Este método recibe como parámetro el
            //resultado de la operación y lo muestra por pantalla.
            //No posee valor de retorno.
        
        }
        
        
    }
}
