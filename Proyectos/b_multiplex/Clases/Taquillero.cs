using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_multiplex.Clases
{
    public class Taquillero:Persona
    {
        private int cod_interno;

        public Taquillero(string nombre, long nro_id, long nro_tel) : 
            base(nombre, nro_id, nro_tel)
        {
            cod_interno = new Random().Next(100000, 999999);
        }
    }
}
