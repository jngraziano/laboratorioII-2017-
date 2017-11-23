using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Operario
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _salario;

        public Operario()
        { this._salario = 1500;
        }
        public Operario(string nombre, string apellido):this()
        { this._nombre = nombre;
        this._apellido = apellido;

        }
        public Operario(string nombre, string apellido, int legajo):this(nombre,apellido)
        {
            this._legajo = legajo;
        
        }



        public float getSalario()
        { return this._salario; }
        public void setAumentarSalario(float aumento)
        {
            this._salario = this._salario + (this._salario * aumento / 100);
        
        }


        //Retorna un String con toda la información del operario. Utilizar el método ObtenerNombreYApellido.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ObtenerNombreYApellido());
            sb.AppendLine("\nLegajo: ");
            sb.AppendLine(this._legajo.ToString());
            sb.Append("\nSalario: ");
            sb.AppendLine(this.getSalario().ToString());
            return sb.ToString();


        }
//Recibe un operario y retorna un String con toda la información del mismo (utilizar el método Mostrar de instancia)
        public static string Mostrar(Operario op)
        {
            return op.Mostrar();
        
        }
        //Retorna un String que tiene concatenado el nombre y el apellido del operario separado por una coma.
        public string ObtenerNombreYApellido()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this._nombre + ","+ this._apellido);
            return sb.ToString();
        }

        public static bool operator !=(Operario op1, Operario op2)
        {
            return !(op1 == op2);
        
        }

        //Operador == (Igual): Retronará un booleano informando si el nombre, apellido y el legajo de los 
        //operarios coinciden al mismo tiempo.
        public static bool operator ==(Operario op1, Operario op2)
        {
            if (op1.ObtenerNombreYApellido() == op2.ObtenerNombreYApellido() && op1._legajo == op2._legajo)
            {
                return true;

            }
            else { return false; }
        
        }
        


    }
}
