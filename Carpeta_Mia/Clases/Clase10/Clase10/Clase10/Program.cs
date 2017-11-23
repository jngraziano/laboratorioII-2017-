using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//DEBO AGREGAR ESTO PARA QUE FUNCIONE
using System.Xml;//PARA CREAR XML
using System.Xml.Serialization;//PARA CREAR XML

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rta = true;
            bool rta2 = true;
            Boleto b;
            Boleto boleto = new Boleto("NIRO SA",654,15600F);
            Persona persona = new Persona("Juan Niro",78);
            Ticket ticket = new Ticket(DateTime.Today,"SRL",6000);

            //---------------------------------------------
            //Para usar lista en serialización:
            //List<Boleto> listBol = new List<Boleto>();
            //listBol.Add(boleto);
            //es lo mismo pero en el typeof tenemos que poner tipo lista de boletos. 
            //---------------------------------------------
            Console.WriteLine(boleto.ToString());
            Console.WriteLine(persona.ToString());
            Console.WriteLine(ticket.ToString());

            //SERIALIZACION
            /*--------------------------------------------------------------------------------------------------------------------------------------------------------------------
            * Serializacion de OBJETOS:
            * es transformar un objeto que esta recibiendo en memoria (cualquier tipo) en una secuencia lineal de bytes/xml/etc, 
            * para que se puedan escribir, para poder transportarlo. Luego realizo desrializacion para reconstruir mi objeto.
            *
            * pasar a: 
            * ->Binaria
            * ->XML -> Archivos standarizados
            *       ->Independentes de: lenguaje/S.O/dispositivo/etc
            * OBJETO PARA ESCRIBIR UN XML
            * XmlTextWriter
            * */
            XmlTextWriter xmltw = new XmlTextWriter(@"F:\Facultad\Programacion II (C#) 2016\Clases\Clase10\Clase10\MiBoleto.xml",Encoding.UTF8);
            XmlSerializer xmls = new XmlSerializer(typeof(Boleto));//SE LE INDICA EL TIPO DE OBJETO A SERIALIZAR
            xmls.Serialize(xmltw, boleto);
            //EL OBJETO QUE QUIERA SERIALIZAR DEBE TENER UN PARAMETRO POR DEFAULT Y LA CLASE TIENE QUE SER PUBLICA Y LOS ATRIBUTOS PUBLICOS(o propiedad publica)
            //PARA LEER UN XML(DESERIALIZARLO):
            XmlTextReader xmltr = new XmlTextReader(@"F:\Facultad\Programacion II (C#) 2016\Clases\Clase10\Clase10\MiBoleto.xml");
            b=(Boleto)xmls.Deserialize(xmltr);//retorna un objeto, entonces tengo que castearlo para que entre a b.
            Console.WriteLine(b.ToString());
            //-------------------------------------------------------------------------------------------------------------------------------------------------

              Console.ReadLine();
                //LLAMO A PROGRAM PARA IR A LA FUNCION, tiene que ser estatico.
                rta  = Program.Guardar(boleto);
                rta2 = Program.Leer();
               //aca se puede hacer un IF para ver si cargo o no los datos.
             


        }
        //METODO EN PROGRAM FUERA DEL MAIN
        public static bool Guardar(Boleto boleto)
        {
            //STREAMWRITER CREO UN TXT
            /*si el archivo de texto no existe lo va a crear
            y dependiendo del parametro append va a sobrescribir o no.
            UNA FORMA PARA QUE NO ME TOME LA BARRA COMO SI QUISIERA PONER \n ES PONIENDO DOS BARRAS
             OTRA FORMA ES PONERLE EL CARACTER @ ANTES DEL PATH(HACE QUE EL COMPILADOR NO TOME EN CUENTA NINGUN CARACTER
             ESCAPE EN ESE STRING)
             para guardar es:
                 
             sw.WriteLine(
             sw.Write(
             uno con salto de linea y otro no*/
            
            //puedo usar la siguiente ruta concatenando->  AppDomain.CurrentDomain.BaseDirectory+"\\...nombredelarchivo...";
            //esto es para cuando quiero llevar a un cliente y claramente no tenga D:\ o F:\ etc

            StreamWriter sw = new StreamWriter(@"F:\Facultad\Programacion II (C#) 2016\Clases\Clase10\Clase10\MiBoleto.txt", true);
            sw.WriteLine(boleto.ToString());


            //OTRA FORMA DE HACERLO SIN NECESITAR PONER CLOSE, POR LAS DUDAS SI NOS LO OLVIDAMOS: 
            //using(StreamWriter sw = new StreamWriter(@"F:\Facultad\Programacion II (C#) 2016\Clases\Clase10\Clase10\MiBoleto.txt", true))
            //{
            //sw.WriteLine(boleto.ToString());}

            sw.WriteLine(boleto.ToString());
            sw.Close();//SIEMPRE HAY QUE CERRARLO
            return true;

            
        }
        public static bool Leer()
        { 
             //SREAMREADER LEER TXT
            //Lo siguiente es para validar si el archivo existe o no, devuelve un booleano. Lo metemos dentro de un IF.
            //ESTO SIRVE SOLO PARA EL STREAMREADER
            //PARA LEER:
            //sr.READ() / sr.READLINE() / sr.READTOEND() se tiene que usar este ultimo ya que lee desde el primer hasta el ultimo caracter devolviendo un string
            if (File.Exists(@"F:\Facultad\Programacion II (C#) 2016\Clases\Clase10\Clase10\MiBoleto.txt"))
            {
                StreamReader sr = new StreamReader(@"F:\Facultad\Programacion II (C#) 2016\Clases\Clase10\Clase10\MiBoleto.txt");
                sr.ReadToEnd();
                sr.Close();//se puede usar el using tambien como el otro. 
                return true;
            }
            else
            { return false; }
            /*
             * PARA USAR sr.REALINE() en vez de sr.READTOEND->
             * While(string Linea = sr.ReadLine() != null)
             * { Console.WriteLine(Linea);}
             * */

            //Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory(dsp del ultimo punto es un ejemplo);
            //esto sirve para llegar a un lugar especifico de la maquina. Retorna un string. Le concateno el archivito

           
            
        }
    }
}
