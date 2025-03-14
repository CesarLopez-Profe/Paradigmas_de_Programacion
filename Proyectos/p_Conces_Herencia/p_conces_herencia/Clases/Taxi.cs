using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    public class Taxi:Automovil
    {
        private string nro_tarjeta;
        private string empresa;

        public Taxi(string placa, string marca, string modelo, ushort ano, 
            ushort cilindraje, byte nro_puestos, l_nro_puertas nro_puertas,
            string nro_tarjeta, string empresa) 
            : base(placa, marca, modelo, ano, cilindraje, nro_puestos, nro_puertas)
        {
            Empresa = empresa;
            Nro_tarjeta = nro_tarjeta;
        }

        public string Nro_tarjeta { get => nro_tarjeta; 
            
            set {
                    if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) 
                    || value.Length <5)
                        throw new Exception("Valores de tarjeta no válidos");
                    else
                        nro_tarjeta = value;
                }

        }
        public string Empresa { get => empresa; 
            
            set 
                {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) 
                    || value.Length < 6)
                    throw new Exception("Valores de empresa no válidos");
                else
                    empresa = value;

            }

        }
    }
}
