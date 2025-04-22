using asp_operacionesBD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_operacionesBD.Clases
{
    public class OperaBDOracle:IOperacionesBD
    {
        public void Crear()
        {
            Console.WriteLine("Usando BD Oracle \n" +
                "Validando los datos del usuario....\n" +
                "Validando la integridad\n " +
                "Datos creados Ok");
        }

        public void Leer()
        {
            Console.WriteLine("Usando BD Oracle \n" +
                "Validando los datos del usuario....\n" +
                "Devolviendo los datos");
        }


        public void Actualizar()
        {
            Console.WriteLine("Usando BD Oracle \n" +
                "Validando los datos del usuario....\n" +
                "Validando la integridad de los nuevos datos\n " +
                "Datos actualizados Ok");
        }

        public void Eliminar()
        {
            Console.WriteLine("Usando BD Oracle \n" +
                "Validando los datos del usuario....\n" +
                "Buscando registro a eliminar\n " +
                "Datos eliminados Ok");
        }
    }
}
