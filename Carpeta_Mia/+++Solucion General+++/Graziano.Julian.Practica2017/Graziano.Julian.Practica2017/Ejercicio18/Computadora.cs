using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Computadora
    {
        #region Variables de la clase
        private bool _estaEncendida;
        private EMarca _marca;
        private float _peso;
        private EProcesador _procesador;
        #endregion

        #region Metodos de la clase
        public bool getEstaEncendida()
        { return this._estaEncendida; }
        public EMarca getMarca()
        { return this._marca; }
        public float getPeso()
        { return this._peso; }
        public EProcesador getProcesador()
        { return this._procesador; }
        public void setEstaEncendida(bool encender)
        { this._estaEncendida = encender; }
        public void setMarca(EMarca marca)
        { this._marca = marca; }
        public void setPeso(float peso)
        { this._peso = peso; }
        public void setProcesador(EProcesador procesador)
        { this._procesador = procesador; }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\nEsta encendida?: ");
            sb.Append(this._estaEncendida.ToString());
            sb.AppendLine("\nMarca: ");
            sb.Append(this._marca.ToString());
            sb.AppendLine("\nPeso: ");
            sb.Append(this._peso.ToString());
            sb.AppendLine("\nProcesador: ");
            sb.Append(this._procesador.ToString());

            Console.WriteLine(sb.ToString());
        
        }

        #endregion


    }
}
