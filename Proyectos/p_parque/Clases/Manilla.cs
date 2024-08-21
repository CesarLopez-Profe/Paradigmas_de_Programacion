using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Manilla
    {
        private int id;
        private ushort sdo_ptos;

        public Manilla()
        {
            id = new Random().Next(1000000,9000000);
            Sdo_ptos = 0;
        }

        public ushort Sdo_ptos { get => sdo_ptos; set => sdo_ptos = value; }
        public int Id { get => id;  }
    }
}
