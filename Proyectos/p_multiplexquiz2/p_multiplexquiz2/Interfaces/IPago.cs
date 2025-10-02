using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Interfaces
{
    internal interface IPago
    {
        bool Procesar_pago(uint monto_a_pagar, uint monto_pagado);
    }
}
