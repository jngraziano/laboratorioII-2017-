using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploDeEnumerados
{
    class Program

    {
        static void Main(string[] args)
        {
            Color UnColor;
            String NombreDeColor;
            int Cantidad;
            int NumeroDeColor;
            Bicicleta mibicicleta = new Bicicleta("Felipe");



            #region Recorrer un Enumerado


            /// recorrer un enumerado con ForEach
            ///**********************************
            ///**********************************


            /// sacar los nombres de los items del enumerado con el metodo 
            /// estatico "GetNames" de la clase "Enum"
            foreach (String NombresDelEnumerado in Enum.GetNames(typeof(Color)))
            {
                Console.WriteLine(NombresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum"
            foreach (Color ValoresDelEnumerado in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine(ValoresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum" , luego de
            /// extraerlos los casteo a enterro para obtener su valor numerico 
            foreach (Color ValoresDelEnumerado in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine((int)ValoresDelEnumerado);
            }




            /// recorrer un enumerado con For
            ///******************************
            ///******************************

            Cantidad = Enum.GetValues(typeof(Color)).GetLength(0);

            // esto solo se puede hacer si el enumerado  comienza 
            // en 0 e incrementa de una unidad sus valores
            for (int i = 0; i < Cantidad; i++)
            {
                UnColor = (Color)i;

                Console.WriteLine((int)UnColor);
            }





            #endregion


            #region Asignacion de valores


            ///DESDE UN "STRING"
            ///*****************
            ///Asignacion de valores a un enumerado
            ///desde un  "STRING", con el metodo estatico "Parse" de la clase "Enum" y 
            ///luego aplicando el casteo explicito.
            ///Recordar que debemos manejar los posibles errores de casteo que ocurran
            ///try - Catch

            NombreDeColor = "rojo";
            UnColor = (Color)Enum.Parse(typeof(Color), NombreDeColor, true);
            NombreDeColor = "verde";
            UnColor = (Color)Enum.Parse(typeof(Color), NombreDeColor, true);

            NombreDeColor = "amardfasdfasf";
            UnColor = (Color)Enum.Parse(typeof(Color), NombreDeColor, true);


            ///DESDE UN "INTEGER"
            ///*****************
            ///Asignacion de valores a un enumerado
            ///desde un  "INTEGER", el casteo explicito  "(Color)"
            ///Recordar que debemos manejar losposibles errores de casteo que ocurran
            ///try - Catch

            NumeroDeColor = 3;
            UnColor = (Color)NumeroDeColor;

            NumeroDeColor = 0;
            UnColor = (Color)NumeroDeColor;


            NumeroDeColor = 100;
            UnColor = (Color)NumeroDeColor;






            #endregion


            #region Utilizacion del Switch

            ///facilita el uso de todas sus items en una estrutura "swicht",
            ///colocando dentro del parametro un objeto de tipo enumerado y 
            ///generando los casos automaticamente gracias a su codeSnippet


            switch (UnColor)
            {
                case Color.Rojo:
                    break;
                case Color.Azul:
                    break;
                case Color.Verde:
                    break;
                case Color.Negro:
                    break;
                default:
                    break;
            }



            #endregion


            #region Recorrer enumarado de Dias

            /// sacar los nombres de los items del enumerado con el metodo 
            /// estatico "GetNames" de la clase "Enum"
            foreach (String NombresDelEnumerado in Enum.GetNames(typeof(DiaDeLaSemana)))
            {
                Console.WriteLine(NombresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum"
            foreach (DiaDeLaSemana ValoresDelEnumerado in Enum.GetValues(typeof(DiaDeLaSemana)))
            {
                Console.WriteLine(ValoresDelEnumerado);
            }

            /// sacar  los items del enumerado con el metodo 
            /// estatico "GetValues" de la clase "Enum" , luego de
            /// extraerlos los casteo a enterro para obtener su valor numerico 
            foreach (DiaDeLaSemana ValoresDelEnumerado in Enum.GetValues(typeof(DiaDeLaSemana)))
            {
                Console.WriteLine((int)ValoresDelEnumerado);
            }

            #endregion


            #region Pasaje de Datos
  

            /// PASEJE DE DATOS
            /// 
            /// Valores literales:
            
            Bicicleta bicicletaUno = new Bicicleta("Camila", Color.Rojo);

            /// con una variable del tipo enumerado
            Bicicleta bicicletaDos = new Bicicleta("victoria", UnColor);
            
            /// parseando un string
            Bicicleta bicicletaTres = new Bicicleta("Agustina", (Color)Enum.Parse(typeof (Color),"azul",true));
            
            /// casteando un entero 
            Bicicleta bicicletaCuatro = new Bicicleta("Carmen", (Color)1);

           
           
            #endregion


            #region Posibles errores en tiempo de compilación 
            
            ///MAL

            //Bicicleta bicicletaCuatro1 = new Bicicleta("Carmen",(Color)"AZul");


            //Bicicleta bicicletaTres1 = new Bicicleta("Agustina",(Color) Enum.Parse(Color, "azul", true));


            //Bicicleta bicicletaTres2 = new Bicicleta("Agustina", (Color)Enum.Parse(typeof( Color), "azul", true));

            //foreach (Color ValoresDelEnumerado in Enum.GetValues(Color))
            //{
            //    Console.WriteLine((int)ValoresDelEnumerado);
            //}
            
            
            #endregion
            
        }

    }
}
