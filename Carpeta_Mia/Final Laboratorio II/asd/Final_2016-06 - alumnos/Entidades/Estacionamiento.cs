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
    public class Estacionamiento:ISerializable
    {
        private static string MENSAJE_ESTACIONAMIENTO_LLENO = "El estacionamiento se encuentra lleno.";
        private static string MENSAJE_VEHICULO_REPETIDO = "El vehículo ya se encuentra en el estacionamiento.";
        private static string MENSAJE_ERROR_ARCHIVO_GUARDAR = "Error al guardar el archivo.";
        private static string MENSAJE_ERROR_ARCHIVO_LEER = "Error al leer el archivo.";

        List<Vehiculo> _vehiculos;
        int _espacioDisponible;

        public enum ETipo
        {
            Moto, Camion, Automovil, Todos
        }

        #region "Constructores"
        private Estacionamiento()
        {
            this._vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(int espacioDisponible):this()
        {
            this._espacioDisponible = espacioDisponible;
        }
        #endregion
        

        #region "Sobrecargas"
        
        #endregion
       
        #region "Métodos"

        /// <summary>
        /// Expone los datos de la Estacionamiento y sus vehículos (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="Estacionamiento">Estacionamiento a exponer</param>
        /// <param name="ETipo">Tipos de Vehiculos a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Estacionamiento estacionamiento, ETipo tipoDeVehiculo) //quitar static
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", estacionamiento._vehiculos.Count, estacionamiento._espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in estacionamiento._vehiculos)
            {
                switch (tipoDeVehiculo)
                {
                    case ETipo.Automovil:
                        if(v is Automovil)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Moto:
                        if (v is Moto)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Camion:
                        if (v is Camion)
                            sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion
       
        #region "Operadores"
        /// <summary>
        /// Agregará un vehículo a la Estacionamiento
        /// </summary>
        /// <param name="Estacionamiento">Objeto del tipo Estacionamiento donde se agregará el vehículo</param>
        /// <param name="vehiculo">Objeto del tipo Vehículo a agregar</param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            try
            {
                for (int i = 0; i < estacionamiento._vehiculos.Count; i++)
                {
                    if (estacionamiento._vehiculos[i] == vehiculo)
                        return estacionamiento;
                }

                estacionamiento._vehiculos.Add(vehiculo);
            }
            catch (Exception e)
            {
                try
                {
                    Console.WriteLine(e.InnerException);
                    throw new EstacionamientoLlenoException(Estacionamiento.MENSAJE_ESTACIONAMIENTO_LLENO);

                }
                catch (EstacionamientoLlenoException f)
                {
                    Console.WriteLine(f.Message);

                }
            
            }
            return estacionamiento;
        }
        /// <summary>
        /// Quitará un vehículo de la Estacionamiento
        /// </summary>
        /// <param name="Estacionamiento">Objeto del tipo Estacionamiento donde se agregará el vehículo</param>
        /// <param name="vehiculo">Objeto del tipo Vehículo a agregar</param>
        /// <returns></returns>
        public static Estacionamiento operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            Estacionamiento estaux = new Estacionamiento(estacionamiento._espacioDisponible);
            estaux._vehiculos = estacionamiento._vehiculos;
            foreach (Vehiculo recorre in estacionamiento._vehiculos)
            {
                if (recorre == vehiculo)
                {
                    estaux._vehiculos.Remove(vehiculo);
                
                }
            
            }

            return estaux;
        }

        
        #endregion
       


        #region Serialización

        public bool leer(string archivo, Estacionamiento datos)
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
                    throw new ErrorArchivoException(Estacionamiento.MENSAJE_ERROR_ARCHIVO_LEER, e.InnerException);
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
                    throw new ErrorArchivoException(Estacionamiento.MENSAJE_ERROR_ARCHIVO_GUARDAR, e.InnerException);
                }
                catch (ErrorArchivoException f)
                {
                    Console.WriteLine(f.Message);
                    return false;
                
                }
            
            }
        }

        #endregion
    }
}
