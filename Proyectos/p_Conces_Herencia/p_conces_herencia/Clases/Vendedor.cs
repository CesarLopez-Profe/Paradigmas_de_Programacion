using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    internal class Vendedor : Persona
    {
        private float comision;
        private float por_com_inf = 0.015f;
        private float por_com_sup = 0.02f;

        public Vendedor(string nombre, string nro_doc_id, float comision) 
            : base(nombre, nro_doc_id)
        {
            Comision = comision;
        }

        public float Comision { get => comision;

            set
            {
                if (value < por_com_inf || value > por_com_sup)
                    throw new Exception("Error en el porcentaje de la comisión");
                else
                    comision = value;

            }   }
    }
}
