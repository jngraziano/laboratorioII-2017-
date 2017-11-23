using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos_y_Constructores_2011
{
    class Auto
    {
        #region Atributos de Instancia

        public int cantidadPuertas;
        public int cantidadRuedas;
        public string color;
        public string marca;

        #endregion

        #region Atributos de Clase

        public static int cantVecesInstanciada;
        public static DateTime fechaUtilizacion;

        #endregion

        #region Métodos

        #region Métodos de Instancia
        
        public string Mostrar() {

            string datosAuto = "";

            datosAuto = "Cantidad de puertas: " + this.cantidadPuertas.ToString();
            datosAuto += "\nCantidad de ruedas: " + this.cantidadRuedas.ToString();
            datosAuto += "\nColor: " + this.color;
            datosAuto += "\nMarca: " + this.marca;
            
            return datosAuto;
        }
        
        #endregion
        
        #region Métodos de Clase
        
        public static string Mostrar(Auto miAutito)
        {
            return miAutito.Mostrar();
        }

        #endregion

        #endregion

        #region Constructores
        //CONSTRUCTOR POR DEFECTO (SIN PARAMETROS)
        //public Auto()
        //{
        //    this.cantidadPuertas = 5;
        //    this.cantidadRuedas = 4;
        //    this.color = "SIN COLOR";
        //    this.marca = "SIN MARCA";
        //}

        #region Con Parámetros

        //public Auto(string marca, string color, int puertas)
        //{
        //    //AGREGO A LOS ATRIBUTOS LOS VALORES DE LOS PARAMETROS
        //    this.marca = marca;
        //    this.color = color;
        //    this.cantidadPuertas = puertas;

        //    //AGREGO VALOR POR DEFECTO (DISTINTO DEL ORIGINAL)
        //    this.cantidadRuedas = 4;

        //}

        #endregion

        #region De Clase

        //static Auto()
        //{
        //    cantVecesInstanciada = 0;
        //    fechaUtilizacion = DateTime.Now;
        //}

        #endregion

        #endregion

     }
}
