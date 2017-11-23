using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameBoligrafo
{
    class Boligrafo
    {
        private string _marca;
        private string _color;
        private int _cantidadTinta;
        List<Boligrafo> ListaBoligrafos =new List<Boligrafo>();

    public Boligrafo()
    {
        this._cantidadTinta=0;
    
    }
    
    public Boligrafo(string marca):this()
        {
            this._marca = marca;
        
        }
    public Boligrafo(string marca, string color):this(marca)
        {
            this._color = color;
        
        }
    public Boligrafo(string marca, string color, int cantidadtinta):this(marca, color)
        {
            this._cantidadTinta =cantidadtinta;
        
        }
    public Boligrafo(int cantidadtinta, string color, string marca):this(marca, color)
    {
        this._cantidadTinta = cantidadtinta;

    }
    

        
    public void Escribir(int CantidadNecesaria)
    {
        
        if (CantidadNecesaria > this._cantidadTinta)
        {
            Console.WriteLine("La cantidad almacenada no es suficiente");
            this.Mostrar();

        }
        else
        {
            this._cantidadTinta = this._cantidadTinta - CantidadNecesaria;
        }
    }
    private void Mostrar()
    {
        Console.WriteLine("{0}\n{1}\n{2}\n", this._marca, this._color, this._cantidadTinta);
        Console.ReadKey();
    }
    public static void MostrarBoligrafos(List<Boligrafo> ListaBoligrafos)
    {
        foreach(Boligrafo valor in ListaBoligrafos)
        {
            valor.Mostrar();
        
        }
    
    }

    public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo unPen)
    {
        foreach (Boligrafo valor in lista)
        {
            if (valor == unPen)
            {
                lista.Remove(unPen);
                return lista;
            }
            else { Console.WriteLine("No se encontro igual"); return lista;}

        }
        return lista;
    }
    public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo unPen)
    {
        lista.Add(unPen);
        return lista;
    }
    public static bool operator ==(Boligrafo unPen, Boligrafo otroPen)
    {
        if (unPen._marca == otroPen._marca && unPen._color == otroPen._color)
        {
            return true;

        }
        else { return false; }

    }
    public static bool operator !=(Boligrafo unPen, Boligrafo otroPen)
    {
        return !(unPen == otroPen);     
    }
    public bool RecargarTinta ()
    {
        if (this._cantidadTinta < 50)
        {
            this._cantidadTinta = 100;
            return true;
        
        }
        else { return false; }
    }
    public bool RecargarTinta(int cantidad)
    {
        if (this._cantidadTinta > 50)
        {
            this._cantidadTinta = this._cantidadTinta + cantidad;
            return true;
        }
        else { return false; }
    }
 




       
    }
}
