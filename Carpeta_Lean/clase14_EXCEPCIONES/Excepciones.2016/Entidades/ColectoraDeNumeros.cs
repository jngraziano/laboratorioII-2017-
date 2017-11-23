using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNumero { get; set; }

        public int SumaDeNumeros { get { return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Suma); } }
        public int RestaDeNumeros { get { return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Resta); } }
        public int MultiplicacionDeNumeros { get {return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Multiplicacion);} }
        public double DivisionDeNumeros { get { return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Division); } }


        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }
        public ColectoraDeNumeros(ETipoNumero tipo):this()
        {
            this.TipoNumero = tipo;
        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros cn, Numero n)
        {
            cn._numeros.Add(n);
            return cn;
        }
        
        public static ColectoraDeNumeros operator -(ColectoraDeNumeros cn, Numero n)
        {
            cn._numeros.Remove(n);
            return cn;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("");
            foreach (Numero item in this._numeros)
            {
                sb.AppendLine(item.Number.ToString());
            }

            return sb.ToString();
        }

        protected static double ObtenerResultado(ColectoraDeNumeros cn, ETipoResultado tipo) 
        {
            double rta = 0;
            Numero n;
            double rtaSuma = 0;
            double rtaResta = 0; 
            double rtaMulti = 0;
            double rtaDiv = 0;

            for(int i=1; i<cn._numeros.Count; i++)
            {
                n = cn._numeros[0];
                switch (tipo)
                {
                    case ETipoResultado.Suma:
                        rta += n + cn._numeros[i];
                        break;
                    case ETipoResultado.Resta:
                        rta += n - cn._numeros[i];
                        break;
                    case ETipoResultado.Multiplicacion:
                        rta += n * cn._numeros[i];
                        break;
                    case ETipoResultado.Division:
                        rta += n / cn._numeros[i];
                        break;
                    default:
                        break;
                }
            }
            return rta;
        }
    }
}
