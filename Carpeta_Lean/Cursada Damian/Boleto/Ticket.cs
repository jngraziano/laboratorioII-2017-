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
    public class Ticket:IGuardar
    {
        public DateTime fecha;
        public string razonSocial;
        public double importe;

        public Ticket(DateTime fecha, string razonsocial, double importe)
        {
            this.fecha = fecha;
            this.razonSocial = razonsocial;
            this.importe = importe;
        }


        public Ticket()
        { 
        
        }

        public double Importe { 
            get { return this.importe; }
            
            set
            {
                if (value < 0)
                {
                    throw new Exception("El numero debe ser positivo");
                }
                else if(value >= 0)
                {
                    this.importe=value;
                }
            }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("La fecha es: ");
            sb.AppendLine(this.fecha.ToString());
            sb.Append("La razon social es: ");
            sb.AppendLine(this.razonSocial);
            sb.Append("El importe es: ");
            sb.AppendLine(this.importe.ToString());
            
            return sb.ToString();
        }

        public bool Serializar()
        {

            try
            {
                XmlTextWriter tw = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "\\MiTicket.xml", Encoding.UTF8);

                XmlSerializer xmlserial = new XmlSerializer(typeof(Ticket));

                xmlserial.Serialize(tw, this);

                tw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
         }


    }
}
