using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    abstract class Transporte
    {
        protected eVelocidad _VelocidadMax;
        protected string _tiempodeUso;
        public virtual eVelocidad VelocidadMax { get { return this._VelocidadMax; } }
        /*METODO ABSTRACTO, no coloco nada dentro del get
         SIEMPRE SE AGREGA UN ;
         NO PUEDEN TENER IMPLEMENTACION EN LA CLASE BASE
         LOS METODOS Y PROPIEDADES ABSTRACTAS SOLO PUEDEN ESTAR DEFINIDAS EN CLASES ABSTRACTAS
         CLASE ABSTRACTA:
         SIEMPRE VAN A SER LAS CLASES QUE ESTEN EN LA CIMA DE LA GERARQUIA
         ES UN MODELO DE ALGO QUE NO PUEDE SER INSTANCIADO. NO SE VA A PODER INSTANCIAR
         NO PUEDO CREAR UN OBJETO DE ALGO ABSTRACTO*/
        

        public abstract void Frenar();

        public Transporte(eVelocidad veloMax, string tiempodeUso)
        {
            this._VelocidadMax = veloMax;
            this._tiempodeUso = tiempodeUso;
           
        
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nVelocidad Maxima: ");
            sb.AppendLine(this._VelocidadMax.ToString());
            sb.Append("\nTiempo de Uso: ");
            sb.AppendLine(this._tiempodeUso.ToString());

            return sb.ToString();

        
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
