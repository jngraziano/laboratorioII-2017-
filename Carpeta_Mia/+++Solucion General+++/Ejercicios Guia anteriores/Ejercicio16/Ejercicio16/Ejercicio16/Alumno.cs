using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        
       

        public void CalcularFinal()
        {
            if(this._nota1 >=4 && this._nota2 >=4)
            {
               Random notaRando = new Random();
               this._notaFinal= notaRando.Next(1,10);
                      
            }
        else
            {
                 this._notaFinal=-1; 
            }

        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1=notaUno;
            this._nota2=notaDos;
        }
        public void Mostrar()
        {
            Console.Write("Nombre: {0} \n Apellido: {1} \n Legajo: {2} \n Nota1: {3} \n Nota2: {4} \n\n\n ", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2);
        }
        


    }
}
