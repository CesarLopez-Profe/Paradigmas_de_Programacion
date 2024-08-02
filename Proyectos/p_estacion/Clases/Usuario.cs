using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_estacion.Clases
{
    internal class Usuario
    {
        //atributos descriptivos
        private string id;
        private string nombre;
        private long telefono;
      
        //atributos de estado
        private Bicicleta bicicleta;
        internal bool tiene_bici = false;

        public Usuario(string id, string nombre, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }

        public string Id { get => id;
            set {

                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)
                    || value.Length < 7)
                    throw new Exception("Error, revise los datos de id");
                else
                    id = value;
            } 
        }
        
        public string Nombre { get => nombre;
            set {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)
                    || value.Length < 6)
                    throw new Exception("Error, revise los datos del nombre");
                else
                    nombre = value;
            } 
        
        }
        
        public long Telefono { get => telefono;
            set { 
                if(value > 0 && value.ToString().Length >= 10)
                    telefono = value;
                else
                    throw new Exception("Error, revise el teléfono");
            }
        
        }

        internal Bicicleta Bicicleta { get => bicicleta; set => bicicleta = value; }
    }
}
