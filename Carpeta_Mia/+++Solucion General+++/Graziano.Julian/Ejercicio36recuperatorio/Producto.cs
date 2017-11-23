using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36recuperatorio
{
    class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        #region Constructores
        public Producto(int codigoDeBarra)
        {
            //USO UN RANDOM PARA INSTANCIAR CODIGO DE BARRA
            Random obj = new Random();

            this._codigoDeBarra = obj.Next(); 
        }
        
        
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo):this(codigoDeBarra)
        {
           
            this._nombre = nombre;
            this._tipo = tipo;
        }
        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio):this(codigoDeBarra,nombre,tipo)
        {
            
            this._precio = precio;
        }


        #endregion

        #region Metodos
        public void mostrar()
        {
            Console.WriteLine("\nCodigo de Barra: {0}\nNombre: {1}\nPrecio: {2}\nTipo: {3}", this._codigoDeBarra, this._nombre, this._precio, this._tipo);
        
        }
        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
           if (proUno._tipo == tipo)
                { return true; }
                else
                { return false; }
            
           
        
        }
        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno == proDos)
            { return true; }
            else
            { return false; }
        
        }
        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        {
            return !(proUno._tipo == tipo);


        }
        public static bool operator !=(Producto proUno, Producto proDos)
        {
            return !(proUno == proDos);

        }
        
        
        
        
        
        
        
        #endregion




        




    }
}
