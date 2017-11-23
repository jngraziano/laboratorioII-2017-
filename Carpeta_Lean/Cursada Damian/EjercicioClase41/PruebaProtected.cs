using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase41
{
    class PruebaProtected:Empleado
    {
        public void Prueba()
        {
            base.Comer("Torta");
        }

        public PruebaProtected(string a) : base(a) { }
    }
}
