using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ev_Notas.Eventos;

namespace Ev_Notas.Clases
{
    internal class Registro
    {
        internal const float p1 = 0.25f;
        internal const float p2 = 0.25f;
        internal const float p3 = 0.25f;
        internal const float p4 = 0.25f;

        //Se instancia la clase publicadora
        internal Publisher_Becas publicador;

        //Método para manejar el evento
        internal void EventHandler(){}
        

        internal float Calcular_Nota(float n1, float n2, float n3, float n4)
        {
            float nota_final = 0;

            if (n1 >= 0 && n1 <= 5
                && n2 >= 0 && n2 <= 5
                && n3 >= 0 && n3 <= 5
                && n4 >= 0 && n4 <= 5
                )
            {
                nota_final = n1 * p1 + n2 * p2 + n3 * p3 + n4 * p4;

                //se instancia evento
                publicador = new Publisher_Becas();
                //Se suscribe al evento
                publicador.evt_beca += EventHandler;

                //invoca los eventos
                publicador.Informar_Beca_Superior(nota_final);
                publicador.Informar_Beca_Excelencia(nota_final);

                return nota_final;
            }
            else throw new Exception("Datos notas, no válidos");
        }
        
        


    }
}
