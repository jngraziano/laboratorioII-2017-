using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41practica
{
    class Empleado:SerHumano
    {
        public float sueldo=5000;
        public string sueño;

        public Empleado(string Nombre, Single peso, Single Altura, string Sexo):base(Nombre,peso,Altura,Sexo)
        {
            this.sueño = "Mucho";
        
        }
        public void Trabajar()
        {
            if (this.sueño == "Poco")
            {
                Console.WriteLine("\nDebería trabajar mas");
                

            }
            else
            {
                Console.WriteLine("\nDebería trabajar menos");
                Console.WriteLine("\nSu sueldo es de: {0} encima", this.sueldo);
            
            }
        
        }
    }
}
