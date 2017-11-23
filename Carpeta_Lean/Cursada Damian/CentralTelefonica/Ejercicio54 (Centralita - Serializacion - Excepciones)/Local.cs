using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    [Serializable]
    class Local: Llamada
    {
        protected float _costo;
 
        private float CalcularCosto() 
        {
            return this._costo * base.Duracion; 
        }
        
        public override float CostoLlamada 
        {
            get { return this.CalcularCosto(); }
        }

       

        public Local(Llamada unaLlamada, float costo):this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) :base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        protected override string Mostrar() 
        {
            //base.Mostrar();
            StringBuilder resp = new StringBuilder();
           // resp.AppendLine("****************************************");
            resp.AppendLine(base.Mostrar());
            resp.Append("Costo de la llamada Local: ");
            resp.AppendLine(this.CostoLlamada.ToString());

            return resp.ToString();
        
        }

        public override bool Equals(object a)
        {
            bool aux = false;

            if (a is Local)
            {

                aux = true;
            
            }
            return aux;
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

         
    }
}
