using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region Atributos
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        
        public void CalcularFinal() 
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random objetoRandom = new Random();
                this._notaFinal = objetoRandom.Next(4,10) ;
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos) 
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostrar() 
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nLegajo: {2}\nNota1: {3}\nNota2: {4}\n", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2);
            if (this._notaFinal!= -1)
                Console.WriteLine("\nNota Final: {0}\n", _notaFinal);
        }

    }
}
