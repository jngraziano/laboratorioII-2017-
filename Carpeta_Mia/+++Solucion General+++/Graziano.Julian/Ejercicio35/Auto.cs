using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Auto
    {
        private string _color;
        private double _precio;
        private EMarcas _marca;
        private DateTime _fecha=new DateTime();

        public Auto(EMarcas marca, string color)
        {
            this._marca = marca;
            this._color = color;
        }
        public Auto(EMarcas marca, string color, double precio)
        {
            this._marca = marca;
            this._color = color;
            this._precio = precio;
            
        
        }
        public Auto(EMarcas marca, string color, double precio, DateTime fecha)
        {
            this._marca = marca;
            this._color = color;
            this._precio = precio;
            this._fecha = fecha;
        }
        public Auto(EMarcas marca, string color, DateTime fecha)
        {
            this._marca = marca;
            this._color = color;
            this._fecha = fecha;
        }
        public Auto(EMarcas marca,double precio)
        {
            this._marca = marca;
            this._precio = precio;
        }

        public void AgregarImpuestos(double valor)
        {
            this._precio = this._precio + valor;
        }

        public void MostrarAuto(Auto auto1)
        {
            Console.WriteLine("\nMarca: {0}\nColor: {1}\nPrecio: {2}\nFecha: {3}", auto1._marca, auto1._color, auto1._precio, auto1._fecha);
                /*private string _color;
        private double _precio;
        private EMarcas _marca;
        private DateTime _fecha;
                 * */
        }
        public static bool operator ==(Auto auto1, Auto auto2)
        {
            if (auto1._marca == auto2._marca)
            { return true; }
            else
            { return false; }
        
        }
        public static bool operator !=(Auto auto1, Auto auto2)
        { return !(auto1 == auto2); }
        
        
        public static double operator +(Auto auto1, Auto auto2)
        {
            if (auto1 == auto2 && auto1._color == auto2._color)
            {
                //Console.WriteLine("\nSon iguales en marca y color. Se realizó la suma");
                double importeDouble = auto1._precio + auto2._precio;
                return importeDouble;
            }
            else
            { //Console.WriteLine("\nNo son iguales en marca y color. No se pudo hacer la suma");
                return 0;
            }
        
        
        }
    }
}
