using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Atraccion
    {
        private string nombre;
        private byte puntos;
        private TimeSpan duracion;

        public Atraccion(string nombre, byte puntos, TimeSpan duracion)
        {
            this.Nombre = nombre;
            this.Puntos = puntos;
            this.Duracion = duracion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Puntos { get => puntos; set => puntos = value; }
        public TimeSpan Duracion { get => duracion; 
            
            set
            {
                if (value >= Parque.min_min_atr && value <= Parque.min_max_atr)
                    duracion = value;
                else
                    throw new Exception("Duración no permitida para las atracciones");
            }
        
        }

        public bool Descontar_puntos(Manilla manilla, Parque parque) /*dos formas: lista estatica o mandar el paeque como arg*/
        {
            try
            {
                //si los puntos de la manilla es mayor o igual a los puntos
                //de la atracción, descuento los puntos de la atracción a la 
                //manilla, genero el registro y retornar true
                if(manilla.Sdo_ptos>=puntos)
                {
                    manilla.Sdo_ptos-=puntos;
                    parque.L_registros.Add(new Registro(this, manilla));

                    return true;
                }

                //de lo contrario, return false.
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error Descontando puntos \n" +
                    ex);
            }

        }

 /*       public string Descontar_puntos(Manilla manilla)
        {
            try
            {
                //si los puntos de la manilla es mayor o igual a los puntos
                //de la atracción, descuento los puntos de la atracción a la 
                //manilla y retornar mensaje junto con los puntos de la manilla

                //de lo contrario, return mensaje saldo insuficiente.

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error Descontando puntos sobrecargado \n" +
                    ex);
            }

        }*/


    }
}
