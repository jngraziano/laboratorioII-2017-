using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion
{
    class Banco
    {
        private List<Cuenta> cuenta;

        public Banco()
        {
            this.cuenta = new List<Cuenta>();
        }

        public List<Cuenta> ListaCuenta { get { return this.cuenta; } }

        public static List<Cuenta> operator +(Banco objBanco, Banco objBanco2)
        {

            //List<Cuenta> aux = new List<Cuenta>();
            //Single auxsaldo = 0;

            //for (int i = 0; i < objBanco.ListaCuenta.Count; i++)
            //{
            //    Boolean flag = false;
            //    auxsaldo = 0;
            //    for (int j = 0; j < objBanco2.ListaCuenta.Count; j++)
            //    {
            //        if (objBanco.ListaCuenta[i].Cbu == objBanco2.ListaCuenta[j].Cbu)
            //        {
            //            auxsaldo = objBanco.ListaCuenta[i].Saldo + objBanco2.ListaCuenta[j].Saldo;
            //            flag = true;
            //            break;
            //        }
            //    }

            //    aux.Add(objBanco.ListaCuenta[i]);
            //    if (flag == true)
            //    {
            //        aux[i].Saldo = auxsaldo;
            //    }
            //}

            //for (int i = 0; i < objBanco2.ListaCuenta.Count; i++)
            //{
            //    Boolean flag = false;

            //    for (int j = 0; j < objBanco.ListaCuenta.Count; j++)
            //    {
            //        if (objBanco2.ListaCuenta[i].Cbu == objBanco.ListaCuenta[j].Cbu)
            //        {
            //            flag = true;
            //            break;
            //        }
            //    }

            //    if (flag == false)
            //    {
            //        aux.Add(objBanco2.ListaCuenta[i]);
            //    }
            //}

            //return aux;

            List<Cuenta> c = new List<Cuenta>();

            foreach (Cuenta Item in objBanco.ListaCuenta)
            {
                c.Add(Item);
            }

            foreach (Cuenta Item in objBanco2.ListaCuenta)
            {
                foreach (Cuenta Item2 in c)
                {
                    if (Item.Cbu == Item2.Cbu)
                    {
                        Item2.Saldo += Item.Saldo;
                        break;
                    }
                    else
                    {
                        c.Add(Item);
                        break;
                    }

                }
            }

            return c;






        }

    }
}