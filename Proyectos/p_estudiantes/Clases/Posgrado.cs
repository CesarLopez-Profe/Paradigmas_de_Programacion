using p_estudiantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_estudiantes.Clases
{
    internal class Posgrado : Estudiante, IEstudiar_Posgrado
    {
        public override string Matricular_materias()
        {
            return ("Me estoy matriculando");
        }

        public override string Exponer()
        {
            return ("Estoy exponiendo desde hijo");
        }

        public string Escribir_tesis()
        {
            return ("estoy encartado escribiendo la tesis");
        }

        public string Sustentar_tesis()
        {
            return ("Estoy sustentando la tesis");
        }
    }
}
