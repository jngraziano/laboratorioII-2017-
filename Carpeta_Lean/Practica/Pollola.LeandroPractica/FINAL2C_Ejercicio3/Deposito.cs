using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL2C_Ejercicio3
{
    class Deposito
    {
        private Producto[] listaProductos = new Producto[3];

        public  Deposito() 
        {
            for (int j = 0; j < 3; j++)
            {listaProductos[j] = new Producto();}
        }

        public Deposito(int cantLugares)
        {
            for (int j = 0; j < cantLugares; j++)
            { listaProductos[j] = new Producto(); }
        }

    
        public static Deposito operator +(Deposito d, Producto p)
        {
            int indice = Deposito.LugarLibre(d);

            if (indice == -1)
            {
                Console.WriteLine("El deposito esta lleno");
            }
            else 
            {
                d.listaProductos[indice].Nombre = p.Nombre;
                d.listaProductos[indice].Stock = p.Stock;
                Console.WriteLine("Producto agregado");
            }
           
            return d;
        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] arrayRespuesta = new Producto[10];

            for (int j = 0; j < 10; j++)
            { arrayRespuesta[j] = new Producto(); }

            //RECORRE EL 1ER ARRAY Y AGREGA AL ARRAYRESPUESTA
            for (int j = 0; j < 3; j++ )
            {
                arrayRespuesta[j].Nombre = d1.listaProductos[j].Nombre;
                arrayRespuesta[j].Stock =  d1.listaProductos[j].Stock;
            }
            //RECORRO ELSEGUNDO,VEO  SI EXISTE SUMO STOCK, SINO AGREGO
            bool esIgual = false;
            int indice = -1;
            int retorno = -1;

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < arrayRespuesta.Length; k++)
                {
                    if (arrayRespuesta[k] == d2.listaProductos[j])
                    {
                        esIgual = true;
                        indice = k;
                    }
                }

                if (esIgual)
                {
                    arrayRespuesta[indice].Stock += d2.listaProductos[j].Stock;
                }
                else
                {
                    //COMPRUEBO PRIMER INDICE EN NULO
                    for (int i = 0; i < arrayRespuesta.Length ; i++)
                    {
                        if (arrayRespuesta[i].Nombre == null)
                        {
                            retorno = i;
                            break;
                        }
                    }
                    //AGREGO EN LUGAR VACIO
                    arrayRespuesta[retorno].Nombre = d2.listaProductos[j].Nombre;
                    arrayRespuesta[retorno].Nombre = d2.listaProductos[j].Nombre;
                    Console.WriteLine("Producto agregado");
                }
            }
            return arrayRespuesta;
        }

        public static int LugarLibre (Deposito d)
        {
            int retorno= -1;

            for (int i=0; i < d.listaProductos.GetLength(0)  ; i++)
            {
                if (d.listaProductos[i].Nombre == null)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }


    }
}
