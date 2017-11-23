using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
   public abstract class Transporte
   {
       #region Atributos
       
       protected byte _cantidadPasajeros;
       protected Velocidades _velocidadMaxima;
       
       #endregion

       #region Constructor

       public Transporte(byte pasajeros, Velocidades velocidadMaxima)
       {
           this._cantidadPasajeros = pasajeros;
           this._velocidadMaxima = velocidadMaxima;
       }

       #endregion

       #region Métodos

       public virtual void Avanzar()
       {
           Console.Write("Está avanzando ");
       }
       
       public abstract void Frenar();

       #endregion

   }
}
