using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria_Ahorcado
{
    public class Palabra
    {
        private char _caracterLetraOculta;
        private List<Letra> _letrasDeLaPalabra;



        /// <summary> 
        /// Retorna el número total de letras visibles que tiene la Palabra 
        /// </summary> 
        private int _cantidadLetrasVisibles
        {
            get {

                int control = 0;

                    foreach (Letra a in this._letrasDeLaPalabra)
                    {
                        if (a.EstaVisible == true)
                        {
                            control++;
                        }
                    }
                return control;
                }
        } 
    
        
        /// <summary> 
        ///Retorna true si la cantidad de letras de la Palabra es igual 
        ///a la cantidad de letras visibles 
        /// </summary> 
        public bool PalabraDescubierta 
        {
            get
            {
                if (this._cantidadLetrasVisibles == _letrasDeLaPalabra.Count)
                {
                    return true;
                }

                return false;
            }
        }   

        /// <summary> 
        ///Dentro de este constructor NO SE DEBE inicializar el atributo 
        ///_letrasDeLaPalabra. 
        ///Deberá agregar las Letras de acuerdo a la palabra con la que se 
        ///jugará. Tener en cuenta que en un principio, todas las letras NO DEBEN 
        ///estar visibles, a excepción de los espacios, que sídeben poder 
        ///visualizarse por defecto 
        /// </summary> 
        /// <param name="palabra">Representa la Palabra que se utilizará para 
        ///jugar</param> 
        /// <param name="caracterLetraOculta">Representa el caracter que se 
        ///mostrará para las letras que no fueron descubiertas</param> 
        public Palabra (string palabra, char caracterLetraOculta):this() 
        {
            this._caracterLetraOculta = caracterLetraOculta;

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra.Substring(i, 1) != " ")
                {
                    this._letrasDeLaPalabra.Add(new Letra(char.Parse(palabra.Substring(i, 1)), false));
                }
                else
                {
                    //this._letrasDeLaPalabra[i] = new Letra(char.Parse(palabra.Substring(i, 1)), true);     
                    this._letrasDeLaPalabra.Add(new Letra(char.Parse(" "), true));
                }
            
            }

        }

        /// <summary> 
        ///Este constructor es el único que inicializa el atributo 
        /// _letrasDeLaPalabra
        /// </summary> 
        private Palabra()
        {
            _letrasDeLaPalabra = new List<Letra>();
        } 
    
        /// <summary> 
        ///Retorna una cadena de caracteres con la palabra correcta 
        /// </summary> 
        public string PalabraCorrecta 
        {
            get
            {
               
                    string acum = "";

                    for (int i = 0; i < this._letrasDeLaPalabra.Count; i++)
                    {
                        //string.Concat(acum, this._letrasDeLaPalabra[i].Caracter);
                        acum += this._letrasDeLaPalabra[i].Caracter;
                    }

                    return acum;
               
            }

        }
        /// <summary> 
        ///Retorna una cadena de caracteres con la palabra descubierta hasta el 
        ///momento, los caracteres que no fueron 
        ///descubiertos se mostrarán con el valor del atributo 
        ///_caracterLetraOculta, además deberá haber un espacio 
        ///entre cada letra. 
        ///Se deberá tener en cuenta si cada Letra está visible o no. 
        /// </summary> 
        public string PalabraDescubiertaHastaElMomento 
        {
            get { 
                 string acum = "";   
                
                for (int i = 0; i < this._letrasDeLaPalabra.Count; i++)
			            {
                            if (this._letrasDeLaPalabra[i].EstaVisible == true)
                            {
                                //String.Concat(acum, this._letrasDeLaPalabra[i].Caracter);                            
                                acum += this._letrasDeLaPalabra[i].Caracter + " ";
                            }
                            else
                            {
                                //String.Concat(acum, this._caracterLetraOculta);
                                acum += this._caracterLetraOculta + " ";
                            }

                        }

                return acum;
                }
        } 
    
        /// <summary> 
        ///Recorre la lista de Letras, si existe el caracter que se recibe por 
        ///parámetros, deberá habilitar 
        ///la letra (ponerla visible), para TODAS las coincidencias. 
        ///Si se encuentra por lo menos 1 coincidencia, retornará verdadero. 
        /// </summary> 
        /// <param name="letraADescubrir"></param> 
        /// <returns></returns> 
        public bool DescubrirLetra (char letraADescubrir) 
        {
            bool flag = false;
            
            for (int i = 0; i < this._letrasDeLaPalabra.Count; i++)
            {
                if (letraADescubrir == this._letrasDeLaPalabra[i].Caracter)
                {
                    this._letrasDeLaPalabra[i].EstaVisible = true;
                    flag = true;
                }
            }

            return flag;


        } 




    }
}
