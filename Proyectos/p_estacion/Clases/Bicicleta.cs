using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_estacion.Clases
{
    internal class Bicicleta
    {
        private string codigo;
        private DateOnly fecha_compra;
        private int codigo_gps;

        public Bicicleta(string codigo, DateOnly fecha_compra)
        {
            Codigo = codigo;
            Fecha_compra = fecha_compra;
            codigo_gps = new Random().Next();
        }

        public string Codigo { get => codigo; 
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)
                    || value.Length < 6)
                    throw new Exception("Error, revise los datos del codigo de la bici");
                else
                    codigo = value;
            }

        }
        public DateOnly Fecha_compra { get => fecha_compra;

            set 
            {
                if (value >= DateOnly.FromDateTime(DateTime.Now))
                    throw new Exception("La fecha debe ser anterior al día de hoy");
                
                else if (value < DateOnly.FromDateTime(new DateTime(2023, 1, 1)))
                    throw new Exception("La fecha no puede ser anterior al 1/1/2023");

                else 
                    fecha_compra = value;

            }
                
        }
        public int Codigo_gps { get => codigo_gps;}
    }
}
