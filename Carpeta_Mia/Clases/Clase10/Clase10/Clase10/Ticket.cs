using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    class Ticket
    {
        public DateTime fecha = new DateTime();
        public string razonSocial;
        public double importe;

        public Ticket(DateTime Fecha, string razonsocial, double importe)
        {
            
            this.fecha = Fecha;
            this.razonSocial = razonsocial;
            this.importe = importe;
        
        }


        //poliformismo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nFecha: ");
            sb.AppendLine(this.fecha.ToString());
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this.razonSocial);
            sb.Append("\nImporte: ");
            sb.AppendLine(this.importe.ToString());
            
            return sb.ToString();
        }
    }
}
