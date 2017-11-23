using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismoPractica
{
    public class Centralita
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

       

        public override string ToString()
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
            foreach (Llamada recorre in this._listaDeLlamadas)
            {
                sb.Append("Datos Lista: ");
                sb.AppendLine(recorre.ToString());

            }
            return sb.ToString();
        }

        public void OrdenarLLamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        
        }

        //agregado por el ejercicio 53

        private List<Llamada> AgregarLlamada(Llamada uno)
        {
            this._listaDeLlamadas.Add(uno);
            return this._listaDeLlamadas;
        
        }

        public static bool operator ==(Centralita central, Llamada unaLlamada)
        {
            bool aux = false;
            foreach (Llamada recorre in central._listaDeLlamadas)
            {
                if (recorre == unaLlamada)
                {
                    aux = true;
                }
                else
                {
                    aux = false;
                }

            
            }
            return aux;
        
        }
        public static bool operator !=(Centralita central, Llamada unaLlamada)
        { return !(central == unaLlamada); }

        public static Centralita operator +(Centralita central, Llamada unaLlamada)
        {
            
                if (central == unaLlamada)
                {
                    Console.WriteLine("\nYa se encuentra la llamada.");
                }
                else
                {
                    central.AgregarLlamada(unaLlamada);
                }
                
            
            
            return central;
        
        }

            

    }
}
