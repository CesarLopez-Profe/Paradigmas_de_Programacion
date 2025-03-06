using p_Parque.Clases;
namespace p_Parque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Atraccion> l_atracciones = new List<Atraccion> {

                    new Atraccion("Montaña Rusa Extrema", TimeSpan.FromMinutes(3), 25),
                    new Atraccion("Carrusel Mágico", TimeSpan.FromMinutes(2), 10),
                    new Atraccion("Casa del Terror", TimeSpan.FromMinutes(5), 15),
                    new Atraccion("Autos Chocones", TimeSpan.FromMinutes(4), 20),
                    new Atraccion("Río Aventura", TimeSpan.FromMinutes(5), 15),
                    new Atraccion("Torre de Caída Libre", TimeSpan.FromMinutes(2), 20),
                    new Atraccion("Simulador Espacial", TimeSpan.FromMinutes(5), 25),
                    new Atraccion("La Rueda Gigante", TimeSpan.FromMinutes(5), 15),
                    new Atraccion("Tren Fantasma", TimeSpan.FromMinutes(2), 25),
                    new Atraccion("Montaña Acuática", TimeSpan.FromMinutes(3), 25)

                };

                Parque parque_norte = new Parque("Parque Norte Medellín", l_atracciones);

                Console.WriteLine($"El parque {parque_norte.Nombre} cuenta con:\n\nAtracciones:");
                parque_norte.L_atracciones.ForEach(atr => Console.WriteLine($"Atracción: {atr.Nombre}, Duración: {atr.Duracion}, Puntos: {atr.Ptos_ingresar}"));

                Console.WriteLine($"Cantidad de Manillas : {parque_norte.L_manillas.Count} \nInformación de las Taquillas:");
                parque_norte.L_taquillas.ForEach(taq => Console.WriteLine($"Taquilla: {taq.Id}, Cantidad Manillas: {taq.L_manillas.Count}"));


                //Luego de implementadas los métodos de la tarea ,acá deben vender manillas, y hacer ingresos de esas manillas a las diferentes atracciones 
                //e imprimir verificaciones de las manillas ingresando a atracciones y los puntos que les van quedando
                //la cantidad de manillas de cada taquilla y el saldo de lo que va vendiendo









            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}