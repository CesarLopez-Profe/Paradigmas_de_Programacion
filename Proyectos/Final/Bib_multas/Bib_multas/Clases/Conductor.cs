using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_multas.Clases
{
    public class Conductor
    {
        public enum tipos_id { CC, TI, CE, PAS};
        public enum estados_licencia { Activa, Suspendida};

        private tipos_id tipo_id;
        private string id;
        private string nombre;
        private byte edad;
        private ulong num_licencia;
        private estados_licencia estado_licencia;
        private uint total_puntos = 5000;
        private readonly byte long_min_id = 3, edad_min=18;

        public Conductor(tipos_id tipo_id, string id, string nombre, byte edad)
        {
            Random aleatorio = new Random();

            this.tipo_id = tipo_id;

            Id = id;          
            Nombre = nombre;
            Edad = edad;
            num_licencia = (ulong)aleatorio.Next(100000, 999999);
            Total_puntos = total_puntos;
            estado_licencia = estados_licencia.Activa;
        }

        public string Id { get => id; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < long_min_id)
                    throw new Exception($"El id del conductor no puede ser vacio o tener menos de {long_min_id} caracteres");
                else
                    id = value;
            }
        }
        public string Nombre { get => nombre; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre no puede ser nulo o estar en blanco");
                else
                    nombre = value;
            }
        }
        public byte Edad { get => edad; 
            set
            {
                if (value < edad_min)
                    throw new Exception($"La edad debe ser mayor o igual a {edad_min}");
                else
                    edad = value;
            }
        }
        public ulong Num_licencia { get => num_licencia; }
        public uint Total_puntos { get => total_puntos; 
            set
            {
                if (value < 0)
                    throw new Exception("El total de puntos no puede ser menor a 0");
                else
                    total_puntos = value;
            }
        }

        public estados_licencia Estado_licencia { get => estado_licencia; set => estado_licencia = value; }

        public override string ToString()
        {
            return nombre + " - ID: " + tipo_id.ToString() +"-"+ id;
        }
    }
}
