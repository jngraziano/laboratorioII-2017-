using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Computadora
    {
        private bool _estaEncendida;
        private EMarca _marca;
        private float _peso;
        private EProcesador _procesador;

        public bool getEstaEncendida()
        { 
           return this._estaEncendida;
        
        }

        public EMarca getMarca()
        { 
            return this._marca;
        
        }

        public float getPeso()
        { 
            return this._peso;
        
        }

        public EProcesador getProcesador()
        { 
            return this._procesador;
        
        }

        public void setEstaEncendida(bool encender)
        {
            this._estaEncendida = encender;
            
        }

        public void setMarca(EMarca marca)
        {
            this._marca = marca;
        
        }

        public void setPeso(float peso)
        {
            this._peso = peso;
        }

        public void setProcesador(EProcesador procesador)
        {
            this._procesador = procesador;
        
        }

        //FUNCIONES
        public void InformarEstado()
        {
            Console.Clear();
            Console.WriteLine("INFORME TOTAL");
            Console.WriteLine("\n\nMarca: {0}\nProcesador: {1}\nEsta encendida?: {2}\nPeso: {3}", this._marca, this._procesador, this._estaEncendida, this._peso);
            Console.ReadKey();
        }
        public void Encender()
        {
            Console.Clear();
            Console.WriteLine("ENCENDER");
            Console.WriteLine("\n\nEstado actual: {0}", this._estaEncendida);
            if (this._estaEncendida == false)
            {
                this._estaEncendida = true;
                Console.WriteLine("Se prendio el equipo.");

            }
            else
            {
                Console.WriteLine("La PC ya se encuentra encendida");
            
            }
        
        }
        public void Apagar()
        {
            Console.Clear();
            Console.WriteLine("APAGAR");
            Console.WriteLine("\n\nEstado actual: {0}", this._estaEncendida);
            if (this._estaEncendida == true)
            {
                this._estaEncendida = false;
                Console.WriteLine("\nSe apago el equipo.");
                Console.WriteLine("\nEstado: {0}", this._estaEncendida);

            }
            else
            {
                Console.WriteLine("La PC ya se encuentra Apagada");
                Console.WriteLine("\nEstado: {0}", this._estaEncendida);

            }

        }

    }
}
