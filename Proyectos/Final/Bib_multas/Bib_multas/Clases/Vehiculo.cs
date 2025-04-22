using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib_multas.Clases
{
    public class Vehiculo
    {
        private string placa;
        private string marca;
        private string modelo;
        private DateTime ano;
        private readonly ushort ano_inic = 1930, ano_fin = (ushort)(DateTime.Today.Year + 2);

        public Vehiculo(string placa, string marca, string modelo, DateTime fecha_hora)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Fecha_hora = fecha_hora;

        }

        public string Placa { get => placa; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La placa no puede ser nulo o estar en blanco");
                else
                    placa = value;
            }
        }
        public string Marca { get => marca;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("La marca no puede ser nulo o estar en blanco");
                else
                    marca = value;
            }
        }
        public string Modelo { get => modelo; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("El modelo no puede ser nulo o estar en blanco");
                else
                    modelo = value;
            }
        }
        public DateTime Fecha_hora { get => ano; 
            set
            {
                if (value.Year < ano_inic || value.Year > ano_fin)
                    throw new Exception($"El año no puede ser menor a {ano_inic} o mayor a {ano_fin}");
                else
                    ano = value;
            }
        }
    }
}
