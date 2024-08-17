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
            this.id = id;
            this.l_manillas = l_manillas;
            saldo_ventas = 0;
        }

        public Manilla Vender_manilla(ulong dinero)
        {
            try
            {
                //validar: dinero es mayor que la cantidad minima            
                Manilla manilla_ret;

                if (dinero >= Parque.vlr_min_carga &&
                    l_manillas.Count > 0)
                {
                    manilla_ret = l_manillas.ElementAt(0);
                    l_manillas.RemoveAt(0);
                    manilla_ret.Sdo_ptos = (ushort)((dinero - Parque.vlr_entrada) / Parque.vlr_punto);
                    return manilla_ret;
                }
                else
                    throw new Exception("Dinero insuficiente, o no hay manillas");
                
                
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
