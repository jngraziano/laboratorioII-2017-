using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arrai = new Int32[27];

            for (int i = 0; i < arrai.Length; i++)
            {
                arrai[i] = i;
                
            
            }

            for (int i = arrai.Length-1; i >=0; i--)
            {
                if (arrai[i] % 7 == 0&&arrai[i]!=0)
                {
                    Console.WriteLine(i);
                
                }
            }
            Console.ReadLine();
        
        }
    }
}
