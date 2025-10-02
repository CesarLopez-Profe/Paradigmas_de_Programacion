using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    public class Multiplex
    {
        public enum tipo_sillas {G,V};
        
        private string nombre;
        private List<Sala> l_salas;
        private List<Taquilla> l_taquillas;
        internal Dulceria dulceria;
        
        //atributos de clase
        internal static float descto_soc_m_j = 0.5f;
        internal static float descto_soc_otros_dias = 0.25f;
        internal static int vlr_bol_g = 20000;
        internal static int vlr_bol_v = 35000;
        internal static byte cant_max_vta_bol = 10;
        internal static TimeSpan aseo = new TimeSpan(0, 20, 0), cortos = new TimeSpan(0, 15, 0);

        internal List<Sala> L_salas { get => l_salas;  }
        internal List<Taquilla> L_taquillas { get => l_taquillas;  }

        public Multiplex(string nombre, List<Producto> l_productos_vende)
        {
            Nombre = nombre;
            l_salas = new List<Sala>();
            l_taquillas = new List<Taquilla>();
            dulceria = new Dulceria(l_productos_vende);
        }

        public string Nombre { get => nombre; set {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new Exception("Error, El nombre de la persona no puede estar en blanco " +
                        " o ser menor a dos caracteres");
                else
                    nombre = value;
            
            }

        }

        public bool Agregar_sala(Sala sala)
        {
            try
            {
                if(l_salas.Contains(sala)||l_salas.Count==12) 
                    return false;
                else
                {
                    l_salas.Add(sala);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
            
        }

        public bool Agregar_taquilla(Taquilla taquilla)
        {
            try
            {
                if (l_taquillas.Contains(taquilla)||l_taquillas.Count==5)
                    return false;
                else 
                {
                    
                    l_taquillas.Add(taquilla);
                    return true;
                }
                
            }
            catch (Exception)
            {
                return false;
            }


        }

        public bool Abrir_Taquilla(Taquilla taquilla)
        {
            try
            {
                
                foreach(Taquilla elem in l_taquillas)
                {
                    if(elem.Nro == taquilla.Nro)
                    {
                        if (!elem.Abierta) elem.Abierta = true;
                        return true;
                    }
                        

                }
                return false;                

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
