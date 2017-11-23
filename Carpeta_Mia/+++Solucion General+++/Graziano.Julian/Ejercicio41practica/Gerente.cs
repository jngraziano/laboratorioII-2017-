using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio41practica
{
    class Gerente:SerHumano
    {
        public float sueldo=30000;
        public string sueño;

        public Gerente(string Nombre, Single peso, Single Altura, string Sexo):base(Nombre,peso,Altura,Sexo)
        {
            this.sueño = "Poco";
        
        }

        public void Trabajar()
        {
            if (this.sueño == "Poco")
            {
                Console.WriteLine("\nDebería trabajar mas");
                Console.WriteLine("\nSu sueldo es de: {0} encima", this.sueldo);

            }
            else
            {
                Console.WriteLine("\nDebería trabajar menos");

            }

        }

    }
}
