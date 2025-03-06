using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Parque.Clases
{
    internal class Parque
    {
        
        //atributos de usuario
        private string nombre;

        //atributos de estado
        private bool abierto;
        internal static List<Registro> l_registros;
        private List<Taquilla> l_taquillas;
        private List<Atraccion> l_atracciones;
        private List<Manilla> l_manillas;
        
        //atributos de control o validacion
        private readonly byte long_min_nom = 5, cant_total_atrac = 10, cant_tot_taq = 3, cant_man_taq = 100;
        private readonly ushort cant_tot_man = 1000;

        public Parque(string nombre, List<Atraccion> l_atracciones)
        {
            this.Nombre = nombre;
            
            L_atracciones = l_atracciones;
            l_registros = new List<Registro>();
            l_manillas = new List<Manilla>();
            l_taquillas = new List<Taquilla>();

            for (short i = 1; i <= cant_tot_man; i++) { l_manillas.Add(new Manilla()); }

            for (byte i = 1; i <= cant_tot_taq; i++)
            { 
                    l_taquillas.Add(new Taquilla(i)); 
                    EnviarManillas(l_taquillas.Find(taq=>taq.Id==i));
                    //EnviarManillas(l_taquillas[length-1]);
            }
            abierto = true;

        }

        public string Nombre { get => nombre; 
            
            set => nombre = nombre = !(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length < long_min_nom)
                ? value : throw new Exception($"El nombre {value} no es válido");
        }
        internal List<Atraccion> L_atracciones { get => l_atracciones;
            set => l_atracciones = value.Count == cant_total_atrac ? value : 
                throw new Exception($"La lista de atracciones no cumple con el tamaño, debe ser {cant_total_atrac} y su lista tenía {value.Count}"); }
        internal List<Taquilla> L_taquillas { get => l_taquillas;  }
        internal List<Atraccion> L_atracciones1 { get => l_atracciones;  }
        internal List<Manilla> L_manillas { get => l_manillas; }

        public bool EnviarManillas(Taquilla taquilla)
        {
            try
            {

                if (l_manillas.Count >= cant_man_taq && taquilla.L_manillas.Count == 0)
                {
                    for (byte i = 1; i <= cant_man_taq; i++)
                    {
                        taquilla.L_manillas.Add(l_manillas[0]);
                        l_manillas.RemoveAt(0);
                    }
                    return true;
                }
                else return false;

            }

            catch(Exception ex) {

                throw new Exception($"Ocurrió un error no esperado en Enviar Manillas \n{ex}");

            }
        }
    
    
    }
}
