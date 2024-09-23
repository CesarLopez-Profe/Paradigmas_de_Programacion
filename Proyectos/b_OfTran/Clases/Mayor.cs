using b_OfTran.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static b_OfTran.Clases.Transito;

namespace b_OfTran.Clases
{
    internal class Mayor : Multa, ISancionMayor
    {
        public Mayor(Conductor conductor) : 
            base(conductor)
        {

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

        public string Imponer_trab_social()
        {
            try
            {
                //hacer un random entre 1 y 3
                byte ts_alea = (byte)(new Random().Next(0,3));
                //buscar el random el enum de trabajo social 
                l_trab_soc ts_elegido = (l_trab_soc)(ts_alea);
                //convertimos el valor del enum en un string y lo retornamos
                return ts_elegido.ToString();

                
                
            }
            catch (Exception ex)
            {
                throw new Exception("falla restando puntos \n" + ex);
            }
        }

        public string Anular_licencia()
        {
            try
            {
                if (conductor.Estado_lic == Conductor.l_estados_li.Suspendida)
                    return "La licencia de este conductor estaba suspendida";
                else
                {
                    //ir al conductor, cambiar el licencia por anulada
                    conductor.Estado_lic = Conductor.l_estados_li.Suspendida;
                    //retorna string con mensaje
                    return "La licencia queda suspendida exitosamente";

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Falla anulando licencia \n" + ex);
            }
        }
    }
}
