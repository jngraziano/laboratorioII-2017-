using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instancia por Clase
            Auto auto = new Auto(eVelocidad.media,"20:15",4,"ECV-349");
            Bicicleta bicicleta = new Bicicleta(eVelocidad.minima,"15:33",20);
            Caballo caballo = new Caballo(eVelocidad.baja,"3:50","Rojizo","PuraSangre");
            Cohete cohete = new Cohete(eVelocidad.super,"0:25","Lunar",1);
            //Transporte transporte = new Transporte(eVelocidad.super,"33:50");
            #endregion
            #region EXPLICACION PROPIA
            /*VIRTUAL Y OVERRIDE SON MODIFICADORES DE COMPORTAMIENTO
            CUALQUIER METODO QUE ESTE INDICADO COMO VIRTUAL VA A SER POSIBLE MODIFICARLO 
            SOLAMENTE EN HERENCIA. POR LO GENERAL EL POLIFORMISMO SE USA SOLO EN HERENCIA.
            EL POLIMORFISMO ES EN TIEMPO DE EJECUCION
             * -------------------------------------
             el .ToString() es un virtual proveniente de la base OBJECT el cual se puede modificar tambien.
             * VIRTUAL VA EN LA CLASE BASE
             * OVERRIDE VA EN LAS HEREDADAS
             * -------------------------------------
            VIRTUAL(CONCEPTUALMENTE EXPLICADO): 
             * Parcial -> base (AGREGO LO QUE PONGO EN EL METODO MOSTRAR DE LAS CLASES a EL MOSTAR de METODO DE BASE)
             * (muestro las dos cosas)
             * Total -> sin base
             * sin modificar -> sin override
             * -------------------------------------
             EN EL EJEMPLO MODIFICAMOS EL METODO .TOSTRING. 
             * DECLARO EN LAS CLASES EL METODO .TOSTRING y TE LA REALIZA SOLA, SOLO QUE MODIFICO LO QUE RETORNA
             * PARA QUE VAYA AL METODO MOSTRAR DE LA MISMA CLASE Y NO ME MUESTRE "namespace Clase9.Bicicleta"
             */
            #endregion

            List<Transporte> lista = new List<Transporte>();
            lista.Add(auto);
            lista.Add(bicicleta);
            lista.Add(caballo);
            lista.Add(cohete);

            foreach (Transporte t in lista)
            { /*
                 * EL WRITELINE POR DEFAULT SIEMPRE VA AL METODO .TOSTRING
              * POR ENDE ES MAS FACIL MOSTRAR AHORA PORQUE LLAMAMOS SOLO AL OBJETO SIN LLAMAR AL METODO "MOSTRAR" ESPECIFICO
                 * (CLARAMENTE MUESTA BIEN EL TOSTRING PORQUE LO MODIFICAMOS)
                */
                Console.WriteLine(t);
                Console.Clear();
                //USO EL METODO FRENAR.
                t.Frenar();
               
            
            }
            Console.ReadKey();
            
        }
    }
}
