using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
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
            //arturito.Disparar();

            //brazo.Caminar();
            //brazo.Disparar();

            Console.ReadLine();
        }
    }

    #region Problema

    //La complejidad... preocupante, pero más preocupante aún es el hecho que tenemos código redundante ya que, aunque varios 
    //robots disparen de la misma forma, cada uno tiene su propia implementación.
    //Así que estamos usando uno de los principios de diseño de software pero algo anda mal.   

    #region Solucion

    //SOLUCION:
    //Encapsulamiento!!!
    //Identificar los aspectos que cambian, y sepáralos de los que se mantienen iguales.
    //Eso precisamente se hace en POO haciendo uso de encapsulamiento, cosa que los cambios en este objeto no afecten el resto 
    //del código de la implementación.
    //Encapsular, en este caso implica necesariamente crear un objeto nuevo por cada funcionalidad que cambia, 
    //las funcionalidades que cambian en nuestros Robot son Caminar y Disparar
    //Estas funcionalidades que cambian las llamaremos COMPORTAMIENTOS (behaviors en inglés). 
    //Cada acción (caminar, disparar), tienen una serie de comportamientos posibles aunque exhiben la misma interfaz, 
    //es decir los mismos métodos con los mismos tipos de datos, así que podemos pensar en generalizar dicha interfaz, 
    //de tal forma que podamos crear diferentes comportamientos...

    #endregion

    #endregion
}
