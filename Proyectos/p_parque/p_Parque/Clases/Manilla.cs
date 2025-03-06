using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Parque.Clases
{
    internal class Manilla
    {
        private static uint id = 100000;
        private uint saldo_ptos;

        public Manilla()
        {
            id+=1;
            saldo_ptos = 0;
        }

        public uint Id { get => id;  }
        public uint Saldo_ptos { get => saldo_ptos;  }

        internal void RestarSaldo(byte ptos) 
        {
                try
                {
                    saldo_ptos -= ptos;
                }
                catch(Exception ex) 
                { 
                        throw new Exception( $"Excepción no esperada en el método actualizar_saldo {ex.Message}");
                }
        }

    }
}
