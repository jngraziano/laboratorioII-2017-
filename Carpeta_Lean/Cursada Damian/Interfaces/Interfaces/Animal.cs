using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Animal
    {
            protected int patas;

            public Animal(int patas)
            {
                this.patas = patas;
            }


            public virtual void Caminar()
            {
                Console.WriteLine("Este animal camina sobre {0} patas", this.patas);
            }

            abstract public void Comer();
            
    }
}
