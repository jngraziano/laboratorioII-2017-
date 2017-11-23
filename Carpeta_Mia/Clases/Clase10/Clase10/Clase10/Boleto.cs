using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Boleto
    {
        private string empresa;
        public int numero;
        public float valor;

        public string Empresa { get { return this.empresa; } set { this.empresa = value; } }

        public Boleto()
        { }


        public Boleto(string empresa, int numero, float valor):this()
        {
            //this.empresa = empresa;
            this.numero = numero;
            this.valor = valor;
        
        }
        //poliformismo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nEmpresa: ");
            sb.AppendLine(this.empresa);
            sb.Append("\nNumero: ");
            sb.AppendLine(this.numero.ToString());
            sb.Append("\nValor: ");
            sb.AppendLine(this.valor.ToString());

            return sb.ToString();
        }





    }
}
