using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase41
{
    class Empleado:SerHumano
    {
        public float _sueldo;
        protected int _edad;

        public Empleado(string sexo):base(sexo) 
        { 
        
        }
        
        
        public void Trabajar()
        {
            Console.WriteLine("Nooooo 5 minutos mas....");
        }
    
        
    }
}
