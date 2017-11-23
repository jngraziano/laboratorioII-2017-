using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahorcado.Palabras;

namespace Ahorcado.Palabras
{
    public class Palabra
    {
        private char _caracterLetraOculta;
        private List<Letra> _letrasDeLaPalabra;

        private int _cantidadLetrasVisibles
        {
            get
            {
                int aux=0 ;
                foreach (Letra let in this._letrasDeLaPalabra)
                {
                    if(let.EstaVisible) {  aux ++ ;}
                }

                return aux;
            }
        }
        ///// <summary>
        ///// Retorna true si la cantidad de letras de la Palabra es igual
        ///// a la cantidad de letras visibles
        ///// </summary>
        public bool PalabraDescubierta
        {
            get 
            {
                if (this._letrasDeLaPalabra.Count == this._cantidadLetrasVisibles) { return true; }
                else { return false; }
            
            }
        }
        /// <summary>
        /// Dentro de este constructor NO SE DEBE inicializar el atributo _letrasDeLaPalabra.
        /// Deberá agregar las Letras de acuerdo a la palabra con la que se
        //jugará. Tener en cuenta que en un principio, todas las letras NO DEBEN
        //    estar visibles, a excepción de los espacios, que sí deben poder
        //    visualizarse por defecto
        /// </summary>
        /// <param name="palabra">Representa la Palabra que se utilizará para jugar</param>
        /// <param name="caracterLetraOculta">Representa el caracter que se  mostrará para las letras que no fueron descubiertas
        /// </param>

        public Palabra(string palabra, char caracterLetraOculta)
            : this()
        {
            this._caracterLetraOculta = caracterLetraOculta;  
            //agregar la letra y setear si esta visible o no segun la letra
            for (int i = 0; i < palabra.Length; i++)
            {
                char letraAEvaluar;

                letraAEvaluar = char.Parse(palabra.Substring(i, 1));
                Letra letraPalabra = new Letra(letraAEvaluar, false);

                this._letrasDeLaPalabra.Add(letraPalabra);
            }
        } //hasta aca viene bien


        /// <summary>
        /// Este constructor es el único que inicializa el atributo _letrasDeLaPalabra
        /// </summary>
        private Palabra()
        {
            List<Letra> auxObjLetra = new List<Letra>();
            this._letrasDeLaPalabra = auxObjLetra;
        }
        /// <summary>
        /// Retorna una cadena de caracteres con la palabra correcta
        /// </summary>
        public string PalabraCorrecta
        {
            get 
            {
                string respuesta= "";
                foreach (Letra let in this._letrasDeLaPalabra) 
                {
                    respuesta += let.caracter;
                }
                return respuesta;
            }

        }
        ///// <summary>
        ///// Retorna una cadena de caracteres con la palabra descubierta hasta el momento, los caracteres que no fueron
        ///// descubiertos se mostrarán con el valor del atributo _caracterLetraOculta, además deberá haber un espacio
        ///// entre cada letra.
        ///// Se deberá tener en cuenta si cada Letra está visible o no.
        ///// </summary>
        public string PalabraDescubiertaHastaElMomento
        {
            get 
            {

                string aux = " ";

                foreach (Letra let in this._letrasDeLaPalabra)
                {
                    if (let.EstaVisible == true)
                    {
                        aux += let.caracter + " ";

                    }
                    else
                    {
                        aux += this._caracterLetraOculta + " ";
                    }
                }


                return aux;//cadena con palabra descubierta hasta el momento
            }
           
        }
        ///// <summary>
        ///// Recorre la lista de Letras, si existe el caracter que se recibe parámetros, deberá habilitar
        ///// la letra (ponerla visible), para TODAS las coincidencias.
        ///// Si se encuentra por lo menos 1 coincidencia, retornará verdadero.
        ///// </summary>
        ///// <param name="letraADescubrir"></param>
        ///// <returns></returns>
        public bool DescubrirLetra(char letraADescubrir)
        {
            int cont = 0;
            bool aux = true;
            foreach (Letra recorro in this._letrasDeLaPalabra)
            {
                if (recorro.caracter == letraADescubrir)
                {   
                    
                    recorro.EstaVisible = true;
                    cont++;
                }

            }

            if (cont > 0) { aux = true; }
            else { aux = false; }

            return aux;

        }
    }
}
