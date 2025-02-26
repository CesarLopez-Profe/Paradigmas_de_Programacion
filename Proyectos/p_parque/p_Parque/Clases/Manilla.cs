using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Parque.Clases
{
    internal class Manilla
    {
        private uint id;
        private uint saldo_ptos;

        public Manilla()
        {
            id = (uint) new Random().Next(100000,9999999);
            saldo_ptos = 0;
        }

        public uint Id { get => id;  }
        public uint Saldo_ptos { get => saldo_ptos;  }

        internal bool ActualizarSaldo()

    }
}
