using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manejo_de_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ManejarCadenas();
        }

#region Manejo de Cadenas

        static void ManejarCadenas()
        { 
            // Manejo de cadenas de Caracteres
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("******Manejo de cadenas de Caracteres********");
            Console.WriteLine("*********************************************"); 
            Console.ReadLine();
            
            //DECLARO UNA VARIABLE DE TIPO STRING
            String cadena;
            int valor;

            //INICIALIZO LA VARIABLE DE TIPO STRING
            cadena = "Hola";

            Console.WriteLine("Declaro una variable de tipo 'string' y la muestro.");
            Console.WriteLine("cadena = {0}", cadena);
            Console.ReadLine();


            Console.WriteLine("Comparo \"Hola\" con 'cadena'.");
            Console.WriteLine("Utilizo String.Compare(\"Hola\", cadena)");
            Console.ReadLine();

            //UTILIZO EL METODO COMPARE
            if (String.Compare("Hola", cadena) == 0)
                Console.WriteLine("Las cadenas son iguales.");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Comparo \"HOLA\" con 'cadena'.");
            Console.WriteLine("Utilizo String.Compare(\"HOLA\", cadena)");
            Console.ReadLine();

            if (String.Compare("HOLA", cadena) > 0)
                Console.WriteLine("HOLA es > que {0}", cadena);

            if (String.Compare("HOLA", cadena) < 0)
                Console.WriteLine("HOLA es < que {0}", cadena);

            Console.ReadLine();
            Console.Clear();

            //UTILIZO EL METODO COPY
            cadena=String.Copy("Chau");

            Console.WriteLine("Utilizo 'cadena = String.Copy(\"Chau\")'.");
            Console.WriteLine("cadena = {0}", cadena); 
            
            Console.ReadLine();
            Console.Clear();

            //UTILIZO EL METODO CONCAT
            cadena = String.Concat("Hola ", "Mundo");

            Console.WriteLine("cadena = String.Concat(\"Hola \", \"Mundo\")");
            Console.WriteLine(cadena);
            
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("METODOS DE INSTANCIA.");
            Console.WriteLine();

            //UTILIZO EL METODO COMPARETO
            Console.WriteLine("cadena.CompareTo(\"Hola\")--> {0}. Recordar 0 -> Iguales.", 
                                cadena.CompareTo("Hola"));
            Console.ReadLine();

            //UTILIZO EL METODO CONTAINS
            Console.WriteLine("cadena.Contains(\"la\")");
            if (cadena.Contains("la"))
            {
                Console.WriteLine("Está en la instancia");
            }
            else
            {
                Console.WriteLine("No está en la instancia");
            }
            Console.ReadLine();
            Console.Clear();

            //UTILIZO EL METODO ENDSWITH
            Console.WriteLine("cadena.EndsWith(\"do\")");

            if(cadena.EndsWith("do"))
            {
                Console.WriteLine("Está en la instancia");
            }
            else
            {
                Console.WriteLine("No está en la instancia");
            }
            Console.ReadLine();
            Console.Clear();


            //UTILIZO EL METODO INDEXOF Y LASTINDEXOF
            Console.WriteLine("valor = cadena.IndexOf(\"o\")");

            valor = cadena.IndexOf("o");

            Console.WriteLine("valor = {0}", valor);
            Console.ReadLine();

            Console.WriteLine("valor = cadena.LastIndexOf(\"o\")");

            valor = cadena.LastIndexOf("o");

            Console.WriteLine("valor = {0}", valor);

            Console.ReadLine();
            Console.Clear();
            
            //UTILIZO EL METODO INSERT
            Console.WriteLine("cadena.Insert(cadena.Length, \" CSharp\")");
            Console.WriteLine();
            Console.WriteLine("cadena = {0}", 
                            cadena.Insert(cadena.Length, " CSharp"));

            Console.ReadLine();
            Console.Clear();


            //UTILIZO EL METODO REMOVE
            Console.WriteLine("cadena = cadena.Remove(cadena.Length - 6)");
            Console.WriteLine();

            cadena = cadena.Remove(cadena.Length - 6);
            Console.WriteLine("cadena = {0}", cadena);

            Console.ReadLine();
            Console.Clear();


            //UTILIZO EL METODO REPLACE Y SUBSTRING
            Console.WriteLine("cadena.Replace(cadena.Substring(1,1), \"*\")");
            Console.WriteLine();

            cadena = cadena.Replace(cadena.Substring(0, 1), "*");
            Console.WriteLine("cadena = {0}", cadena);

            Console.ReadLine();
            Console.Clear();


            //UTILIZO EL METODO TOLOWER Y TOUPPER
            Console.WriteLine("cadena = cadena.ToUpper()");
            Console.WriteLine();

            cadena = cadena.ToUpper();
            Console.WriteLine("cadena = {0}",cadena);

            Console.ReadLine();

            Console.WriteLine("cadena = cadena.ToLower()");
            Console.WriteLine();

            cadena = cadena.ToLower();
            Console.WriteLine("cadena = {0}", cadena);

            Console.ReadLine();
            Console.Clear();


            //UTILIZO EL METODO TRIMEND Y TRIMSTART
            Console.WriteLine("cadena = cadena.TrimEnd(\"a\")");
            Console.WriteLine();

            cadena = cadena.TrimEnd('a');
            Console.WriteLine("cadena = {0}", cadena);

            Console.ReadLine();

            Console.WriteLine("cadena = cadena.TrimStart(\"*\")");
            Console.WriteLine();

            cadena = cadena.TrimStart('*');
            Console.WriteLine("cadena = {0}", cadena);

            Console.ReadLine();
            Console.Clear();

            //UTILIZO EL METODO TRIM
            Console.WriteLine("Agrego espacios al principio y al final de 'cadena'.");
            cadena = "                 " + cadena;
            cadena = cadena + "                ";

            Console.WriteLine("cadena = {0}", cadena);
            Console.ReadLine();

            Console.WriteLine("cadena.Trim()");
            Console.WriteLine();

            cadena = cadena.Trim(); 
            Console.WriteLine("cadena = {0}", cadena);

            Console.ReadLine();
            Console.Clear();
        }

#endregion          

    }
}

