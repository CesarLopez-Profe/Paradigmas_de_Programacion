using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_Concesionario
{
    public class Automovil
    {
        //atributos de usuario
        private string marca;
        private string modelo;
        private ulong precio;
        private string placa;

        //atributos de validación de reglas
        private const byte long_marca = 3, long_modelo = 3, long_placa = 6;
        private const ulong precio_min = 80000000;

        //atributos de estado

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
            set => marca = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= long_marca) ? 
                value : throw new Exception("Nombre Automóvil No Válido");
        }
        public string Modelo { get => modelo; 
            set => modelo = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= long_modelo) ?
                value : throw new Exception("Modelo Automóvil No Válido");
        }
        public ulong Precio { get => precio; 
            set => precio = (value < precio_min) ? throw new Exception("Precio Automóvil No Válido"): value; }
        public string Placa { get => placa; 

            set => placa = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length != long_placa ||
            value.Substring(0, 2).ToCharArray().Any(c => !char.IsLetter(c)) 
            || value.Substring(3, 2).ToCharArray().Any(c => !char.IsNumber(c))) ? value : throw new Exception("Formato de la placa No Válido"); 
        
        
        }
    }
}