using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase30._05
{
    public class Ticket: IGuardar
    {
        public DateTime fecha;
        public string razonSocial;
        private double importe;
        public double Importe { get { return this.importe; } 
            set { if (value <= 0) 
                    {
                    //lanzo una exception o derivadas de exception. Puedo generar un tipo de exception
                    throw new Exception("No puede ingresar numero negativos o igual 0.");
                    } 
                   else { this.importe = value; } 
                }   
                                }

        public bool serializar()
        {

            try
            {
                using (XmlTextWriter objXML = new XmlTextWriter(@"D:\Ticket.xml", Encoding.UTF8))
                {
                    XmlSerializer objSER = new XmlSerializer(typeof(Ticket)); //SE LE INDICA QUE TIPO DE OBJETO VA A SERIALIZAR

                    objSER.Serialize(objXML, this);
                    Console.WriteLine("Ticket Serializado");
                    Console.WriteLine(this.ToString());
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Referencia de objeto nulo");
                return false;
            }

            catch (FieldAccessException)
            {
                Console.WriteLine("No tiene acceso a la carpeta");
                return false;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try { Console.WriteLine(e.InnerException.ToString()); }
                catch (Exception e2) { Console.WriteLine(e2.Message); }
                return false;
            }
          
        }

        public Ticket() 
        {
        
        
        }
        public Ticket(DateTime tiempo, string razon, double importe) 
        {
            this.fecha = tiempo;
            this.razonSocial = razon;
            this.importe = importe;
        
        }

        public override string ToString()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Fecha: ");
            resp.AppendLine(this.fecha.ToString());
            resp.Append("Razon social: ");
            resp.AppendLine(this.razonSocial);
            resp.Append("Importe: ");
            resp.AppendLine(this.importe.ToString());

            return resp.ToString();
        
        } 
    }
}
