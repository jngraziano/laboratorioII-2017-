using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Vuelo
    {
        private DateTime _fecha;
        private string _empresa;
        private decimal _precio;
        private List<Pasajero> _listaDePasajeros;
        private int _cantMax;

        public int _CantMax { get { return this._cantMax; } }
        public string InfoVuelo { 
            get {
                
                return this._fecha.ToString() + this._empresa + this._precio.ToString() + this._CantMax;
                
            } 
       }
        public int cantidadpasajeros { get { 
            int cantidadpasajeros = 0;
        foreach (Pasajero recorre in this._listaDePasajeros)
        {
            cantidadpasajeros++;
        
        }
        return cantidadpasajeros;
        
        } }

        public Vuelo(DateTime fecha, string empresa, decimal precio, int cantidadmax)
        {
            this._empresa = empresa;
            this._fecha = fecha;
            this._precio = precio;
            this._cantMax = cantidadmax;
            
        
        }
        public Vuelo(DateTime fecha, decimal precio, string empresa)
        {
            
            List<Pasajero> list = new List<Pasajero>();
            this._listaDePasajeros = list;
            
           
                    
        }
        public bool agregarPasajero(Pasajero pas1)
        {
            bool rta = true;
            foreach (Pasajero recorre in this._listaDePasajeros)
            {
                if (recorre == pas1)
                {
                    Console.WriteLine("Ya se encuentra el pasajero");
                    rta=false;

                }
                else
                { 
                    
                    if (this.cantidadpasajeros < this._CantMax)
                    {
                        this._listaDePasajeros.Add(pas1);
                        rta = true; ;
                    }
                    else
                    { Console.WriteLine("No hay capacidad");
                        rta= false;
                    }
                    

                }
            
            }
            return rta;
        
        }


        public void MostrarVuelo()
        {
            Console.WriteLine(this.InfoVuelo);
        
        }

         public decimal costovuelo (Vuelo unVuelo)
        {
            decimal result=0;
           foreach (Pasajero recorre in unVuelo._listaDePasajeros)
            {
                if( recorre.esPlus == true)
                {
                    result += unVuelo._precio * (20 * unVuelo._precio / 100);
                }
                else
                { 
                    result+=unVuelo._precio;
                }
            
            }
             return result;
         }
        public static decimal operator +(Vuelo unVuelo, Vuelo dosVuelo)
        {
            decimal result=0;
           foreach (Pasajero recorre in unVuelo._listaDePasajeros)
            {
                if( recorre.esPlus == true)
                {
                    result += unVuelo._precio * (20 * unVuelo._precio / 100);
                }
                else
                { 
                    result+=unVuelo._precio;
                }
            
            }

            foreach (Pasajero recorre in dosVuelo._listaDePasajeros)
            {
                if (recorre.esPlus == true)
                {
                    result += dosVuelo._precio * (20 * dosVuelo._precio / 100);
                }
                else
                {
                    result += dosVuelo._precio;
                }

            }
            return result;

        }

        public static implicit operator decimal(Vuelo unVuelo)
        {
            return unVuelo.costovuelo(unVuelo);
                                           
        }


    }
}
