using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Cliente:Persona
    {
        private float descuento;

        public Cliente(string cedula, string nombre, float descuento) : 
            base(cedula, nombre)
        {
            Descuento = descuento;
        }

        internal float Descuento { get => descuento; 
            
            set
            {
                if (value >= Concesionario.descto_min && value <= Concesionario.descto_max)
                    descuento = value;
                else
                    throw new Exception("El valor del descuento proporcionado no es válido");
            }
       
        }
    }
}
