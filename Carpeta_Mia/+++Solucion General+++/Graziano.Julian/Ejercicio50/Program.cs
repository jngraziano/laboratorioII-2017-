using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar al menos 2 pasajeros por cada uno de los tipos de
            //colectivos posibles (Método SacarBoleto). Solicitar bajada de
            //pasajero al menos una vez (SolicitarBajada). Llamar al Método
            //ToString de los dos colectivos.
            ColectivoNormal unColectivoNormal = new ColectivoNormal();
            ColectivoPreparadoDiscapacitados unColectivoPreparadoDiscapacitados = new ColectivoPreparadoDiscapacitados();

            Pasajero unPasajero = new Pasajero(eTipoPasajero.PasajeroConDiscapacidadMotriz);
            Pasajero dosPasajero = new Pasajero(eTipoPasajero.PasajeroNormal);
            Pasajero tresPasajero = new Pasajero(eTipoPasajero.PasajeroEscolar);
            Pasajero cuatroPasajero= new Pasajero(eTipoPasajero.XXXXLLM);

            Console.WriteLine("COLECTIVO NORMAL");
            Console.WriteLine("\nPasajero uno (discapacitado)");
            unColectivoNormal.SacarBoleto(unPasajero);
            unColectivoNormal.SolicitanBajar(unPasajero);
            Console.ReadKey();
            Console.WriteLine("\nPasajero dos (normal)");
            unColectivoNormal.SacarBoleto(dosPasajero);
            unColectivoNormal.SolicitanBajar(dosPasajero);

            Console.WriteLine(unColectivoNormal.ToString());
            Console.ReadKey();
            

           
            Console.WriteLine("\nCOLECTIVO ESPECIAL");
            Console.WriteLine("\nPasajero uno (discapacitado)");
            unColectivoPreparadoDiscapacitados.SacarBoleto(unPasajero);
            unColectivoPreparadoDiscapacitados.SolicitanBajar(unPasajero);
            Console.ReadKey();
            Console.WriteLine("\nPasajero dos (normal)");
            unColectivoPreparadoDiscapacitados.SacarBoleto(dosPasajero);
            unColectivoPreparadoDiscapacitados.SolicitanBajar(dosPasajero);

            Console.WriteLine(unColectivoPreparadoDiscapacitados.ToString());
            Console.ReadKey();

                      

        }
    }
}
