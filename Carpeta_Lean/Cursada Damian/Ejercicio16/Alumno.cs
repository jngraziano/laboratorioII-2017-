using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region atributos

        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        #endregion

        #region metodos

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                _notaFinal = Alumno.nota.Next(1,10);
            }
        }



        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }



        public void Mostrar()
        {
            Console.WriteLine("El alumno: {0} {1} tiene nota 1: {2} y nota 2:{3}. El nro de legajo es {4} y la nota final es: {5}.", this.apellido, this.nombre, this._nota1, this._nota2, this.legajo, this._notaFinal);
            Console.ReadLine();
        }

        #endregion
         
        static Random nota;

        static Alumno()
        {
            Alumno.nota = new Random();
        }
    }


}
  