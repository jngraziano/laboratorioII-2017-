using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    abstract class Robot
    {
        protected IDisparableComportamiento _disparador;
        protected ICaminableComportamiento _caminador;

        #region Oculto y comentado

        public IDisparableComportamiento IDisparador
        {
            get { return this._disparador; }
            set { this._disparador = value; }
        }
        public ICaminableComportamiento ICaminable
        {
            get { return this._caminador; }
            set { this._caminador = value; }
        }

        #endregion

        public void Caminar()
        {
            this._caminador.Caminar();
        }

        public void Disparar()
        {
            this._disparador.Disparar();
        }
    }
}
