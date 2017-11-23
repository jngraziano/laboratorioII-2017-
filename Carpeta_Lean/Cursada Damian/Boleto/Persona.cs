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
     public class Persona:IGuardar
    {
        public string nombre;
        public int edad;


        public Persona()
        {
        
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("El nombre es: ");
            sb.AppendLine(this.nombre);
            sb.Append("La edad es: ");
            sb.AppendLine(this.edad.ToString());
            
            
            return sb.ToString();
        }

        public bool Serializar()
        {

            try
            {

                XmlTextWriter tw = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "\\MiPersona.xml", Encoding.UTF8);

                XmlSerializer xmlserial = new XmlSerializer(typeof(Persona));

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
