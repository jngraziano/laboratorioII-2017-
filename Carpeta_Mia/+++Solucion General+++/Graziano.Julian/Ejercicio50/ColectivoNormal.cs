using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class ColectivoNormal:Colectivo
    {
         
            
            

        public ColectivoNormal()
        {
            base._numeroDelinea = 112;
            base._numeroDeMovil = 123123;
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
                if (unPasajero.TipoDePasajero != eTipoPasajero.PasajeroConDiscapacidadMotriz)
                {
                    Console.WriteLine("\nSe subio el pasajero");
                    base._listaPasajeros.Add(unPasajero);

                    
                }
                else
                {
                    throw new Exception("\nNo se puede ya que es discapacitado.");                
                }

            }
            catch (Exception e)
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
            if (unPasajero.TipoDePasajero != eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                Console.WriteLine("\nDesciende Pasajero");


            }
            else
            { Console.WriteLine("\nNunca se subio el pasajero."); }
        
        
        }

        
    }
}
