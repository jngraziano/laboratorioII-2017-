using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio4
{
    class Class1
    {
        public int _valor;

        public int PropAsigna 
        { 
            //get{ return this._valor; }
            set
            {
                if (value > 0)
                {
                    this._valor = value;
                    Console.WriteLine("Valor inicializado con {0}", value);
                }
                else 
                {
                    throw new Exception("Es un numero negativo");
                }
            }
        }

    }
}
