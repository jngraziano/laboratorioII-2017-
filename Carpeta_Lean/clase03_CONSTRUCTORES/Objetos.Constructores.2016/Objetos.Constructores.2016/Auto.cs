using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2016
{
    class Auto
    {
        #region Atributos

        #region De Instancia

        public int cantRuedas;
        private ConsoleColor color;
        private EMarcas marca;
        
        #endregion

        #region De Clase

        private static DateTime fechaCreacion;
        public static int cantidadObj;
        public static DateTime fechaUltimaInstancia;
        #endregion

        #endregion

        #region Métodos

        #region De Instancia

        public string Mostrar()
        {
            return this.cantRuedas.ToString() + " - " + this.marca.ToString() + " - " + this.color.ToString() + "\n";
        }

        #endregion

        #region De Clase

        public static string Mostrar(Auto a)
        {
            return a.Mostrar();
        }

        #endregion

        #endregion

        public static void DiferenciaEntreInstancias() 
        {
           TimeSpan dif =  Auto.fechaUltimaInstancia - Auto.fechaCreacion;

           Console.WriteLine(dif.TotalMilliseconds);
        }
        
        #region Contructor



        public Auto(int cantRuedas, ConsoleColor color, EMarcas marca)
        {
            this.cantRuedas = cantRuedas;
            this.color = color;
            this.marca = marca;
            Auto.cantidadObj++;
            Auto.fechaUltimaInstancia = DateTime.Now;
        }

        static Auto()
        {
            Auto.cantidadObj = 0;
            Auto.fechaCreacion = DateTime.Now;
        }

        //public Auto()
        //{
        //    this.cantRuedas = 4;
        //    this.color = ConsoleColor.Yellow;
        //    this.marca = EMarcas.Sin_Marca;
            
        //    Auto.cantidadObj++;

        //}
        
        #endregion 

        ~Auto() 
        {
            System.Diagnostics.Trace.WriteLine(this.Mostrar());
        }

    }
}
