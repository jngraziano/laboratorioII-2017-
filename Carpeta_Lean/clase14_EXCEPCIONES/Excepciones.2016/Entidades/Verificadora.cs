using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Verificadora
    {
        public static bool VerificarNumero(Numero n, ETipoNumero tipo)
        {
            bool rta = false;

            switch (tipo)
            {
                case ETipoNumero.Par:
                    rta = n.Number % 2 == 0;
                    break;
                case ETipoNumero.Impar:
                    rta = n.Number % 2 != 0;
                    break;
                case ETipoNumero.Positivo:
                    rta = n.Number > 0;
                    break;
                case ETipoNumero.Negativo:
                    rta = n.Number < 0;
                    break;
                case ETipoNumero.Cero:
                    rta = n.Number == 0;
                    break;
                default:
                    break;
            }

            return rta;
        }
    }
}
