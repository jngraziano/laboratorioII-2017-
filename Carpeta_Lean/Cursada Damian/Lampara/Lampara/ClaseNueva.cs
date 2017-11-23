using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria._2016;

namespace Lampara
{
    class ClaseNueva:Pintura
    {

        #region Constructores
        public ClaseNueva(int cantidad, string marca):base(cantidad,marca)
        { 
        
        }


        #endregion


        #region Metodos
        public void Mostrar()
        {
            Console.WriteLine(base.Cantidad + base.Marca);

        }
        #endregion


    }
}
