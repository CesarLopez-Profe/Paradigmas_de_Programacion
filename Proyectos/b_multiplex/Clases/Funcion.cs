using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_multiplex.Clases
{
    public class Funcion
    {
        private static int consecutivo=1;
        private Sala sala;
        private Pelicula pelicula;
        private DateTime hora_inicio;
        private DateTime hora_final;

        public Funcion(Sala sala, Pelicula pelicula, DateTime hora_inicio)
        {
            consecutivo++;
            this.sala = sala;
            this.pelicula = pelicula;
            this.hora_inicio = hora_inicio;
            hora_final = hora_inicio + Multiplex.aseo + Multiplex.cortos + pelicula.Duracion;
        }

        public int Consecutivo { get => consecutivo;  }
        public DateTime Hora_inicio { get => hora_inicio;  }
        public DateTime Hora_final { get => hora_final;  }
        internal Sala Sala { get => sala; }
        internal Pelicula Pelicula { get => pelicula; }
    }
}
