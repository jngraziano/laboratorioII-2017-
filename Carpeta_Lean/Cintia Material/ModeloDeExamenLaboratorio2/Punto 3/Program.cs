using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Sabiendo que la clase producto Tiene un solo atributo estatico llamado"contador", 
            //modificar las lineas de codigo para hacer que el metodollamado "Mostrar" sea de clase 
            //y que pueda mostrarme el unico articulo de la clase

            //Public void Mostrar(producto aux)
            //{
            //    Console.WriteLine("El nombre es:" + aux.nombre);
            //}
        }
    }
    public class Producto
    {
        public static int contador;


        public static void Mostrar(Producto aux)
        {
            Console.WriteLine("El nombre es:"+Producto.contador);
        }
    }
}
