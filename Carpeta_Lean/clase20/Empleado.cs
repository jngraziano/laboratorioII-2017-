using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    //DECLARO UN DELEGADO
    public delegate void LimiteSueldoDel(Double sueldo, Empleado e);


    public enum TipoManejador
    {
        SobreAsignacionSueldo = 1,
        SalarioIncorrecto = 2,
        Ambos = 3
    }

    /// <summary>
    /// Clase que sera el 'emisor' del evento
    /// </summary>
    public class Empleado
    {
    //DECLARO UN EVENTO
    public event LimiteSueldoDel LimiteSueldo;

#region Atributos

    private String _nombre;
    private Double _sueldo;

#endregion

#region Propiedades

        public String Nombre 
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public Double Sueldo 
        {
            get { return this._sueldo; }
            set
            {
                //SI EL VALOR SUPERA AL PERMITIDO...
                if(value > 1000)
                {
                    //LANZO EL EVENTO
                    LimiteSueldo(value, this);
                }
                else
                {
                    this._sueldo = value;
                }

            }
        }
#endregion

    }
}
