using p_Lampara.Clases;

namespace p_Lampara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Lampara lamp1 = new Lampara("Philips", Lampara.l_colores.cromo,
                    Lampara.l_voltajes.V110, 500001, Lampara.l_bombillas.Led, 3);


                lamp1.Asignar_tablero("ABC32453");
                lamp1.Encender();
                Console.WriteLine("La lámpara está encendida " + lamp1.Encendida);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}