using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Boleto
{
    /*Serializacion

     * -Binaria
     * -XML ------------>Archivos standarizados
     *      ------------>Indepentiendes:
     *                     -Lenguaje
     *                     -S.O
     *                     -Dispositivo
     *                     -etc
  
     * 
     
     
     */
    
    
    
    class Program
    {
        public static bool Guardar(Boleto a)
        {
            using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\MiBoleto.txt", true))
            {
            sw.Write(a.ToString());
            }
            
            //sw.Close();
            
            return true;

        }

        public static bool Leer()
        {
            bool aux = false;

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory+"\\MiBoleto.txt")) 
            {
                using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory+"\\MiBoleto.txt"))
                {
                    string linea;
                    while((linea =  sr.ReadLine())!= null)
                    {
                        Console.WriteLine(linea);
                        Console.ReadKey();
                    }
                }
            }



            return aux;
        }


        public static bool SerializadorXML(IGuardar obj)
        {
            return obj.Serializar();
        
        }

        static void F1()
        {
            try
            {

                Program.F2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en F1");
                throw e;
            }
            finally
            {
                Console.WriteLine("Estoy en el finally de F2");
            }
        
        
        }

        

        static void F2()
        {
            try
            {

                Program.F3();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en F2");
                throw e;
                
            }
        }

        static void F3()
        {
            Console.Write("estoy en F3");
            throw new Exception("Excepcion en F3");
        
        }


        static void Main(string[] args)
        {

            Boleto boletito = new Boleto("San Vicente", 11, 6.50f);
            Persona pasajero = new Persona("Juan Pelota", 35);
            Ticket tickesito = new Ticket(DateTime.Now, "La hispana", 1000.00d);

            Console.WriteLine(boletito.ToString());
            //Console.WriteLine(pasajero.ToString());
            //Console.WriteLine(tickesito.ToString());

            Console.ReadKey();


            //StreamWriter sw = new StreamWriter(@"D:\MiBoleto.txt", true);


            //sw.Write(boletito.ToString());
            //sw.Close();

           // Guardar(boletito);

            //Leer();

            //-----------------------------------------------------------------------------------------------------
            //Como escribir en un archivo XML lo que contiene un objeto de tipo Boleto.
            

            
            
            
            //XmlTextWriter tw = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "\\MiBoleto.xml", Encoding.UTF8);

            //XmlSerializer xmlserial1 = new XmlSerializer(typeof(Boleto));

            //xmlserial1.Serialize(tw, boletito);





            //----------------------------------------------------------------------------------------------------------------------------------
            //Como enviar a un objeto de tipo Boleto  lo que contiene un archivo XML.
            
            /*
              1-Declaramos un objeto Boleto (b)... sin instanciar
              2-Instanciamos un Objeto XmlTextReader y leemos (como un buffer, ponele) lo que contiene el archivo MiBoleto.xml 
              3-Instanciamos un Objeto XmlSerial y le pasamos que tipo de objeto tiene que desmembrar (Serializar)
              4-Instanciamos el objeto b de tipo con el objeto xmlserial (de clase XmlSerializer) pasandole el objeto txtreader ("buffer" de clase XmlTextReader) como parametro a la funcion Deserialize
             
             */
         
            
            //Codigo para descomentar y probar
            
            
            //1
            //Boleto b;

            //2 
            //XmlTextReader txtreader = new XmlTextReader(AppDomain.CurrentDomain.BaseDirectory + "\\MiBoleto.xml");
            //3
            //XmlSerializer xmlserial = new XmlSerializer(typeof(Boleto));
            //4
            //b = (Boleto)xmlserial.Deserialize(txtreader);



           // boletito.Serializar();

            SerializadorXML(boletito);
            SerializadorXML(pasajero);
            SerializadorXML(tickesito);


            try
            {
                tickesito.Importe = -3;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            //Console.WriteLine("Funciona");
           // Console.WriteLine(b.ToString());

            Console.ReadKey();
       
            //-------------------------------------------------------------------------------------------------------------------------------------------

            try
            {

                Program.F1();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());

            }
            
            
            
            
            Console.ReadKey();
        }
    }
}
