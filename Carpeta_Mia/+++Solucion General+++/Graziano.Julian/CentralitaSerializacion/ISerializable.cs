using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionPractica
{
    interface ISerializable
    {
        string RutaDeArchivo { get; set; }


        bool DeSerializarse();

        bool Serializarse();
    }
}
