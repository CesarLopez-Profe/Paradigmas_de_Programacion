using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace p_Cursos.Clases
{
    internal class Curso
    {
        private string nombre;
        private string codigo;
        private string descripcion;
        private byte cupo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Profesor profesor;
        private List<Modulo> l_modulos = new List<Modulo>();
        private List<Estudiante> l_estudiantes = new List<Estudiante>();


        public Curso(string nombre, string codigo, string descripcion, byte cupo, DateTime fechaInicio, DateTime fechaFin, Profesor profesor, List<Modulo> l_modulos)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            Cupo = cupo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Profesor = profesor;
            L_modulos = l_modulos;
        }

        public Curso(string nombre, string codigo, string descripcion, byte cupo, DateTime fechaInicio, DateTime fechaFin, Profesor profesor)
        {
            Nombre = nombre;
            Codigo = codigo;
            Descripcion = descripcion;
            Cupo = cupo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Profesor = profesor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte Cupo { get => cupo; set => cupo = value; }
        public DateTime FechaInicio { get => fechaInicio; set 
            {
                if (value == DateTime.MinValue)
                {
                    throw new Exception("La fecha no puede ser nula");
                } else if (value < DateTime.Now) {

                    throw new Exception("No puede crear un curso con fecha menor a la actual");
                }
                else
                {
                    fechaInicio = value;
                }
            } 
        }
        public DateTime FechaFin
        {
            get => fechaFin; set
            {
                if (value == DateTime.MinValue)
                {
                    throw new Exception("La fecha no puede ser nula");
                }
                else if (value < FechaInicio)
                {

                    throw new Exception("No puede crear un curso con fecha menor a la actual");
                }
                else
                {
                    fechaFin = value;
                }
            }
        }
        internal Profesor Profesor { get => profesor; set => profesor = value; }
        internal List<Modulo> L_modulos { get => l_modulos; set => l_modulos = value; }
        internal List<Estudiante> L_estudiantes { get => l_estudiantes; set => l_estudiantes = value; }

        public bool insertar_modulo(Modulo modulo)
        {
            try
            {
                if (DateTime.Now > FechaInicio)
                {
                    return false;
                }
                else
                {
                    l_modulos.Add(modulo);
                    return true;
                }
            
            }catch(Exception e) 
            {
                throw new Exception("Error al insertar módulo: " + e);
            }
        }


    }

    
}
