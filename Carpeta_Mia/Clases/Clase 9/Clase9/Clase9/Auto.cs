using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    class Auto:Transporte
    {
        public int CantRuedas;
        public string Patente;

        /*
        public override eVelocidad VelocidadMax()
        {
           get
            {
                if(base._VelocidadMax== eVelocidad.media)
                {}
                return eVelocidad.super;
            }
            
            
            * ACA ADENTRO CON UN GET PUEDO HACER LO QUE QUIERA, PORQUE MODIFICO LA PROPIEDAD AGREGANDOLE POR EJEMPLO
            * UN IF(VELOCIDAD == 50)
            * RETURN eVelocidad.Media
            * OSEA DEVUELVE UN TIPO eVELOCIDAD; LE ESTOY AGREGANDO A LA PROPIEDAD
            * LO IMPORTANTE ES VIRTUAL METODOS NO PROPIEDADES

        }*/

        public override void Frenar()
        {
            Console.WriteLine("Se frena con freno demano");
        }
        public Auto(eVelocidad veloMax, string tiempoUso, int cantidadRuedas, string patente)
            : base(veloMax, tiempoUso)
        {
            this.CantRuedas = cantidadRuedas;
            this.Patente = patente;
        
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nAUTO");
            sb.AppendLine(base.Mostrar());
            sb.Append("\nCantidad de Ruedas: ");
            sb.AppendLine(this.CantRuedas.ToString());
            sb.Append("\n Patente: ");
            sb.AppendLine(this.Patente);

            return sb.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
