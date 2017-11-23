using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    class Lavadero
    {
        //Por último se desea construir la clase Lavadero que tendrá una lista genérica de Vehiculos, un atributo
        //cantidadVehiculos (int), precioAuto (float) y precioMoto (float), que se inicializaran desde su constructor.
        //Los métodos que tendrá Lavadero son:
        //MostrarTotalFacturado: devolverá la ganancia del lavadero (Double), dicho método tendrá una
        //sobrecarga que reciba como parámetro la enumeración Vehiculos (con Auto y Moto como
        //enumerados) y retornará la ganancia del Lavadero por tipo de vehículo.
        //El método IngresarAlLavadero (que recibe como único parámetro un Vehiculo), agregará a la lista
        //dicho objeto e incrementara su contador de vehículos en uno.

        public List<Vehiculo> listaVehiculos;
        public int cantidadVehiculos;
        public float precioAuto;
        public float precioMoto;
        
        
        public Lavadero()
        {
            List<Vehiculo> list = new List<Vehiculo>();
            this.listaVehiculos = list;
        }

        public Lavadero(float precAuto, float precMoto):this()
        {
            
            this.precioAuto = precAuto;
            this.precioMoto = precMoto;
        }
        
        public Lavadero(int cantidadvehi, float precioaut, float preciomot):this(precioaut,preciomot)
        {
            this.cantidadVehiculos=cantidadvehi;
        }
        //Los métodos que tendrá Lavadero son:
        //MostrarTotalFacturado: devolverá la ganancia del lavadero (Double), dicho método tendrá una
        //sobrecarga que reciba como parámetro la enumeración Vehiculos (con Auto y Moto como
        //enumerados) y retornará la ganancia del Lavadero por tipo de vehículo.
        //El método IngresarAlLavadero (que recibe como único parámetro un Vehiculo), agregará a la lista
        //dicho objeto e incrementara su contador de vehículos en uno.
        public double MostrarTotalFacturado()
        {
            double retorno = 0;
            retorno=(this.MostrarTotalFacturado(TipoVehiculo.Auto) + this.MostrarTotalFacturado(TipoVehiculo.Moto));
            return retorno;
        }
        public double MostrarTotalFacturado(TipoVehiculo tipo)
        {
            double result = 0;
            switch (tipo)
            {
                case TipoVehiculo.Auto:
                    foreach(Vehiculo recorre in this.listaVehiculos)
                    {
                        if(recorre is Auto)
                        {
                            result+=this.precioAuto;
                        }
                    }
                    break;
                case TipoVehiculo.Moto:
                    foreach (Vehiculo recorre in this.listaVehiculos)
                    {
                        if (recorre is Moto)
                        {
                            result += this.precioMoto;
                        }

                    }
                    break;
                          
            }
            return result;
        }
        //El método IngresarAlLavadero (que recibe como único parámetro un Vehiculo), agregará a la lista
        //dicho objeto e incrementara su contador de vehículos en uno.
        public List<Vehiculo> IngresarAlLavadero(Vehiculo unVehiculo)
        {
            this.listaVehiculos.Add(unVehiculo);
            this.cantidadVehiculos++;
            return this.listaVehiculos;
        }
    }
}
