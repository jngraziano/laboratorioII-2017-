using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private int _nota1 = 0;
        private int _nota2 = 0;
        private float _notaFinal = 0;
        public string apellido;
        public int legajo;
        public string nombre;


        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random Objram = new Random();
                this._notaFinal = Objram.Next(7,10);

            }
            else
            {
                this._notaFinal = -1;
            
            }
        }
        public void Estudiar(int notaUno, int notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        
        }
        public void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Detalles");
            Console.WriteLine("\n\nNota 1: {0}\nNota2: {1}\nApellido: {2}\nNombre: {3}\nLegajo: {4}", this._nota1,this._nota2,this.apellido,this.nombre,this.legajo);
            //Console.WriteLine("\nNota 2: {0}",this._nota2);
            if (this._notaFinal == -1)
            {
                Console.WriteLine("El usuario no aprobo");

            }
            else
            {
                Console.WriteLine("\n\nEl usuario aprobo con: {0}", this._notaFinal);
            
            }
        
        }



    }
}
