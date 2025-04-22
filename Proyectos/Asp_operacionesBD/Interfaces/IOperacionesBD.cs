using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_operacionesBD.Interfaces
{
    public interface IOperacionesBD
    {
        void Crear();
        void Leer();
        void Actualizar();
        void Eliminar();

    }
}
