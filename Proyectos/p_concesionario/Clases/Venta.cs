using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Venta
    {
        private List<Persona> l_personas;
        private Auto auto;
        private ulong valor;
        private DateTime fecha;

        public Venta(List<Persona> l_personas, Auto auto, ulong valor)
        {
            this.l_personas = l_personas; //pasar por accesor que valide que vengan dos elementos en la lista y que uno sea vend y otro clte
            this.auto = auto;
            this.valor = valor;
        }

        public Venta(Cliente cliente, Vendedor vendedor, Auto auto, ulong valor)
        {
            l_personas = new List<Persona>();
            l_personas.Add(cliente);
            l_personas.Add(vendedor);
            this.auto = auto;
            this.valor = valor;
        }
    }
}
