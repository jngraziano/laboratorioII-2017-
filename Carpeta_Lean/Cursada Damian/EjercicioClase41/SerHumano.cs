using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase41
{
    class SerHumano
    {
        string _nombre;
        Single _peso;
        Single _altura;
        string _sexo;

        public SerHumano(string sexo) 
        {
            this._sexo = sexo;
        
        }

        


        public void Comer(string a)
        {
            Console.WriteLine("Tengo lija {0}", a);
        }

        public void Dormir()
        { 
        
        }
    }
}
