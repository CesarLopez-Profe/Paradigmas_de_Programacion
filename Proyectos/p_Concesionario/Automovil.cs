using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_Concesionario
{
    public class Automovil
    {
        private string marca;
        private string modelo;
        private ulong precio;
        private string placa;

        public Automovil(string marca, string modelo, ulong precio, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Placa = placa;
        }

        public string Marca
        {
            get => marca;
            set => marca = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= 3) ? 
                value : throw new Exception("Nombre Automóvil No Válido");
        }
        public string Modelo { get => modelo; 
            set => modelo = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= 3) ?
                value : throw new Exception("Modelo Automóvil No Válido");
        }
        public ulong Precio { get => precio; 
            set => precio = (value < 80000000) ? throw new Exception("Precio Automóvil No Válido"): value; }
        public string Placa { get => placa; 

            set => placa = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length != 6 ||
            value.Substring(0, 2).ToCharArray().Any(c => !char.IsLetter(c))) ? value : throw new Exception("Formato de la placa No Válido"); 
        
        
        }
    }
}