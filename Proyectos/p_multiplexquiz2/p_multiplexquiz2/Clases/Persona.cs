using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    public abstract class Persona
    {
        private string nombre;
        private long nro_id;
        private long nro_tel;

        public Persona(string nombre, long nro_id, long nro_tel)
        {
            Nombre = nombre;
            Nro_id = nro_id;
            Nro_tel = nro_tel;
        }

        public string Nombre { get => nombre; set
            {
                if (string.IsNullOrEmpty(value) 
                    || string.IsNullOrWhiteSpace(value) 
                    || value.Length < 2)
                    throw new Exception("Error, El nombre de la persona en español no puede estar en blanco " +
                        " o ser menor a dos caracteres");
                else
                    nombre = value;

            }
        }
        public long Nro_id { get => nro_id;

            set
            {
                if (value <= 0)
                    throw new Exception("Error, número de id no debe ser menor o igual a cero ");
                else
                    nro_id = value;

            }

        }
        public long Nro_tel { get => nro_tel; set
            {
                if (value <= 0 || value.ToString().Length!=10)
                    throw new Exception("Error, número de tel no debe ser menor o igual a cero o tener menos de 10 números");
                else
                    nro_tel = value;

            }
        }
    }
}
