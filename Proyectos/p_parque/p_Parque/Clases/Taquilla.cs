using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Parque.Clases
{
    internal class Taquilla
    {
        //atributos usuario
        private byte id;
        
        //atributos de estado
        private List<Manilla> l_manillas;
        private ulong saldo;

        //atributos de validación
        private readonly byte cant_manillasxtaq = 100;
        private readonly ushort monto_min = 20000, montoxpto=500, val_entrada=4000;
        

        public Taquilla (byte id)
        {
            this.id = id;
            l_manillas = new List<Manilla> ();
            saldo = 0;
        }

        public byte Id { get => id;
            set => id = value == 1 || value == 2 || value == 3 ? value: throw new Exception($"Id taquilla {value} no es válido"); } //corregir el quemado
        public ulong Saldo { get => saldo; set => saldo = value; }
        internal List<Manilla> L_manillas { get => l_manillas; 
            set => l_manillas = value.Count==cant_manillasxtaq?value:throw new Exception($"La cantidad de manillas {value.Count} no es válida"); }
    
        /* TAREA 1
         * public Manilla VenderManilla(ulong monto)
        {
            try
            {
               //0.verifico si hay manillas
                //1.verifico el monto exacto
               //2.calculo los puntos para elmonto, descontando la entrada
               //3.agrego los puntos a la manilla
               //devuelvo manilla
            }
            catch (Exception e)
            {
                throw new Exception($"ocurrió excepcion en VenderManilla\n {e.ToString}");
            }
        }
        */

        //TAREA 2 
        //método que recargue la manilla, devuelve un bool, recibe un monto, no descuenta la entrada
    
    }



}
