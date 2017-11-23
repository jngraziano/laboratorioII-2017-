using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianGraziano_Final_LaboratorioII
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Punto Dos
           
            Stack<Double> obj = new Stack<double>();

            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj = (Stack<Double>)obj.Reverse();
                       

            #endregion 

            #region Punto Tres
            Producto producto1 = new Producto("Lavandina",200);
            Producto producto2 = new Producto("Mouse", 300);
            Deposito deposito1 = new Deposito(producto1);
            Deposito deposito2 = new Deposito(producto2);
            
            //deposito1.array + deposito2.array;



            #endregion

            #region Punto Cuatro
            Producto pro = new Producto("Pala", 22);
            Prodimpuesto pI = new Prodimpuesto(pro.nombre, pro.stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");
           

            #endregion

            #region Punto Siete
            //realizado en la clase galpon
            #endregion

            #region Punto Nueve
            deposito1.lista.Add(pro);
            deposito1.lista.Add(pI);
            deposito1.lista.Add(pEX);
            deposito1.lista.Add(p);
            Galpon unGalpon = new Galpon(1,deposito1);

            
            #endregion
        }
    }
}
