using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Parque
    {
        private string nombre;
        private List<Atraccion> l_atracciones;
        private List<Registro> l_registros;
        private List<Taquilla> l_taquillas;       
        private List<Manilla> l_manillas;

        internal static uint vlr_entrada = 4000;
        internal static uint vlr_min_carga = 20000;
        internal static uint vlr_punto = 500;
        private const ushort cant_man_entr_taq = 100;
        private const ushort cant_man_parque = 1000;
        private const byte cant_atracc = 10;
        private const byte cant_taquillas = 3;

        public Parque(string nombre, List<Atraccion> l_atracciones)
        {
            this.Nombre = nombre;
            this.L_atracciones = l_atracciones; 
            //la lista de registros vacía
            l_registros = new List<Registro>();

            //crear la lista de manillas
            l_manillas = Generar_manillas();
            
            //creación de taquillas
            for(byte i=1; i<=cant_taquillas; i++)
            {
                l_taquillas.Add(Crear_taquilla(i));
            }

        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Atraccion> L_atracciones { get => l_atracciones;
            set {
                if (value.Count == cant_atracc)
                    l_atracciones = value;
                else
                    throw new Exception("La lista debe contener exactamente " + cant_atracc
                        + " atracciones");
            } 
        }

        private List<Manilla> Generar_manillas()
        {
            try
            {
                List<Manilla> l_manillas_ret = new List<Manilla> ();

                for(int i=1; i<=cant_man_parque; i++ )
                {
                    l_manillas_ret.Add(new Manilla());
                }
                return l_manillas_ret;

            }
            catch (Exception e) {
                throw new Exception("Error generando las manillas \n" + e);
            }
        }

        private Taquilla Crear_taquilla(byte id)
        {
            try
            {
                
                List<Manilla> l_manillas_taq = new List<Manilla>();
                for(byte i = 1; i<=cant_man_entr_taq; i++)
                {
                    l_manillas_taq.Add(l_manillas.ElementAt(0));
                    l_manillas.RemoveAt(0);
                }
                return new Taquilla(id, l_manillas_taq);
            }
            
            catch (Exception e)
            {
                throw new Exception("Error generando las manillas \n" + e);
            }

        }
    }
}
