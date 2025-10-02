using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Crispeta:Producto
    {
        internal enum enum_sabor {Saladas, Dulces, Combinadas };

        private enum_sabor sabor;

        public Crispeta(string descripcion, uint valor, enum_sabor sabor) 
            : base(descripcion, valor)
        {
            this.sabor = sabor;
        }
    }
}
