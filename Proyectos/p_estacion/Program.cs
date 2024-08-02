using p_estacion.Clases;

namespace p_estacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Bicicleta> lista_bicis = new List<Bicicleta>();
                string cod_bic;


                for (byte i=1; i<=10;  i++)
                {
                    cod_bic = "B0000000" + i.ToString();
                    lista_bicis.Add(new Bicicleta(cod_bic,new DateOnly(2024,1,30)));
                }

                Estacion est_upb = new Estacion("Estacion UPB", "Portería Bulerias");
                est_upb.Abrir_estacion(lista_bicis);

                foreach(Bicicleta elem in lista_bicis)
                {
                    Console.WriteLine(elem.Codigo + "\n"
                        + elem.Fecha_compra + "\n"
                        + elem.Codigo_gps);
                }

                Usuario usr1 = new Usuario("CE455566", "Agudelito ", 3128976543);

                Console.WriteLine(est_upb.L_bicicletas.Count);

                est_upb.Entregar_bicicleta(usr1);

                Console.WriteLine(est_upb.L_bicicletas.Count);
                Console.WriteLine(usr1.Bicicleta.Codigo);


            }

            catch (Exception error) { 
                Console.WriteLine(error.ToString());
            }
        }
    }
}