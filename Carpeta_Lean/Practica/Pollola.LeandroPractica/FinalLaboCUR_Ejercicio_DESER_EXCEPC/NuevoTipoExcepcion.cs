using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLaboCUR_Ejercicio_DESER_EXCEPC
{
    class NuevoTipoExcepcion:Exception
    {
        private DateTime _date;

        public NuevoTipoExcepcion()
        {
            this._date = DateTime.Now;

        }

        public string MensajeDeError { get { return this.Message; } }
        public DateTime FechaError { get { return this._date; } }

        public override string ToString()
        {
            return this.MensajeDeError + this.FechaError.ToString();
        }
    }
}
