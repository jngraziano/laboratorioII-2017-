using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Ahorcado;
using Ahorcado.GUI;

namespace Ahorcado
{
    class Juego
    {
        private int _cantidadErrores;
        private const int _cantidadMaximaDeErrores = 6;
        private bool _inicioDelJuego;
        private char _letraActual;
        private Palabra _palabraADescubrir;
        private Random _random;
        private Pantalla pantalla;

      

        /// <summary>
        /// Retorna cuál era la palabra correcta
        /// </summary>
        public string PalabraResuelta
        {
             get
                {
                    return this._palabraADescubrir.PalabraCorrecta;
                }
        
        }

        /// <summary>
        /// Retorna una lista de palabras, que luego se utilizarán para jugar con
        /// una de ellas. En principio
        /// deberá contener 10 elementos que quedan a criterio del alumno.
        /// </summary>
        /// <returns></returns>
        private List<string> ObtenerListaDePalabras()
                    {
                        List<string> listaDePalabras = new List<string>();

                        listaDePalabras.Add("el señor de los ladrillos");
                        listaDePalabras.Add("escalera");
                        listaDePalabras.Add("hipopotamo");
                        listaDePalabras.Add("el estanciero");
                        listaDePalabras.Add("economia no muy economica");
                        listaDePalabras.Add("biblioteca");
                        listaDePalabras.Add("telefono descompuesto");
                        listaDePalabras.Add("colectivo sin sube");
                        listaDePalabras.Add("universidad priblica");
                        listaDePalabras.Add("heladera");

                        return listaDePalabras;


                    }

        public Juego()
                {

                   
            
            

                    _random = new Random();
                    List<string> _listaDePalabras;
                    int indice;
                    _listaDePalabras = ObtenerListaDePalabras();
                    indice = _random.Next(0, _listaDePalabras.Count - 1);
                    _palabraADescubrir = new Palabra(_listaDePalabras[indice], 'X');
                    pantalla = Pantalla.ObtenerInstancia("TP Prog 2 - Vogel Damian", 0, 0);
                    Console.WriteLine(this.pantalla.MensajeInicial);
                    Console.ReadKey();
                    this.pantalla.DibujarFigura(eErrores.SinErrores);
                    
        
                }


        /// <summary>
        /// Retornará true si la palabra fue descubierta
        /// </summary>
            public bool Ganado
            {
                get
                {
                    return this._palabraADescubrir.PalabraDescubierta;
                }
            }

        /// <summary>
        /// Retornará verdadero si la cantidad de errores no supera la cantidad
        /// máxima, y además la
        /// palabra no fue descubierta.
        /// </summary>
        public bool DeboSeguirJugando
        {
             get
                 {
                     if (this._cantidadErrores < _cantidadMaximaDeErrores && !this.Ganado)
                     {
                         return true;
                     }

                     return false;
                        
                 }
        }

        public void Jugar()
                    {
                        if (_inicioDelJuego)
                            {
                                this.MostrarJugada();
                                _inicioDelJuego = false;                       
                            }
                        
                        this.PedirJugada();
                        this.EjecutarJugada();
                        this.MostrarJugada();
                    }   

        /// <summary>
        /// Pide el ingreso de una letra (por consola), almacena el valor leído
        /// en _letraActual
        /// </summary>
        public void PedirJugada()
        {
            Console.Write("Por favor ingrese una letra:");
            string aux = Console.ReadLine();

            this._letraActual = char.Parse(aux.Substring(0, 1));          
        }

        /// <summary>
        /// Utiliza el atributo _letraActual (que previamente modificó el método
        /// PedirJugada()), para
        /// descubrir la letra de la _palabraADescubrir; tener en cuenta que en
        /// el caso que no exista la
        /// letra en la palabra a descubrir, la _cantidadErrores deberá ser
        /// modificada.
        /// </summary>
        public void EjecutarJugada()
            {
                if (this._palabraADescubrir.DescubrirLetra(this._letraActual))
                {
                }
                else
                {
                    this._cantidadErrores++;
                }
           }

        /// <summary>
        /// De acuerdo a _cantidadErrores, invocará a pantalla.DibujarFigura(...)
        /// con el parámetro que corresponda.
        /// Luego, deberá mostrar por consola la palabra descubierta hasta el
        /// momento
        /// </summary>
        public void MostrarJugada()
                {
                    switch (this._cantidadErrores)
                    {
                        case 0:

                                this.pantalla.DibujarFigura(eErrores.SinErrores);
                                break;
                        case 1:
                            
                                this.pantalla.DibujarFigura(eErrores.UnError);
                                break;
                        case 2:
                            
                                this.pantalla.DibujarFigura(eErrores.DosErrores);
                                break;
                        case 3:

                                this.pantalla.DibujarFigura(eErrores.TresErrores);
                                break;
                        case 4:
                                
                                this.pantalla.DibujarFigura(eErrores.CuatroErrores);
                                break;
                        
                        case 5:

                                this.pantalla.DibujarFigura(eErrores.CincoErrores);
                                break;
                        
                        case 6:

                                this.pantalla.DibujarFigura(eErrores.SeisErrores);
                                break;
                        
                        default:
                            break;
                    }

                    Console.WriteLine(this._palabraADescubrir.PalabraDescubiertaHastaElMomento);
               
                }

    }
}
