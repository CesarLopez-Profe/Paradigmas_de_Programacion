using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p_conces_herencia.Clases
{
    internal class Venta
    {
        private List<Persona> l_personas;
        private Automovil auto;
        private ulong valor;

        private DateTime fecha;
        private ulong val_vta_min = 60000000;
        private byte persxvta = 2;

        public Venta(List<Persona> l_personas, Automovil auto, ulong valor)
        {
            this.L_personas = l_personas;
            this.auto = auto;
            this.Valor = valor;
            fecha = DateTime.Now;
        }

        public List<Persona> L_personas { get => l_personas;

            set {
                bool hay_cliente = false, hay_vendedor = false;
                //Validar que la lista de personas sea ==2 y un vendedor y un cliente
                if (value.Count() == persxvta)
                {
                    //recorro la lisa para saber si hay un vendedor y un cliente
                    foreach (Persona pers in value)
                    {
                        if (pers is Cliente) hay_cliente = true;
                        else if (pers is Vendedor) hay_vendedor = true;
                    }

                    if (hay_cliente && hay_vendedor) l_personas = value;
                    else throw new Exception("La lista debe tener un vendedor y un cliente");
                }
                else throw new Exception($"La lista debe tener {persxvta} Personas");

            }
        }
        public ulong Valor { get => valor;

            set => valor = value >= val_vta_min ? value :
                throw new Exception($"El valor de la venta debe ser mayor a: ${val_vta_min}"); 
        }

        public override string ToString()
        {
            string txt_retornar = "";

            txt_retornar += $"El automovil vendido fue: {auto.Marca}  {auto.Modelo} \n";
            txt_retornar += $"Por un valor de: {valor} \n";
            foreach (Persona pers in l_personas)
            {
                if (pers is Vendedor)
                    txt_retornar += $"Vendedor: {pers.Nombre} \n";
                else
                    txt_retornar += $"Comprador: {pers.Nombre} \n";
            }

            return txt_retornar;            
        }
        
    }
    
}
