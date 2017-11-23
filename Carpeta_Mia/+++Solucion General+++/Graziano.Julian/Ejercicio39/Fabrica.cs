using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Fabrica
    {
        private Operario[] _operarios;
        private string _razonSocial;
        int acum = 5;

        public Fabrica()
        {
        Operario[] aux=new Operario[acum];
        this._operarios=aux;
        for (int i = 0; i < acum; i++)
        {
            this._operarios[i]= new Operario();
        }
        }
        public Fabrica(string razonSocial)
            : this()
        {
            this._razonSocial=razonSocial;
        }



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nRazon Social: ");
            sb.AppendLine(this._razonSocial);
            sb.Append("\nOperarios: ");
            sb.AppendLine(this.MostrarOperarios());

            return sb.ToString();
        
        }
        //MostrarCosto (de clase): muestra la cantidad total del costo 
        //de la fábrica en concepto de salarios (utilizar el método RetornarCostos).
        public static void MostrarCosto(Fabrica fbr)
        { 
            Console.WriteLine(fbr.RetornarCostos());
        }


        //MostrarOperarios (de instancia, privado): Recorre el Array de operarios
        //de la fábrica y muestra el nombre, apellido y el salario de cada operario 
        //(utilizar el método Mostrar de operario).
        private string MostrarOperarios()
        {
            StringBuilder sb= new StringBuilder();
            for(int i=0;i<acum;i++)
            {
                
                sb.Append(this._operarios[i].Mostrar());
                 
            }
            
            return sb.ToString();
        }
        //ObtenerIndice (de instancia, privado): Devuelve el valor del primer índice „libre‟
        //(elemento en null) del Array de Operario, -1 si no encuentra ninguno.

        private int ObtenerIndice()
        {
            int valor=0;
            for(int i=0;i<acum;i++)
            {
                if(this._operarios[i].getSalario()== 1500)
                {
                    valor= i;
                    break;
                }
                else
                {
                    valor= -1;
                }
            
            }
            return valor;
        
        }
        //ObtenerIndice (de instancia, privado): Recibe un operario y retorna 
        //el índice donde se encuentra dicho operario en el Array, -1 si no está.
        private int ObtenerIndice(Operario op)
        { int valor=0;
            for(int i=0;i<acum;i++)
            {
                if(this._operarios[i] == op)
                {                
                valor=-1;
                }
                else
                {
                valor=i;
                }
            
            }
            return valor;
        
        }
       
        public static Fabrica operator -(Fabrica fbr, Operario op)
        {
            if (fbr.ObtenerIndice() == -1 && fbr == op)
            {
                fbr._operarios[fbr.ObtenerIndice()] = null;

            }

            return fbr;
        
        }
        //Operador + (Adición): Agrega un operario al Array de tipo Operario, siempre y cuando haya lugar disponible 
        //en la fábrica 
        //(utilizar el método ObtenerIndice) y el operario no se encuentre ya ingresado (utilizar sobrecarga ==)
        public static Fabrica operator +(Fabrica fbr, Operario op)
        {
                if (!(fbr.ObtenerIndice()== -1)&& fbr == op)
                {
                    fbr._operarios[fbr.ObtenerIndice()]= op;
                  
                }

                return fbr;
        
        }
        //Operador == (Igual): Retronará un booleano informando si el operario se 
        //encuentra en la fábrica o no (utilizar la sobrecarga == de operario).
        public static bool operator ==(Fabrica fbr, Operario op)
        {
            bool rta = true;
            for (int i = 0; i < 5; i++)
            {
                if (op == fbr._operarios[i])
                { rta= true; }
                else
                { rta= false; }
            }
            return rta;
        }
        public static bool operator !=(Fabrica fbr, Operario op)
        { return !(fbr == op); }


//RetornarCostos (de instancia, privado): Retorna el dinero que la fábrica tiene que gastar en concepto de salario 
        //de todos sus operarios.
        private float RetornarCostos()
        {
            float result=0;
            for(int i=0;i<acum;i++)
            {
                result+=this._operarios[i].getSalario();
            }
            return result;
        
        }



    }
}
