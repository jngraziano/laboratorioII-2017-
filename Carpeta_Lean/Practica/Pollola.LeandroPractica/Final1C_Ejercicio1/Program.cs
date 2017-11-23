using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public int Intermedio(int num_1, int num_2, int num_3)
        {
            if ((num_1 < num_2 && num_1 > num_3) || (num_1 > num_2 && num_1 < num_3)) { return num_1; }
            else if ((num_2 < num_1 && num_2 > num_3) || (num_2 > num_1 && num_2 < num_3)) { return num_2; }
            else if ((num_3 < num_1 && num_3 > num_2) || (num_3 > num_1 && num_3 < num_2)) { return num_3; }
            else { return 0; }
        }
    }
}
