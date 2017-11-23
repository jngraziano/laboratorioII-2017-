using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class ColectivoPreparadoDiscapacitados:Colectivo
    {
        private bool _lugarDiscapacitadoDisponible;


        public ColectivoPreparadoDiscapacitados()
        { this._lugarDiscapacitadoDisponible = true;
        base._numeroDelinea = 112;
        base._numeroDeMovil = 32233;
        
        }

        public override void SacarBoleto(Pasajero unPasajero)
        {
            //El método SacarBoleto agregara a la lista de pasajero
            //(_listPasajeros ya inicializada) el Pasajero enviado como
            //parámetro en caso de que el colectivo sea Normal y el pasajero
            //sea discapacitado motriz deberá lanzar una excepción, indicando
            //que no se puede, en caso que el colectivo lo acepte deberá
            //deshabilitar LugarDiscapacitadosDisponible.
            try
            {
                if (unPasajero.TipoDePasajero == eTipoPasajero.PasajeroConDiscapacidadMotriz && this._lugarDiscapacitadoDisponible == true)
                {
                    Console.WriteLine("\nSe subio el pasajero");
                    base._listaPasajeros.Add(unPasajero);
                    this._lugarDiscapacitadoDisponible = false;
                }
                else if (unPasajero.TipoDePasajero != eTipoPasajero.PasajeroConDiscapacidadMotriz)
                {
                    base._listaPasajeros.Add(unPasajero);

                }
                else
                {
                    throw new Exception("\nNo puede subir. O no hay lugar o es discapacitado");
                
                }
            }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                        

        }
        public override void SolicitanBajar(Pasajero unPasajero)
        {
            //El método SolicitarBajada en caso que el pasajero sea
            //discapacitado motriz deberá mostrar por pantalla ―bajar rampa
            //discapacitados y desciende pasajero‖ y deberá habilitar
            //LugarDiscapacitadosDisponible, en caso contrario ―desciende
            //pasajero‖.

            if (unPasajero.TipoDePasajero == eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                Console.WriteLine("\nBAJAR RAMPA DISCAPACITADOS. Desciende el pasajero");
                this._lugarDiscapacitadoDisponible = true;


            }
            else
            { Console.WriteLine("\nDesciende Pasajero"); }

        
        }

        public override string ToString()
        {
            base.ToString();
            StringBuilder sw = new StringBuilder();
            sw.Append("\nLugar de Discapacitados Disponible: ");
            sw.AppendLine(this._lugarDiscapacitadoDisponible.ToString());

            return sw.ToString();
            
        }
    }
}
