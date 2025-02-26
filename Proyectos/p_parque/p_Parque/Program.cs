using p_Parque.Clases;
namespace p_Parque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Atraccion el_hulk = new Atraccion("El Hulk", new TimeSpan(0,1,30),22);
                Manilla manilla = new Manilla();
                Registro reg_prueba;

;               reg_prueba = el_hulk.RegistrarIngreso(manilla);

                Console.WriteLine($"La manilla {reg_prueba.Manilla.Id} ingresó a {reg_prueba.Atraccion.Nombre} ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}