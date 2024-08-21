using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Taquilla
    {
        private byte id;
        private List<Manilla> l_manillas;
        private ulong saldo_ventas;

        public Taquilla(byte id, List<Manilla> l_manillas)
        {
            this.Id = id;
            this.L_manillas = l_manillas;
            saldo_ventas = 0;
        }

        public byte Id { get => id;

            set {
                if (value < 1 || value > Parque.cant_taquillas)
                    throw new Exception("El id de la taquilla no es válido. Debe ser entre 1 y 3");
                else
                    id = value;
                
            } 
        }
        internal List<Manilla> L_manillas { get => l_manillas;

            set {
                if (value.Count != Parque.cant_man_entr_taq)
                    throw new Exception("La cantidad de manillas no es válida " + value.Count + "\n");
                else
                    l_manillas = value;
            } 
        
        }

        public Manilla Vender_manilla(ulong dinero)
        {
            try
            {
                //validar: dinero es mayor que la cantidad minima            
                Manilla manilla_ret;

                if (dinero >= Parque.vlr_min_carga &&
                    L_manillas.Count > 0 && dinero%Parque.vlr_punto==0)
                {
                    manilla_ret = L_manillas.ElementAt(0);
                    L_manillas.RemoveAt(0);
                    manilla_ret.Sdo_ptos = (ushort)((dinero - Parque.vlr_entrada) / Parque.vlr_punto);
                    return manilla_ret;
                }
                else
                    throw new Exception("Revisar dinero puede ser insuficiente o no es multiplo de "  + Parque.vlr_punto +
                        " o no hay manillas");
                
                
                //todo está bien, saco la manilla de la lista de manilla 
                //de la taquilla y la devuelvo
            }

            catch(Exception ex)
            {
                throw new Exception("Ocurrió un error vendiendo manillas \n"+
                    ex);
            }   
        }
    }
}
