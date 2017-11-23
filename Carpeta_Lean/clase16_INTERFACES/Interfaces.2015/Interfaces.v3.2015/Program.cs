using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    #region Oculto y comentado

    //class DispararConBombaAtomica : IDisparableComportamiento
    //{
    //    public void Disparar()
    //    {
    //        Console.WriteLine("Destrucción total....sobreviventes: 0");
    //    }
    //}
    //class NoCaminaVuela : ICaminableComportamiento
    //{
    //    public void Caminar()
    //    {
    //        Console.WriteLine("No camina....vuela!!!");
    //    }
    //}

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            T800 terminator = new T800();
            R2D2 arturito = new R2D2();
            Industrial brazo = new Industrial();
            T1000 newTerminator = new T1000();

            terminator.Caminar();
            terminator.Disparar();

            arturito.Caminar();
            arturito.Disparar();

            brazo.Caminar();
            brazo.Disparar();

            newTerminator.Caminar();
            newTerminator.Disparar();

            Console.ReadLine();

            #region Oculto y comentado

            //arturito.IDisparador = new DispararConTodo();
            //arturito.Disparar();

            //brazo.ICaminable = new CaminarSobreRodillos();
            //brazo.IDisparador = new DispararNormal();

            //brazo.Caminar();
            //brazo.Disparar();

            //Console.ReadLine();

            #region mas oculto y comentado

            //arturito.ICaminable = new NoCaminaVuela();
            //arturito.Caminar();
            //arturito.IDisparador = new DispararConBombaAtomica();
            //arturito.Disparar();

            //Console.ReadLine();

            #region mas mas oculto y comentado

            //En este último ejemplo hemos utilizado la clase R2D2 pero observemos atentamente ¿Qué pasa si en lugar de usar este Robot 
            //hacemos uso de la clase base Robot?
            //Para ello solo debemos quitarle la marca abstract que fue puesta allí para nuestra propuesta de solución inicial.
            //El resultado: se hace exactamente igual, es decir ¡YA NO NECESITAMOS USAR HERENCIA!

            //Robot enolaGay = new Robot();
            
            //enolaGay.ICaminable = new NoCaminaVuela();
            //enolaGay.IDisparador = new DispararConBombaAtomica();

            //enolaGay.Caminar();
            //enolaGay.Disparar();

            //Console.ReadLine();

            #endregion

            #endregion

            #endregion

        }
    }
}
