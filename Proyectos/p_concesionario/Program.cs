using p_concesionario.Clases;

namespace p_concesionario
{
    internal class Program
    {
        public enum l_trab_soc { biblioteca, parque, ciclovia };
        static void Main(string[] args)
        {

            try
            {
                l_trab_soc ts_elegido = (l_trab_soc)(0);
                Console.WriteLine(ts_elegido);


                /*
                 * Cliente agudelito = new Cliente("95555555", "Juan Agudelo", 0.012f);
                Vendedor mantillita = new Vendedor("76576890", "Nicolas Mantilla", 0.018f);

                Taxi taxi1 = new Taxi("KLL123", "Kia", Auto.l_modelos.Rio, 2024, 1100, 5, Auto.l_nro_ptas.cuatro,
                    "TO123", "Tax Social");

                Concesionario honesto_joe = new Concesionario("Honesto Joe", "Calle sin nombre");

                honesto_joe.Vender_auto(taxi1,agudelito, mantillita, 120000000);

                Console.WriteLine(taxi1.Consultar_plan_mtto());*/



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}