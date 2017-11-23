using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region Variables de la clase
        private byte _nota1;
        private byte _nota2;
        private int _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region Metodos de la clase

        public void CalcularFinal()
        {  //El método CalcularFinal deberá colocar la nota del final sólo si
            //las notas 1 y 2 son mayores o iguales a 4, caso contrario la
            //inicializará con -1. Para darle un valor a la nota final utilice
            //el método de instancia Next de la clase Random.
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random notaram = new Random();
                this._notaFinal = notaram.Next(1, 10);
            }
            else { this._notaFinal = -1; }
        }

        public void Estudiar(byte NotaUno, byte NotaDos)
        {
            //Sólo se podrá ingresar las notas (nota1 y nota2) a través del
            //método Estudiar.
            this._nota1 = NotaUno;
            this._nota2 = NotaDos;
        }

        public void Mostrar()
        {
            //Por último, el método Mostrar, expondrá en la consola todos los
            //datos de los alumnos, a excepción de la nota final. Este valor se
            //mostrará sólo si es distinto de -1.
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.AppendLine(nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(apellido);
            sb.Append("Legajo: ");
            sb.AppendLine(legajo.ToString());
            sb.Append("Nota 1: ");
            sb.AppendLine(this._nota1.ToString());
            sb.Append("Nota 2: ");
            sb.AppendLine(this._nota2.ToString());
            Console.WriteLine(sb.ToString());
            if (this._notaFinal != -1)
            {
                Console.WriteLine("\n\nNota Final: {0}", this._notaFinal);
            }
            else { Console.WriteLine("\n\nNo llego a tener nota final."); }
            

        }

        #endregion
    }
}
