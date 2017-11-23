using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Empleado : SerHumano
    {
        protected float _sueldo;


        public float Trabajar()
        {
            //claramente lo use para dar el sueldo.
            this._sueldo = base._cargaHoraria * 10;
            return this._sueldo;
        }

        public void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("Empleado:\n");
            Console.WriteLine("Nombre: {0}\nPeso: {1}\nAltura: {2}\nSexo: {3}\nCarga Horaria: {4}", base.nombre, base.peso, base.altura, base.sexo, base.cargaHoraria);
            Console.ReadKey();


        }


    }
}
