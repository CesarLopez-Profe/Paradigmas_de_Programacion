using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Lampara.Clases
{
    internal class Lampara
    {
        public enum l_colores { negro, cromo, rojo };
        public enum l_voltajes { V110, V220 };
        public enum l_bombillas { Led, Halogena };

        public string marca;
        public l_colores color;
        public l_voltajes voltaje;
        private uint dur_hor_bombilla;
        public l_bombillas tipo_bombilla;
        private float long_cable;

        //atributos de estado
        private string cod_tablero;
        private bool encendida = false;

        public uint Dur_hor_bombilla { get => dur_hor_bombilla;
            set {
                if (value < 500000 || value > 1000000)
                    throw new Exception("Error en las horas de duracion bombilla");
                else
                    dur_hor_bombilla = value;
            }

        }

        public float Long_cable { get => long_cable;

            set {

                if (value < 1.5f || value > 4.5f)
                    throw new Exception("Error en la long del cable");
                else
                    long_cable = value;
            } 
        }

        public string Cod_tablero { get => cod_tablero;  }
        public bool Encendida { get => encendida;  }

        public Lampara(string marca, l_colores color, l_voltajes voltaje,
            uint dur_hor_bombilla, l_bombillas tipo_bombilla, float long_cable)
        {
            this.marca = marca;
            this.color = color;
            this.voltaje = voltaje;
            Dur_hor_bombilla = dur_hor_bombilla;
            Long_cable = long_cable;
            this.tipo_bombilla = tipo_bombilla;
           
        }

        public void Encender()
        {
            try
            {
                if (!encendida)
                    encendida = true;
            }

            catch (Exception error)
            {
                throw new Exception("Ocurrió un error al encender la lampara \n" + error);
            }

        }

        public bool Cambiar_bombilla()
        {
            try
            {
                if (encendida)
                    return false;
                else
                    return true;

            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error cambiando bombilla \n" + e);
            }

        }

        public void Apagar()
        {
            try
            {
                if (encendida)
                    encendida = false;

            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el metodo apagar" + e);
            }
        }

        public bool Cambiar_cable(float long_cable)
        {
            try
            {
                // Verificar si la longitud del cable está dentro del rango válido
                if (long_cable >= 1.5 && long_cable <= 4.5)
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {
                throw new Exception("Error al cambiar el cable: " + e.Message);
            }

        }

        public void Asignar_tablero(string cod_tablero)
        {
            try
            {
                if (String.IsNullOrEmpty(cod_tablero) || String.IsNullOrWhiteSpace(cod_tablero)
                    || cod_tablero.Length <= 6)
                    throw new Exception("Usuario: el código del tablero no cumple los requisitos");
                else
                    this.cod_tablero = cod_tablero;
            }
            catch (Exception e)
            {
                throw new Exception("Error al asignar tablero: " + e.Message);
            }

        }

    }
}
