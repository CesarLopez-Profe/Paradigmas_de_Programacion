using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p_estud_int_pol.Interfaces
{
    internal interface IEstudiantePosgrado
    {
        void EscribirTesis(string tema);
        bool SustentarTesis(DateTime hora);
    }
}
