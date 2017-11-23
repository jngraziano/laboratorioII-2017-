using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Segundo_Parcial
{
    class Lavadero
    {
        public List<Vehiculo> vehiculos;
        public int cantidadVehiculos;
        public float precioAuto;
        public float precioMoto;


        public Lavadero(float precioAuto, float precioMoto)
        {
            vehiculos = new List<Vehiculo>();

            this.cantidadVehiculos = 0;
            this.precioAuto = precioAuto;
            this.precioMoto = precioMoto;
        
        }

        public double MostrarTotalFacturado(Vehiculos a)
        {
            double acum = 0d;

            if (a == Vehiculos.Auto)
            {
                foreach (Vehiculo item in vehiculos)
                {
                    if (item is Auto)
                    {
                        acum += this.precioAuto;
                    }
                }

                return acum;
            }

            if (a == Vehiculos.Moto)
            {
                foreach (Vehiculo item in vehiculos)
                {
                    if (item is Moto)
                    {
                        acum += this.precioMoto;
                    }
                }

                return acum;
            }
            
            return acum;
    
        }

        public double MostrarTotalFacturado()
        {
            double acum = 0d;
            
            
            foreach (Vehiculo item in vehiculos)
            {
                if (item is Auto)
                {
                    acum += this.precioAuto;
                }

                if (item is Moto)
                {
                    acum += this.precioMoto;
                }
            }


            return acum;
        }

        public List<Vehiculo> IngresarAlLavadero(Vehiculo vehiculoQueIngresa)
        {
            this.vehiculos.Add(vehiculoQueIngresa);
            this.cantidadVehiculos++;

            return this.vehiculos;
        }
        
    
    
    
    }
}
