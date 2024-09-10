using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Vendedor:Persona
    {

        internal float comision;

        public Vendedor(string cedula, string nombre, float comision) : 
            base(cedula, nombre)
        {
            Comision = comision;
        }

        //tarea
        protected float Comision { get => comision; set => comision = value; }
    
    }
}
