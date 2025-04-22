using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_Notas.Eventos
{
    internal class Publisher_Becas
    {
        internal delegate void delegado_nota(); //En este caso, el delegado no devuelve nada ni tiene parámetros
        internal event delegado_nota evt_beca;
        float min_nota_beca_s = 4.95f;
        float min_nota_beca_e = 4.7f;

        public void Informar_Beca_Superior(float nota)
        {
            if(evt_beca != null)
            {
                evt_beca();
                if (nota >= min_nota_beca_s)
                {
                    Console.WriteLine( "Gana Beca Superior");
                }

            }
            else
            {
                Console.WriteLine( "No se ha suscrito al evento");
            }
        }
        public void Informar_Beca_Excelencia(float nota)
        {
            if (evt_beca != null)
            {
                evt_beca();
                if (nota >= min_nota_beca_e && nota < min_nota_beca_s)
                {
                    Console.WriteLine("Gana Beca Excelencia");
                }

            }
            else
            {
                Console.WriteLine("No se ha suscrito al evento");
            }
        }


    }
}
