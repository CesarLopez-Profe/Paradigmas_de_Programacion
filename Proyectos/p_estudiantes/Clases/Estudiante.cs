using p_estudiantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_estudiantes.Clases
{
    internal abstract class Estudiante : ISer_Estudiante
    {
        public string Estudiar()
        {
            return ("Estoy estudiando, padre");
        }

        public virtual string Exponer()
        {
            return ("Estoy Exponiendo, padre");
        }

        public abstract string Matricular_materias();
        
    }
}
