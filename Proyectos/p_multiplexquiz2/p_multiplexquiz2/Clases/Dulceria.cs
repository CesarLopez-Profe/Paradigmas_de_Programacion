using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    internal class Dulceria
    {
        private bool abierta;
        private List<Producto> l_productos_vende;

        public Dulceria(List<Producto> l_productos_vende)
        {
            abierta = true;
            this.l_productos_vende = l_productos_vende;
        }

        public string VenderProducto(List<Producto> l_productos_vta)
        {
            try
            {
                if (abierta)
                {
                    string detalle = string.Join("",
                        l_productos_vta
                        .GroupBy(p => p.Descripcion)
                        .Select(g => $"{g.Count()} {g.Key}:{g.Sum(p => (decimal)p.Valor).ToString("C0")}  \n"));

                    decimal totalVenta = l_productos_vta.Sum(p => (decimal)p.Valor);

                    return detalle + "\n Total Venta " + totalVenta.ToString("C0");
                }
                else
                    throw new Exception("La dulcería está cerrada");
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado en la dulcería");
            }
        }
    }
}
