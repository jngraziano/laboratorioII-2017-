 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    class Centralita:ISerializable
    {

        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string _ruta;


        #region Constructores

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public Centralita() //this("Sin nombre")
        {
            this._listaDeLlamadas = new List<Llamada>();
            this._ruta = AppDomain.CurrentDomain.BaseDirectory; 
        }
        #endregion

       
        #region Propiedades

        public float GananciaPorLocal 
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }
        
        public string RutaDelArchivo
        {
            get{ return this._ruta;}
            set { this._ruta = value; }
        }
      
        
        #endregion 


      
        #region Metodos

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float acum = 0f;
            
             foreach (Llamada item in this.Llamadas)
             {
                 
                 if (item is Local && (tipo == TipoLlamada.Local || tipo == TipoLlamada.Todas))
                 {
                     acum += ((Local)item).CostoLlamada;

                 }
                 else if (item is Provincial && ( tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas))
                 {
                     acum += ((Provincial)item).CostoLlamada;
                    
                 }

                // return acum;
             }

             return acum;

          
        
        
        
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
            
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            try
            {
                this.GuardarEnArchivo(nuevaLlamada, true);
            }
            catch (CentralitaException excepcion)
            {
                throw new CentralitaException(excepcion.Message, excepcion.Source, excepcion.InnerException.ToString());
            }
        
        }

        public bool Serializarse ()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(this.RutaDelArchivo,Encoding.UTF8);
                
                XmlSerializer serializer = new XmlSerializer(typeof(Centralita));

                serializer.Serialize(writer, this);

                writer.Close();
                return true;
            }
            catch (Exception excepcion) 
            {
                 throw new CentralitaException(excepcion.Message, excepcion.Source, excepcion.InnerException.ToString());
               
            }
                
        }

        public bool DeSerializarse()
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(this.RutaDelArchivo);

                XmlSerializer serializer = new XmlSerializer(typeof(Centralita));

                Centralita alDope;
                alDope = (Centralita)serializer.Deserialize(reader);
                return true;
            }
            catch (Exception excepcion)
            {
                
                try
                {
                   throw new CentralitaException(excepcion.Message,excepcion.Source,excepcion.TargetSite.ToString(),excepcion.InnerException);
                }
                catch (CentralitaException excepcion2)
                {
                    Console.WriteLine(excepcion2.Message + excepcion2.NombreClase + excepcion2.NombreMetodo + excepcion2.Source);
                }
                return false;
            }
        }

        private bool GuardarEnArchivo(Llamada unaLlamada, bool booleano)
        {
            try
            {
                StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Llamadas.txt", booleano);

                writer.WriteLine(DateTime.Now.ToLongDateString());
                writer.WriteLine(unaLlamada.ToString());
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                //Console.WriteLine("Rompe aca en Guardar en Archivo---->" + e.Message);
                try
                {
                    throw new CentralitaException(e.Message, e.Source, e.TargetSite.ToString(), e.InnerException);
                }
                catch (CentralitaException e2)
                {
                    Console.WriteLine("No puede guardar el archivo en el txt");
                    return false;
                }
             }



        }
        
        
        #endregion 

        #region Poliformismo

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Empresa: ");
            sb.AppendLine(this._razonSocial);

            sb.Append("Las ganancias totales son: ");
            sb.AppendLine(this.GananciaTotal.ToString());

            sb.Append("Las ganancias por llamadas Locales son: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());

            sb.Append("Las ganacias por llamadas Provinciales son: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());

            sb.AppendLine("El registro de llamadas es:");

            //Console.WriteLine(sb.ToString());

            foreach (Llamada item in this.Llamadas)
            {

                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

        #endregion 
        
        #region Sobre Carga
        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool aux = false;

            foreach (Llamada item in centralita.Llamadas)
            {
                if (item == llamada)
                {
                    aux = true;
                }
            }

            return aux;

        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
            
        }

        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            try
            {
                bool aux = false;

                if (centralita != llamada)
                {
                    
                    centralita._listaDeLlamadas.Add(llamada);
                    centralita.AgregarLlamada(llamada);
                    aux = true;
                }

                if (aux == false)
                {
                    try
                    {
                        throw new CentralitaException("Ya existe en la lista", "Clase Centralita", "Sobre Carga de operador +");
                    }
                    catch (CentralitaException e)
                    {
                        Console.WriteLine(e.NombreClase + e.NombreMetodo);
                    }
                }
                    return centralita;
            }
            catch (CentralitaException excepcion)
            {
                throw new CentralitaException(excepcion.Message, excepcion.Source, excepcion.InnerException.ToString());          
            }
        
        
        }
        
        
        #endregion
    }
}
