using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces._2015
{
    class Program
    {
        static void Main(string[] args)
        {
            T800 terminator = new T800();
            R2D2 arturito = new R2D2();
            Industrial brazo = new Industrial();

            terminator.Caminar();
            terminator.Disparar();

            arturito.Caminar();
            arturito.Disparar(); //??

            brazo.Caminar();//??
            brazo.Disparar();//??

            Console.ReadLine();
        }
    }

    #region Problema
    
    //El problema es: MANTENIMIIENTO, crear un programa es solo la primera parte, la segunda parte es mantener ese programa 
    //en el tiempo, hacerle mejoras, evolucionarlo etc. 
    
    #region Solucion

    //SOLUCION:
    //Lo primero que a uno se le viene a la mente para resolver el tema de los Robot que no Disparan o que no Caminan 
    //es utilizar INTERFACES, lo cual suele ser una muy buena idea, sobre todo teniendo en cuenta este principio de diseño.
    //REGLA: Programe contra una interfaz no contra implementaciones concretas.
    //En este sentido hay que ser claro que este principio hace referencia a interfaces desde el punto de vista del diseño de software 
    //no de ningún lenguaje en particular y en este sentido entonces una interfaz puede ser en esencia un Súper Tipo.
  
    #endregion 

    #endregion
}
