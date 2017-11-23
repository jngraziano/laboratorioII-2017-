using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Banco
    {
        private DateTime _fechaInicio;
        private List<CuentaCorriente> _listaCuentasCorrientes;
        private string _razonSocial;

        public Banco()
        {
            List<CuentaCorriente> aux = new List<CuentaCorriente>();
            this._listaCuentasCorrientes = aux;
        }
        public Banco(DateTime fechaInicio)
            : this()
        {
            this._fechaInicio = fechaInicio;
        }

        public Banco(string razonSocial, DateTime fechaInicio):this(fechaInicio)
        {
            this._razonSocial = razonSocial;
            
        }
        
        public void MostrarBanco()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Razon Social: \n");
            sb.AppendLine(this._razonSocial);
            sb.Append("Fecha Inicio: \n");
            sb.AppendLine(this._fechaInicio.ToString());
            sb.Append("Lista Cuentas corrientes: \n");
            foreach (CuentaCorriente cuenta in this._listaCuentasCorrientes)
            {
                CuentaCorriente CC = new CuentaCorriente(cuenta.Dueño,cuenta.numeroCuenta,cuenta.Saldo);

                
                sb.Append("Dueño: \n");
                sb.AppendLine(CC.Dueño.Mostrar(cuenta.Dueño));
                sb.Append("Numero de cuenta: \n");
                sb.AppendLine(CC.numeroCuenta.ToString());
                sb.AppendLine("Saldo: \n" + (double)CC);
                
            }
            Console.WriteLine(sb.ToString());
        }
        public static Banco operator -(Banco unBanco, CuentaCorriente unaCuenta)
        {
            foreach (CuentaCorriente valor in unBanco._listaCuentasCorrientes)
            {
                if (valor == unaCuenta)
                {
                    unBanco._listaCuentasCorrientes.Remove(unaCuenta);
                    Console.WriteLine("Fue removido correctamente");
                    break;
                }

                else { Console.WriteLine("No se encontro."); }

            }
            return unBanco;    
        
        }
        public static Banco operator +(Banco unBanco, CuentaCorriente unaCuenta)
        {
            //foreach(CuentaCorriente valor in unBanco._listaCuentasCorrientes)
            //{
            //    if (valor == unaCuenta)
            //    {
                    unBanco._listaCuentasCorrientes.Add(unaCuenta);
                //    Console.WriteLine("Fue agregado correctamente");
                //    break;
                //}
                //else { Console.WriteLine("No se encontro."); }

            //}
            return unBanco;   
        
        }

    }
}
