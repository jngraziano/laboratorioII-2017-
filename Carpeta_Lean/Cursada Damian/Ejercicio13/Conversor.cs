using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double a)
        {

            double resto;
            int entero;
            double aux = a;
            string acum = null;

            do
            {
                entero = (int)aux / 2;
                resto = aux % 2;

                aux = entero;

                acum = resto.ToString() + acum;

                if (aux == 1)
                {
                    acum = aux.ToString() + acum;
                }

            } while (aux > 1);

            return acum;
        }

        public static double BinarioDecimal(string a)
        {
            int size = a.Length;
            int entero;
            double acum = 0;
            int cont = 1;

            for (int i = 0; i < size; i++)
            {
                entero = int.Parse(a.Substring(i, 1));

                if (entero == 1)
                {
                    acum += Math.Pow(2, size - cont);
                    //acum += (entero*2)^(size - cont);
                    
                }
               cont++;
                
            }
            return acum;
        }
    
        public static string DecimalOctal (string a)
        {
            double nroDecimal = double.Parse(a);
            
            
             string octal = null;
            
            do{
            
                int entero = (int)nroDecimal / 8;
                float resto = (float)nroDecimal / 8;

                if (nroDecimal % 8 == 0)
                {
                    octal = "0" + octal;
                }
                    nroDecimal = entero;

                string aux = null;
                string acum = "0,";
                int cont = 1;
                float multiplicacionPorBase = 0;
            

                string divisionString = resto.ToString();
                int size = divisionString.Length;
            
                
                for (int i = 0; i < size; i++)
                    {
                            aux = divisionString.Substring(i, 1);
                            cont++;

                           

                                                      
                                if (aux.CompareTo(",") == 0)
                                     {
                                         for (int j = i+1; j < size; j++)
                                         {
                                         acum = acum + divisionString.Substring(j, 1);
                                         }
                             
                                        multiplicacionPorBase = float.Parse(acum);
                                        octal = (multiplicacionPorBase * 8).ToString() + octal;
                                     }
            
                     }
                
                    }while(nroDecimal>8);
          
            octal = nroDecimal.ToString() + octal;
                    
            return octal;
        }

        //public static double OctalDecimal(string a)
        //{ 
                
        
        
        
        
        
        
        
        
        //}





    }
}