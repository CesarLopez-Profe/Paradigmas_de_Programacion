using p_estud_int_pol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_estud_int_pol.Clases
{
    internal class Posgrado:Estudiante, IEstudiantePosgrado
    {
        internal string programa;

        public Posgrado(string nombre, string programa):base(nombre)
        {
            this.programa = programa;
        }

        public void EscribirTesis(string tema)
        {
            Console.WriteLine($"El estudiante {nombre} está escribiendo una tesis sobre {tema}");
        }
        public bool SustentarTesis(DateTime hora)
        {
            Random alea=new Random();
            if (alea.Next(1, 9) % 2==0) return true;
            else return false;

        }

        public override string PresentarPrueba(String tema)
        {
            if (new Random().Next(0, 5) < 3.5)
                return $"Perdió la prueba de {tema}";
            else
                return $"Ganó la prueba de {tema}";
        }

    }
}
