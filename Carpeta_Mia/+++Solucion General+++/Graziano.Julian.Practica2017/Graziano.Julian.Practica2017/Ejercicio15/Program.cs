using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //15.Realizar un programa que permita realizar operaciones matemáticas
            //simples (suma, resta, multiplicación y división).
            //Para ello se le debe pedir al usuario que ingrese dos números y
            //la operación que desea realizar (pulsando el caracter +, -, * ó).
            //El usuario decidirá cuando finalizar el programa.
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
            #region Variables
            float num1, num2,result;
            char opera;
            char rta = 's';

            #endregion

            do
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("\n\nIngrese primer numero: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese segundo numero: ");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("\n\nIngrese operacion deseada (+,-,*,/): ");
                opera = char.Parse(Console.ReadLine());
                result=Calculadora.Calcular(num1, num2, opera);
                Calculadora.Mostrar(result);


                Console.WriteLine("\nDesea Continuar (S/N): ");
                rta = char.Parse(Console.ReadLine());

            } while (rta != 'n');
        }
    }
}
