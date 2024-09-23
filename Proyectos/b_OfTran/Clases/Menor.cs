using b_OfTran.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_OfTran.Clases
{
    internal class Menor : Multa, ISancionMenor
    {
        public Menor(Conductor conductor) : 
            base(conductor)
        {

        }

        public uint Restar_ptos()
        {
            try
            {
                //restar los puntos menores del conductor
                conductor.Total_ptos -= Transito.Ptos_resta_men;
                //retornar los puntos con los que queda el conductor
                return conductor.Total_ptos;
            }
            catch (Exception ex)
            {
                throw new Exception("falla restando puntos \n" + ex);
            }
        }

        public override ulong Imponer_sancion_economica()
        {
            try
            {
                //salario minimo * cant salarios menores
                ulong total_sancion = Transito.Valr_sal_min * Transito.Cant_salmin_men;
                //retorna el anterior valor
                return total_sancion;
            }
            catch (Exception ex)
            {
                throw new Exception("Falla calculando sancion menor \n" + ex);
            }
        }

    }
}
