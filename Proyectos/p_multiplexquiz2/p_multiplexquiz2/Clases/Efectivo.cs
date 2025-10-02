using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Efectivo:Pago
    {
        Efectivo() { }

        //Quebrar el polimorfismo
        public override bool Procesar_pago(uint monto_a_pagar, uint monto_pagado)
        {
            throw new NotImplementedException();
        }
        public new uint Procesar_pago(uint monto_a_pagar, uint monto_pagado)
        {
            try
            {
                if (monto_a_pagar < monto_pagado)
                    return monto_pagado - monto_a_pagar;
                else
                    return 0;
            }

            catch (Exception ex)
            {
                throw new Exception("Hubo un error en el pago con tarjeta\n " + ex.ToString());
            }
        }

    }
}
