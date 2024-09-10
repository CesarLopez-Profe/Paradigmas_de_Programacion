using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Deportivo:Auto
    {

        private bool coupe = true;
        private bool descapotable = true;


        public Deportivo(string placa, string marca, l_modelos modelo, ushort ano, 
            ushort cilindraje, byte nro_puestos, l_nro_ptas nro_puertas, 
            bool coupe, bool descapotable) : 
            base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas)
        {
            Coupe = coupe;
            Descapotable = descapotable;
        }

        //tarea
        protected bool Coupe { get => coupe; set => coupe = value; }
        protected bool Descapotable { get => descapotable; set => descapotable = value; }

    }
}
