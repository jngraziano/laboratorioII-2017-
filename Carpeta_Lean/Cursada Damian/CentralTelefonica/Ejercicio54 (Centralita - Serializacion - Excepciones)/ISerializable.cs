﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54__Centralita___Serializacion___Excepciones_
{
    interface ISerializable
    {
        string RutaDelArchivo { get; set; }

       bool DeSerializarse ();
       bool Serializarse();
    

    }
}
