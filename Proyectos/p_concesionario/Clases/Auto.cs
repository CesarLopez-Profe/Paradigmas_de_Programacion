using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal abstract class Auto
    {
        public enum l_modelos {Rio, Forte, K5 };
        public enum l_nro_ptas { dos, tres, cuatro, cinco };

        private string placa;
        private string marca;
        protected l_modelos modelo;
        private ushort ano;
        private ushort cilindraje;
        private byte nro_puestos;
        protected l_nro_ptas nro_puertas;
        protected uint kilometraje = 0;

        
        protected Auto(string placa, string marca, l_modelos modelo, ushort ano, ushort cilindraje, 
            byte nro_puestos, l_nro_ptas nro_puertas)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.modelo = modelo;
            this.Ano = ano;
            this.Cilindraje = cilindraje;
            this.Nro_puestos = nro_puestos;
            this.nro_puertas = nro_puertas;
        }

        protected string Placa { get => placa; set => placa = value; }
        protected string Marca { get => marca; set => marca = value; }
        protected ushort Ano { get => ano; set => ano = value; }
        protected ushort Cilindraje { get => cilindraje; set => cilindraje = value; }
        protected byte Nro_puestos { get => nro_puestos; set => nro_puestos = value; }

    }
}
