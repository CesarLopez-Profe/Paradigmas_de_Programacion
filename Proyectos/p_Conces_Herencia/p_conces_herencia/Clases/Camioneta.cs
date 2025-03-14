using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    public class Camioneta : Automovil
    {

        private bool doble = false;
        private byte nro_explo;

        private const byte nro_explo_min = 1;
        private const byte nro_explo_max = 7;

        public byte Nro_explo
        {
            get => nro_explo; set

            {
                if (value < nro_explo_min || value > nro_explo_max)
                    throw new Exception("El nro de exploradoras no es válido");
                else
                    nro_explo = value;
            }

        }



        public Camioneta(string placa, string marca, string modelo, ushort ano, ushort cilindraje
            , byte nro_puestos, l_nro_puertas nro_puertas, bool doble, byte nro_explo)
            : base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas)
        {
            this.doble = doble;
            Nro_explo = nro_explo;
        }

    }
}