using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraisos
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        public Cliente()
        { 
        this._nombre = "NN";
        this._aliasParaIncognito = "Sin alias";
        this._tipoDeCliente = eTipoCliente.SinTipo;
        }
        public Cliente(eTipoCliente tipoCliente)
            : this()
        {
            this._tipoDeCliente = tipoCliente;

        }
        public Cliente(eTipoCliente tipoCliente, string nombre)
            : this(tipoCliente)
        {
            this._nombre = nombre;
        }

        #region Metodos
        public void CrearAlias()
        {
            Random obj = new Random();

            this._aliasParaIncognito = obj.Next(1000, 9999).ToString()+this._tipoDeCliente;
        
        }
        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
                return this._aliasParaIncognito;
            }
            else
            { return this._aliasParaIncognito; }
        }
            
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nNombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("\nAlias: ");
            sb.AppendLine(this._aliasParaIncognito);
            sb.Append("\nTipo de Cliente: ");
            sb.AppendLine(this._tipoDeCliente.ToString());

            return sb.ToString();
        
        }
        public static string RetornarDatos(Cliente uncliente)
        { 
            return uncliente.RetornarDatos();
        
        }

        #endregion 



    }
}
