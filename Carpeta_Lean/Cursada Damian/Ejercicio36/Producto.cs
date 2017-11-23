using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Producto
    {

        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;




        private Producto(int _codigoDeBarra)
        {

            Random a = new Random();

            this._codigoDeBarra = a.Next(_codigoDeBarra);

        }
        
  
        
        public Producto(int _codigoDeBarra, string _nombre, eTipoComestible _tipo) :this(_codigoDeBarra)  
         {
            //Random a = new Random();

            //this._codigoDeBarra = a.Next(_codigoDeBarra);
            this._nombre = _nombre;
            this._tipo = _tipo;      
        }

        public Producto(int _codigoDeBarra, string _nombre, eTipoComestible _tipo, double _precio):this(_codigoDeBarra, _nombre, _tipo)   
        {
            this._precio = _precio;       
        }

      

        public void Mostrar()
        {
            
            Console.WriteLine("Nombre: {0}",this._nombre); 
            Console.WriteLine("Tipo: {0}",this._tipo);
            Console.WriteLine("Codigo: {0}", this._codigoDeBarra);
            Console.WriteLine("Precio: {0}", this._precio);
                
                
                
        }


        public static bool operator ==(Producto a, Producto b)
        {
            if (String.Compare(a._nombre, b._nombre) == 0 && a._tipo == b._tipo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        public static bool operator != (Producto a, Producto b)
            {
                return !(a==b);
            }
        
        public static bool operator == (Producto a, eTipoComestible comestible)
            {
                if (a._tipo == comestible)
                {
                    return true;
                }
                else {
                    return false;
                }
                
            }

        public static bool operator !=(Producto a, eTipoComestible comestible)
        {
            return !(a == comestible);
        }

        


    }

    
        



}

