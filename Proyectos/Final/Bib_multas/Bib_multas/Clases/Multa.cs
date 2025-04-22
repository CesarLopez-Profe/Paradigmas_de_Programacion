using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bib_multas.Interfaces;

namespace Bib_multas.Clases
{
    public abstract class Multa : ISancionEconomica
    {
        protected Conductor sancionado;
        protected Vehiculo vehiculo;
        protected ulong valor;
        protected DateTime fecha_hora;
        protected ulong consecutivo; 

        public Multa(Conductor sancionado, Vehiculo vehiculo)
        {
            Random r = new Random();

            this.sancionado = sancionado;
            this.vehiculo = vehiculo;        
            fecha_hora = DateTime.Now;
            consecutivo = (ulong)(r.Next(100000, 999999));
            
        }

        public Conductor Sancionado { get => sancionado; }
        public Vehiculo Vehiculo { get => vehiculo; }
        public ulong Valor { get => valor; set => valor = value; }
        public DateTime Fecha_hora { get => fecha_hora; set => fecha_hora = value; }
        public ulong Consecutivo { get => consecutivo; set => consecutivo = value; }
        public abstract ulong Calcular_sancion();   
    }
}
