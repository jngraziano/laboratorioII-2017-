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

       #region Propiedad Abstracta

       //CREO PROPIEDAD ABSTRACTA DE SOLO LECTURA
       public abstract String TiempoDeUso
       {
           get;
       }

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

       #region Polimorfismo ToString

       //SOBRESCRIBO EL MÉTODO TOSTRING(), 
       //HEREDADO DE OBJECT
       public override string ToString()
       {
           System.Text.StringBuilder sb = new StringBuilder();

           sb.AppendLine("En la clase Transporte...");
           sb.Append("Cantidad de pasajeros: ");
           sb.AppendLine(this._cantidadPasajeros.ToString());
           sb.Append("Velocidad Máxima: ");
           sb.AppendLine(((Int32)this._velocidadMaxima).ToString());

           return sb.ToString();
       }

       #endregion 
   }
}
