using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metro a centimetro
            Metro resultado;
            //Metro metro = new Metro(); PRIMERA VERSION
            //Centimetro centimetro = new Centimetro(); PRIMERA VERSION

            Metro metro = new Metro(10); 
            Centimetro centimetro = new Centimetro(10); 

            //metro.valor = 10; PRIMERA VERSION
            //centimetro.valor = 10; PRIMERA VERSION
            
            resultado = metro + centimetro;

            //Console.Write("Resultado en Metros: {0} \n", resultado.valor);
            Console.Write((double) resultado);

            //Centimetro a metro
            Centimetro resultado2 = new Centimetro(10);

            resultado2 = centimetro + metro;

            //Console.Write("Resultado en centimetros: {0}",resultado2.valor); PRIMERA VERSION
            Console.Write((double) resultado2);
            Console.ReadKey();

        }
    }
}
