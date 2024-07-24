using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_bicicleta.Clases
{
    internal class Bicicleta
    {
        public enum l_tamanos { S, M, L };
        public enum l_colores {Cromo, Negro, Rojo };
        public enum l_materiales {Alumnio, Fibra, Carbono };
        
        //Atributos de Propiedad
        public string marca;
        public l_tamanos tam_marco;
        public float tam_llanta;
        public byte nro_cambios;
        public l_colores color;
        public l_materiales material;

        //Atributos de Estado
        public byte cambio_actual = 1;
        public float vel_actual = 0;


        public byte Subir_cambio()
        {
            try
            {
                if (cambio_actual < nro_cambios) 
                    cambio_actual++;

                return cambio_actual;

            }
            catch(Exception error)
            {
                throw new Exception("Ocurrió un error subiendo el cambio \n" + error);
            }



        }



    }
}
