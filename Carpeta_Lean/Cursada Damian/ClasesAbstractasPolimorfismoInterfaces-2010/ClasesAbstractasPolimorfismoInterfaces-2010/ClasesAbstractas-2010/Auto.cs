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
    }
}
