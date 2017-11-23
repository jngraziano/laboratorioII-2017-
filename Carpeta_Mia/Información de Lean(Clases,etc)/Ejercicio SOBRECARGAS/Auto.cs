using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_SOBRECARGAS
{
    class Auto
    {
        #region Atributos
        private string _marca;
        private string _color;
        private ETipoCombustible _tipoCombustible;
        private float _precio;
        #endregion

        #region Constructor x defecto
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Auto() 
        {
            this._marca = "---";
            this._color = "---";
            this._tipoCombustible = ETipoCombustible.SIN_TIPO;
            this._precio = 0;
        }
        #endregion

        #region Constructores de campos
        /// <summary>
        /// Setea la marca
        /// </summary>
        /// <param name="m">Marca</param>
        public Auto(string m):this()        //Esto llama al constructor por defecto
        {
            this._marca = m;  
        }

        /// <summary>
        /// Setea la marca y el color
        /// </summary>
        /// <param name="m">Marca</param>
        /// <param name="c">Color</param>
        public Auto(string m,string c):this(m) //esto llama al constructor de marca directamente
        {
            //this._marca = m; se comenta para reutilizar codigo
            this._color = c;
        }

        /// <summary>
        /// Setea la marca, el color y tipo de Combustible
        /// </summary>
        /// <param name="m">Marca</param>
        /// <param name="c">Color</param>
        /// <param name="t">TCombustible</param>
        public Auto(string m, string c,ETipoCombustible t):this(m,c)
        {
            //this._marca = m; se comenta para reutilizar codigo
            //this._color = c; se comenta para reutilizar codigo
            this._tipoCombustible = t;
        }

        /// <summary>
        /// Setea marca, color, tipo combustible, precio
        /// </summary>
        /// <param name="m">Marca</param>
        /// <param name="c">Color</param>
        /// <param name="t">TipoCombustible</param>
        /// <param name="p">Precio</param>
        public Auto(string m, string c, ETipoCombustible t,float p):this(m,c,t)
        {
            //this._marca = m;           se comenta para reutilizar codigo   
            //this._color = c;           se comenta para reutilizar codigo
            //this._tipoCombustible = t; se comenta para reutilizar codigo
            this._precio = p;
        }

        private string Mostrar()
        {
            //Console.WriteLine("Marca: {0} \n Color: {1} \n Tipo Combustible: {2} \n Precio: {3}\n ",this._marca,this._color,this._tipoCombustible,this._precio); Esto es para void
            return this._marca + this._color + this._tipoCombustible + this._precio;
        
        }

        public static string Mostrar(Auto autito)
        {
            //Console.WriteLine("Marca: {0} \n Color: {1} \n Tipo Combustible: {2} \n Precio: {3}\n ",this._marca,this._color,this._tipoCombustible,this._precio); Esto es para void
            return autito.Mostrar();

        }
        #endregion

    }
}
