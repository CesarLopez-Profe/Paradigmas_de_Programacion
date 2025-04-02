using b_multiplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_multiplex.Clases
{
    public class Sala:IEfectos
    {
        private byte nro;
        private short nro_sillas_v;
        private short nro_sillas_g;
        private short nro_sill_ven_v = 0;
        private short nro_sill_ven_g = 0;
        private string efectos;

        public Sala(byte nro, short nro_sillas_v, short nro_sillas_g)
        {
            Nro = nro;
            Nro_sillas_v = nro_sillas_v;
            Nro_sillas_g = nro_sillas_g;
        }

        internal byte Nro { get => nro; set
            {
                if (value <= 0 || value >12) throw new Exception("Error en el nro de la sala");
                else nro = value;
            }

        }
        internal short Nro_sillas_v { get => nro_sillas_v; set
            {
                if (value <= 0) throw new Exception("Error en el nro de sillas vip");
                else nro_sillas_v = value;
            }
        }
        internal short Nro_sillas_g { get => nro_sillas_g; set
            {
                if (value <= 0) throw new Exception("Error en el nro de sillas general");
                else nro_sillas_g = value;
            }
        }
        internal short Nro_sill_ven_v { get => nro_sill_ven_v;
            set {
                if (value > 0 && (nro_sill_ven_v + value) <= nro_sillas_v)
                    nro_sill_ven_v += value;
                else
                    throw new Exception("No especificó el número de sillas o " +
                        "no se pueden vender el nro de sillas solicitado para VIP, " +
                        "no hay suficientes sillas");
            } 
        }
        internal short Nro_sill_ven_g { get => nro_sill_ven_g; 
            
            set {
                if (value > 0 && (nro_sill_ven_g + value) <= nro_sillas_g)
                    nro_sill_ven_g += value;
                else
                    throw new Exception("No especificó el número de sillas o " +
                         "no se pueden vender el nro de sillas solicitado para GENERAL, " +
                         "no hay suficientes sillas");

            }

        }

        public string Efectos { get => efectos;  }

        public bool EquiparEfectos(string efectos)
        {
            try
            {
                this.efectos = efectos;
                return true;

            }
            catch(Exception ex)
            {
                throw new Exception($"Error equipando efectos \n{ex}");
            }
        }

        public override bool Equals(object? obj)
        {
            var sala_in = obj as Sala;

            if(sala_in != null)
            {
                return sala_in.Nro == nro;
            }
            return false;

        }


    }
}
