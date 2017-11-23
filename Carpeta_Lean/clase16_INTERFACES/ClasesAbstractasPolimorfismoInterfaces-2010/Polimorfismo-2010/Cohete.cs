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

        #region Propiedades

        //IMPLEMENTO LA PROPIEDAD ABSTRACTA
        public override string TiempoDeUso
        {
            get
            {
                return "Usado hace 50 años...";
            }
        }

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

        #region Polimorfismo ToString

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.ToString());

            sb.AppendLine("En la clase Cohete...");

            sb.Append("Cantidad de ventanas: ");
            sb.AppendLine(this.cantidadVentanas.ToString());
            sb.Append("Modelo: ");
            sb.AppendLine(this.modelo);

            return sb.ToString();
        }

        #endregion
    }
}
