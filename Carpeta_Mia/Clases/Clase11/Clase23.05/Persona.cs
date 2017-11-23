using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase30._05
{
     class Persona: IGuardar
    {
        public string nombre;
        public int edad;

        public bool serializar()
        {

            try 
            {
                using (XmlTextWriter objXML = new XmlTextWriter(@"D:\Persona.xml", Encoding.UTF8))
                {
                    XmlSerializer objSER = new XmlSerializer(typeof(Persona)); //SE LE INDICA QUE TIPO DE OBJETO VA A SERIALIZAR
                    Console.WriteLine("Persona Serializado");
                    Console.WriteLine(this.ToString());
                    objSER.Serialize(objXML, this);
                    return true;
                }
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try { Console.WriteLine(e.InnerException.ToString()); }
                catch (Exception e2) { Console.WriteLine(e2.Message); }
                
                return false;
            }
           
        }

        public Persona() 
        {
        
        }

        public Persona(string nom, int edad) 
        {
            this.nombre= nom;
            this.edad = edad ;
        }

        public override string ToString()
        {
            StringBuilder resp = new StringBuilder();
            resp.Append("Nombre: ");
            resp.AppendLine(this.nombre);
            resp.Append("Edad: ");
            resp.AppendLine(this.edad.ToString());

            return resp.ToString();

        } 

    }
}
