using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

//30.05
//Las interfaces son metodos y propiedades abstractas (sin implementacion)
//Todos los metodos de interfaz van a ser publico pero no se puede colocar el modificador de visibilidad
// bool Serializar();
//las clases se obligan a implementar los metodos
//NO COLOCAR EL ABSTRACT Y EN LAS CLASES NO TENGO QUE PONER EL OVERRIDE.
//PONER EL MODIFICADOR DE VISIBILIDAD EN LA IMPLEMENTACION DEL METODO DE LA CLASE 
//La interfaz no es una clase, no se puede heredar. 
//Se puede crear variables de tipo interfaz

//POR CADA TRY TENGO AL MENOS UN CATCH, PUEDO TENER LOS QUE QUIERA
//EL ULTIMO TIENE QUE SER EL GENERICO, NO PUEDE SER EL PRIMERO PORQUE SINO ES EL PRIMERO QUE AGARRA

//GESTION DE ERRORES
// BLOQUES TRY CATCH 
// AL CATCH se le pasa un tipo catch(Exception e)
// Console.Write(e.Message);
//return false ;


namespace Clase30._05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boleto> listaboletos = new List<Boleto>();

            Boleto boletoUno = new Boleto("EMPRESA1", 555111, 9);
            Persona personaUno = new Persona("LEANDRO", 25);
            Ticket ticketUno = new Ticket(DateTime.Today, "SRL", 20);

            //en los bloques try en principio voy a poner lo que podrìa generar un error en tiempo de ejecucion
            //en los bloques catch voy a poner lo que quiero que haga si se rompe. Por lo general se utilizan cuando estoy usando archivos
            //en los bloques finally (el contenido se va a ejecutar siempre haya o no ocurrido una excepcion) 
            //este ultimo es mejor usarlo antes que el using porque te va a cerrar cuando lo necesites.
            
            Console.WriteLine("Prueba de numero negativo");
            try
            { ticketUno.Importe = -3;
                //coloco -3 para que rompa y me muestre el mensaje.
            }
            catch(Exception e)
            {Console.WriteLine(e.Message);}
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Muestra de burbujeo de F1,F2,F3");
            try { Program.F1(); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("SerializadorXML");

            SerializadorXML(boletoUno);
            SerializadorXML(ticketUno);
            SerializadorXML(personaUno);

            Console.ReadLine();

        }

        private static bool SerializadorXML(IGuardar obj)
        {
            try { return obj.serializar(); }
            catch (Exception e) { Console.WriteLine(e.Message); return false; } 
            
        
        }
        public static void F1()
        {
            //el throw es para lanzar la excepcion que va desde abajo hacia arriva, enviando la excepcion creada en este ej, en el F3
            try { Program.F2(); }
            catch (Exception e) { Console.WriteLine("Estoy en F1"); throw e; }
            finally { Console.WriteLine("Estoy en el finally de F1"); }
           
        }
        public static void F2()
        {
            try { Program.F3(); }
            catch (Exception e) { Console.WriteLine("Estoy en F2"); throw e; }
            
        
        }
        public static void F3()
        {
            Console.WriteLine("Estoy en F3");
            throw new Exception("Aca se creo la Excepcion");
        }


        
    }
}


