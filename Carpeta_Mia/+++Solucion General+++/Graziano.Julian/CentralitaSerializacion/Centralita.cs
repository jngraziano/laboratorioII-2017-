using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaSerializacionPractica
{
    public class Centralita : ISerializable
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        protected string _ruta;

        #region Ganancias
        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float acumulador = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Local)
                        {
                            acumulador += ((Local)recorre).CostoLlamada;

                        }

                    }

                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Provincial)
                        {
                            acumulador += ((Provincial)recorre).CostoLlamada;

                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Local)
                        {
                            acumulador += ((Local)recorre).CostoLlamada;

                        }
                        else if (recorre is Provincial)
                        {
                            acumulador += ((Provincial)recorre).CostoLlamada;
                        }

                    }

                    break;
                default: ;
                    break;



            }
            return acumulador;

        }


        #endregion

        #region Propiedades
        public List<Llamada> Llamadas { get{return this._listaDeLlamadas;} }
        //agregado por el ejercicio 54
        public string RazonSocial { get { return this._razonSocial; } set { this._razonSocial = value; } }
        public string RutaDeArchivo { get { return this._ruta; } set { this._ruta = value; } }
        #endregion

        #region Constructores
        public Centralita()
        {
            List<Llamada> list = new List<Llamada>();
            this._listaDeLlamadas = list;

        }
        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion


        #region Metodos

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this._razonSocial.ToString());
            sb.Append("\nGanancia Total: ");
            sb.AppendLine(this.GananciaTotal.ToString());
            sb.Append("\nGanancia Locales: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());
            sb.Append("\nGanancia Provinciales: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());

            Console.WriteLine(sb.ToString());

            foreach (Llamada recorre in this._listaDeLlamadas)
            {
                sb.Append("Datos Lista: ");
                //forma 1
                if (recorre is Provincial)
                { Console.WriteLine(((Provincial)recorre).ToString()); }
                //forma 2
                if (recorre is Local)
                {
                    Local llamLoc = ((Local)recorre);
                    Console.WriteLine(llamLoc.ToString());

                }

            }
          
        }

        public void OrdenarLLamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        
        }

        //agregado por el ejercicio 53

        private void AgregarLlamada(Llamada uno)
        {
            try
            {
                this._listaDeLlamadas.Add(uno);
               
                this.GuardarEnArchivo(uno,true);

            }
            catch (Exception e)
            {
                try
                {
                    throw new CentralitaException(e.Message, e.Source, e.TargetSite.ToString(), e.InnerException);

                }
                catch (CentralitaException f)
                { Console.WriteLine(f.Mensaje, f.NombreClase, f.NombreMetodo, f.InnerException); }
            
            }
            
        
        }
        //agregado por el ejercicio 54
        public bool Serializarse()
        {
            //Serializarse. Retornará true, si es que se pudo
            //serializar el objeto actual, incluyendo el listado de
            //llamadas del mismo, en el path indicado por el atributo
            //privado _ruta. En el caso de no poder serializarlo
            //(debido a una excepción) se deberá lanzar una excepción
            //de tipo CentralitaException, indicándole:
            //o Mensaje de error.
            //o Nombre de la clase que provocó la excepción.
            //o Nombre del método que provoco la excepción.
            //o El objeto de tipo Exception.
            try
            {
                XmlTextWriter xmlT = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8);
                XmlSerializer xmlS = new XmlSerializer(typeof(Centralita));

                xmlS.Serialize(xmlT, this);
                xmlT.Close();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    Console.WriteLine(e.InnerException);
                    throw new CentralitaException(e.Message, e.Source, e.TargetSite.ToString(), e.InnerException);
                }
                catch (CentralitaException f)
                {
                    Console.WriteLine(f.Mensaje + f.NombreClase + f.NombreMetodo + f.InnerException);

                }
                return false;
            }

        }

        public bool DeSerializarse()
        {
            try
            {
                XmlTextReader xmlR = new XmlTextReader(this.RutaDeArchivo);
                XmlSerializer xmlS = new XmlSerializer((typeof(List<Llamada>)), new Type[] { typeof(Centralita), typeof(Provincial), typeof(Local) });
                
               Centralita nuevaCentral = (Centralita)xmlS.Deserialize(xmlR);
                xmlR.Close();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    throw new CentralitaException(e.Message, e.Source, e.TargetSite.ToString(), e.InnerException);
                }
                catch (CentralitaException f)
                { Console.WriteLine(f.Mensaje + f.NombreClase + f.NombreMetodo + f.InnerException); }
                return false;

            }

        }
        private bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"E:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\CentralitaSerializacion", agrego);
                sw.Write("\nListado Centralita: ");
                sw.Write(unaLlamada.ToString());
                sw.Close();

                //ACA FALTA ESTO que tiro magia
                //En el archivo se agregará/sobrescribirá (según el
                //atributo agrego) un encabezado, la fecha de la llamada
                //(con formato de tiempo largo) y la descripción de la
                //llamada (utilizar polimorfismo).
                return true;

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); return false; }


        }
            
        #endregion

        #region Sobrecargas Operadores
        public override string ToString()
        {
            return base.ToString();
        }
        public static bool operator ==(Centralita central, Llamada unaLlamada)
        {
            bool aux = false;
            foreach (Llamada recorre in central._listaDeLlamadas)
            {
                if (recorre == unaLlamada)
                {
                    aux = true;
                }
                else
                {
                    aux = false;
                }

            
            }
            return aux;
        
        }

        public static bool operator !=(Centralita central, Llamada unaLlamada)
        { return !(central == unaLlamada); }

        public static Centralita operator +(Centralita central, Llamada unaLlamada)
        {
            try{
                if (central != unaLlamada)
                {

                    central.AgregarLlamada(unaLlamada);
                }
                else { Console.WriteLine("\nYa se encuentra la llamada en la central"); }
               }
            catch(Exception e)
            {
                try
                {
                    throw new CentralitaException(e.Message, e.Source, e.TargetSite.ToString(), e.InnerException);

                }
                catch (CentralitaException f)
                { Console.WriteLine(f.Message,f.NombreMetodo,f.NombreClase,f.InnerException); }
                
               
            }
                               
            
            
            return central;

        }

        #endregion

    }
}
