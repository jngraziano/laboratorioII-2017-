using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercico47
{
    interface Mascota
    {
        /*
         * La interfaz ‗Mascota‘ proporcionará propiedades públicas de
lectura/escritura para el nombre de las mascotas y un método
llamado ‗Jugar()‘ que mostrará por consola como juega cada
mascota.
         * */
        string Nombre { get; set; }

        void Jugar();

        bool Serealizador();

    }
}
