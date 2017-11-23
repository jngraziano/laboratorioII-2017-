using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianGraziano_Final_LaboratorioII
{
    class Comparadora
    {
  
        public bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio)
        {
            if( tres<dos && tres>uno)
            {
                
                elDelMedio=tres;
                return true;
            }
            else
            {elDelMedio = 0; return false;}

        }
    
    }
}
