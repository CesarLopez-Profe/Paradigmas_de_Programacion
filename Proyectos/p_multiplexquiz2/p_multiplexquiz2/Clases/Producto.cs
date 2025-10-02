using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace p_multiplexquiz2.Clases
{
    public abstract class Producto
    {
        private string descripcion;
        private uint valor;

        public Producto(string descripcion, uint valor)
        {
            this.Descripcion = descripcion;
            this.Valor = valor;
        }

        public string Descripcion { get => descripcion;

            set => descripcion = String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length <= 5 ?
                throw new Exception("Revise el nombre del producto, no es válido")
                : value; }
        public uint Valor { get => valor; 
            
            set => valor = value >= 10000 ? value: throw new Exception("Revise el Valor del producto, no es válido")
                ; 
        }    
    }
}
