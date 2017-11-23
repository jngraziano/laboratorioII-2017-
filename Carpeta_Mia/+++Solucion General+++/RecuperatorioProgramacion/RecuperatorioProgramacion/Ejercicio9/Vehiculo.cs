using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Vehiculo
    {
        public double kmrecorridos;

        public Vehiculo(double recorridos)
        {
            this.kmrecorridos = recorridos;
        
        }

        public static explicit operator Double(Vehiculo unVehiculo)
        {
            return unVehiculo.kmrecorridos;
        
        }
    }
}
