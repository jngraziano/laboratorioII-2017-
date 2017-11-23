using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    class Cohete:Transporte
    {
        #region Atributos

        public string modelo;
        public int cantidadVentanas;
        
        #endregion

        #region Constructor

        public Cohete(byte pasajeros, Velocidades velocidad, int cantidadVentanas,string modelo)
            :base(pasajeros,velocidad)
        {
            this.cantidadVentanas = cantidadVentanas;
            this.modelo = modelo;
        }

        #endregion

        #region Métodos

        public override void Frenar()
        {
            Console.WriteLine("El Cohete esta frenando...");
        }

        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine ("el Cohete.");
        }

        #endregion

    }
}
