using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class SerHumano
    {
        protected string _nombre;
        protected Single _peso;
        protected Single _altura;
        protected string _sexo;
        protected int _cargaHoraria;

        public string nombre { get { return this._nombre; } set { this._nombre = value; } }
        public Single peso { get { return this._peso; } set { this._peso = value; } }
        public Single altura { get { return this._altura; } set { this._altura = value; } }
        public string sexo { get { return this._sexo; } set { this._sexo = value; } }
        public int cargaHoraria { get { return this._cargaHoraria; } set { this._cargaHoraria = value; } }

        

        public string comer()
        {

            string rta1 = "Esta Menor a 50k. Debe comer mas.";
            string rta2 = "Esta Mayor a 50k. Debe comer menos.";
            
            if (this._peso < 50)
            {

                return rta1;

            }
            else { return rta2; }

        }
        public void dormir()
        {
            if (this._cargaHoraria > 50)
            {

                Console.WriteLine("Esta Trabajando mas de 50hs. Debe Dormir 8 hs");
            }
            else { Console.WriteLine("Esta Trabajando menos de 50hs. Trabaja poco, puede dormir menos"); }

        }
        public char validaCHAR(char rta)
        {
            while (rta != 's' && rta != 'n')
            {
                Console.WriteLine("\nError en letra. Reingrese: ");
                rta = char.Parse(Console.ReadLine());
            }
            return rta;

        }

    }
}
