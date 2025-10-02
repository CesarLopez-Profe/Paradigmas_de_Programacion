using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Tarjeta : Pago
    {
        public enum tipo_tarjeta {Débito,Crédito}

        private string entidad;
        private ulong nro;
        private tipo_tarjeta tipo;

        public Tarjeta(string entidad, ulong nro, tipo_tarjeta tipo)
        {
            this.Entidad = entidad;
            this.Nro = nro;
            this.tipo = tipo;
        }

        public string Entidad { get => entidad; set => entidad = value; }
        public ulong Nro { get => nro; set => nro = value; }
        
        public override bool Procesar_pago(uint monto_a_pagar, uint monto_pagado)
        {
            try
            {
                //Voy  a hacer algo que no debo hacer y solo lo hago
                //con propósito explicativo

                Console.WriteLine("Conectando con Entidad...");
                Console.WriteLine("Enviando Pago....");
                Console.WriteLine("Recibiendo respuesta.....");

                if (monto_a_pagar == monto_pagado) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un error en el pago con tarjeta\n " + ex.ToString());
            }
        }
    }
}
