using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_OfTran.Clases
{
    public class Transito
    {
        
        private List<Multa> l_multas;
       
        private static ushort ptos_resta_men = 1000;
        private static ulong valr_sal_min = 1300000;
        private static byte cant_salmin_men = 3;
        private static byte cant_salmin_may = 15;
        private static byte cant_hor_trabsoc = 2;

        internal static ushort Ptos_resta_men { get => ptos_resta_men;  }
        internal static ulong Valr_sal_min { get => valr_sal_min; }
        internal static byte Cant_salmin_men { get => cant_salmin_men; }
        internal static byte Cant_salmin_may { get => cant_salmin_may;  }
        internal static byte Cant_hor_trabsoc { get => cant_hor_trabsoc;  }

        public enum l_multas_men { Mal_Estacionado, Luces, Exceso_Velocidad_N1 };
        public enum l_multas_may { soat_vencido, tecnico_mecanica_vencida, Manejar_embriagado };
        public enum l_trab_soc { Servicio_Biblioteca, Servicio_Parques, Asistencia_ciclovías };

        public Transito()
        {
            l_multas = new List<Multa>();
        }

        public ulong[] Calcular_valor_acum_Multas()
        {
            try
            {
                ulong[] v_acumulados = { 0, 0 };

                foreach(Multa multa in l_multas)
                {
                    if (multa is Mayor)
                        v_acumulados[0] += multa.Valor;
                    else
                        v_acumulados[1] += multa.Valor;
                }

                return v_acumulados;

            }

            catch(Exception ex)
            {
                throw new Exception("Error en calculo valor multas \n" + ex);
            }
        }
    }
}
