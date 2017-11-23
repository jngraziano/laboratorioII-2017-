using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    //Para poder Deserializar OK
    [XmlInclude(typeof(Automovil))]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Camion))]
    public class Estacionamiento : ISerializable
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

        public Estacionamiento(int espacioDisponible)
            : this()
        {
            this._espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Mostrar(this, ETipo.Todos));
            return sb.ToString();
        }

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
                        if (v is Automovil)
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
            //Lugar disponible
            try
            {
                if (estacionamiento._vehiculos.Count < estacionamiento._espacioDisponible)
                {
                    //Vehiculo Repetido
                    for (int i = 0; i < estacionamiento._vehiculos.Count; i++)
                    {
                        try
                        {
                            if (estacionamiento._vehiculos[i] == vehiculo)
                            {
                                throw new VehiculoRepetidoException(MENSAJE_VEHICULO_REPETIDO);
                            }
                            else
                            {
                                estacionamiento._vehiculos.Add(vehiculo);
                            }
                        }
                        catch (VehiculoRepetidoException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                else
                {
                    throw new EstacionamientoLlenoException(MENSAJE_ESTACIONAMIENTO_LLENO);
                }
            }
            catch (EstacionamientoLlenoException e)
            {
                Console.WriteLine(e.Message);
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
            for (int i = 0; i < estacionamiento._vehiculos.Count; i++)
            {
                Vehiculo v = estacionamiento._vehiculos[i];
                if (v == vehiculo)
                {
                    estacionamiento._vehiculos.Remove(v);
                    break;
                }
            }

            return estacionamiento;
        }
        #endregion

        #region Serialización


        public bool leer(string archivo, out Estacionamiento datos)
        {
            bool flag_ok = false;
            try
            {
                XmlTextReader read = new XmlTextReader(archivo);
                XmlSerializer ser = new XmlSerializer(typeof(Estacionamiento));
                datos = (Estacionamiento)ser.Deserialize(read);
                flag_ok = true;
            }
            catch (Exception e)
            {
                try
                {
                    throw new ErrorArchivoException("Error al serializar Estacionamiento", e.InnerException);
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
                XmlSerializer ser = new XmlSerializer(typeof(Estacionamiento));
                XmlTextWriter read = new XmlTextWriter(archivo, Encoding.UTF8);
                ser.Serialize(read, this);
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
