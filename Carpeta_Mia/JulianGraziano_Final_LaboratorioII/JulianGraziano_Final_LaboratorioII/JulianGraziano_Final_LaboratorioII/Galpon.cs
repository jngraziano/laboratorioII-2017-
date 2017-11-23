using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace JulianGraziano_Final_LaboratorioII
{
    class Galpon
        //:IGuardarXML
    {
        

        public List<Deposito> listaDeposito;
        private int _cantidadDepositos;



        public int CantidadDepositos{set{this._cantidadDepositos=value;}}


        //public Galpon()
        //{
        //    List<Deposito> list = new List<Deposito>;
        //    this.listaDeposito=list;
        //}

        public Galpon(int CantidadDepo, Deposito unDeposito)
            //: this()
        {
            this._cantidadDepositos = CantidadDepo;
            this.listaDeposito.Add(unDeposito);
        }


        public int AsignarCantidadDepositos(int cantidad)
        {
            int devuelve = 0;
            try{
                    if(cantidad != 0)
                    {
                     devuelve= cantidad;
                    }
               }
            catch(Exception e)
                {
                    devuelve = 0;
                    throw new ArgumentException(e.Message);
                    
                    
                }
            return devuelve;
        }

        //public bool SerializarXML(Galpon unGalpon)
        //{
        //    //XmlWriter xmlW = new XmlWriter(@"F:\Facultad\Programacion II (C#) 2016\JulianGraziano_Final_LaboratorioII\archivo.xml", Encoding.UTF8);
        //    //XmlSerializer xmlS = new XmlSerializer(typeof(Galpon), this);

        //    //xmlS.Serialize(xmlW,unGalpon);
        //    //xmlW.Close();
            
        //    //return true;
                    
        //Me arrojaba un error como que no reconocia el metodo XmlSerializer por eso lo deje comentado.
        //}

    }
}
