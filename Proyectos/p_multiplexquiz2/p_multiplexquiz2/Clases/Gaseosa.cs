using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Gaseosa:Producto
    {
        internal enum enum_tamano {Grande, Mediana, Pequeña };

        private enum_tamano tamano;

        public Gaseosa(string descripcion, uint valor, enum_tamano tamano) : base(descripcion, valor)
        {
            this.tamano = tamano;
        }
    }
}
