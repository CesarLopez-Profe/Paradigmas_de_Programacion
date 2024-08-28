using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Cursos.Clases
{
    internal class Profesor
    {
        private string nombre;
        private byte edad;
        private string correo;
        private string labor;

        public Profesor(string nombre, byte edad, string correo, string labor)
        {
            Nombre = nombre;
            Edad = edad;
            Correo = correo;
            Labor = labor;
        }

        public string Nombre { get => nombre; set 
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre no puede estar vacío");
                }
                else
                {
                    nombre = value;
                }
            } 
        }
        public byte Edad { get => edad; set 
            {
                if (value > 100)
                {
                    throw new Exception("Edad incorrecta");
                }
                else
                {
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
            } }
        public string Labor { get => labor; set {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("la labor no puede estar vacía");
                }
                else
                {
                    labor = value;
                }
            } 
        }
    }
}
