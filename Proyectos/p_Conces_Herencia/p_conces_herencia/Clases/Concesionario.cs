using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p_conces_herencia.Clases
{
    public class Concesionario
    {
        private string nombre;
        private string direccion;
        private List<Venta> l_ventas;

        private readonly byte long_min_nom = 5, long_min_dir = 10;

        public Concesionario(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            l_ventas = new List<Venta>();
        }

        public string Nombre
        {
            get => nombre; 
            
            set => nombre = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < long_min_nom)?
                    value : throw new Exception("El nombre no es válido");
            }
        

        public string Direccion
        {
            get => direccion; 
            
            set => direccion = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < long_min_dir)?
                    value : throw new Exception("La dirección no es válida");
            
        
        }   

        public bool VenderAutomovil(Automovil auto,List<Persona>l_personas, 
        ulong valor){
            try{
                l_ventas.Add(new Venta(l_personas,auto,valor));
                return true;
            }
            
            catch(Exception ){
             
                return false;
            }
        }

    }
}