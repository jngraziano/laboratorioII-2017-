using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerenciaPractica
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }

        public List<Llamada> Llamadas { get{return this._listaDeLlamadas;} }

        public Centralita()
        {
            List<Llamada> list = new List<Llamada>();
            this._listaDeLlamadas = list;

        }
        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
           float acumulador=0;
            switch(tipo)
            {
                case TipoLlamada.Local:
                    foreach(Llamada recorre in this._listaDeLlamadas)
                    {
                        if(recorre is Local)
                        {
                            acumulador+=((Local)recorre).CostoLlamada;
                        
                        }
                    
                    }

                    break;
                case TipoLlamada.Provincial:
                    foreach(Llamada recorre in this._listaDeLlamadas)
                    {
                        if(recorre is Provincial)
                        {
                            acumulador+=((Provincial)recorre).CostoLlamada;
                        
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                        foreach(Llamada recorre in this._listaDeLlamadas)
                        {
                            if (recorre is Local)
                            {
                                acumulador += ((Local)recorre).CostoLlamada;
                            
                            }
                            else if (recorre is Provincial)
                            {
                                acumulador += ((Provincial)recorre).CostoLlamada;
                            }
                        
                        }

                    break;
                 default:;
                    break;

                               
            
            }
            return acumulador;
        
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this._razonSocial.ToString());
            sb.Append("\nGanancia Total: ");
            sb.AppendLine(this.GananciaTotal.ToString());
            sb.Append("\nGanancia Locales: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());
            sb.Append("\nGanancia Provinciales: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());
            foreach(Llamada recorre in this._listaDeLlamadas)
            {
                recorre.Mostrar();
            
            }
        
        }

        public void OrdenarLLamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        
        }



    }
}
