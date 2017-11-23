using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio6
{
    class ConstructorA
    {
        public ConstructorA ()
        {
            try 
            {
                throw new MiExcepcion("Constructor A");
            }
            catch (MiExcepcion e) 
            {
                ConstructorB otroConstructor = new ConstructorB();
            }
        }
    }
}
