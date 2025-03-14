using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    public abstract class Persona
    {
        private string nombre;
        private string nro_doc_id;

        protected Persona(string nombre, string nro_doc_id)
        {
            Nombre = nombre;
            Nro_doc_id = nro_doc_id;
        }

        public string Nombre
        {
            get => nombre; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    || value.Length < 10)
                    throw new Exception("El nombre no es válido");
                else
                    nombre = value;
            }



        }
        public string Nro_doc_id
        {
            get => nro_doc_id; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    || value.Length < 5)
                    throw new Exception("El número del doc_id no es válido");
                else
                    nro_doc_id = value;
            }
        }
    }
}
