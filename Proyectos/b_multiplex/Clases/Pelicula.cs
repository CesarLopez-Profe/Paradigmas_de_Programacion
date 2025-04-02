using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_multiplex.Clases
{
    public class Pelicula
    {
        private string nombre_ingles;
        private string nombre_espanol;
        private TimeSpan duracion;
        private byte edad_min;

        public Pelicula(string nombre_ingles, string nombre_espanol, 
            TimeSpan duracion, byte edad_min)
        {
            Nombre_ingles = nombre_ingles;
            Nombre_espanol = nombre_espanol;
            Duracion = duracion;
            Edad_min = edad_min;
        }

        public TimeSpan Duracion { get => duracion; 
            
            set 
            
            {
                if (value == TimeSpan.Zero)
                    throw new Exception("Error, la duración no puede ser cero");
                else
                    duracion = value;
            }
        
        }

        public string Nombre_ingles { get => nombre_ingles; set => nombre_ingles = value; }
        public string Nombre_espanol { get => nombre_espanol;

            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new Exception("Error, El nombre de la película en español no puede estar en blano " +
                        " o ser menor a dos caracteres");
                else
                    nombre_espanol = value;

            }

        }

        public byte Edad_min
        {
            get => edad_min; set
            {

                if (value < 0) throw new Exception("La edad no puede ser menor que cero");
                else edad_min = value;

            }
        }
    }
}
