using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace Entidades
{
    public class Automovil : Vehiculo, ISerializable //quitar herencia
    {
        private static string MENSAJE_ERROR_ARCHIVO_GUARDAR = "Error al guardar el archivo.";
        private static string MENSAJE_ERROR_ARCHIVO_LEER = "Error al leer el archivo.";

        #region Constructores
        public Automovil(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        #endregion
        //aparentemente esta bien
        #region Propiedades
        /// <summary>
        /// Los automoviles tienen 4 ruedas
        /// </summary>
        protected override short CantidadRuedas
        {
            get
            {
                return 4;
            }
        }

        #endregion
        //aparentemente esta bien
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.Append(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #region Serialización

        public bool leer(string archivo, Automovil datos)
        {
            try
            {
                XmlTextReader xmlR = new XmlTextReader(archivo);
                xmlR.Close();
                return xmlR.Read();


            }
            catch (Exception e)
            {
                try
                {
                    Console.WriteLine(e.Message);
                    throw new ErrorArchivoException(Automovil.MENSAJE_ERROR_ARCHIVO_LEER, e.InnerException);
                }
                catch (ErrorArchivoException f)
                {
                    Console.WriteLine(f.Message);
                    return false;

                }

            }
        }

        public bool guardar(string archivo)
        {
            try
            {
                XmlTextWriter xmlW = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer xmlS = new XmlSerializer(typeof(Estacionamiento));

                xmlS.Serialize(xmlW, this);
                xmlW.Close();

                return true;
            }
            catch (Exception e)
            {
                try
                {
                    Console.WriteLine(e.Message);
                    throw new ErrorArchivoException(Automovil.MENSAJE_ERROR_ARCHIVO_GUARDAR, e.InnerException);
                }
                catch (ErrorArchivoException f)
                {
                    Console.WriteLine(f.Message);
                    return false;

                }

            }
        }
    }

        #endregion
    }


