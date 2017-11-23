using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto() 
        {
            float costoLlamadaProv = 0f;

            if (this._franjaHoraria == Franja.Franja_1)
                { costoLlamadaProv= base.Duracion * 0.99f; }
            
            if (this._franjaHoraria == Franja.Franja_2)
                { costoLlamadaProv = base.Duracion * 1.25f; }
            
            if (this._franjaHoraria == Franja.Franja_3)
                { costoLlamadaProv = base.Duracion * 0.66f; }

            return costoLlamadaProv;
        }

        protected override string Mostrar() 
        {
           // base.Mostrar();
            StringBuilder resp = new StringBuilder();
            //resp.AppendLine("*********************************************");
            resp.AppendLine(base.Mostrar());
            resp.Append("Costo llamada Provincial: ");
            resp.AppendLine(this.CostoLlamada.ToString());
            resp.Append("Franja Horaria: ");
            resp.AppendLine(this._franjaHoraria.ToString());

            return resp.ToString();
            //Console.WriteLine(resp);
        }



        //Para revisar!
        public Provincial(Franja miFranja, Llamada unaLlamada) :this (unaLlamada.NroOrigen, miFranja , unaLlamada.Duracion , unaLlamada.NroDestino)
        {
        
        }




        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(origen, destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object a)
        {
            bool aux = false;

            if (a is Provincial)
            {

                aux = true;

            }
            return aux;
        }

    }
}
