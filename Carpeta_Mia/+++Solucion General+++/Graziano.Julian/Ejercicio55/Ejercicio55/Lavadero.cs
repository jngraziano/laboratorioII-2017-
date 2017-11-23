using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    class Lavadero
    {
        public List<Vehiculo> listaVehiculos;
        public int cantidadVehiculos;
        public float PrecioAuto;
        public float PrecioMoto;

        public Lavadero(float preciotutu, float preciomoto)
        {
            this.PrecioAuto = preciotutu;
            this.PrecioMoto = preciomoto;
            List<Vehiculo> list = new List<Vehiculo>();
            this.listaVehiculos = list;
        
        }
        //Los métodos que tendrá Lavadero son:
        //MostrarTotalFacturado: devolverá la ganancia del lavadero (Double), dicho método tendrá una
        //sobrecarga que reciba como parámetro la enumeración Vehiculos (con Auto y Moto como
        //enumerados) y retornará la ganancia del Lavadero por tipo de vehículo.
       
        public double MostrarTotalFacturado()
        {
            double acum = 0;
            acum+=MostrarTotalFacturado(Vehiculos.Auto)+MostrarTotalFacturado(Vehiculos.Moto);
            return acum;
        
        }
        public double MostrarTotalFacturado(Vehiculos tipo)
        {
            double acum = 0;

            switch(tipo)
            {
                case Vehiculos.Auto:
                 foreach(Vehiculo recorre in this.listaVehiculos)
                 {
                     if(recorre is Auto)
                     {acum+=this.PrecioAuto;}
                 
                 }
                    break;
                case Vehiculos.Moto:
                    foreach(Vehiculo recorre in this.listaVehiculos)
                    {
                        if(recorre is Moto)
                        {
                            acum+=this.PrecioMoto;
                        
                        }
                    
                    }
                    break;
                default:;
                    break;             
            
            }
            return acum;
        }

        public List<Vehiculo> IngresarAlLavadero(Vehiculo unVehiculo)
        {
            this.listaVehiculos.Add(unVehiculo);
            this.cantidadVehiculos++;

            return this.listaVehiculos;
        
        }
            //El método IngresarAlLavadero (que recibe como único parámetro un Vehiculo), agregará a la lista
            //dicho objeto e incrementara su contador de vehículos en uno.
    
    }

}
