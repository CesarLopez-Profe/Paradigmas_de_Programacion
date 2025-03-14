using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    internal class Cliente:Persona
    {
        private float descto;
        private float por_desc_inf = 0.01f;
        private float por_desc_sup = 0.025f;


        public Cliente(string nombre, string nro_doc_id, float descto) 
            : base(nombre, nro_doc_id)
        {
            Descto = descto;
        }

        public float Descto { get => descto;

            set
            {
                if (value < por_desc_inf || value > por_desc_sup)
                    throw new Exception("Error en el porcentaje del descuento");
                else
                    descto = value;

            }


        }
    }
}
