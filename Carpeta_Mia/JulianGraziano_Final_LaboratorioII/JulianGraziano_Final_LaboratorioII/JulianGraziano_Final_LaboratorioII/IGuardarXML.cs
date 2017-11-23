using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace JulianGraziano_Final_LaboratorioII
{
    interface IGuardarXML
    {
        bool SerializarXML(Galpon unGalpon);

        

    }
}
