using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    internal abstract class Auto
    {
        private string placa;
        private string marca;
        private string modelo;
        private ushort ano;
        private ushort cilindraje;
        private byte nro_puestos;
        private byte nro_puertas;
        private uint kilometraje;

        protected Auto(string placa, string marca, string modelo, 
            ushort ano, ushort cilindraje, byte nro_puestos, byte nro_puertas, uint kilometraje)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cilindraje = cilindraje;
            this.Nro_puestos = nro_puestos;
            this.Nro_puertas = nro_puertas;
            this.Kilometraje = kilometraje;
        }

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public ushort Ano { get => ano; set => ano = value; }
        public ushort Cilindraje { get => cilindraje; set => cilindraje = value; }
        public byte Nro_puestos { get => nro_puestos; set => nro_puestos = value; }
        public byte Nro_puertas { get => nro_puertas; set => nro_puertas = value; }
        public uint Kilometraje { get => kilometraje; set => kilometraje = value; }
    }
}
