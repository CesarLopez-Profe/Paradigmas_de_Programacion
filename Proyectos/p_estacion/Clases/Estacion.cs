using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_estacion.Clases
{
    internal class Estacion
    {
        private string nombre;
        private string direccion;
        private List<Bicicleta> l_bicicletas;

        public Estacion(string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
        }

        public string Nombre { get => nombre;

            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)
                    || value.Length < 5)
                    throw new Exception("Error, revise los datos del nombre de la estación");
                else
                    nombre = value;
            }

        }
        public string Direccion { get => direccion;

            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)
                    || value.Length < 10)
                    throw new Exception("Error, revise los datos de la dirección de la estación");
                else
                    nombre = value;
            }

        }
        internal List<Bicicleta> L_bicicletas { get => l_bicicletas;

            set
            {
                if (value.Count() >= 0 && value.Count <= 10)
                    l_bicicletas = value;
                else
                    throw new Exception("La estación no puede tener menos de 0 bicicletas ni más de 10");

            }
        
        }
    
        public void Abrir_estacion(List<Bicicleta> l_bicicletas)
        {
            try
            {
                L_bicicletas = l_bicicletas;
            }

            catch(Exception error) { 
                throw new Exception(error.ToString());
            }
        }
       
        public void Entregar_bicicleta(Usuario usuario)
        {
            try
            {
                //Le entrego la bicicleta al usuario y lo marco que tiene la bicicleta
                usuario.Bicicleta = l_bicicletas.ElementAt(0);
                usuario.tiene_bici = true;
                //Sacamos la bici de la lista
                l_bicicletas.RemoveAt(0);

            }

            catch(Exception error)
            {
                throw new Exception(error.ToString());
            }
        }

        public void Recibir_bicicleta(Usuario usuario, Bicicleta bicicleta)
        {
            try
            {
                //Ingreso a la lita la bici que trae el usuario
                l_bicicletas.Add(bicicleta);

                //Le quito la bicicleta al usuario y lo marco que No tiene la bicicleta
                //usuario.Bicicleta ??como hago para que el usuario no tenga bicicleta
                usuario.tiene_bici = false;
                

            }

            catch (Exception error)
            {
                throw new Exception(error.ToString());
            }
        }

    }
}
