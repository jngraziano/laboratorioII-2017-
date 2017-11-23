using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercico47
{
    public class Pez:Animal,Mascota
    {
        protected string _nombre;

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public Pez()
        { }

        public Pez(string Nombre, int patas) : base(patas) 
        {
            this._nombre = Nombre;
                    
        }

        public override void Caminar()
        {
            base.Caminar();
            Console.WriteLine("\nNombre: {0}", this._nombre);

        }
        public override void Comer()
        {
            Console.WriteLine("\n\nEste animal come sardinas.");

        }
        public void Jugar()
        {
            Console.WriteLine("\n\nEste animal juega con otros peces.");

        }
        public override bool Serealizador()
        {
            XmlTextWriter xmlW = new XmlTextWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercico47\PezXml.xml", Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(typeof(Pez));

            xmlS.Serialize(xmlW, this);

            return true;

        }
    }
}
