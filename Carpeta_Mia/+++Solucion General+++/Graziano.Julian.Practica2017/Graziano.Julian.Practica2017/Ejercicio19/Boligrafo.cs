using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Boligrafo
    {
        #region variables de la clase
        private int _cantidadTinta;
        private string _color;
        private string _marca;
         //b. Realizar 4 (cuatro) sobrecargas del constructor, todas tienen como parámetro color y marca,
            //las que no reciben como parámetro una cantidad, deberán inicializar ese atributo en 0
            //(cero).
        
        public Boligrafo()
        { this._cantidadTinta=0;}

        public Boligrafo(string color):this()
        {
            this._color=color;
            this._cantidadTinta=0;
        }
        
        public Boligrafo(string color, string marca):this(color)
        {
            this._marca=marca;
            this._cantidadTinta=0;
           
        }
        
        public Boligrafo(string color, string marca, int cantidadtinta):this(color,marca)
        {
           
            this._cantidadTinta=cantidadtinta;
        }
        
        #endregion

        #region metodos de la clase
        
        public void Escribir(int CantidadNecesaria)
        {   //4) Método “Escribir”: método de instancia, público, que genera un consumo de tinta en el bolígrafo,
            //la cantidad es recibida por parámetro y si la tinta que contiene el bolígrafo no es suficiente se
            //deberá informar por consola los datos del bolígrafo utilizando el método “Mostrar”.
            if(this._cantidadTinta < CantidadNecesaria)
            {
                Console.WriteLine("\nLa cantidad disponible no es sufienciente.");

            }
            else{this._cantidadTinta=this._cantidadTinta-CantidadNecesaria;}
        
        }
        public void Mostrar()
        { 
            //2) Crear el método privado de instancia llamado “Mostrar” (sin parámetros) que mostrará todos
            //los atributos del objeto bolígrafo por consola.
            StringBuilder sb = new StringBuilder();
            sb.Append("\nColor: ");
            sb.AppendLine(this._color);
            sb.Append("\nMarca: ");
            sb.AppendLine(this._marca);
            sb.Append("\nCantidad de tinta: ");
            sb.AppendLine(this._cantidadTinta.ToString());
            Console.WriteLine(sb.ToString());

        }
        public static void MostrarBoligrafos(List<Boligrafo> ListadeBoligrafos)
        {
            //3) Método “MostrarBoligrafos”: método público de clase que tiene como parámetro una lista
            //genérica de bolígrafos y que nos mostrará los atributos de cada objeto contenido en la lista
            //llamando al método “Mostrar” creado en el punto anterior .
            foreach(Boligrafo corre in ListadeBoligrafos)
            {
                corre.Mostrar();
            }
        }
        public static bool operator !=(Boligrafo unPen, Boligrafo otroPen)
        { return !(unPen==otroPen);}
        public static bool operator ==(Boligrafo unPen, Boligrafo otroPen)
        { 
            //6) Sobrecarga del operador “==” permite saber si dos objetos comparten la misma marca y el
            //mismo color.
            if(unPen._marca == otroPen._marca && unPen._color == otroPen._color)
            {return true;}
            else{return false;}
        }
        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo unPen)
        {   //7) Sobrecarga del operador “+”, recibe como parámetros una lista de bolígrafos y un bolígrafo,
            //agregar ese bolígrafo a la lista y retorna la lista.
            //miLista = miLista + Otrobligrafo;
            lista.Add(unPen);
            return lista;
        }
        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo unPen)
        {
            //8) Sobrecarga del operador “-”, recibe como parámetros una lista de bolígrafos y un bolígrafo,
            //eliminar el objeto bolígrafo de la lista que coincida con los datos del objeto recibido por
            //parámetros (utilizar el operador “==”) y retorna la lista.
            //miLista = miLista - BoligrafoTres;
            foreach(Boligrafo recorre in lista)
            {
                if (recorre == unPen)
                { lista.Remove(unPen);}
                else { Console.WriteLine("\nNo se encontró el elemento.");}

                
            }
            return lista;
        }
        public bool RecargarTinta()
        {
            if(this._cantidadTinta < 50)
            {this._cantidadTinta=100;return true;}
            else{return false;}
        }
        public bool RecargarTinta(int cantidad)
        {//5) Método “RecargarTinta” (Sobrecargado): método de instancia, público, sin parámetros, permite
            //recargar (poner en 100) la cantidad de tinta del bolígrafo sólo si su tinta es menor a 50, este
            //método retornará “true” si pudo recargar y “false” si no pudo realizar la acción.
            //a. Sobrecargar: realiza la misma acción pero recibe como parámetro la cantidad de tinta que
            //se le agregara al objeto solo si su tinta es mayor a 50.
            if(this._cantidadTinta>50){this._cantidadTinta=cantidad;return true;}
            else{return false;}
        }

        #endregion
    }
}
