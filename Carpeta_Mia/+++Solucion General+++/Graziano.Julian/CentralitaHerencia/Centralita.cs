using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get {return this.CalcularGanancia(TipoLlamada.Local);} }
        public float GananciaPorProvincial { get {return this.CalcularGanancia(TipoLlamada.Provincial);}  }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get {return this._listaDeLlamadas;} }
              
        public Centralita()
        {
            List<Llamada> ini = new List<Llamada>();
            this._listaDeLlamadas = ini;
        }
        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
        
        }
        
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float valorRecau=0;

            switch(tipo)
            {
                case TipoLlamada.Local:
                    foreach(Llamada valor in this._listaDeLlamadas)
                    {
                        if (valor is Local)
                        {
                            valorRecau += ((Local)valor).CostoLLamada;
                            //break;
                        }
                                            
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach(Llamada valor in this._listaDeLlamadas)
                    {
                        if (valor is Provincial)
                        { 
                        valorRecau+=((Provincial)valor).CostoLLamada;
                        //break;
                        }
                                            
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada llamadasTotal in this.Llamadas) 
                    {
                        if (llamadasTotal is Local) 
                        { this.CalcularGanancia(TipoLlamada.Local); }
                        else if (llamadasTotal is Provincial)
                        { this.CalcularGanancia(TipoLlamada.Provincial);  }

                    }
                    break;

            
                     
                default: ;
                     break;
            
            
            }
            
        return valorRecau;
        }

        public void Mostrar()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append("Razon Social: ");
            sb.AppendLine(this._razonSocial);
            sb.Append("Ganancia Total: ");
            sb.AppendLine(this.GananciaTotal.ToString());
            sb.Append("Ganancia Llamados Locales: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());
            sb.Append("Ganancia Llamados Provinciales: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());

            Console.WriteLine(sb);

          foreach(Llamada valor in this.Llamadas)
            {
              if(valor is Provincial)
              {
                  //FORMA DE PROBAR DENTRO DE LLAMADA
                  //SI ES PROVINCIAL O LOCAL
                  ((Provincial) valor).Mostrar();}//FORMA 1
              if(valor is Local)
              {
                  Local aux = ((Local)valor);//FORMA 2
                  aux.Mostrar();
                  
              
              }
             
            }
            
        
        }

        public void OrdenarLLamadas()
        {

        }
        



    }
}
