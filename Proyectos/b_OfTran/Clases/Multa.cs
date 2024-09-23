using b_OfTran.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_OfTran.Clases
{
    internal abstract class Multa:ISancion
    {
        protected Conductor conductor;
        protected DateTime fecha_hora;
        private ulong valor;
        protected ulong codigo;
        protected string infraccion_cometida;

        internal ulong Valor { get => valor; set => valor = value; }

        protected Multa(Conductor conductor)
        {
            this.conductor = conductor;
        }

        public abstract ulong Imponer_sancion_economica();

        
    }
}
