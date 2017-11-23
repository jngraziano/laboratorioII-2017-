using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

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

        public override sealed string Mostrar()
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


        public bool leer(string archivo, out Automovil datos)
        {
            bool flag_ok = false;
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryReader bin = new BinaryReader(fs);


                //datos = bin.ReadString();

                //flag_ok = true;
            }
            catch (Exception e)
            {
                try
                {
                    throw new ErrorArchivoException(MENSAJE_ERROR_ARCHIVO_LEER, e.InnerException);
                }
                catch (ErrorArchivoException error)
                {
                    Console.Write(error.Message + error.InnerException);

                }
            }
            datos = null;
            return flag_ok;

        }

        public bool guardar(string archivo)
        {
            bool flag_ok = false;
            try
            {
                FileStream fs = new FileStream(archivo, FileMode.Open);
                BinaryWriter bin = new BinaryWriter(fs);

                bin.Write(this.Mostrar());

                flag_ok = true;
            }
            catch (Exception e)
            {
                try
                {
                    throw new ErrorArchivoException(MENSAJE_ERROR_ARCHIVO_GUARDAR, e.InnerException);
                }
                catch (ErrorArchivoException error)
                {
                    Console.Write(error.Message + error.InnerException);

                }
            }
            return flag_ok;

        }

        #endregion
    }
}
