using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_multas.Clases
{
    public class Transito
    {
        private List<Multa> l_multas;
        internal static readonly ulong val_sal_minimo = 1423500;
        private string direccion;
        private ulong telefono;
        private readonly uint val_nro_tel = 999999;

        public Transito(string direccion, ulong telefono)
        {
            l_multas = new List<Multa>();
            Direccion = direccion;
            Telefono = telefono;
        }

        public ulong Val_sal_minimo { get => val_sal_minimo;            
        }
        public string Direccion { get => direccion; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La direccion no puede ser nulo o estar en blanco");
                else
                    direccion = value;
            }
        }
        public ulong Telefono { get => telefono; 
            set
            {
                if (value < val_nro_tel)
                    throw new Exception("Telefono incorrecto");
                else
                    telefono = value;
            }
        }

        public List<Multa> L_multas { get => l_multas; set => l_multas = value; }
    
    
        public ulong[] Totalizar_multas()
        {
            try
            {
                ulong[] total_multas = new ulong[2] { 0, 0 };

                foreach(Multa m in l_multas)
                {
                    if (m is Mayor)
                        total_multas[0] += m.Valor;
                    else if (m is Menor)
                        total_multas[1] += m.Valor;
                }

                return total_multas;
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Totalizar_multas " + e);
            }
        }
    }
}
