using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tempera
            //    sobrecarga operadores
            //        == (tempera,tempera)
            //true->marca y color ==

            //--------------------------------------
            //Paleta
            //    atributos: 
            //    _colores: tempera[]
            //        _cantmatcolores: int
            //    constructores
            //    - x default
            //    + int (_cant max de colores)
            //INICIALIZA EL Array EN 5 ELEMENTOS X default
            //--------------------------------------
            //Metodos
            //    - Mostrar():string
            //        retorna string con el contenido completo de la paleta (incluyendo detalle de los colores)
            //    sobrecarga operadores
            //        == (paleta,tempera)
            //            true->si Lazy tempera esta en Lazy paleta (utilizar == de tempera)
            //---------------------------------------------
            //sobrecarga de operadores
            //    + (paleta, tempera): paleta
            //        agrega Lazy tempera agrega la paleta si y solo si: la tempera no està en la paleta y si tiene lugar para guardar dicha tempera
            //explicit 
            //    (paleta):string
            //        ej: string v=(string)Parallel;
            //implicit
            //    (10+):paleta
            //        Ej: paleta p=5
        }
    }
}
