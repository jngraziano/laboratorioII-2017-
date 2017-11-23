using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraisos
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public int cantidadDeCuentas;
        public DateTime fechaInicioActividades;

        private ParaisoFiscal()
        {
            List<CuentaOffShore> list = new List<CuentaOffShore>();
            this._listadoCuentas = list;
        }
        static ParaisoFiscal()
        {
            ParaisoFiscal aux = new ParaisoFiscal();

            aux.cantidadDeCuentas = 0;
            aux.fechaInicioActividades = DateTime.Now;
        
        }
        private ParaisoFiscal(eParaisosFiscales lugar)
        {
            this._lugar = lugar;
        }

        #region Metodos
        
        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            
            ParaisoFiscal pf = new ParaisoFiscal(epf);
            return pf;
        }

        public void MostrarParaiso()
        {
           
            Console.WriteLine("Fecha de Inicio: {0}\nLugar de Radicacion: {1}\n", this.fechaInicioActividades, this._lugar);
            foreach (CuentaOffShore recorre in this._listadoCuentas)
            {
                 int nro= (int)recorre;
                Console.WriteLine("\nCantidad de Cuentas Offshore: {0}", this.cantidadDeCuentas);
                Console.WriteLine("\nDueño: {0}\nNumero de Cuenta: {1}\nSaldo: {2}", recorre.Dueño, nro, recorre.Saldo);
           
            }
            
        
        }
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool rta=true;
           
            foreach (CuentaOffShore recorre in pf._listadoCuentas)
            {
                if (recorre == cos)
                {
                    rta = true;

                }
                else
                {
                    rta = false;
                
                }
            
            }
            return rta;
        
        }
        
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        { return !(pf == cos); }
        
        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf == cos)
            {
                pf._listadoCuentas.Remove(cos);
                pf.cantidadDeCuentas -= 1;
                Console.WriteLine("\nSe removió la cuenta.");
                return pf;

            }
            else
            {
                Console.WriteLine("\nNo se encontro la cuenta");
                return pf;
            
            }
        }
        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf != cos)
            {
                pf._listadoCuentas.Add(cos);
                pf.cantidadDeCuentas += 1;
                
                Console.WriteLine("\nSe agregó la cuenta.");
                return pf;

            }
            else
            {
                foreach (CuentaOffShore recorre in pf._listadoCuentas)
                {
                    cos.Saldo=recorre.Saldo + cos.Saldo;
                    //pf._listadoCuentas.Add(cos);
                }
                    
                Console.WriteLine("\nSe encontrò la cuenta, se realizo la suma de saldos.");
                return pf;

            }
        
        }



        #endregion

    }
}
