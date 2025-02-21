using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_Concesionario
{
    public class Concesionario
    {
        private string nombre;
        private string direccion;
        private string nombre_repre;
        private List<Automovil> l_automoviles;
        private List<Automovil> l_automoviles_vendidos;

        public Concesionario(string nombre, string direccion, string nombre_repre)
        {
            Nombre = nombre;
            Direccion = direccion;
            Nombre_repre = nombre_repre;
            l_automoviles = new List<Automovil>();
            l_automoviles_vendidos = new List<Automovil>();
        }

        public string Nombre { get => nombre; 
            set => nombre = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= 5) ?
                value : throw new Exception("Nombre Concesionario No Válido");
        }
        public string Direccion { get => direccion; 
            set => direccion = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= 10) ?
                value : throw new Exception("Dirección No Válida");
        }
        public string Nombre_repre { get => nombre_repre; 
            set => nombre_repre = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length <= 10) ?
                value : throw new Exception("Nombre Representante No Válido");
        }
        public List<Automovil> L_automoviles { get => l_automoviles;  }
        public List<Automovil> L_automoviles_vendidos { get => l_automoviles_vendidos;  }

        public bool Agregar_Auto(Automovil auto) //Este método agrega un auto a la lista validando que la placa del auto no exista en esa lista
        {
            try
            {
                if (l_automoviles.Any(auto_lista => auto_lista.Placa.Equals(auto.Placa))) 
                    throw new Exception("La placa ya existe en la lista de autos a vender");
                else 
                    l_automoviles.Add(auto);

                return true;
            }
            catch(Exception ex) 
            {
                throw new Exception("Error inesperado agregando auto\n"+ex); 
            }
        }

        public bool Vender_Auto() //Este método saca el primer auto de la lista y lo pasa a la lista vendida, valida antes que en la lista de autos vendidos esa placa no la hayan vendido
        {
            try
            {
                if (l_automoviles_vendidos.Any(auto_lista_v => auto_lista_v.Placa.Equals(l_automoviles[0]))) 
                    throw new Exception("La placa ya existe en los autos vendidos");
                else
                {
                    l_automoviles_vendidos.Add(l_automoviles[0]);
                    l_automoviles.RemoveAt(0);
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado vendiendo auto\n" + ex);
            }

        }

    }
}