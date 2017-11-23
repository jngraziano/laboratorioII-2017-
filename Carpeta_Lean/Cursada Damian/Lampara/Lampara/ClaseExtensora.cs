using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria._2016;


namespace Lampara
{
    static class ClaseExtensora
    {
        public static void Visualizador(this Producto a)
        {
            Console.WriteLine(a.Codigo + "-" + a.Descripcion + "-" + a.PrecioDeVenta);
        
        }

        public static string Visualizador(this Pintura a)
        {
            return a.Cantidad + "-" + a.Marca;   
        
        }

        public static string Visualizador(this Lampara a)
        {
            return a.Codigo + "-" + a.Marca + "-" + a.Tipo;      
        }

        

        //Para hacer!

        
        //public static string Visualizador(this DepositoPintura a)
        //{ 
          
        
        //}
    
    }
}
