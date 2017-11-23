using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Boleto
{
     class Boleto:IGuardar
    {
        private string empresa;
        public int numero;
        public float valor;

        
        public Boleto()
        {
        
        }

        public string Empresa { get { return this.empresa; } set {this.empresa=value;} }
        
        public Boleto(string empresa, int numero, float valor)
        {
            this.empresa = empresa;
            this.numero = numero;
            this.valor = valor;
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Empresa: ");
            sb.AppendLine(this.empresa);
            sb.Append("Numero de Boleto: ");
            sb.AppendLine(this.numero.ToString());
            sb.Append("El valor del boleto es: ");
            sb.AppendLine(this.valor.ToString());

            return sb.ToString();
        
        }

        public bool Serializar()
        {
            try
            {
                XmlTextWriter tw = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "\\MiBoleto.xml", Encoding.UTF8);

                XmlSerializer xmlserial1 = new XmlSerializer(typeof(Boleto));

                xmlserial1.Serialize(tw, this);

                tw.Close();

                return true;
            }
            catch (Exception e)
            {
                try
                {
                    Console.WriteLine(e.Message);
                    Console.Write(e.InnerException.ToString());
                    return false;
                }
                catch (NullReferenceException a)
                {
                    Console.WriteLine("Referencia nula");
                    
                    return false;
                }
                
            
            }
            
            }


    
    
    }
}
