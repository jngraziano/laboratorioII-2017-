using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Centralita
    {
         #region Atributos, Propiedades y Constructores

        private List<Llamada> _listaDeLlamadas;
        private string _razonSocial;

        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }

        public List<Llamada> Llamadas { get { return this._listaDeLlamadas; } }

        public Centralita()
        {
            List<Llamada> list = new List<Llamada>();
            this._listaDeLlamadas=list;
        }
        public Centralita(string NombreEmpresa)
            : this()
        { this._razonSocial = NombreEmpresa; }

        #endregion

        #region Metodos

        public List<Llamada> AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
            return this._listaDeLlamadas;
        }


        public float CalcularGanancia(TipoLlamada tipo)
        {
            
            float result = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Local)
                        {
                            result += ((Local)recorre).CostoLlamada;
                        
                        }
                    
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if(recorre is Provincial)
                        {
                        result += ((Provincial)recorre).CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Local)
                        {
                            result += ((Local)recorre).CostoLlamada;

                        }
                        if (recorre is Provincial)
                        {
                            result += ((Provincial)recorre).CostoLlamada;
                        }
                    
                    }
                    /*
                     * Tambien se puede ahorrar codigo:
                     * if(recorre is Local)
                     * {CalcularGanancia(TipoLlamada.Local);}
                     * else if (recorre is Provincial)
                     * {CalcularGanancia(TipoLlamada.Provincial);}
                     * */
                    break;
                default: ;
                    break;
            
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this._razonSocial.ToString());
            sb.Append("\nGanancia Local: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());
            sb.Append("\nGanancia Provincial: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());
            sb.Append("\nGanancia Total: ");
            sb.AppendLine(this.GananciaTotal.ToString());
            foreach (Llamada recorre in this._listaDeLlamadas)
            {
                sb.Append("\nListado de llamadas: ");
                sb.AppendLine(recorre.ToString());

            }

            return sb.ToString();
        
        }

        public void OrdenarLlamadas()
        {

            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);



        }

       
        #region Sobrecarga de Operadores
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool rta=false;
           
            foreach(Llamada recorre in central._listaDeLlamadas)
            {
                if(recorre == nuevaLlamada)
                {
                    rta= true;
                
                }
                else
                {rta=false;}
            
            }
                return rta;
            
            
        
        }
        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central==nuevaLlamada);
        }
        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if(central == nuevaLlamada)
            {
                Console.WriteLine("\nLa llamada ya se encuentra en el listado.");
            }
            else
            {
            central.AgregarLlamada(nuevaLlamada);
            }
            return central;
        }
        #endregion


        #endregion
    }
    
}
