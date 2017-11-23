using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercico47
{
    public abstract class Animal
    {
        protected int _patas;

        public Animal()
        { }
        public Animal(int Patas)
        {
            this._patas=Patas;
        }
        
        public virtual void Caminar()
        {
            if (this._patas == 0)
            { Console.WriteLine("\nEl animal no tiene patas"); }
            else
            {

                Console.WriteLine("\nEste animal camina sobre {0} patas", this._patas);
            }
        
        }
        public abstract void Comer();
        public abstract bool Serealizador();
    }
}
