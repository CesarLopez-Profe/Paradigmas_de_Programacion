using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Membresia : Pago
    {
        private ulong nro;
        private Socio socio;

        public Membresia(ulong nro, Socio socio)
        {

            this.Nro = nro;
            this.socio = socio;
        }

        public ulong Nro { get => nro; set => nro = value; }
        
        public override bool Procesar_pago(uint monto_a_pagar, uint monto_pagado)
        {
            try
            {
                //Voy  a hacer algo que no debo hacer y solo lo hago
                //con propósito explicativo

                Console.WriteLine("Conectando con Base de Datos Membresías...");
                Console.WriteLine("Enviando Solciitud de Pago....");
                Console.WriteLine("Recibiendo respuesta .....");

                return monto_a_pagar == monto_pagado?true:false;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un error en el pago con tarjeta\n " + ex.ToString());
            }
        }
    }
}
