using System.Numerics;
using System.Reflection;

namespace p_Concesionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Concesionario autos_luxe = new Concesionario("Autos Luxe", "Calle 45#30-20", "Maria A Cano");

                autos_luxe.Agregar_Auto(new Automovil("Toyota", "Corolla", 120000000, "ABC123"));
                autos_luxe.Agregar_Auto(new Automovil("Honda", "Civic", 85000000, "DEF456"));
                autos_luxe.Agregar_Auto(new Automovil("Ford", "Mustang", 200000000, "GHI789"));
                autos_luxe.Agregar_Auto(new Automovil("Chevrolet", "Camaro", 190000000, "JKL012"));

                Console.WriteLine("Lista de autos");
                autos_luxe.L_automoviles.ForEach(n => Console.WriteLine(n.Marca + " " + n.Modelo + " " + n.Precio));

                Console.WriteLine("Lista de autos vendidos");
                autos_luxe.L_automoviles_vendidos.ForEach(n => Console.WriteLine(n.Marca + " " + n.Modelo + " " + n.Precio));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }
    }
}