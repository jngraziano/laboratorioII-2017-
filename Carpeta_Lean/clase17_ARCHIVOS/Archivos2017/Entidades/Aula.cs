using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Aula
    {
        private int _numero;
        private string _nombre;
        private bool _internet;

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
           
        }

        public bool Intenet
        {
           
            set { this._internet = value; }
        }

        private List<Persona> _listadoDePersonas;
        public List<Persona> ListadoDePersonas
        {
            get { return this._listadoDePersonas; }
        }

        public Aula()
        {
            this._listadoDePersonas = new List<Persona>();
        }

        public Aula(int numero, bool internet, string nombre):this()
        {
            this._internet = internet;
            this._nombre = nombre;
            this._numero = numero;
        }


        public bool serializarMe()
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Aula));

                using (StreamWriter escritor = new StreamWriter(this.Numero + "aula.xml"))
                {
                    serializador.Serialize(escritor, this);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
