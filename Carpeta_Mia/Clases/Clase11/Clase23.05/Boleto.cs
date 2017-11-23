using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase30._05
{
    public class Boleto : IGuardar
    {
        public string empresa;
        public int numero;
        public float valor;

        //serializo un boleto
        public bool serializar()
        {
            try
            {
                using (XmlTextWriter objXML = new XmlTextWriter(@"D:\Boleto.xml", Encoding.UTF8))
                {
                    XmlSerializer objSER = new XmlSerializer(typeof(Boleto)); //SE LE INDICA QUE TIPO DE OBJETO VA A SERIALIZAR

                    objSER.Serialize(objXML, this);
                    Console.WriteLine("Boleto Serializado");
                    Console.WriteLine(this.ToString());
                    return true;

                }

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                //Este tryCatch se da porque el InnerException es nulo y vuelve a ingresar al try pero como
                //no lo encuentra, crashea. Ahi entra otra vez el 2do catch y ejecuta y muestr el segundo mensaje.
                try { Console.WriteLine(e.InnerException.ToString()); }
                    //tipo de objeto del catch cambia de Exception a NullReferenceException (tengo que verificarlo)
                catch (NullReferenceException e2) { Console.WriteLine(e2.Message); }
                return false;
            }
           
        }

        public Boleto()
        {

        }

        public Boleto(string emp, int num, float val) 
        {
            this.empresa= emp;
            this.numero = num ;
            this.valor = val; 
        }

        public override string ToString()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Empresa: ");
            resp.AppendLine(this.empresa);
            resp.Append("Numero: ");
            resp.AppendLine(this.numero.ToString());
            resp.Append("Valor: ");
            resp.AppendLine(this.valor.ToString());

            return resp.ToString();

        } 

    }
}
