using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_concesionario.Clases
{
    internal class Concesionario
    {

        internal static readonly float descto_min = 0.01f;
        internal static readonly float descto_max = 0.025f;

        private string nombre;
        private string direccion;
        private List<Venta> l_ventas;

        public Concesionario(string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            l_ventas = new List<Venta>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public void Vender_auto(Auto auto, Cliente cliente, Vendedor vendedor, ulong valor)
        {
            try
            {
                l_ventas.Add(new Venta(cliente, vendedor, auto, valor));
            }
            catch (Exception ex)
            {
                throw new Exception("ocurrió un error en vender auto \n"+ ex.ToString());
            }
        }
    }
}
