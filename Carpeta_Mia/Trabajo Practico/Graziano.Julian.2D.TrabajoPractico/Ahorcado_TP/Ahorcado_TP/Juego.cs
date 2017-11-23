using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahorcado.Palabras;
using Ahorcado.GUI;

namespace Ahorcado_TP
{
    class Juego
    {


        private const int _cantidadMaximaDeErrores = 6;
        
        private int _cantidadErrores;
        private bool _inicioDelJuego = true;
        private char _letraActual;
        private Palabra _palabraADescubrir;
        private Random _random = new Random();
        public Pantalla pantalla = Pantalla.ObtenerInstancia("Instancia inicializa", 0, 0) ;

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
        /// Retorna una lista de palabras, que luego se utilizarán para jugar con una de ellas. En principio
        /// deberá contener 10 elementos que quedan a criterio del alumno.
        /// </summary>
        /// <returns></returns>
        private List<string> ObtenerListaDePalabras()
        {
            List<string> resp = new List<string>();

            resp.Add("Republica Argentina");
            resp.Add("Republica del Peru");
            resp.Add("Republica del Brasil");
            resp.Add("Republica del Paraguay");
            resp.Add("Holanda");
            resp.Add("España");
            resp.Add("Italia");
            resp.Add("Reino Unido");
            resp.Add("Suecia");
            resp.Add("Noruega");

            return resp;
        
        }
        public Juego()
        {
            List<string> _listaDePalabras;
            int indice;
            
            _listaDePalabras = ObtenerListaDePalabras();
            indice = _random.Next(0, _listaDePalabras.Count - 1);

            this._palabraADescubrir = new Palabra(_listaDePalabras[indice], '_');

        }
        /// <summary>
        /// Retornará true si la palabra fue descubierta
        /// </summary>
        public bool Ganado
        {
            get
            {
                if (this._palabraADescubrir.PalabraDescubierta) { return true; }
                else { return false; }
            
            }
        }
       
        /// <summary>
        /// Retornará verdadero si la cantidad de errores no supera la cantidad máxima, y además la
        /// palabra no fue descubierta.
        /// </summary>
        public bool DeboSeguirJugando
        {
            get
            {
                if (this._cantidadErrores <= Juego._cantidadMaximaDeErrores && !this._palabraADescubrir.PalabraDescubierta)
                { return true; }
                else { return false;  }
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
        /// Pide el ingreso de una letra (por consola), almacena el valor leído en _letraActual
        /// </summary>
                   
            public void PedirJugada()
        {
            

            Console.Write("Ingrese una letra: ");
            var caracterQueIngr = Console.ReadKey();

            while (!char.IsLetter(caracterQueIngr.KeyChar))
            {
                Console.Write("\nReingrese corregido: ");
                caracterQueIngr = Console.ReadKey();
            }

            this._letraActual = caracterQueIngr.KeyChar;

        }
        
        /// <summary>
        /// Utiliza el atributo _letraActual (que previamente modificó el método PedirJugada()), para
        /// descubrir la letra de la _palabraADescubrir; tener en cuenta que en el caso que no exista la
        /// letra en la palabra a descubrir, la _cantidadErrores deberá ser modificada.
        /// </summary>
        public void EjecutarJugada()
        {
           if( !this._palabraADescubrir.DescubrirLetra(this._letraActual))
           {
               this._cantidadErrores += 1;
           }    
           
        }
        /// <summary>
        /// De acuerdo a _cantidadErrores, invocará a pantalla.DibujarFigura(...) con el parámetro que corresponda.
        /// Luego, deberá mostrar por consola la palabra descubierta hasta el momento
        /// </summary>
        public void MostrarJugada()
        {
            

            switch(this._cantidadErrores)
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
                default: ;
                    break;
                    
            
            
            }
            
            Console.WriteLine("Palabra descubierta hasta el momento {0}", this._palabraADescubrir.PalabraDescubiertaHastaElMomento );

            
       
        }
    }
}
