using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    class Cajon:ISerializable
    {
        #region Atributos, Prop y Constructores
        private int _capacidad;
        private List<Fruta> _frutas;

        public List<Fruta> Frutas { get { return this._frutas; } }
        public double PrecioDeManzanas { get { return this.ObtenerTotal(EtipoFruta.Manzana); } }
        public double PrecioDePlatanos { get { return this.ObtenerTotal(EtipoFruta.Platano); } }
        public double PrecioTotal { get { return this.ObtenerTotal(EtipoFruta.Todo); } }

        public Cajon()
        {
            List<Fruta> list = new List<Fruta>();
            this._frutas = list;
        }
        public Cajon(int capacidad):this()
        { 
            this._capacidad = capacidad;
            
        }
        
        #endregion

        #region Metodos

        private double ObtenerTotal(EtipoFruta tipo)
        {
            //retorna el acumulado de precios segun el parametro de tipo Etipo Fruta que reciba
            double result = 0;
            switch (tipo)
            {
                case EtipoFruta.Manzana:
                    //result+=
                        break;
                case EtipoFruta.Platano:
                    //result+=((Platano)
                        break;
                case EtipoFruta.Todo:
                    //result+=((Manzana).            
                        break;
                default:;
                    break;
            }

            return result;
        
        }


        public static Cajon operator +(Cajon c, Fruta f)
        {
            //sera el encargado de agregar frutas al cajon siempre y cuando no supere la capacidad del mismo
            //de superar la capacidad deberá lanzar la excepcion CajonLLenoException. Debe recibir una fruta
            //que sea null, deberá lanzar la excepcion estandar( ya presente en el sistema) ArgumentException
            int acum=0;
            try 
            {
                if (acum < c._capacidad)
                { c._frutas.Add(f); acum++; }
                else
                {
                    throw new Exception("CajonLleno");
                }
               
            
            }
            catch (Exception e)
            {
                try
                {
                     Console.WriteLine(e.Message);
                    if(f== null)
                    {
                        throw new ArgumentException();
                    
                    }
                   
                }
                catch( ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                
                }

            }

            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nCapacidad: ");
            sb.AppendLine(this._capacidad.ToString());

            foreach (Fruta recorre in this._frutas)
            {
                sb.Append(recorre.FrutaToString());
            
            }
            return sb.ToString();
            
        }

        #endregion

    }
}
