using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Agua:Producto
    {
        private ushort cont_cc;

        public Agua(string descripcion, uint valor, ushort cont_cc) : base(descripcion, valor)
        {
            this.cont_cc = cont_cc;
        }
    }
}
