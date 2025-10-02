using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    public class Socio:Persona
    {
        private int nro_vip;

        public Socio(string nombre, long nro_id, long nro_tel) : 
            base(nombre, nro_id, nro_tel)
        {
            nro_vip = new Random().Next(100000, 999999);
        }
    }
}
