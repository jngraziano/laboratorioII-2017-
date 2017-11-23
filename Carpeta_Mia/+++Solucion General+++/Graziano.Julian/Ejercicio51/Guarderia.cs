using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio51
{
    class Guarderia:ICargar,IGuardar
    {
        private List<Mascota> _listaMascota;
        private float _precioGato;
        private float _precioPerro;

        public float PrecioPorGato { get { return this._precioGato; } }
        public float PrecioPorPerro { get { return this._precioPerro; } }
        public List<Mascota> ListaMascota { get { return this._listaMascota; } set { this._listaMascota = value; } }

        public Guarderia(float precioGato, float precioPerro)
        {
            this._precioGato = precioGato;
            this._precioPerro = precioPerro;
            List<Mascota> list = new List<Mascota>();
            this._listaMascota = list;
        }

        public bool DeserializarListaMascota()
        {
            XmlTextReader objXml = new XmlTextReader(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio51\Serializa.xml");
            XmlSerializer objSer = new XmlSerializer(typeof(List<Mascota>));
            List<Mascota> listMascota = (List<Mascota>)objSer.Deserialize(objXml);
            Console.Clear();
            foreach (Mascota mascota in listMascota)
            {
                Console.WriteLine(mascota.Mostrar());
            }
            objXml.Close();
            return true;
        
        }

        public bool ImprimirDatosListasMascotas()
        {
            //Este método guardará sin sobrescribir los datos de las
            //mascotas que tengo en la guardería.


            return true;
        }

        public void IngresarMascota(Mascota miMascota)
        {
            //IngresarMascota: (que recibe como único parámetro una Mascota),
            //agregará a la lista dicho objeto

            this._listaMascota.Add(miMascota);
        }

        public float MostrarTotalFactura()
        {
            float resp = 0;
            foreach (Mascota recorre in this._listaMascota)
            {
                if (recorre is Gato)
                {
                    resp += this.PrecioPorGato;

                }
                else
                { resp += this.PrecioPorPerro; }
            
            }
            return resp;
        
        }
        public float MostrarTotalFactura(EMascota tipoDeMascota)
        {
            float result = 0;
            
            /*MostrarTotalFacturado: devolverá la ganancia de la guardería
            (Single), dicho método tendrá una sobrecarga que reciba como
            parámetro la enumeración EMascota (con Perro y Gato como
            enumerados) y retornará la ganancia de la Guardería por tipo de
            Mascota.*/
            foreach (Mascota recorre in this._listaMascota)
            {
                if (tipoDeMascota == EMascota.Gato && recorre is Gato)
                {
                    result += this.PrecioPorGato;
                
                }
                else if (tipoDeMascota == EMascota.Perro && recorre is Perro)
                {
                    result += this.PrecioPorPerro;
                }
            
            }

            return result;
        
        }

        public static Guarderia operator +(Guarderia miGuarderia, Mascota unaMascota)
        {
            /*Se realizará la sobrecarga del operador + para permitir sumar una
                mascota a la guardería, retornando una guardería con la mascota agregada
                en la lista genérica, ejemplo:
                Miguarderia = Miguarderia + UnaMascota
             * */

            miGuarderia._listaMascota.Add(unaMascota);

            return miGuarderia;
        
        }
        public bool SerializarListaMascota(string path)
        {
            try
            {
                XmlTextWriter xtW = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer xS = new XmlSerializer(typeof(List<Mascota>));

                xS.Serialize(xtW, this._listaMascota);
                xtW.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                return false;
            
            }

            
        
        }
        public override string ToString()
        {
            //ToString: deberá devolver en un String los datos de todas las
            //mascotas que tiene la Guardería, este método utilizará un objeto de
            //tipo StringBuilder.
            StringBuilder sb = new StringBuilder();
            foreach (Mascota recorre in this._listaMascota)
            {
                
                sb.Append("\nLista de Mascotas: ");
                sb.AppendLine(this._listaMascota.ToString());
            }
            return sb.ToString();
        
        }
        public bool TraerDatosMascota()
        {
            //Este método leerá de un archivo de texto los datos de las
            //mascotas que están en él.
            //Lo guardará en un StringBuilder los mostrará por consola.
            XmlTextReader xmlR = new XmlTextReader(@"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\Ejercicio51\Serializa.xml");

            xmlR.Read();

            StringBuilder sb = new StringBuilder();

            sb.Append(xmlR);





            return true;
        
        }


        
    }
}
