using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Interfases
{
    public class MiClase
    {
        public string atributo;

        public MiClase(string atributo)
        {
            this.atributo = atributo;
        }

        public override string ToString()
        {
            return this.atributo;
        }
    }
}
