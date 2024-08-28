using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Cursos.Clases
{
    internal class Estudiante
    {
        private string nombre;
        private byte edad;
        private string correo;

        public Estudiante(string nombre, byte edad, string correo)
        {
            Nombre = nombre;
            Edad = edad;
            Correo = correo;
        }

        public string Nombre { get => nombre; set 
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El título no puede estar vacío");
                }
                else
                {
                    nombre = value;
                }
            } }
        public byte Edad { get => edad; set 
            { 
                if(value > 100)
                {
                    throw new Exception("Edad incorrecta");
                }
                else { 
                    edad = value;
                    }
            } }
        public string Correo { get => correo; set 
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El correo no puede estar vacío");
                }
                else
                {
                    correo = value;
                }
            } 
        }

        public bool inscribirse (Curso curso)
        {
            try 
            {
                if(DateTime.Now > curso.FechaInicio || curso.L_estudiantes.Count == curso.Cupo) 
                {
                    return false;
                }
                else
                {
                    curso.L_estudiantes.Add(this);
                    return true;
                }

                
            }catch(Exception e) 
            {
                throw new Exception("Error en el método inscribirse: " + e);
            }
        }

    }
}
