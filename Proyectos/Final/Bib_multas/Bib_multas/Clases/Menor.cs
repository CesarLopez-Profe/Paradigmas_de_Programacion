using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bib_multas.Interfaces;

namespace Bib_multas.Clases
{
    public class Menor : Multa, IRestaPuntos
    {
        public enum inf_menores { Mal_estacionado, contravía, semaforo_en_rojo};
        private inf_menores inf_menor;
        private readonly byte cant_sal_min =3;
        private readonly ushort ptos_a_restar = 1000;
        public Menor(Conductor sancionado, Vehiculo vehiculo, inf_menores inf_menor) : base(sancionado, vehiculo) 
        {
            this.inf_menor = inf_menor;
            Valor = Calcular_sancion();
        }

        public override ulong Calcular_sancion()
        {
            try
            {
                return (Transito.val_sal_minimo * cant_sal_min);
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Calcular Sancion en la clase Menor " + e);
            }
        }

        public uint Restar_puntos()
        {
            try
            {
                if (Sancionado.Total_puntos >= ptos_a_restar)
                    return (Sancionado.Total_puntos - ptos_a_restar);
                else
                    throw new Exception("El sancionado no tiene suficientes puntos para restarle");             
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrio un error en el metodo Restapuntos de la clase Menor " + e);
            }
        }

        public override string ToString()
        {
            return inf_menor + " " + Valor;
        }
    }
}
