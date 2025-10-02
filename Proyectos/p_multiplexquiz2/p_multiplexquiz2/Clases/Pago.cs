using p_multiplexquiz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal abstract class Pago: IPago
    {
        private uint monto_pagado;
        private DateTime fecha_pago;

        public Pago()
        {

        }

        public abstract bool Procesar_pago(uint monto_a_pagar, uint monto_pagado);
    }
}
