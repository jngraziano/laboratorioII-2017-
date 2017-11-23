using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;


        public Rectangulo(Punto vertice1, Punto vertice3)
            {
                
                this.vertice1 = vertice1;
                this.vertice3 = vertice3;

                this.vertice2 = new Punto(this.vertice1.getX(), this.vertice3.getY());
                this.vertice4 = new Punto(this.vertice1.getY(), this.vertice3.getX());

                this.lado = Math.Abs(this.vertice1.getX() - this.vertice3.getY());
             
                this.perimetro = this.lado*4;   
             
                this.area = this.lado*this.lado;
            }



    }







}
