using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Taxi:Auto
    {
        private string tarjeta_ope;
        private string empresa;

        public Taxi(string placa, string marca, l_modelos modelo, ushort ano, ushort cilindraje, byte nro_puestos, 
            l_nro_ptas nro_puertas, string tarjeta_ope, string empresa) : 
            base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas)
        {
            Tarjeta_ope = tarjeta_ope;
            Empresa = empresa;
        }

        protected string Tarjeta_ope { get => tarjeta_ope; set => tarjeta_ope = value; }
        protected string Empresa { get => empresa; set => empresa = value; }
    }
}
