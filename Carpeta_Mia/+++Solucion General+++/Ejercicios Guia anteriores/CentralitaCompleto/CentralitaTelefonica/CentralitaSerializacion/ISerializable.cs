using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    interface ISerializable
    {
        string RutaDeArchivo { get; set; }

        bool Serializarse();
        bool DesSerizarse();
    }
}
