using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Registro
    {
        private Atraccion atraccion;
        private Manilla manilla;
        private DateTime hora_ingr;

        public Registro(Atraccion atraccion, Manilla manilla)
        {
            this.atraccion = atraccion;
            this.manilla = manilla;
            hora_ingr = DateTime.Now;
        }
    }
}
