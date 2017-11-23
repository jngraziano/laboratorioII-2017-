using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio42
{
    class ClientePlus:Cliente,IMostrar
    {
        private int _puntos;

        public int Puntos { get { return this._puntos; } set { this._puntos = value; } }

        public ClientePlus(string Apellido, int CuentaBancaria, string cuit, int edad, string nombre, int puntos)
            : base(cuit, CuentaBancaria)
        {
            this.Apellido = Apellido;
            this.Edad = edad;
            this.Nombre = nombre;
            this.Puntos = puntos;
        
        }

        public override void GuardarEnDisco(Cliente unCliente)
        {

            StreamWriter sw = new StreamWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio42\ClientePlus.txt");
            sw.WriteLine(unCliente.Apellido);
            sw.WriteLine(unCliente.CuentaBancaria);
            sw.WriteLine(unCliente.Cuit);
            sw.WriteLine(unCliente.Edad);
            sw.WriteLine(unCliente.Nombre);
            sw.WriteLine(this.Puntos);

            sw.Close();
        }

        public void Mostrar()
        {
            Console.WriteLine("\nCliente Plus:\n");
            Console.WriteLine("\nNombre: {0}\nApellido: {1}\nEdad: {2}\nPuntos: {3}\n", this.Nombre, this.Apellido, this.Edad, this.Puntos);
        
        }
        

    }
}
