using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Interfaces
{
    public class MiClase : IMiInterface
    {
        public int PropiedadLE
        {
            get { return this.atributo.Length;  }
            set { }
        }

        public int PropiedadSL
        {
            get { return 8; }
        }

        public int PropiedadSE
        {
            set { this.atributo = value.ToString(); }
        }

        public string atributo;

        public MiClase(string atributo)
        {
            this.atributo = atributo;
        }

        public override string ToString()
        {
            return this.atributo;
        }

        public double MetodoConParametros(int p1, int p2)
        {
            return p1 + p2;
        }

        public void MetodoSinRetornoNiParametros()
        {
            Console.WriteLine("hola");
        }

    }
}
