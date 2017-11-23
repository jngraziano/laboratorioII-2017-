using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graziano.Julian._2D
{
    class Materia
    {
        List<Alumno> _alumnos = new List<Alumno>();
        EMateria _nombre;
        Random _notaParaUnAlumno = new Random();

        public List<Alumno> Alumno
        {
            get { return this._alumnos; }
            set{this._alumnos=value;}
        
        }
        public EMateria Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        
        }

        //public void CalificarAlumnos()
        //{ 

        
        //}

        public static  explicit operator  String(Materia materia)
        {
            string resultado;
            resultado=materia.Nombre.ToString();

            foreach(Alumno aux in materia.Alumno)
            {resultado +=aux.Nota + aux.Legajo + aux.Apellido;}
            
            
            return (resultado);
        }

        public  static implicit operator  float(Materia m)
        {
           float aux=0;

            foreach(Alumno conta in m.Alumno)
            {
                aux += conta.Nota;
            
            }
            return ((float)aux / m._alumnos.Count);
        }
        
        //private Materia()
        //{}
        private Materia()
        {
        this.Alumno =new List<Alumno>();
        
        }

        public static implicit operator Materia(EMateria nombre)
        {
            return (nombre);

        }

        private string Mostrar()
        {
            return (this.Nombre.ToString());
        
        }
        public static bool operator ==(Materia m, Alumno a)
        {
            bool verfal=false;
            foreach (Alumno aux in m.Alumno)
            {
                
                if (a.Apellido == aux.Apellido && a.Nombre == aux.Nombre)
                {
                   verfal= true;
                    
                }
                else
                {
                    verfal= false;
                    
                }
                
            }
            return verfal;
        }

        
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m==a);
        }
        public static Materia operator -(Materia m, Alumno a)
        {
           if (m == a)
                {
                    return m;

                }
                else
                {
                    m.Alumno.Remove(a);

                    return m;
                
                }
        
        }
        public static Materia operator +(Materia m, Alumno a)
        {
            
                if (m == a)
                {
                    return m;

                }
                else
                {
                    m.Alumno.Add(a);

                    return m;
                
                }
            
          }
        
        
        }


    }

