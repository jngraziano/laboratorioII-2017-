using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    public interface ISerializable
    {
        string RutaArchivo { get; }

        bool SerializarXML();
    }
}
