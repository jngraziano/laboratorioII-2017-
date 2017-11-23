using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    class Centralita:ISerializable
    {
        #region Atributos, Propiedades y Constructores

        private List<Llamada> _listaDeLlamadas;
        private string _razonSocial;
        private string _ruta;

        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }


        public List<Llamada> Llamadas { get { return this._listaDeLlamadas; } set { this._listaDeLlamadas = value; } }
        public string RazonSocial { get { return this._razonSocial; } set { this._razonSocial = value; } }
        public string RutaDeArchivo { get { return this._ruta; } set { this._ruta = value; } } 

        public Centralita()
        {
            List<Llamada> list = new List<Llamada>();
            this._listaDeLlamadas = list;
        }
        public Centralita(string NombreEmpresa)
            : this()
        { this._razonSocial = NombreEmpresa; }

        #endregion

        #region Metodos

        #region AgregarLlamada/CalcularGanancia/OrdenarLlamadas/ToString
        public List<Llamada> AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
            return this._listaDeLlamadas;
        }


        public float CalcularGanancia(TipoLlamada tipo)
        {

            float result = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Local)
                        {
                            result += ((Local)recorre).CostoLlamada;

                        }

                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Provincial)
                        {
                            result += ((Provincial)recorre).CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada recorre in this._listaDeLlamadas)
                    {
                        if (recorre is Local)
                        {
                            result += ((Local)recorre).CostoLlamada;

                        }
                        if (recorre is Provincial)
                        {
                            result += ((Provincial)recorre).CostoLlamada;
                        }

                    }
                    /*
                     * Tambien se puede ahorrar codigo:
                     * if(recorre is Local)
                     * {CalcularGanancia(TipoLlamada.Local);}
                     * else if (recorre is Provincial)
                     * {CalcularGanancia(TipoLlamada.Provincial);}
                     * */
                    break;
                default: ;
                    break;

            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this._razonSocial.ToString());
            sb.Append("\nGanancia Local: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());
            sb.Append("\nGanancia Provincial: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());
            sb.Append("\nGanancia Total: ");
            sb.AppendLine(this.GananciaTotal.ToString());
            foreach (Llamada recorre in this._listaDeLlamadas)
            {
                sb.Append("\nListado de llamadas: ");
                sb.AppendLine(recorre.ToString());

            }

            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {

            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);



        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool rta = false;

            foreach (Llamada recorre in central._listaDeLlamadas)
            {
                if (recorre == nuevaLlamada)
                {
                    rta = true;

                }
                else
                { rta = false; }

            }
            return rta;



        }
        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }


        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            try{
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
                
            }
                return central;
            }
            catch(Exception e)
            {
                try
                {
                    Console.WriteLine(e.InnerException);
                    throw new CentralitaException("\nYa se encuentra la llamada.", e.Source, e.TargetSite.ToString());
                }
                catch (CentralitaException f)
                { Console.WriteLine(f.Mensaje + f.NombreClase + f.NombreMetodo); }
                return central;
            }
            
        }
        #endregion

        #region Serializar/Deserializar/GuardarenTXT

        public bool Serializarse()
        {
            #region Lo que me pide
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
            #endregion

            #region NOTAS IMPORTANTES SERIALIZACION
            /*
             * Serializacion con try/catch.
             * ******TRY******
             * En este punto, creamos un try en donde debo colocar lo que quiero que suceda si es exitoso. 
             * Creamos un XMLTEXTWRITER pasandole la ruta del archivo la cual ya tenemos un atributo con ese dato disponible y el Encoding.
             * Creamos un XMLSERIALIZER pasandole el tipo que queremos serializar.
             * Lo serializamos usando "xmlS.Serialize" y le pasamos el XMLTEXTWRITER (ej: xmlT) y un this para indicar que es esto lo que queremos
             * serializar.
             * Debemos cerrar el XMLTEXTWRITER utilizando en el ej: xmlT.Close(), y devolvemos el TRUE que devuelve la funcion.
             * 
             * ******CATCH******
             * En el bloque catch, debemos crear la primera excepcion de todo--> Exception e (RECORDAR, ES LA EXCEPCION GENERICA)
             * Dentro del catch, creamos otro bloque try/catch
             *              SEGUNDO TRY
             *              Mostramos por consola lo que pide el ejercicio, en este caso un InnerException desde el obj Exception e que habiamos creado
             *              Luego lanzamos la nueva exepcion que nos pide, creamos una nueva a partir de la clase CentralitaException.
             *              Le pasamos Dentro de este, utilizando el obj e, e.Message, e.Source, e.TargetSite.Tostring(), e.InnerException.
             *              Estos son los valores que necesita el constructor de CentralitaException (mensaje, clase, metodo e innerException)
             *              Le estamos mandando los errores que se generan a la CentralitaExeption
             *              SEGUNDO CATCH
             *              Generamos una CentralitaException f y dentro mostramos con el ConsoleWriteLine concatenando. llamando a las propiedades de 
             *              CentralitaException que habiamos guardado en el try anterior. EJ: f.Mensaje+f.NombreClase+f.Metodo+f.InnerException
             * Cerramos el segundo bloque try/catch y retornamos el FALSE.
             */

            #endregion


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
                    //     CORRESPONDE A -->       MENSAJE  /  CLASE  /  METODO (recordar pasar a string) / InnerException            
                }
                catch (CentralitaException f)
                {
                    Console.WriteLine(f.Mensaje + f.NombreClase + f.NombreMetodo + f.InnerException);
                    
                
                }
                return false;
            
            }


        
        }

        public bool DesSerizarse()
        {
            #region Lo que me pide
            //Retornará true, si es que se pudo
            //deserializar del archivo .XML al objeto actual, del path
            //indicado por el atributo privado _ruta. En el caso de no
            //poder deserializarlo (debido a una excepción) se deberá
            //lanzar una excepción de tipo CentralitaException,
            //indicándole:
            //o Mensaje de error.
            //o Nombre de la clase que provocó la excepción.
            //o Nombre del método que provoco la excepción.
            //o El objeto de tipo Exception.
            #endregion

            #region NOTAS IMPORTANTES DESSERIALIZACION
            /*
             * ******TRY******
             * En este punto, creamos un try en donde debo colocar lo que quiero que suceda si es exitoso. 
             * Creamos un XMLTEXTREADER pasandole SOLO la ruta del archivo la cual ya tenemos un atributo con ese dato disponible.
             * Creamos un XMLSERIALIZER pasandole el tipo que queremos serializar.
             * IMPORTANTE --> En este caso solo coloque para desseralizar la lista, para deserealizar cada uno se debería poner todos los typeof 
             * de la siguiente manera --> (typeof(List<Llamada>)), new Type[] { typeof(Centralita), typeof(Provincial), typeof(Local) }
             * Creamos una centralita para guardar la informacion que se deserializó.
             * Lo deserializamos usando "xmlS.Deseralize" y le pasamos el XMLTEXTREADER (ej: xmlR) y lo asignamos a la centralita creada de auxiliar.
             * Debemos cerrar el XMLTEXTREADER utilizando en el ej: xmlR.Close(), y devolvemos el TRUE que devuelve la funcion.
             * 
             * ******CATCH******
             En el bloque catch, debemos crear la primera excepcion de todo--> Exception e (RECORDAR, ES LA EXCEPCION GENERICA)
             * Dentro del catch, creamos otro bloque try/catch
             *              SEGUNDO TRY
             *              Mostramos por consola lo que pide el ejercicio, en este caso un InnerException desde el obj Exception e que habiamos creado
             *              Luego lanzamos la nueva exepcion que nos pide, creamos una nueva a partir de la clase CentralitaException.
             *              Le pasamos Dentro de este, utilizando el obj e, e.Message, e.Source, e.TargetSite.Tostring(), e.InnerException.
             *              Estos son los valores que necesita el constructor de CentralitaException (mensaje, clase, metodo e innerException)
             *              Le estamos mandando los errores que se generan a la CentralitaExeption
             *              SEGUNDO CATCH
             *              Generamos una CentralitaException f y dentro mostramos con el ConsoleWriteLine concatenando. llamando a las propiedades de 
             *              CentralitaException que habiamos guardado en el try anterior. EJ: f.Mensaje+f.NombreClase+f.Metodo+f.InnerException
             * Cerramos el segundo bloque try/catch y retornamos el FALSE.
             */


            #endregion

            try
            {

                XmlTextReader xmlR = new XmlTextReader(this.RutaDeArchivo);
                XmlSerializer xmlS = new XmlSerializer((typeof(List<Llamada>)));

                Centralita auxiliar = new Centralita();
                auxiliar=(Centralita)xmlS.Deserialize(xmlR);
                xmlR.Close();
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

        public bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            #region lo que me pide

            //GuardarEnArchivo. Este método privado, guardará en un
            //archivo de texto nombrado como Llamadas.txt (ubicado en
            //el path indicado por el atributo _ruta).
            //En el archivo se agregará/sobrescribirá (según el
            //atributo agrego) un encabezado, la fecha de la llamada
            //(con formato de tiempo largo) y la descripción de la
            //llamada (utilizar polimorfismo).
            //Si por algún motivo no se pudiera escribir en el archivo
            //se deberá lanzar una excepción (de tipo
            //CentralitaException) informando:
            //o Mensaje de error.
            //o Nombre de la clase que provocó la excepción.
            //o Nombre del método que provoco la excepción.
            //o El objeto de tipo Exception.
            #endregion

            #region DATOS IMPORTANTES TXT
            /*
             * Se crea con un STREAMWRITER (pasandole la ruta, en el segundo ( si queremos ) podemos pasarle un bool, donde indique si sobreescribe o no)
             * Utilizamos un EJ: stW.WRITE() o stW.WRITELINE() que escribira en el txt, un string o lo que le pasemos 
             * Cerramos con un Close().
             * 
             * Se lee con un STREAMREADER(pasandole la ruta).
             * Utilizamos un stR.READ() o stR.READLINE() que lea en el txt la información que contiene. y lo asignamos a un atributo
             * Cerramos con un Close()
             * 
             * */ 


            #endregion

            try
            {
                StreamWriter stW = new StreamWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Ejercicios Guia anteriores\CentralitaCompleto\CentralitaTelefonica\Llamadas.txt", agrego);
                stW.Write("\nListado: ");
                stW.WriteLine(unaLlamada.ToString());
                stW.Close();
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


        #endregion

        #endregion
    }
}
