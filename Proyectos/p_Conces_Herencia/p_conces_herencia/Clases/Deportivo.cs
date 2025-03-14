using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    public class Deportivo : Automovil
    {
        private bool coupe=true;
        private bool descapotable = true;

        public Deportivo(string placa, string marca, string modelo, ushort ano, ushort cilindraje, 
            byte nro_puestos, l_nro_puertas nro_puertas, bool coupe, bool descapotable) : 
            base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas)
        {
            this.coupe = coupe;
            this.descapotable = descapotable;   

        }
    }
}
