using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55practica
{
    class Lavadero
    {
        #region Atributos, Constructores
        public List<Vehiculo> listaVehiculos;
        public int cantidadVehiculos;
        public float precioAuto;
        public float precioMoto;

        public int CantidaddeVehiculos { get { return this.cantidadVehiculos; } set { this.cantidadVehiculos = value; } }

        public Lavadero()
        {
            List<Vehiculo> list = new List<Vehiculo>();
            this.listaVehiculos = list;
        }

        public Lavadero(float preciodeauto, float preciodemoto):this()
        {
            this.precioAuto = preciodeauto;
            this.precioMoto = preciodemoto;
        }

        public Lavadero(int cantidaddevehiculos, float preciodeauto, float preciodemoto):this(preciodeauto,preciodemoto)
        {
            
            this.cantidadVehiculos = cantidaddevehiculos;
            
        
        }


        #endregion

        #region Metodos

        /*
         * MostrarTotalFacturado: devolverá la ganancia del lavadero (Double), dicho método tendrá una
sobrecarga que reciba como parámetro la enumeración Vehiculos (con Auto y Moto como
enumerados) y retornará la ganancia del Lavadero por tipo de vehículo.

         * El método IngresarAlLavadero (que recibe como único parámetro un Vehiculo), agregará a la lista
dicho objeto e incrementara su contador de vehículos en uno.
         */

        public double MostrarTotalFacturado()
        {
            double result = 0;
            result=this.MostrarTotalFacturado(Vehiculos.Auto) + this.MostrarTotalFacturado(Vehiculos.Moto); 
            return result;
        }

        public double MostrarTotalFacturado(Vehiculos tipo)
        {
            double result=0;
            switch (tipo)
            {
                case Vehiculos.Auto:
                    foreach (Vehiculo recorre in this.listaVehiculos)
                    {
                        if (recorre is Auto)
                        {
                            result += precioAuto;
                        }

                    }
                    break;
                case Vehiculos.Moto:
                    foreach (Vehiculo recorre in this.listaVehiculos)
                    {
                        if (recorre is Moto)
                        {
                            result += precioMoto;
                        }
                    }
                    break;
                default: ;
                    break;

            }
            return result;
        
        }

        public List<Vehiculo> IngresarAlLavadero(Vehiculo unVehiculo)
        {
            this.listaVehiculos.Add(unVehiculo);
            this.CantidaddeVehiculos++;
            return this.listaVehiculos;
            
        }

        
       

        #endregion

        }
}
