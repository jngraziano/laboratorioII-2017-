using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio45
{
    public class Asignatura:Serializar
    {
        #region Lo que pide
        //        Desarrolle una clase llamada Asignatura que:
//Tenga dos atributos privados, uno de tipo entero (el
//identificador) y el otro de tipo decimal (la calificación).
//Dicha clase tendrá un constructor con un parámetro de tipo
        //entero.
        #endregion

        #region Atributos, Prop y Constructores
        private int _ID;
        private decimal _calif;

        public int ID { get { return this._ID; } set { this._ID = value; } }
        public decimal Calificacion { get { return this._calif; } set { this._calif = value; } }


        public Asignatura()
        {
            Random obj = new Random();
            this.Calificacion = (decimal)obj.NextDouble();
            this.ID = obj.Next(1, 1000);
        
        }

        public Asignatura(int id)
        {
            this.ID = id;

        }
        public bool Serializer()
        {
            XmlTextWriter xml = new XmlTextWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio45\XmlAsignatura.xml", Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(typeof(Asignatura));
            xmlS.Serialize(xml, this);
            xml.Close();

            return true;
        }
        #endregion



    }
}
