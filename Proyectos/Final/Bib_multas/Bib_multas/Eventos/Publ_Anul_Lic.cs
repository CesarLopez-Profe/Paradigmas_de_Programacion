using Bib_multas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_multas.Eventos
{
    internal class Publ_Anul_Lic
    {
        internal delegate void dele_anul_lic();
        internal event dele_anul_lic evt_anul_lic;

        public string Informar_Anula_Lic(Conductor conductor)
        {
            if (evt_anul_lic != null)
                return $"licencia anulada al condutor {conductor.ToString()}";
            else
                throw new Exception("El método se debe llamar desde un evento suscrito");
        }

    }
}
