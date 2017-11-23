using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio42
{
    class Cliente
    {
        private string _apellido;
        private int _cuentaBancaria;
        private string _cuit;
        private int _edad;
        private string _nombre;

        #region Prop y Const
        public string Apellido {get;set;}
        public int CuentaBancaria { get { return this._cuentaBancaria; } }
        public string Cuit { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public Cliente(string CUIT, int CuentaBancaria)
        {
            this.Cuit = CUIT;
            this._cuentaBancaria = CuentaBancaria;        
        }

        #endregion

        #region Metodos
        public virtual void GuardarEnDisco(Cliente unCliente)
        {
            StreamWriter sw = new StreamWriter(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio42\Cliente.txt");
            sw.WriteLine(unCliente.Apellido);
            sw.WriteLine(unCliente.CuentaBancaria);
            sw.WriteLine(unCliente.Cuit);
            sw.WriteLine(unCliente.Edad);
            sw.WriteLine(unCliente.Nombre);
            sw.Close();
        
        }
        public static bool ValidarCUIT(string ValidaCUIT)
        {
            if (ValidaCUIT.Count() < 11)
            {
                return true;
            }
            else
            {
                return false;
            }   
                  
        }


        #endregion






    }
}
