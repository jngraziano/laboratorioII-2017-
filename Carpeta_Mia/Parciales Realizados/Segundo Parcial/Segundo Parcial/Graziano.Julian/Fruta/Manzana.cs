using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Fruta
{
    public class Manzana:Fruta,ISerializable
    {
        #region Atributos, Prop y Constructores
        public double precio;

        public override bool TieneCarozo { get { return true; } }
        public string Tipo { get { return "Manzana"; } }
        public double Precio { get { return this.precio; } }

        public string RutaArchivo { get { return @"C:\Users\alumno.LAB5PC03\Desktop\Segundo Parcial\Graziano.Julian\SerializoManzana.xml"; }}
       

        public Manzana(float peso, ConsoleColor color, double precio) : base(peso, color) 
        {
            this.precio = precio;
        
        }
        #endregion


        #region Metodos
        public override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.FrutaToString());
            sb.AppendLine("\nPrecio: ");
            sb.Append(this.precio);

            return sb.ToString();

            
        }

        public override string ToString()
        {
           
            return this.FrutaToString();
        }


        #endregion

        #region Interface

        public bool SerializarXML()
        {
            try
            {
                XmlTextWriter xmlT = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8);
                XmlSerializer xmlS = new XmlSerializer(typeof(Manzana));

                xmlS.Serialize(xmlT, this);

                return true;

            }
            catch(Exception e) 
            {
                Console.WriteLine(e.InnerException);
                return false;
            }
        
        }

        #endregion
    }
}
