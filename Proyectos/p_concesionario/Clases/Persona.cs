using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal abstract class Persona
    {
        private string cedula;
        private string nombre;


        public Persona(string cedula, string nombre)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
        }

        //queda de tarea
        protected string Cedula { get => cedula;

            set {
                if (value.Length >= 5 && !String.IsNullOrEmpty(value)
                    && !String.IsNullOrWhiteSpace(value))
                    cedula = value;
                else
                    throw new Exception("Revise la cédula");
            } 
        
        }
        protected string Nombre { get => nombre; set => nombre = value; }
    }
}
