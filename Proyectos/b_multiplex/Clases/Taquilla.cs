using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_multiplex.Clases
{
    public class Taquilla
    {
        private byte nro;
        private Taquillero taquillero;
        private bool abierta = false;
        private List<Venta> l_ventas;

        public Taquilla(byte nro, Taquillero taquillero)
        {
            Nro = nro;
            this.taquillero = taquillero;
            abierta = true;
            //instanciar una lista para poder operarla
            l_ventas = new List<Venta>();
        }

        public byte Nro { get => nro; set
            {
                if (value <= 0 || value > 5) throw new Exception("Error en el nro de la taquilla");
                else nro = value;
            }
        
        }
        public bool Abierta { get => abierta; set => abierta = value; }
        internal Taquillero Taquillero { get => taquillero; }
        internal List<Venta> L_ventas { get => l_ventas; }

        public string Vender_boleta(Funcion funcion, byte cantidad, Multiplex.tipo_sillas tipo_silla, Persona persona)
        {
            try
            {
                string tirilla_boletas="";
                Boleta bol;

                if (abierta && cantidad > 0 && cantidad <= Multiplex.cant_max_vta_bol
                    && funcion.Hora_inicio >= DateTime.Today)
                {
                    
                    for(byte i = 1; i <= cantidad; i++)
                    {
                        //Se crea cada boleta
                        bol = new Boleta(funcion, persona, tipo_silla);
                        //se crea la venta de cada boleta y se guarda en la lista de ventas de la taquilla
                        l_ventas.Add(new Venta(taquillero, bol));
                        //Se concatena a la tirilla que se va a retornar, la info de la boleta
                        tirilla_boletas += ("\n-------------------------------------------------------"
                        + "\nBoleta nro: " + bol.Consecutivo
                        + "\nSala: " + bol.Funcion.Sala.Nro
                        + "\nPelicula: " + bol.Funcion.Pelicula.Nombre_espanol
                        + "\nFecha: " + bol.Funcion.Hora_inicio.ToShortDateString()
                        + "\nHora de Inicio: " + bol.Funcion.Hora_inicio.ToShortTimeString()
                        + "\n-------------------------------------------------------\n");

                        //Se suma uno a la cantidad de boletas según la clase en esa sala vendidas para esa sala
                        if (tipo_silla == Multiplex.tipo_sillas.V) funcion.Sala.Nro_sill_ven_v = 1;
                        else if (tipo_silla == Multiplex.tipo_sillas.G) funcion.Sala.Nro_sill_ven_g = 1;


                    }

                    return tirilla_boletas;
                }

                else
                    throw new Exception("No se registro la venta de las boletas por una de las siguientes situaciones: " +
                        "La taquilla está cerrada, o la cantidad de boletas a comprar no es correcta o la fecha de la " +
                        "función no está vigente");


            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el método vender boleta\n" + e );
            }
        }


        public override bool Equals(object? obj)
        {
            var taquilla_in = obj as Taquilla;

            if (taquilla_in != null)
            {
                return taquilla_in.Nro == nro;
            }
            return false;

        }

    }
}
