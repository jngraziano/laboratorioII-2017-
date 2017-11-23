using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Banco
    {
        public List<Cuenta> listaCuentas;

        public Banco()
        {
            List<Cuenta> list = new List<Cuenta>();
            listaCuentas = list;
        
        }
        public static List<Cuenta> operator +(Banco bancoUno, Banco bancodos)
        {
            List<Cuenta> devuelve = new List<Cuenta>();
            foreach (Cuenta recorre1 in bancoUno.listaCuentas)
            {
                foreach (Cuenta recorre2 in bancodos.listaCuentas)
                {
                    if (recorre1.CBU == recorre2.CBU)
                    {
                        recorre1.Saldo += recorre2.Saldo;
                        devuelve.Add(recorre1);
                        break;
                    }
                    else
                    {
                        devuelve.Add(recorre1);
                        devuelve.Add(recorre2);
                        break;
                    }
                }
            }

            return devuelve;
        }

    }
}
