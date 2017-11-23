using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligra
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public ConsoleColor Color { get { return this._color; }}
        public int Tinta { get { return this._tinta; }}

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            this._tinta = tinta;
        
        }
        
        public bool Pintar(int gasto)
        {
            
            if (gasto < this.Tinta)
            {
                Console.WriteLine("El gasto fue de {0}", gasto);

                return true;
               
            }
            else
            {
                Console.WriteLine("El gasto fue de {0}", gasto);

                return false;
            
            }
                 
        }
        public void Recargar()
        {
            Console.WriteLine("Se debe recargar");
            
        
        }


    }
}
