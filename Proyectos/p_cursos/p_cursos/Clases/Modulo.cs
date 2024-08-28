using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Cursos.Clases
{
    internal class Modulo
    {
        private string titulo;
        private string contenido;

        public Modulo(string titulo, string contenido)
        {
            Titulo = titulo;
            Contenido = contenido;
        }

        public string Titulo { get => titulo; set 
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El título no puede estar vacío");
                }
                else
                {
                    titulo = value;
                }
            } 
        }
        public string Contenido { get => contenido; set
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El título no puede estar vacío");
                }
                else
                {
                    contenido = value;
                }
            }
        }
    }
}

