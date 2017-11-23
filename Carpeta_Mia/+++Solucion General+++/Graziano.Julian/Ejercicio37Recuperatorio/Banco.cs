using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37Recuperatorio
{
    class Banco
    {
        private DateTime _fechaInicio;
        private List<CuentaCorriente> _listaCuentasCorrientes;
        private string _razonSocial;

        public Banco()
        {
            List<CuentaCorriente> list = new List<CuentaCorriente>();
            this._listaCuentasCorrientes = list;
        
        }
        
        public Banco(DateTime fechaInicio):this()
        { this._fechaInicio = fechaInicio; }
        
        public Banco(string razonSocial, DateTime fechaInicio):this(fechaInicio)
        {
            
            this._razonSocial = razonSocial;
            
        }

        public void MostrarBanco()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Fecha Inicio: ");
            sb.AppendLine(this._fechaInicio.ToString());
            sb.Append("\nRazon social: ");
            sb.AppendLine(this._razonSocial);
            sb.Append("\nLista de cuentas: ");
            foreach (CuentaCorriente recorre in this._listaCuentasCorrientes)
            {
                CuentaCorriente CC = new CuentaCorriente(recorre.Dueño,recorre.numeroCuenta,recorre.Saldo);
                
                sb.Append("Dueño: \n");
                sb.AppendLine(CC.Dueño.Mostrar(recorre.Dueño));
                sb.Append("Numero de cuenta: \n");
                sb.AppendLine(CC.numeroCuenta.ToString());
                sb.AppendLine("Saldo: \n" + (double)CC);
                
            }
            Console.WriteLine(sb.ToString());
            
            }
        
        
        
        public static Banco operator -(Banco unBanco, CuentaCorriente unaCuenta)
        {

            foreach (CuentaCorriente recorre in unBanco._listaCuentasCorrientes)
            {
                if (recorre.numeroCuenta == unaCuenta.numeroCuenta)
                { 
                    unBanco._listaCuentasCorrientes.Remove(unaCuenta);
                    Console.WriteLine("\nLa cuenta fue removida.");
                }
                else
                { Console.WriteLine("No existe la cuenta"); }
            }
            return unBanco;
        }
        public static Banco operator +(Banco unBanco, CuentaCorriente unaCuenta)
        {
            foreach (CuentaCorriente recorre in unBanco._listaCuentasCorrientes)
            {
                if (recorre.numeroCuenta == unaCuenta.numeroCuenta)
                {
                    unBanco._listaCuentasCorrientes.Add(unaCuenta);
                    Console.WriteLine("\nLa cuenta fue Agregada.");
                }
                else
                { Console.WriteLine("No existe la cuenta"); }
            }
            return unBanco;
                    
        }
    }
}
