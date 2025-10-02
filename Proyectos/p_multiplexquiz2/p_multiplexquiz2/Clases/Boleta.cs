using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Boleta
    {
        private static int consecutivo=1000;
        private Funcion funcion;
        private Persona persona;
        private int valor;

        public Boleta(Funcion funcion, Persona persona, Multiplex.tipo_sillas clase)
        {
            consecutivo++;
            this.funcion = funcion;
            this.persona = persona;

            if (persona is Socio
                && (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday 
                || DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                && clase == Multiplex.tipo_sillas.G)

                valor = (int)(Multiplex.vlr_bol_g * Multiplex.descto_soc_m_j);

            else if (persona is Socio
                && !(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday 
                || DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                && clase == Multiplex.tipo_sillas.G)

                valor = (int)(Multiplex.vlr_bol_g * Multiplex.descto_soc_otros_dias);

           else if (persona is Socio
                && (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday || DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                && clase == Multiplex.tipo_sillas.V)

                valor = (int)(Multiplex.vlr_bol_v * Multiplex.descto_soc_m_j);

            else if (persona is Socio
                && !(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday || DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                && clase == Multiplex.tipo_sillas.V)

                valor = (int)(Multiplex.vlr_bol_v * Multiplex.descto_soc_otros_dias);

            else if (!(persona is Socio) && clase == Multiplex.tipo_sillas.G)
                valor = Multiplex.vlr_bol_g;

            else if (!(persona is Socio) && clase == Multiplex.tipo_sillas.V)
                valor = Multiplex.vlr_bol_v;

        }

        public int Consecutivo { get => consecutivo;  }
        public int Valor { get => valor;  }
        public Funcion Funcion { get => funcion;  }
        public Persona Persona { get => persona;  }
    }
}
