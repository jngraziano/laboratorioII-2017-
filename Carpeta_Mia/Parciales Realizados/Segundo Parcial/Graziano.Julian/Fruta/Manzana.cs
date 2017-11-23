using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    public class Manzana:Fruta,ISerializable
    {
        #region Atributos, Prop y Constructores
        public double precio;

        public override bool TieneCarozo { get { return true; } }
        public string Tipo { get { return "Manzana"; } }

        public override string RutaArchivo { get{return  set; }
       

        public Manzana(float peso, ConsoleColor color, double precio) : base(peso, color) 
        {
            this.precio = precio;
        
        }
        #endregion


        #region Metodos
        public override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.FrutaToString());
            sb.AppendLine("\nPrecio: ");
            sb.Append(this.precio);

            return sb.ToString();

            
        }

        public override string ToString()
        {
           
            return this.FrutaToString();
        }


        #endregion

        #region Interface



        #endregion
    }
}
