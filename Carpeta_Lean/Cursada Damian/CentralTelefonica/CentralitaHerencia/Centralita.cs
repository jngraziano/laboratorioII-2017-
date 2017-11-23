 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    class Centralita
    {

        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #region Constructores

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public Centralita() //this("Sin nombre")
        {
            _listaDeLlamadas = new List<Llamada>();
        
        }
        #endregion

       
        #region Propiedades

        public float GananciaPorLocal 
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }
        
        
        #endregion 


      
        #region Metodos

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float acum = 0f;
            
             foreach (Llamada item in this.Llamadas)
             {
                 
                 if (item is Local && (tipo == TipoLlamada.Local || tipo == TipoLlamada.Todas))
                 {
                     acum += ((Local)item).CostoLlamada;

                 }
                 else if (item is Provincial && ( tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas))
                 {
                     acum += ((Provincial)item).CostoLlamada;
                    
                 }

                // return acum;
             }

             return acum;

          
        
        
        
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
            
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        
        }
        #endregion 

        #region Poliformismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Empresa: ");
            sb.AppendLine(this._razonSocial);

            sb.Append("Las ganancias totales son: ");
            sb.AppendLine(this.GananciaTotal.ToString());

            sb.Append("Las ganancias por llamadas Locales son: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());

            sb.Append("Las ganacias por llamadas Provinciales son: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());

            sb.AppendLine("El registro de llamadas es:");

            //Console.WriteLine(sb.ToString());

            foreach (Llamada item in this.Llamadas)
            {

                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

        #endregion 
        
        #region Sobre Carga
        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool aux = false;

            foreach (Llamada item in centralita.Llamadas)
            {
                if (item.Equals(llamada))
                {
                    aux = true;
                }
            }

            return aux;

        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
            
        }

        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            bool aux = false;
            
            if (centralita != llamada)
            {
                centralita.AgregarLlamada(llamada);
                aux = true;
            }

            if (aux == false)
            {
                Console.WriteLine("No se agrego");
            }

            return centralita;
        }
        
        
        #endregion
    }
}
