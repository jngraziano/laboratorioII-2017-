using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    class Caballo:Transporte
    {
        #region Atributos

        public string raza;
        public Colores color;

        #endregion

        #region Constructor

        public Caballo(string raza, byte cantPasajeros, Velocidades miVelocidad, Colores miColor)
        :base(cantPasajeros,miVelocidad)
        {
            this.raza = raza;
            this.color = miColor ;
        }

        #endregion

        #region Métodos

        public override void Frenar()
        {
            Console.WriteLine("El Caballo está frenando...");
        }

        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("el Caballo.");
        }

        #endregion
    }
}
