using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    class Auto:Transporte
    {
        #region Atributos

        public int cantidadRuedas;

        #endregion

        #region Propiedades

        //IMPLEMENTO LA PROPIEDAD ABSTRACTA
        public override string TiempoDeUso
        {
            get
            {
                return "Usado hace 120 años...";
            }
        }

        #endregion
        
        #region Constructor

        public Auto(byte pasajeros, Velocidades velocidad, int ruedas)
            :base(pasajeros,velocidad)
        {
            this.cantidadRuedas = ruedas;
        }

        #endregion

        #region Métodos

        public override void Frenar()
        {
            Console.WriteLine("El Auto está frenando...");
        }

        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("el Auto.");
        }

        #endregion

        #region Polimorfismo ToString

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.ToString());

            sb.AppendLine("En la clase Auto...");
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantidadRuedas.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
