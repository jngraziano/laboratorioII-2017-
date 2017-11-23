using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class SerHumano
    {
        #region Enunciado
        //41.Se requiere crear la clase SerHumano que posea los siguientes
        //atributos privados:
        //_nombre (String)
        //_peso (Single)
        //_altura (Single)
        //_sexo (String)
        //Además tendrá los siguientes métodos:
        //Comer(String)
        //Dormir
        //A partir de la clase SerHumano, se pide:
        //Crear dos clases (que hereden de la anterior) llamadas Gerente y
        //Empleado.
        //Cada una de dichas clases poseerá atributos y métodos
        //característicos (por ejemplo, la clase Empleado tendrá como
        //atributo sueldo y como método Trabajar).
        //Generar, en el método Main, las sentencias necesarias para probar
        //los miembros de ambas clases.
        #endregion

        #region Variables
        private string _nombre;
        private Single _peso;
        private Single _altura;
        private string _sexo;
        #endregion

        #region Metodos de la clase
        //Comer(String)
        //Dormir

        public void Comer(string comida)
        { }
        public void Dormir()
        { }

        #endregion

    }
}
