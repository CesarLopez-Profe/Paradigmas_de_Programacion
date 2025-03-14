using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    internal class Venta
    {
        private List<Persona> l_personas;
        private Automovil automovil;
        private DateTime fecha;
        private ulong valor;

        private readonly ulong val_min = 60000000;

        public Venta(List<Persona> l_personas, Automovil automovil, ulong valor)
        {
            L_personas = l_personas;
            this.automovil = automovil;
            Valor = valor;

            fecha = DateTime.Now;
        }

        public List<Persona> L_personas { get => l_personas; 
        
            set {
                byte cont_vend=0, cont_cli=0;
                foreach (Persona p in value)
                {
                    if (p is Vendedor)
                        cont_vend++;
                    else if (p is Cliente)
                        cont_cli++;
                }

                if (value.Count < 2 || cont_vend != 1 || cont_cli != 1)
                    throw new Exception("Debe haber al menos dos personas en la venta");
                else
                    l_personas = value;

            } 
            
            }
        public Automovil Automovil { get => automovil;  }
        public ulong Valor { get => valor; 
            set => valor = value >= val_min?valor = value
            :throw new Exception("El valor de la venta no es válido");
        } 

         


    }
  
}
