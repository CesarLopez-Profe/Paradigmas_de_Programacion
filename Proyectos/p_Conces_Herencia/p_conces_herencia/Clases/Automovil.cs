using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    public abstract class Automovil
    {
        public enum l_nro_puertas {p2, p3, p5};

        private string placa;
        private string marca;
        private string modelo;
        private ushort ano;
        private ushort cilindraje;
        private byte nro_puestos;
        private l_nro_puertas nro_puertas;

        private const uint  kilometros = 0;
        private const ushort cil_menor = 1000;
        private const ushort cil_mayor = 6000;
        private ushort ano_mayor = (ushort)(DateTime.Now.Year + 2);
        private const byte nro_puestos_min = 2;
        private const byte nro_puestos_max = 7;
        

        public Automovil(string placa, string marca, string modelo, 
            ushort ano, ushort cilindraje, byte nro_puestos, l_nro_puertas nro_puertas)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cilindraje = cilindraje;
            Nro_puestos = nro_puestos;
            this.nro_puertas = nro_puertas;

        }

        public string Placa
        {
            get => placa; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    || value.Length != 6)
                    throw new Exception("Valores de placa no válidos");
                else
                    placa = value;


            }
        }

        public string Marca { get => marca; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    || value.Length <3)
                    throw new Exception("Valores para la marca no válidos");
                else
                    marca = value;
            }
        }

        public string Modelo
        {
            get => modelo; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Valores para el modelo no válidos");
                else
                    modelo = value;
            }
        }


        public ushort Ano { get => ano;

            set {

                if (value < DateTime.Now.Year || value > ano_mayor)
                    throw new Exception("Los valores para el año no son válidos");
                else
                    ano = value;

            } 
        }

        public ushort Cilindraje { get => cilindraje; set {

                if (value < cil_menor || value > cil_mayor)
                    throw new Exception("El valor del cilindraje no es válido");
                else
                    cilindraje = value;
            
            } 
        
        }
        public byte Nro_puestos { get => nro_puestos; set
            {
                if (value < nro_puestos_min || value > nro_puestos_max)
                    throw new Exception("El valor del nro de puestos no es válido");
                else
                    nro_puestos = value;

            }
        }
        
    }
}
