using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Televisor

    {
        public int cantCanales=10;
        //public string marca;

        public Televisor(int cantCnales)
    {
        this.cantCanales=cantCanales;
    }



        
        static void Main(string[] args)
        {
            
            
            Televisor unaTele;
            unaTele = new Televisor(1);
            unaTele.cantCanales=10;  

            Televisor OtraTele=new Televisor(2);
            OtraTele=unaTele;
            OtraTele.cantCanales=20;
            Console.WriteLine(unaTele.cantCanales);


            System.Console.ReadKey(); 
            
           
        
    }
}
}