using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    internal class Concesionario
    {
        private string nombre;
        private string direccion;
        private List<Venta> l_ventas;

        //atr de validación
        private readonly byte long_min_nom = 5, long_min_dir = 10;

        public Concesionario(String nombre, String direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            l_ventas = new List<Venta>();

        }

        public string Nombre { get => nombre;

            set => nombre = !String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value) || value.Length >= long_min_nom ? value :
                throw new Exception($"La longitud del nombre debe ser mayor a: {long_min_nom} caracteres");
        }
        public string Direccion { get => direccion; 
            set => direccion = !String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value) || value.Length >= long_min_dir ? value :
                throw new Exception($"La longitud de la dirección debe ser mayor a: {long_min_dir} caracteres");
        }
        internal List<Venta> L_ventas { get => l_ventas; }

        public bool VenderAuto(List<Persona> l_personas, Automovil auto, ulong valor)
        {

            try
            {
                l_ventas.Add(new Venta(l_personas, auto, valor));
                return true;                
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool VenderAuto(Venta venta)
        {
            try
            {
                l_ventas.Add(venta);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
