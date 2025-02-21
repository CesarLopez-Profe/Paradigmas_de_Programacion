using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_bicicleta.Clases
{
    internal class Bicicleta
    {
        public enum l_tam_marco  {S,M,L,XL};
        public enum l_materiales {Carbono, Aluminio, Titanio };
        public enum l_colores { Negro, Blanco, Gris};

        //Atributos de Usuario
        private l_tam_marco tam_marco;
        private float tam_llanta;
        private l_materiales material;
        private byte cant_cambios;
        private l_colores color;

        //Atributos reglas de negocio
        private const byte camb_min = 1, camb_max = 8;
        private const float tam_ll_min = 16, tam_ll_max = 18.5f;
        private const byte cant_cam_min = 6, cant_cam_max = 8;

        //Atributos de estado
        private byte cambio_actual = 1;
        private bool en_movimiento = false;

        /*public float Tam_llanta { get => tam_llanta; 
            set { 
                if (value < tam_ll_min || value > tam_ll_max)
                    throw new Exception("El tamaño de la llanta no es válido");
                else 
                    tam_llanta = value;  
            }
        }*/

        public float Tam_llanta
        {
            get => tam_llanta; 
            set { tam_llanta = value < tam_ll_min || value > tam_ll_max 
                    ? throw new Exception("El tamaño de la llanta no es válido") : value ; }
        }

        public byte Cant_cambios { get => cant_cambios;
            set
            {
                if (value < cant_cam_min || value > cant_cam_max)
                    throw new Exception("La cantidad de cambios no es válida");
                else
                    cant_cambios = value;
            }
        }

        internal l_tam_marco Tam_marco { get => tam_marco; set => tam_marco = value; }
        internal l_materiales Material { get => material; set => material = value; }
        internal l_colores Color { get => color; set => color = value; }
        public byte Cambio_actual { get => cambio_actual; }
        public bool En_movimiento { get => en_movimiento;  }

        public Bicicleta() { }
        public Bicicleta(l_tam_marco tam_marco, float tam_llanta, 
            l_materiales material, byte cant_cambios, l_colores color)
        {
            Tam_marco = tam_marco;
            Tam_llanta = tam_llanta;
            Material = material;
            Cant_cambios = cant_cambios;
            Color = color;
        }

        public Bicicleta(l_tam_marco tam_marco, float tam_llanta)
        {
            this.tam_marco = tam_marco;
            this.Tam_llanta = tam_llanta;
        }

        /*public void Subir_cambio()
        {
            try
            {
                if (cambio_actual < cant_cambios) cambio_actual++;
            }
            catch (Exception e) {
                throw new Exception("Error en el método subir cambio");
            }

        }*/

        public byte Subir_cambio() => cambio_actual < camb_max && en_movimiento ? cambio_actual++ : cambio_actual;
        public byte Bajar_cambio() => cambio_actual > camb_min && en_movimiento ? cambio_actual-- : cambio_actual;
        public bool Rodar() => !en_movimiento ? en_movimiento = true : en_movimiento;
        public bool Frenar() => en_movimiento ? en_movimiento = false : en_movimiento;





    }
}
