using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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

        public float CalcularGanancia(TipoLlamada tipo)
        {
            //CalcularGanancia (Privado. Recibe un Enumerado de tipo
            //TipoLlamada y retornará el valor de lo recaudado, según
            //el criterio elegido).

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

        public void Mostrar()
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
                recorre.Mostrar();

            }

            Console.WriteLine(sb.ToString());
        
        }

        public void OrdenarLlamadas()
        {

            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);



        }

        #endregion
    }
}
